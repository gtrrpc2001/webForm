using System;
using System.Data;
using System.Collections.Generic;
using Wisej.Web;

namespace cubemesweb.dair_wrapdust
{
    public partial class FormLHReport : Form
    {
        public DataTable dtRaw;
        public DataTable dtArr;
        public DataTable dtRawYesterday;

        public Dictionary<string, TData> dicData1m = new Dictionary<string, TData>();
        public Dictionary<string, TData> dicData = new Dictionary<string, TData>();
        public Dictionary<string, TData> dicDataYesterday = new Dictionary<string, TData>();


        public string empid
        {
            get
            {
                return Application.Session["empid"];
            }
        }
        public FormLHReport()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {/*
            try
            {
                DMDB db = new DMDB();

                {
                    dicData1m.Clear();
                    DateTime dtTime = cs.strTodt(dtpFrom.Value.AddDays(-6).ToString("yy-MM-dd") + " 00:00:00");
                    for (int i = 0; i < 1440 * 7; i++)
                    {
                        string key = dtTime.ToString("yy-MM-dd HH:mm:00");
                        TData dd = new TData();
                        dd.key = key;
                        dd.time = dtTime;
                        dicData1m.Add(key, dd);

                        dtTime = dtTime.AddMinutes(1);
                    }
                }
                {
                    dicData.Clear();
                    DateTime dtTime = cs.strTodt(dtpFrom.Value.AddDays(-6).ToString("yy-MM-dd") + " 00:00:00");
                    for (int j = 0; j < 7; j++)
                    {
                        for (int i = 0; i < 24; i++)
                        {
                            string key = dtTime.ToString("yy-MM-dd HH:00:00");// j.ToString() + i.ToString("00");
                            TData dd = new TData();
                            dd.key = key;
                            dd.time = dtTime;
                            dicData.Add(key, dd);

                            dtTime = dtTime.AddHours(1);
                        }
                    }
                }
                {
                    dicDataYesterday.Clear();
                    DateTime dtTime = cs.strTodt(dtpFrom.Value.AddDays(-1).ToString("yy-MM-dd") + " 00:00:00");
                    for (int i = 0; i < 24; i++)
                    {
                        string key = dtTime.ToString("HH"); //i.ToString("00");
                        TData dd = new TData();
                        dd.key = key;
                        dd.time = dtTime;
                        dicDataYesterday.Add(key, dd);

                        dtTime = dtTime.AddHours(1);
                    }
                }

                if(false)
                {
                    string sql = "select * from ecg_raw_history ";
                    sql += " where eq = '" + empid + "' ";

                    sql += " and writetime > '" + dtpFrom.Value.AddDays(-1).ToString("yy-MM-dd") + "' ";
                    sql += " and writetime < '" + dtpTo.Value.AddDays(1).ToString("yy-MM-dd") + "' ";
                    sql += " and eventcode = '0'";

                    dtRaw = db.sqlToDT(sql);

                    foreach (DataRow dr in dtRaw.Rows)
                    {
                        DateTime dt = cs.strTodt(dr["writetime"].ToString());
                        {
                            string dtkey = dt.ToString("yy-MM-dd HH:mm:00");

                            TData dd;
                            if (dicData1m.TryGetValue(dtkey, out dd))
                            {
                                double bpm = cs.strToDouble(dr["bpm"].ToString());
                                double cal = cs.strToDouble(dr["cal"].ToString());
                                double calexe = cs.strToDouble(dr["calexe"].ToString());
                                double step = cs.strToDouble(dr["step"].ToString());
                                double dist = cs.strToDouble(dr["distancekm"].ToString());
                                double temp = cs.strToDouble(dr["temp"].ToString());
                                int arrcnt = cs.strToInt(dr["arrcnt"].ToString());

                                if (dd.listData.Count == 0)
                                {
                                    dd.bpm = bpm;
                                    dd.cal = cal;
                                    dd.calexe = calexe;
                                    dd.step = step;
                                    dd.distance = dist;
                                    dd.temp = temp;
                                }
                                else
                                {
                                    dd.bpm = Math.Max(dd.bpm, bpm);
                                    dd.cal = Math.Max(dd.cal, cal);
                                    dd.calexe = Math.Max(dd.calexe, calexe);
                                    dd.step = Math.Max(dd.step, step);
                                    dd.distance = Math.Max(dd.distance, dist);
                                    dd.temp = Math.Max(dd.temp, temp);
                                }

                                dd.listBPM.Add(bpm);
                                dd.listCal.Add(cal);
                                dd.listCalExe.Add(calexe);
                                dd.listStep.Add(step);
                                dd.listDistance.Add(dist);
                                dd.listTemp.Add(temp);

                                dd.arrcnt += arrcnt;

                                dd.listData.Add(dr);
                            }
                        }
                        {
                            string dtkey = dt.ToString("HH");

                            TData dd;
                            if (dicData.TryGetValue(dtkey, out dd))
                            {
                                double bpm = cs.strToDouble(dr["bpm"].ToString());
                                double cal = cs.strToDouble(dr["cal"].ToString());
                                double calexe = cs.strToDouble(dr["calexe"].ToString());
                                double step = cs.strToDouble(dr["step"].ToString());
                                double dist = cs.strToDouble(dr["distancekm"].ToString());
                                double temp = cs.strToDouble(dr["temp"].ToString());
                                int arrcnt = cs.strToInt(dr["arrcnt"].ToString());

                                if (dd.listData.Count == 0)
                                {
                                    dd.bpm = bpm;
                                    dd.cal = cal;
                                    dd.calexe = calexe;
                                    dd.step = step;
                                    dd.distance = dist;
                                    dd.temp = temp;
                                }
                                else
                                {
                                    dd.bpm = Math.Max(dd.bpm, bpm);
                                    dd.cal = Math.Max(dd.cal, cal);
                                    dd.calexe = Math.Max(dd.calexe, calexe);
                                    dd.step = Math.Max(dd.step, step);
                                    dd.distance = Math.Max(dd.distance, dist);
                                    dd.temp = Math.Max(dd.temp, temp);
                                }

                                dd.listBPM.Add(bpm);
                                dd.listCal.Add(cal);
                                dd.listCalExe.Add(calexe);
                                dd.listStep.Add(step);
                                dd.listDistance.Add(dist);
                                dd.listTemp.Add(temp);

                                dd.arrcnt += arrcnt;

                                dd.listData.Add(dr);
                            }
                        }
                    }
                }

                {
                    string sql = "select * from ecg_raw_history ";
                    sql += " where eq = '" + empid + "' ";

                    sql += " and writetime > '" + dtpFrom.Value.AddDays(-7).ToString("yy-MM-dd") + "' ";
                    sql += " and writetime < '" + dtpTo.Value.AddDays(1).ToString("yy-MM-dd") + "' ";
                    sql += " and eventcode = '0'";

                    dtRaw = db.sqlToDT(sql);

                    foreach (DataRow dr in dtRaw.Rows)
                    {
                        DateTime dt = cs.strTodt(dr["writetime"].ToString());
                        {
                            string dtkey = dt.ToString("yy-MM-dd HH:mm:00");

                            TData dd;
                            if (dicData1m.TryGetValue(dtkey, out dd))
                            {
                                double bpm = cs.strToDouble(dr["bpm"].ToString());
                                double cal = cs.strToDouble(dr["cal"].ToString());
                                double calexe = cs.strToDouble(dr["calexe"].ToString());
                                double step = cs.strToDouble(dr["step"].ToString());
                                double dist = cs.strToDouble(dr["distancekm"].ToString());
                                double temp = cs.strToDouble(dr["temp"].ToString());
                                int arrcnt = cs.strToInt(dr["arrcnt"].ToString());

                                if (dd.listData.Count == 0)
                                {
                                    dd.bpm = bpm;
                                    dd.cal = cal;
                                    dd.calexe = calexe;
                                    dd.step = step;
                                    dd.distance = dist;
                                    dd.temp = temp;
                                }
                                else
                                {
                                    dd.bpm = Math.Max(dd.bpm, bpm);
                                    dd.cal = Math.Max(dd.cal, cal);
                                    dd.calexe = Math.Max(dd.calexe, calexe);
                                    dd.step = Math.Max(dd.step, step);
                                    dd.distance = Math.Max(dd.distance, dist);
                                    dd.temp = Math.Max(dd.temp, temp);
                                }

                                dd.listBPM.Add(bpm);
                                dd.listCal.Add(cal);
                                dd.listCalExe.Add(calexe);
                                dd.listStep.Add(step);
                                dd.listDistance.Add(dist);
                                dd.listTemp.Add(temp);

                                dd.arrcnt += arrcnt;

                                dd.listData.Add(dr);
                            }
                        }
                        {
                            string dtkey = dt.ToString("yy-MM-dd HH:00:00"); //dt.ToString("ddHH");

                            TData dd;
                            if (dicData.TryGetValue(dtkey, out dd))
                            {
                                double bpm = cs.strToDouble(dr["bpm"].ToString());
                                double cal = cs.strToDouble(dr["cal"].ToString());
                                double calexe = cs.strToDouble(dr["calexe"].ToString());
                                double step = cs.strToDouble(dr["step"].ToString());
                                double dist = cs.strToDouble(dr["distancekm"].ToString());
                                double temp = cs.strToDouble(dr["temp"].ToString());
                                int arrcnt = cs.strToInt(dr["arrcnt"].ToString());

                                if (dd.listData.Count == 0)
                                {
                                    dd.bpm = bpm;
                                    dd.cal = cal;
                                    dd.calexe = calexe;
                                    dd.step = step;
                                    dd.distance = dist;
                                    dd.temp = temp;
                                }
                                else
                                {
                                    dd.bpm = Math.Max(dd.bpm, bpm);
                                    dd.cal = Math.Max(dd.cal, cal);
                                    dd.calexe = Math.Max(dd.calexe, calexe);
                                    dd.step = Math.Max(dd.step, step);
                                    dd.distance = Math.Max(dd.distance, dist);
                                    dd.temp = Math.Max(dd.temp, temp);
                                }

                                dd.listBPM.Add(bpm);
                                dd.listCal.Add(cal);
                                dd.listCalExe.Add(calexe);
                                dd.listStep.Add(step);
                                dd.listDistance.Add(dist);
                                dd.listTemp.Add(temp);

                                dd.arrcnt += arrcnt;

                                dd.listData.Add(dr);
                            }
                        }
                    }
                }

                {
                    string sql = "select * from ecg_raw_history ";
                    sql += " where eq = '" + empid + "' ";

                    sql += " and writetime > '" + dtpFrom.Value.AddDays(-2).ToString("yy-MM-dd") + "' ";
                    sql += " and writetime < '" + dtpTo.Value.AddDays(0).ToString("yy-MM-dd") + "' ";
                    sql += " and eventcode = '0'";

                    dtRawYesterday = db.sqlToDT(sql);

                    foreach (DataRow dr in dtRawYesterday.Rows)
                    {
                        DateTime dt = cs.strTodt(dr["writetime"].ToString());

                        string dtkey = dt.ToString("HH");

                        TData dd;
                        if (dicDataYesterday.TryGetValue(dtkey, out dd))
                        {
                            double bpm = cs.strToDouble(dr["bpm"].ToString());
                            double cal = cs.strToDouble(dr["cal"].ToString());
                            double calexe = cs.strToDouble(dr["calexe"].ToString());
                            double step = cs.strToDouble(dr["step"].ToString());
                            double dist = cs.strToDouble(dr["distancekm"].ToString());
                            double temp = cs.strToDouble(dr["temp"].ToString());
                            int arrcnt = cs.strToInt(dr["arrcnt"].ToString());

                            if (dd.listData.Count == 0)
                            {
                                dd.bpm = bpm;
                                dd.cal = cal;
                                dd.calexe = calexe;
                                dd.step = step;
                                dd.distance = dist;
                                dd.temp = temp;
                            }
                            else
                            {
                                dd.bpm = Math.Max(dd.bpm, bpm);
                                dd.cal = Math.Max(dd.cal, cal);
                                dd.calexe = Math.Max(dd.calexe, calexe);
                                dd.step = Math.Max(dd.step, step);
                                dd.distance = Math.Max(dd.distance, dist);
                                dd.temp = Math.Max(dd.temp, temp);
                            }

                            dd.listBPM.Add(bpm);
                            dd.listCal.Add(cal);
                            dd.listCalExe.Add(calexe);
                            dd.listStep.Add(step);
                            dd.listDistance.Add(dist);
                            dd.listTemp.Add(temp);

                            dd.arrcnt += arrcnt;

                            dd.listData.Add(dr);
                        }
                    }
                }

                {
                    string sql = "select * from ecg_raw_history ";
                    sql += " where eq = '" + empid + "' ";

                    sql += " and writetime > '" + dtpFrom.Value.AddDays(-1).ToString("yy-MM-dd") + "' ";
                    sql += " and writetime < '" + dtpTo.Value.AddDays(1).ToString("yy-MM-dd") + "' ";
                    sql += " and eventcode = '1' ";

                    dtArr = db.sqlToDT(sql);

                }

                if(dtRaw.Rows.Count == 0)
                {
                    MessageBox.Show("데이터가 없습니다.");
                    return;
                }

                string id = dtRaw.Rows[0]["eq"].ToString();
                string formfile = @"c:\msl\lhreportform.xlsx";// @"c:\dair\msl\ECG_" + id + "_" + DateTime.Now.ToString("yyMMddHHmmss") + ".xlsx";
                string file = "LookHeart Report (" + id + ") " + DateTime.Now.ToString("yyMMddHHmmss") + ".xlsx";

                XLWorkbook wb = new XLWorkbook(formfile);

                IXLWorksheet wsi = wb.Worksheet("info");
                wsi.Cell(1, 2).Value = empid;
                wsi.Cell(2, 2).Value = dtpFrom.Value.ToString("yy-MM-dd HH:mm:ss");
                wsi.Cell(3, 2).Value = dtpTo.Value.ToString("yy-MM-dd HH:mm:ss");

                { 
                    IXLWorksheet ws = wb.Worksheet("data");

                    int r = 9;
                    ws.Cell(r, 1).Value = "날짜";// time.ToString("yy-MM-dd HH:mm:ss");
                    ws.Cell(r, 2).Value = "시각";// time.ToString("yy-MM-dd HH:mm:ss");
                    ws.Cell(r, 3).Value = "cal";
                    ws.Cell(r, 4).Value = "calexe";
                    ws.Cell(r, 5).Value = "step";
                    ws.Cell(r, 6).Value = "distance";
                    ws.Cell(r, 7).Value = "temp";
                    ws.Cell(r, 8).Value = "arrcnt";

                    r++;

                    DateTime dtTime = cs.strTodt(dtpFrom.Value.AddDays(-6).ToString("yy-MM-dd") + " 00:00:00");
                    for (int j = 0; j < 7; j++)
                    {
                        for (int i = 0; i < 24; i++)
                        {
                            string key = dtTime.ToString("yy-MM-dd HH:00:00");// j.ToString() + i.ToString("00");
                            TData dd = null;
                            if (dicData.TryGetValue(key, out dd))
                            {
                                ws.Cell(r, 1).Value = dd.time.ToString("yy-MM-dd");
                                ws.Cell(r, 2).Value = dd.time.ToString("HH");

                                //if (dd.bpm > 0)
                                //    ws.Cell(r, 2).Value = dd.bpm;
                                ws.Cell(r, 3).Value = dd.cal;
                                ws.Cell(r, 4).Value = dd.calexe;
                                ws.Cell(r, 5).Value = dd.step;
                                ws.Cell(r, 6).Value = dd.distance;
                                ws.Cell(r, 7).Value = dd.temp;
                                ws.Cell(r, 8).Value = dd.arrcnt;

                                if (dd.temp > 0)
                                    ws.Cell(r, 15).Value = dd.temp;
                                r++;
                            }

                            dtTime = dtTime.AddHours(1);
                        }
                    }
                }
                {
                    IXLWorksheet ws = wb.Worksheet("databpm");

                    int r = 9;
                    ws.Cell(r, 1).Value = "시각";// time.ToString("yy-MM-dd HH:mm:ss");
                    //ws.Cell(r, 2).Value = "bpm";
                    //ws.Cell(r, 3).Value = "cal";
                    //ws.Cell(r, 4).Value = "calexe";
                    //ws.Cell(r, 5).Value = "step";
                    //ws.Cell(r, 6).Value = "distance";
                    //ws.Cell(r, 7).Value = "temp";
                    //ws.Cell(r, 8).Value = "arrcnt";

                    int cc = 2;
                    int mm = 0;
                    r++;
                    foreach (KeyValuePair<string, TData> kv in dicData1m)
                    {
                        TData dd = kv.Value;

                        ws.Cell(9, cc).Value = dd.time.ToString("MM-dd");

                        ws.Cell(r, 1).DataType = XLDataType.Text;
                        ws.Cell(r, 1).SetValue<string>(dd.time.ToString("HH:mm"));// time.ToString("yy-MM-dd HH:mm:ss");
                        ws.Cell(r, 1).DataType = XLDataType.Text;

                        if (dd.bpm > 0)
                            ws.Cell(r, cc).Value = dd.bpm;

                        //ws.Cell(r, 3).Value = dd.cal;
                        //ws.Cell(r, 4).Value = dd.calexe;
                        //ws.Cell(r, 5).Value = dd.step;
                        //ws.Cell(r, 6).Value = dd.distance;
                        //ws.Cell(r, 7).Value = dd.temp;
                        //ws.Cell(r, 8).Value = dd.arrcnt;
                        r++;
                        mm++;
                        if(mm >= 1440)
                        {
                            mm = 0;
                            r = 10;
                            cc++;
                        }
                    }
                }
                {
                    IXLWorksheet ws = wb.Worksheet("datayesterday");

                    int r = 9;
                    ws.Cell(r, 1).Value = "시각";// time.ToString("yy-MM-dd HH:mm:ss");
                    ws.Cell(r, 2).Value = "bpm";
                    ws.Cell(r, 3).Value = "cal";
                    ws.Cell(r, 4).Value = "calexe";
                    ws.Cell(r, 5).Value = "step";
                    ws.Cell(r, 6).Value = "distance";
                    ws.Cell(r, 7).Value = "temp";
                    ws.Cell(r, 8).Value = "arrcnt";

                    r++;
                    foreach (KeyValuePair<string, TData> kv in dicDataYesterday)
                    {
                        TData dd = kv.Value;
                        ws.Cell(r, 1).Value = dd.key;// time.ToString("yy-MM-dd HH:mm:ss");

                        if (dd.bpm > 0)
                            ws.Cell(r, 2).Value = dd.bpm;
                        ws.Cell(r, 3).Value = dd.cal;
                        ws.Cell(r, 4).Value = dd.calexe;
                        ws.Cell(r, 5).Value = dd.step;
                        ws.Cell(r, 6).Value = dd.distance;
                        ws.Cell(r, 7).Value = dd.temp;
                        ws.Cell(r, 8).Value = dd.arrcnt;
                        r++;
                    }
                }

                {
                    IXLWorksheet ws = wb.Worksheet("raw");

                    int r = 9;
                    ws.Cell(r, 1).Value = "시각";// time.ToString("yy-MM-dd HH:mm:ss");
                    ws.Cell(r, 2).Value = "bpm";
                    ws.Cell(r, 3).Value = "cal";
                    ws.Cell(r, 4).Value = "calexe";
                    ws.Cell(r, 5).Value = "step";
                    ws.Cell(r, 6).Value = "distance";
                    ws.Cell(r, 7).Value = "temp";
                    ws.Cell(r, 8).Value = "arrcnt";

                    r++;
                    foreach (DataRow dr in dtRaw.Rows)
                    {
                        DateTime dt = cs.strTodt(dr["writetime"].ToString());

                        ws.Cell(r,1).Value = dt.ToString("yy-MM-dd HH:mm:ss");
                        ws.Cell(r, 2).Value = cs.strToDouble(dr["bpm"].ToString());
                        ws.Cell(r, 3).Value = cs.strToDouble(dr["cal"].ToString());
                        ws.Cell(r, 4).Value = cs.strToDouble(dr["calexe"].ToString());
                        ws.Cell(r, 5).Value = cs.strToDouble(dr["step"].ToString());
                        ws.Cell(r, 6).Value = cs.strToDouble(dr["distancekm"].ToString());
                        ws.Cell(r, 7).Value = cs.strToDouble(dr["temp"].ToString());
                        ws.Cell(r, 8).Value = cs.strToDouble(dr["arrcnt"].ToString());
                        r++;
                    }
                }

                {
                    IXLWorksheet ws = wb.Worksheet("rawarr");

                    int r = 9;
                    ws.Cell(r, 1).Value = "시각";// time.ToString("yy-MM-dd HH:mm:ss");
                    ws.Cell(r, 2).Value = "bpm";
                    ws.Cell(r, 3).Value = "cal";
                    ws.Cell(r, 4).Value = "calexe";
                    ws.Cell(r, 5).Value = "step";
                    ws.Cell(r, 6).Value = "distance";
                    ws.Cell(r, 7).Value = "temp";
                    ws.Cell(r, 8).Value = "arrcnt";

                    r++;
                    foreach (DataRow dr in dtArr.Rows)
                    {
                        DateTime dt = cs.strTodt(dr["writetime"].ToString());

                        ws.Cell(r, 1).Value = dt.ToString("yy-MM-dd HH:mm:ss");
                        ws.Cell(r, 2).Value = cs.strToDouble(dr["bpm"].ToString());
                        ws.Cell(r, 3).Value = cs.strToDouble(dr["cal"].ToString());
                        ws.Cell(r, 4).Value = cs.strToDouble(dr["calexe"].ToString());
                        ws.Cell(r, 5).Value = cs.strToDouble(dr["step"].ToString());
                        ws.Cell(r, 6).Value = cs.strToDouble(dr["distancekm"].ToString());
                        ws.Cell(r, 7).Value = cs.strToDouble(dr["temp"].ToString());
                        ws.Cell(r, 8).Value = cs.strToDouble(dr["arrcnt"].ToString());
                        r++;
                    }
                }

                using (var fs = new MemoryStream())
                {
                    wb.SaveAs(fs);

                    // Set the position to the beginning of the stream
                    fs.Position = 0;
                    // Download the stream
                    Application.Download(fs, file);
                    MessageBox.Show("파일이 다운로드 되었습니다.");
                }
            }
            catch (Exception E)
            {
                cs.logError(E);
            }*/
        }

        private void FormLHReport_Shown(object sender, EventArgs e)
        {
            dtpFrom.Value = DateTime.Now.AddDays(-1);
            dtpTo.Value = DateTime.Now.AddDays(-1);
        }

        private void dtpFrom_ValueChanged(object sender, EventArgs e)
        {
            dtpTo.Value = dtpFrom.Value;
        }
    }
    public class TData
    {
        public DateTime time;

        public string key = "";

        public string xx = "";
        public double yy = 0;

        public double bpm = 0;
        public double cal = 0;
        public double calexe = 0;
        public double step = 0;
        public double distance = 0;
        public double temp = 0;

        public double arrcnt = 0;

        public List<DataRow> listData = new List<DataRow>();
        public List<double> listBPM = new List<double>();
        public List<double> listCal = new List<double>();
        public List<double> listCalExe = new List<double>();
        public List<double> listStep = new List<double>();
        public List<double> listDistance = new List<double>();
        public List<double> listTemp = new List<double>();
    }
}
