using cubemeslight;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using Wisej.Web;
using Wisej.Web.Ext.ChartJS;

namespace cubemesweb.dair_msl
{
    public partial class FormEmpCSVDataViewer : Page
    {
        Wisej.Web.Ext.ChartJS.DataSet lsBPM = null;
        public string empid
        {
            get
            {
                return Application.Session["empid"];
            }
        }

        DataTable dtRaw = null;

        public Dictionary<string, string> dicCheck = new Dictionary<string, string>();

        public Dictionary<string, TData> dicTagData = new Dictionary<string, TData>();

        public Dictionary<string, string> dicColTag = new Dictionary<string, string>();

        public Dictionary<string, Wisej.Web.Ext.ChartJS.DataSet> dicDataSet = new Dictionary<string, Wisej.Web.Ext.ChartJS.DataSet>();
        public Dictionary<string, List<double>> dicSeries = new Dictionary<string, List<double>>();

        public List<string> lLabels = new List<string>();
        public List<DateTime> lDTs = new List<DateTime>();

        public string kind = "";
        public string kindcol = "";
        public string kindchart = "";
        public string table = "";

        //public class TData
        //{
        //    public string tag = "";
        //    public DateTime dt;
        //    public double v = 0;
        //    public Boolean isInit = false;

        //    public TData(string atag, DateTime adt)
        //    {
        //        tag = atag;
        //        dt = adt;
        //    }
        //}

        public Boolean isLoading = false;

        public FormEmpCSVDataViewer(string aempid = "", string akind = "", string akindcol = "")
        {
            InitializeComponent();
        }

        public void doChartInit()
        {
            if (kind == "칼로리" || kind == "걸음걸이")
            {
                kindchart = "bar";
            }
            else
            {
                kindchart = "line";
            }

            if (kind == "칼로리" || kind == "이동거리(Km)" || kind == "걸음걸이")
            {
                table = "ecg_csv_dataday";
            }
            else if (kind == "체온(℃)" || kind == "맥박")
            {
                table = "ecg_csv_bpmday";
            }

            chartBPM.Options.Title.Display = false;
            chartBPM.Options.Legend.Display = false;           

            if (kindchart == "line")
            {
                lsBPM = new LineDataSet();
                ((LineDataSet)lsBPM).PointBorderColor = new[] { Color.Red };// .FromArgb(255, 46, 0) };
                ((LineDataSet)lsBPM).PointRadius = new[] { 0 };
                ((LineDataSet)lsBPM).BorderColor = Color.Red;
            }
            else
            {
                lsBPM = new BarDataSet();
                ((BarDataSet)lsBPM).BorderColor = new[] { Color.Red };// .FromArgb(255, 46, 0) };
            }

            lsBPM.BorderColor = Color.Red;// FromArgb(255, 46, 0);
            lsBPM.Data = new object[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            
            lsBPM.BorderWidth = 1;
            lsBPM.Label = kind;// "BPM";

            gvDataList.Columns[0].HeaderText = "측정시각";
            gvDataList.Columns[0].ToolTipText = "writetime";

            gvDataList.Columns[1].HeaderText = kind;
            gvDataList.Columns[1].ToolTipText = kindcol;

            chartBPM.DataSets.Clear();
            chartBPM.DataSets.Add(lsBPM);

            dicColTag.Add(kindcol, kind);
            dicDataSet.Add(kindcol, chartBPM.DataSets[0]);
            dicSeries.Add(kindcol, new List<double>());
        }

        private void reload()
        {
            try
            {
                dicCheck.Clear();
                dicCheck.Add(empid, empid);

                loadData();                
            }
            catch (Exception E)
            {
                cs.logError(E);
            }
        }

        private void FormEmpCSVDataViewer_Load(object sender, EventArgs e)
        {
            dtpFrom.Value = DateTime.Today;
            dtpTo.Value = DateTime.Today;
            dtpTimeFrom.Value = DateTime.Today;
            dtpTimeTo.Value = DateTime.Today.AddSeconds(86399);

            pData.Visible = false;

            chkTimeAsc.Checked = true;

            doChartInit();
            reload();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            reload();
        }

        private void loadData()
        {
            if (isLoading)
            {
                MessageBox.Show("아직 로딩 중 입니다.");
                return;
            }
            try
            {
                isLoading = true;

                Boolean isARR = false;

                this.Invoke(new Action(delegate () // this == Form 이다. Form이 아닌 컨트롤의 Invoke를 직접호출해도 무방하다.
                {
                    pLoading.Visible = true;
                }));

                List<string> lTag = new List<string>();

                foreach (string tag in dicCheck.Keys)
                {
                    lTag.Add("'" + tag + "'");
                }

                string sql = "SELECT * FROM " + table + " where";

                if (lTag.Count == 0)
                {
                    sql += " eq is null ";
                }
                else
                {
                    sql += " eq in (" + string.Join(",", lTag) + ") ";
                }

                if (isARR)
                {
                    sql += " and tag6 = 1 ";
                }

                sql += " and writetime >= '" + dtpFrom.Value.ToString("yyyy-MM-dd") + " " + dtpTimeFrom.Value.ToString("HH:mm:ss") + "' ";
                sql += " and writetime <= '" + dtpTo.Value.ToString("yyyy-MM-dd") + " " + dtpTimeTo.Value.ToString("HH:mm:ss") + "' ";

                if (chkTimeDesc.Checked)
                {
                    sql += " order by writetime desc ";
                }
                else
                {
                    sql += " order by writetime asc ";
                }

                DMDB db = new DMDB();
                dtRaw = db.sqlToDT(sql);
                dicTagData.Clear();

                this.Invoke(new Action(delegate () // this == Form 이다. Form이 아닌 컨트롤의 Invoke를 직접호출해도 무방하다.
                {
                    try
                    {
                        foreach (List<double> ll in dicSeries.Values)
                        {
                            ll.Clear();
                        }
                    }
                    catch (Exception E)
                    {
                        cs.logError(E);
                    }
                }));

                int rr = 0;
                Stopwatch sw = new Stopwatch();
                sw.Start();
                this.Invoke(new Action(delegate () // this == Form 이다. Form이 아닌 컨트롤의 Invoke를 직접호출해도 무방하다.
                {
                    try
                    {
                        pLoading.Value = 0;
                        if (dtRaw != null)
                            if (dtRaw.Rows.Count > pLoading.Minimum)
                                pLoading.Maximum = dtRaw.Rows.Count;
                    }
                    catch (Exception E)
                    {
                        cs.logError(E);
                    }
                }));

                double dmax = -1;
                double dmin = 999999;

                this.Invoke(new Action(delegate () // this == Form 이다. Form이 아닌 컨트롤의 Invoke를 직접호출해도 무방하다.
                {
                    double first = -999999;
                    
                    lLabels.Clear();
                    lDTs.Clear();

                    foreach (DataRow dr in dtRaw.Rows)
                    {
                        rr++;

                        string tag = dr["eq"].ToString();

                        DateTime dtt = cs.strTodt(dr["writetime"].ToString());

                        if (first == -999999)
                        {
                            first = dtt.ToOADate();
                        }

                        int i = 0;
                        foreach (string sensortag in dicColTag.Keys)
                        {
                            string sv = dr[sensortag].ToString();                            
                            string[] sa = sv.Split(',');
                            string stime = dr["writetime"].ToString();
                            if (sa.Length >= 2)
                            {
                                if (sv.Substring(4, 1) == "-")
                                {
                                    sv = sa[1];
                                    stime = sa[0];
                                }
                                else
                                {
                                    sv = sa[1];
                                    stime = dtt.ToString("yyyy-MM-dd") + " " + sa[0];
                                }
                            }

                            double dv = cs.strToDouble(sv.ToString());                            
                            if (dv < dmin)
                                dmin = dv;
                            if (dv > dmax)
                                dmax = dv;

                            List<double> sr = null;
                            if (dicSeries.TryGetValue(sensortag, out sr))
                            {
                                if (dv >= 0)
                                {
                                    sr.Add(dv);

                                    lLabels.Add(stime);
                                    string sdt = stime;
                                    DateTime dt2;
                                    if (DateTime.TryParse(sdt, out dt2))
                                    {
                                        lDTs.Add(dt2);
                                    }
                                    else
                                    {
                                        lDTs.Add(dt2);
                                    }
                                }
                                if (sw.ElapsedMilliseconds > 500)
                                {
                                    sw.Restart();
                                    pLoading.Value = rr;
                                }
                            }

                            i++;
                        }
                    }

                }));

                this.Invoke(new Action(delegate () // this == Form 이다. Form이 아닌 컨트롤의 Invoke를 직접호출해도 무방하다.
                {
                    try
                    {
                        dicDataSet[kindcol].Data = dicSeries[kindcol].Select(d => (object)d).ToArray();
                        chartBPM.Labels = lLabels.ToArray();
                        chartBPM.UpdateData();

                        gvDataList.RowCount = dicSeries[kindcol].Count;
                        gvDataList.Invalidate();
                    }
                    catch (Exception E)
                    {
                        cs.logError(E);
                    }
                }));
                this.Invoke(new Action(delegate () // this == Form 이다. Form이 아닌 컨트롤의 Invoke를 직접호출해도 무방하다.
                {
                    pLoading.Visible = false;
                }));
            }
            catch (Exception E)
            {
                cs.logError(E);
            }
            isLoading = false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FormEmpOverview ff = (FormEmpOverview)Application.OpenPages[Application.SessionId + ".FormEmpOverview"];
            ff.Show();

        }

        private void btnShowData_Click(object sender, EventArgs e)
        {
            if (btnShowData.Text == "데이터 목록 보기")
            {
                pData.Visible = true;
                pData.Height = pBack1.Height / 2;
                btnShowData.Text = "데이터 목록 숨기기";
            }
            else if (btnShowData.Text == "데이터 목록 숨기기")
            {
                pData.Visible = false;
                btnShowData.Text = "데이터 목록 보기";
            }
        }

        private void gvEmpList_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
        {
            try
            {
                int r = e.RowIndex;
                int c = e.ColumnIndex;

                if (r < 0) return;
                if (c < 0) return;

                if (dicSeries.ContainsKey(kindcol))
                {
                    string col = gvDataList.Columns[c].HeaderText;
                    if (gvDataList.Columns[c].ToolTipText != "")
                        col = gvDataList.Columns[c].ToolTipText;
                    string sv = "";

                    if (col == "writetime")
                    {
                        sv = lLabels[r];
                    }
                    else if (col == kindcol)
                    {
                        sv = dicSeries[kindcol][r].ToString("0");
                    }
                    else if (c == 2)
                    {
                        //sv = "ECG보기";

                    }
                    e.Value = sv;
                }
            }
            catch (Exception E)
            {
                cs.logError(E);
            }
        }

        private void gvEmpList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int r = e.RowIndex;
                int c = e.ColumnIndex;

                if (r < 0) return;
                if (c < 0) return;

                if (dicSeries.ContainsKey(kind))
                {
                    string col = gvDataList.Columns[c].HeaderText;
                    if (c == 2)
                    {
                        DateTime dt = lDTs[r];

                        FormEmpECGDataViewer ff = new FormEmpECGDataViewer(dt) { Name = Application.SessionId + ".FormEmpECGDataViewer" };
                        ff.Show();
                    }
                }
            }
            catch (Exception E)
            {
                cs.logError(E);
            }
        }

        private void chartBPM_ChartClick(object sender, ChartClickEventArgs e)
        {
            try
            {
                int idx = e.DataPoints[0];
                DateTime dt = lDTs[idx];

                FormEmpECGDataViewer ff = new FormEmpECGDataViewer(dt) { Name = Application.SessionId + ".FormEmpECGDataViewer" };
                ff.Show();
            }
            catch (Exception E)
            {
                cs.logError(E);
            }
        }
        private void chkTimeAsc_Click(object sender, EventArgs e)
        {
            chkTimeAsc.Checked = true;
            chkTimeDesc.Checked = false;
            reload();
        }

        private void chkTimeDesc_Click(object sender, EventArgs e)
        {
            chkTimeAsc.Checked = false;
            chkTimeDesc.Checked = true;
            reload();
        }
    }
}
