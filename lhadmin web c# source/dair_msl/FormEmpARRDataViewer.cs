using cubemeslight;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using Wisej.Web;
using Wisej.Web.Ext.ChartJS;

namespace cubemesweb.dair_msl
{
    public partial class FormEmpARRDataViewer : Page
    {
        LineDataSet lsBPM = null;
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
        

        public Boolean isLoading = false;
        DMDB db;
        public FormEmpARRDataViewer()
        {
            InitializeComponent();
            db = new DMDB();
        }

        public void doChartInit()
        {
            chartBPM.Options.Title.Display = false;
            chartBPM.Options.Legend.Display =false;
            lsBPM = new LineDataSet();            
            lsBPM.BorderColor = Color.FromArgb(255, 46, 0);
            lsBPM.Data = new object[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            lsBPM.PointBorderColor = new[] { Color.FromArgb(255, 46, 0) };           
            lsBPM.PointRadius = new[] { 0 };
            lsBPM.BorderWidth = 1;
            lsBPM.Label = "ARR";
            chartBPM.DataSets.Clear();
            chartBPM.DataSets.Add(lsBPM);
            dicColTag.Add("ARR", "ARR");
            dicDataSet.Add("ARR", chartBPM.DataSets[0]);
            dicSeries.Add("ARR", new List<double>());
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

        private void FormEmpARRDataViewer_Load(object sender, EventArgs e)
        {
            DateTime dtnow = DateTime.Now;
            try
            {
                
                DataRow drEmp = db.sqlToDR("select * from 인원_목록 where 아이디 = '" + empid + "' ");

                int hh = cs.strToInt(drEmp["시간차이"].ToString());
                dtnow = dtnow.AddHours(hh);
            }
            catch (Exception E)
            {
                cs.logError(E);
            }
            dtnow = dtnow.Date;

            dtpFrom.Value = dtnow;
            dtpTo.Value = dtnow;
            dtpTimeFrom.Value = dtnow;
            dtpTimeTo.Value = dtnow.AddSeconds(86399);

            pData.Visible = false;

            doChartInit();

            reload();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            reload();
        }    
        
        private void loadData()
        {
            if(isLoading)
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

                string sql = "SELECT idx, writetime, eq, ecgpacket FROM ecg_csv_ecgdata_arr where";

                if (lTag.Count == 0)
                {
                    sql += " eq is null ";
                }
                else
                {
                    sql += " eq in (" + string.Join(",", lTag) + ") ";
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
                dtRaw = db.sqlToDT(sql);
                dicTagData.Clear();

                this.Invoke(new Action(delegate () // this == Form 이다. Form이 아닌 컨트롤의 Invoke를 직접호출해도 무방하다.
                {
                    try
                    {
                        foreach(List<double> ll in dicSeries.Values)
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
                this.Invoke(new Action(delegate () 
                {
                    gvDataList.RowCount = dtRaw.Rows.Count;
                    gvDataList.Invalidate();
                    pLoading.Visible = false;
                }));
                isLoading = false;
            }
            catch (Exception E)
            {
                cs.logError(E);
            }
        }

        public void doUIData()
        {
            pChart.Visible = false;
            pData.Visible = true;
            pData.Dock = DockStyle.Fill;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {           
            FormEmpOverview ff = (FormEmpOverview)Application.OpenPages[Application.SessionId + ".FormEmpOverview"];       
            ff.Show();
        }

        private void btnShowData_Click(object sender, EventArgs e)
        {
            if(btnShowData.Text == "데이터 목록 보기")
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

                {
                    string col = gvDataList.Columns[c].HeaderText;
                    if(gvDataList.Columns[c].ToolTipText != "")
                        col = gvDataList.Columns[c].ToolTipText; 
                    string sv = "";

                    if (col == "writetime")
                    {
                        string time = dtRaw.Rows[r]["writetime"].ToString();
                        
                        sv = time;
                    }
                    else if (col == "ARR")
                    {
                        sv = "ARR";
                    }
                    else if (c == 2)
                    {
                        sv = "ECG보기";

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
                {
                    string col = gvDataList.Columns[c].HeaderText;
                    if (c == 2)
                    {
                        string time = dtRaw.Rows[r]["writetime"].ToString();
                        DateTime dt = cs.strTodt(time);

                        FormEmpECGDataViewer ff = new FormEmpECGDataViewer(dt) { Name = Application.SessionId + ".FormEmpECGDataViewer" };
                        ff.sCallClass = "FormEmpARRDataViewer";
                        ff.Show();
                        ff.ecgpacket = dtRaw.Rows[r]["ecgpacket"].ToString();
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
                
                FormEmpECGDataViewer ff = new FormEmpECGDataViewer(dt, "FormEmpARRDataViewer") { Name = Application.SessionId + ".FormEmpECGDataViewer" };                
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
