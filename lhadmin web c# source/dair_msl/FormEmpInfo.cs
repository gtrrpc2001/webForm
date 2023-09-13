using cubemeslight;
using cubemesweb.dair_wrapdust;
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
    public partial class FormEmpInfo : Page
    {
        DateTime dtFrom = DateTime.Now;
        DateTime dtNow = DateTime.Now;

        DateTime dtNowLast = DateTime.Now;
        Boolean bIsFirst = true;

        LineDataSet lsBPM = null;

        DataRow drEmp = null;
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
        public Dictionary<string, List<TTimeData>> dicSeries = new Dictionary<string, List<TTimeData>>();

        public List<string> lLabels = new List<string>();

        public class TTimeData
        {
            public double BPM;
            public DateTime dtTime;
            public string Time;
        }

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
        public FormEmpInfo(string aempid = "")
        {
            InitializeComponent();
            db = new DMDB();
        }

        private void doChartInit()
        {
            chartBPM.Options.Title.Display = false;
            chartBPM.Options.Legend.Display = false;

            lsBPM = new LineDataSet();
            lsBPM.BorderColor = Color.FromArgb(255, 46, 0);
            lsBPM.Data = new object[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            lsBPM.PointBorderColor = new[] { Color.FromArgb(255, 46, 0) };
            lsBPM.PointBackgroundColor = new[] { Color.FromArgb(255, 46, 0) };
            lsBPM.PointRadius = new[] { 0 };
            lsBPM.Label = "BPM";

            chartBPM.DataSets.Clear();
            chartBPM.DataSets.Add(lsBPM);

            dicColTag.Add("BPM", "BPM");
            dicDataSet.Add("BPM", chartBPM.DataSets[0]);
            dicSeries.Add("BPM", new List<TTimeData>());
        }

        private void doEmpLoad()
        {
            try
            {
                drEmp = db.sqlToDR("select * from 인원_목록 where 아이디 = '" + empid + "' ");
            }
            catch (Exception E)
            {
                cs.logError(E);
            }
        }

        public void reload(string aempid = "")
        {
            try
            {
                txtName.Text = empid;
                txtEmpName.Text = drEmp["성명"].ToString();

                dicCheck.Clear();
                dicCheck.Add(empid, empid);

                loadData();;
            }
            catch (Exception E)
            {
                cs.logError(E);
            }
        }

        private void FormEmpInfo_Load(object sender, EventArgs e)
        {
            btnEmpARRDataViewer.Text = "심장 리듬 이상\r\n데이터 이력보기";
            doChartInit();
            doEmpLoad();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            reload();
        }

       

        public void loadData()
        {
            try
            {
                DateTime dtNowDefault = DateTime.Now;

                int hh = cs.strToInt(drEmp["시간차이"].ToString());
                dtNowDefault = dtNowDefault.AddHours(hh);

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

                string sql = "SELECT idx, writetime, eq, LEFT(RAW, 20) AS 'bpm', LEFT(RAW, 31) AS 'bpm2' FROM ecg_raw where";

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

                if (bIsFirst)
                {
                    dtFrom = dtNowDefault.AddMinutes(-5);
                    dtNow = dtNowDefault.AddMinutes(10);

                    sql += " and writetime >= '" + dtFrom.ToString("yyyy-MM-dd") + " " + dtFrom.ToString("HH:mm:ss") + "' ";
                    sql += " and writetime <= '" + dtNow.ToString("yyyy-MM-dd") + " " + dtNow.ToString("HH:mm:ss") + "' ";
                }
                else
                {
                    dtFrom = dtNowDefault.AddMinutes(-5);
                    dtNow = dtNowDefault.AddMinutes(10);

                    sql += " and writetime > '" + dtFrom.ToString("yyyy-MM-dd") + " " + dtFrom.ToString("HH:mm:ss") + "' ";
                    sql += " and writetime <= '" + dtNow.ToString("yyyy-MM-dd") + " " + dtNow.ToString("HH:mm:ss") + "' ";
                }

                dtRaw = db.sqlToDT(sql);

                dicSeries["BPM"].Clear();
                lLabels.Clear();                

                int rr = 0;
                Stopwatch sw = new Stopwatch();
                sw.Start();

                double dmax = -1;
                double dmin = 999999;

                this.Invoke(new Action(delegate () // this == Form 이다. Form이 아닌 컨트롤의 Invoke를 직접호출해도 무방하다.
                {
                    foreach (DataRow dr in dtRaw.Rows)
                    {
                        rr++;

                        string tag = dr["eq"].ToString();

                        DateTime dtt = cs.strTodt(dr["writetime"].ToString());

                        int i = 0;
                        foreach (string sensortag in dicColTag.Keys)
                        {
                            DateTime dtV = dtt;
                            string[] sa;

                            string stime = "";
                            string sv = dr[sensortag].ToString();

                            if (sv.Substring(4, 1) == "-")
                            {
                                sv = dr["BPM2"].ToString();                               
                                sa = sv.Split(',');
                                if (sa.Length >= 2)
                                {
                                    sv = sa[1];
                                    stime = sa[0];
                                    dtV = cs.strTodt(sa[0]);
                                    stime = dtV.ToString("HH:mm:ss");
                                }
                            }
                            else
                            {                                
                                sa = sv.Split(',');
                                if (sa.Length >= 2)
                                {
                                    sv = sa[1];

                                    stime = sa[0];
                                    dtV = cs.strTodt(dtt.ToString("yyyy-MM-dd") + " " + stime);
                                }
                            }

                            double dv = cs.strToDouble(sv.ToString());

                            if (dv < dmin)
                                dmin = dv;
                            if (dv > dmax)
                                dmax = dv;
                            
                            List<TTimeData> sr = null;
                            if (dicSeries.TryGetValue(sensortag, out sr))
                            {
                                if (dv > 0)
                                {
                                    sr.Add(new TTimeData() { BPM = dv, dtTime = dtV, Time = stime });

                                    lLabels.Add(stime);
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

                // 시작점 데이터 삭제
                if (bIsFirst == false)
                {
                    while (true)
                    {
                        if (dicSeries["BPM"].Count == 0)
                            break;
                        TTimeData td = dicSeries["BPM"].First();
                        if (td.dtTime <= dtFrom)
                        {
                            dicSeries["BPM"].RemoveAt(0);
                        }
                        else
                        {
                            break;
                        }
                    }
                }

                this.Invoke(new Action(delegate () // this == Form 이다. Form이 아닌 컨트롤의 Invoke를 직접호출해도 무방하다.
                {
                    try
                    {
                        dicDataSet["BPM"].Data = dicSeries["BPM"].Select(d => (object)d.BPM).ToArray();
                        chartBPM.Labels = dicSeries["BPM"].Select(d => (string)d.Time).ToArray();

                        txtBPMNow.Text = dicSeries["BPM"].Last().BPM.ToString("0");

                        txtBPMTime.Text = dicSeries["BPM"].Last().dtTime.ToString("yyyy-MM-dd HH:mm:ss");
                        chartBPM.UpdateData(1);
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

                if (bIsFirst)
                    bIsFirst = false;
                dtNowLast = dtNow;

                if (timerTick.Enabled == false)
                {
                    timerTick.Enabled = true;
                }
            }
            catch (Exception E)
            {
                cs.logError(E);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FormEmpList ff = (FormEmpList)Application.OpenPages[Application.SessionId + ".FormEmpList"];
            ff.Show();
        }

        private void btnEmpChartViewer_Click(object sender, EventArgs e)
        {
            FormEmpDataViewer ff = new FormEmpDataViewer() { Name = Application.SessionId + ".FormEmpDataViewer" };
            ff.Show();
        }

        private void btnEmpDataViewer_Click(object sender, EventArgs e)
        {
            FormEmpDataViewer ff = new FormEmpDataViewer() { Name = Application.SessionId + ".FormEmpDataViewer" };
            ff.Show();
            ff.doUIData();
        }

        private void timerTick_Tick(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnEmpARRDataViewer_Click(object sender, EventArgs e)
        {
            FormEmpARRDataViewer ff = new FormEmpARRDataViewer() { Name = Application.SessionId + ".FormEmpARRDataViewer" };
            ff.Show();
            ff.doUIData();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            FormLHReport ff = new FormLHReport();
            ff.Show();
        }
    }
}
