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
    public partial class FormEmpECGDataViewer : Page
    {
        public string sCallClass = "FormEmpDataViewer";

        LineDataSet lsBPM = null;
        public string empid
        {
            get
            {
                return Application.Session["empid"];
            }
        }
        private DateTime dtData;
        public string ecgpacket = "";

        DataTable dtRaw = null;

        public Dictionary<string, string> dicCheck = new Dictionary<string, string>();

        public Dictionary<string, TData> dicTagData = new Dictionary<string, TData>();

        public Dictionary<string, string> dicColTag = new Dictionary<string, string>();

        public Dictionary<string, Wisej.Web.Ext.ChartJS.DataSet> dicDataSet = new Dictionary<string, Wisej.Web.Ext.ChartJS.DataSet>();
        public Dictionary<string, List<double>> dicSeries = new Dictionary<string, List<double>>();

        public List<string> lLabels = new List<string>();
        public List<DateTime> lDTs = new List<DateTime>();

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

        DMDB db;
        public FormEmpECGDataViewer(DateTime dtData,string sCallClass = "")
        {
            InitializeComponent();
            db = new DMDB();
            this.dtData = dtData;
            if(sCallClass != "")
                this.sCallClass = sCallClass;
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
            lsBPM.Label = "ECG";          

            chartBPM.DataSets.Clear();
            chartBPM.DataSets.Add(lsBPM);

            dicColTag.Add("ECG", "ECG");
            dicDataSet.Add("ECG", chartBPM.DataSets[0]);
            dicSeries.Add("ECG", new List<double>());
        }

        private void reload(string aempid = "")
        {
            try
            {
                dicCheck.Clear();
                dicCheck.Add(empid, empid);

                if (ecgpacket != "")
                    loadECGPacket();
                else
                loadData();                
            }
            catch (Exception E)
            {
                cs.logError(E);
            }
        }

        private void FormEmpECGDataViewer_Load(object sender, EventArgs e)
        {
            dtpFrom.Value = DateTime.Today;
            dtpTo.Value = DateTime.Today;
            dtpTimeFrom.Value = DateTime.Today;
            dtpTimeTo.Value = DateTime.Today.AddSeconds(86399);

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
            try
            {
                this.Invoke(new Action(delegate () // this == Form 이다. Form이 아닌 컨트롤의 Invoke를 직접호출해도 무방하다.
                {
                    pLoading.Visible = true;

                    int ii = 30;
                    if(sCallClass == "FormEmpARRDataViewer")
                    {
                        ii = 30;
                    }

                    dtpFrom.Value = dtData.AddSeconds(-ii);
                    dtpTo.Value = dtData.AddSeconds(ii); 
                    dtpTimeFrom.Value = dtData.AddSeconds(-ii);
                    dtpTimeTo.Value = dtData.AddSeconds(ii);
                }));

                List<string> lTag = new List<string>();

                foreach (string tag in dicCheck.Keys)
                {
                    lTag.Add("'" + tag + "'");
                }

                string sql = "SELECT idx, writetime, eq, ecgpacket FROM ecg_csv_ecgdata where";

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
                        
                        DateTime dtCellFirst = DateTime.Now;

                        int i = 0;
                        foreach (string sensortag in dicColTag.Keys)
                        {
                            string sid = dr["eq"].ToString();
                            string sraw = dr["ecgpacket"].ToString();
                            sraw = sraw.Replace("[", "").Replace("]", "");
                            string stime = dtt.ToString("yyyy-MM-dd HH:mm:ss");

                            string[] sa1 = sraw.Split(',');                        

                            List<double> sr = null;
                            if (dicSeries.TryGetValue(sensortag, out sr))
                            {
                                DateTime dt2;
                                DateTime.TryParse(stime, out dt2);
                               

                                for (int j = 0; j < sa1.Length; j++)
                                {
                                    double dd = 0;
                                    if (double.TryParse(sa1[j], out dd))
                                    {
                                        lDTs.Add(dt2);
                                        lLabels.Add(dt2.ToString("HH:mm:ss"));
                                        sr.Add(dd);
                                    }
                                }
                            }                        

                            if (sw.ElapsedMilliseconds > 500)
                            {
                                sw.Restart();
                                pLoading.Value = rr;
                            }

                            i++;
                        }
                    }                    
                }));

                this.Invoke(new Action(delegate () // this == Form 이다. Form이 아닌 컨트롤의 Invoke를 직접호출해도 무방하다.
                {
                    try
                    {
                        dicDataSet["ECG"].Data = dicSeries["ECG"].Select(d => (object)d).ToArray();                       
                        chartBPM.Labels = lLabels.ToArray();                        
                        chartBPM.UpdateData();

                        gvDataList.RowCount = dicSeries["ECG"].Count;
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
        }

        private void loadECGPacket()
        {
            try
            {            
                this.Invoke(new Action(delegate () // this == Form 이다. Form이 아닌 컨트롤의 Invoke를 직접호출해도 무방하다.
                {
                    pLoading.Visible = true;
                }));

                this.Invoke(new Action(delegate () // this == Form 이다. Form이 아닌 컨트롤의 Invoke를 직접호출해도 무방하다.
                {                    
                    DateTime dtCellFirst = DateTime.Now;

                    int i = 0;
                    foreach (string sensortag in dicColTag.Keys)
                    {
                        string sraw = ecgpacket;
                        int i1 = sraw.IndexOf("arr,");
                        sraw = sraw.Substring(i1 + 4);

                        sraw = sraw.Replace("[", "").Replace("]", "");
                        string stime = dtData.ToString("yyyy-MM-dd HH:mm:ss");

                        string[] sa1 = sraw.Split(',');

                        List<double> sr = null;
                        if (dicSeries.TryGetValue(sensortag, out sr))
                        {
                            DateTime dt2;
                            if (DateTime.TryParse(stime, out dt2))
                            {
                            }

                            for (int j = 0; j < sa1.Length; j++)
                            {
                                double dd = 0;
                                if (double.TryParse(sa1[j], out dd))
                                {
                                    lDTs.Add(dt2);
                                    lLabels.Add(dt2.ToString("HH:mm:ss"));
                                    sr.Add(dd);
                                }
                            }
                        }
                    }
                }));

                this.Invoke(new Action(delegate () // this == Form 이다. Form이 아닌 컨트롤의 Invoke를 직접호출해도 무방하다.
                {
                    try
                    {
                        dicDataSet["ECG"].Data = dicSeries["ECG"].Select(d => (object)d).ToArray();                       
                        chartBPM.Labels = lLabels.ToArray();                        
                        chartBPM.UpdateData();

                        gvDataList.RowCount = dicSeries["ECG"].Count;
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
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            if (sCallClass == "FormEmpARRDataViewer")
            {
                FormEmpARRDataViewer ff = (FormEmpARRDataViewer)Application.OpenPages[Application.SessionId + "." + sCallClass];               
                ff.Show();
            }
            else if (sCallClass == "FormEmpDataViewer")
            {
                FormEmpDataViewer ff = (FormEmpDataViewer)Application.OpenPages[Application.SessionId + "." + sCallClass];                
                ff.Show();
            }
            else
            {
                FormEmpDataViewer ff = (FormEmpDataViewer)Application.OpenPages[Application.SessionId + "." + sCallClass];                
                ff.Show();
            }            
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

                if (dicSeries.ContainsKey("ECG"))
                {
                    string col = gvDataList.Columns[c].HeaderText;
                    string sv = "";

                    if (col == "측정시각")
                    {
                        sv = lLabels[r];
                    }
                    else if (col == "ECG")
                    {
                        sv = dicSeries["ECG"][r].ToString("0");
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

                if (dicSeries.ContainsKey("ECG"))
                {
                    string col = gvDataList.Columns[c].HeaderText;
                    if (col == "ECG보기")
                    {
                        DateTime dt = lDTs[r];

                    }
                }
            }
            catch (Exception E)
            {
                cs.logError(E);
            }
        }        
    }
}
