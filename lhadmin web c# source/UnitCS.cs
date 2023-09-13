using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace cubemeslight
{
    public class cs
    {
       
        public static string APP = "dair_msl";  
        public static string _KEY_DM = "4444";
        public static string LOGDIR = "c:\\dair";
        [DllImport("User32", EntryPoint = "FindWindow")]
        private static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll")]
        public static extern void SetForegroundWindow(IntPtr hWnd);

        [DllImport("user32.dll")]
        public static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
        private const int SW_SHOWNORMAL = 1;

        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);
        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);

        public static String _KEY_DUPE = "Cannot insert duplicate key in object";

        public static Color COLOR_TITLE_BACK = System.Drawing.ColorTranslator.FromHtml("#474747");
        public static Color COLOR_WALL_BACK = System.Drawing.ColorTranslator.FromHtml("#636363");

        public static Color COLOR_ON_BACK = Color.MediumSeaGreen;
        public static Color COLOR_OFF_BACK = Color.Gray;

        public static Color COLOR_TAB_NORMAL_BACK = System.Drawing.ColorTranslator.FromHtml("#1a2127");
        public static Color COLOR_TAB_PRESSED_BACK = System.Drawing.ColorTranslator.FromHtml("#5a7083");

        public static Boolean _ISDEBUG = false;

        public static Boolean _WO_DB = false; // without db

        public static UInt64 LoginIdx = 0;

        public static Boolean IsNeedUserSync = false; // 로그인 이후 사용자 권한(deny)를 row한 형태의 테이블로 동기화
        
        public static Boolean isDebug()
        {
            Boolean b = false;
            try
            {
                string[] args = Environment.GetCommandLineArgs();

                foreach (string arg in args)
                {
                    if (arg.Contains("-debug"))
                    {
                        return true;
                    }
                }
            }
            catch (Exception E)
            {
                cs.logError(E);
            }
            return b;
        }
        
        public static int strToInt(string v)
        {
            int d = 0;
            Int32.TryParse(v, out d);
            return d;
        }

        public static DateTime strTodt(string sdt)
        {
            DateTime dt;
            if (DateTime.TryParse(sdt, out dt))
            {
                return dt;
            }
            else
            {
                return new DateTime(1900, 1, 1);
            }
        }

        public static double strToDouble(string v)
        {
            double d = 0;
            double.TryParse(v, out d);
            return d;
        }

        public static string Client_IP
        {
            get
            {
                IPHostEntry host = Dns.GetHostEntry(Dns.GetHostName());
                string ClientIP = string.Empty;
                for (int i = 0; i < host.AddressList.Length; i++)
                {
                    if (host.AddressList[i].AddressFamily == AddressFamily.InterNetwork)
                    {
                        ClientIP = host.AddressList[i].ToString();
                    }
                }
                return ClientIP;
            }
        }

        public static String MyIP()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            throw new Exception("No network adapters with an IPv4 address in the system!");
        }

        public static int iIsServer = -1;
        public static int iIsMap = -1;
        public static string UserDCPFilter = "";
        public static string UserPermission = "";

        public static String UserAuth = ""; // 주기적으로 user테이블의 phone필드 저장

        public static Dictionary<String, String> DicUser = new Dictionary<string, string>();

        public static Dictionary<String, String> DicUserAction = new Dictionary<string, string>();

        public static Thread threadLog = null;

        public static Boolean IsApplicationTerminated = false;

        public static Dictionary<String, StringBuilder> DicLog = new Dictionary<string, StringBuilder>();

        public static void LogInit()
        {        
            threadLog = new Thread(() => DoThreadLog());
            threadLog.Start();
        }

        public static void DoThreadLog()
        {
            while (IsApplicationTerminated == false)
            {
                Thread.Sleep(500);

                lock (DicLog)
                {
                    foreach (KeyValuePair<String, StringBuilder> a in DicLog)
                    {
                        String sFile = a.Key;
                        StringBuilder sb = a.Value;

                        try
                        {
                            if (sb.Length > 0)
                            {
                                File.AppendAllText(sFile, sb.ToString());
                                lock (sb)
                                {
                                    sb.Clear();
                                }
                            }
                        }
                        catch
                        {

                        }
                    }
                }
            }
        }
       
        public static String GetValueFromCSV(String AFile, String AFindCol, String AFindValue, String AResultCol, String ADefault = "")
        {
            String[] saRows = File.ReadAllLines(AFile);

            if (saRows.Count() > 0)
            {
                String[] saHeader = saRows[0].Split(',');

                int iFindCol = -1;
                int iResultCol = -1;
                int i = 0;
                foreach (string sHeader in saHeader)
                {
                    if (sHeader == AFindCol)
                    {
                        iFindCol = i;
                    }
                    if (sHeader == AResultCol)
                    {
                        iResultCol = i;
                    }

                    if ((iResultCol >= 0) && (iFindCol >= 0))
                        break;
                    i++;
                }

                if ((iResultCol >= 0) && (iFindCol >= 0))
                {
                    foreach (string sCols in saRows)
                    {
                        String[] saCols = sCols.Split(',');

                        if (iFindCol < saCols.Count())
                        {
                            if (saCols[iFindCol] == AFindValue)
                            {
                                if (iResultCol < saCols.Count())
                                    return saCols[iResultCol];
                                else
                                    return ADefault;
                            }
                        }    
                    }
                }
            }
            return ADefault;
        }
      
        public static void LocalParamSet(String AID, String AValue, Boolean AInsert = false)
        {
            String sf =  Application.StartupPath + "\\setting.ini";
            WritePrivateProfileString("setting", AID, AValue, sf);
        }
      

        public static void Log(String AFile, String ATag = "", String AMsg = "", Boolean AInfo = true, Boolean AShowTime = true)
        {
            try
            {
                if (ATag == "")
                    ATag = "LOG";

                ATag = String.Format("[{0,-10}] ", ATag);
                StringBuilder sb = null;
                if (DicLog.TryGetValue(AFile, out sb) == false)
                {
                    sb = new StringBuilder();

                    lock (DicLog)
                    {
                        DicLog.Add(AFile, sb);
                    }
                }

                if (AInfo)
                {
                    
                    lock (sb)
                    {                        
                        sb.Append(ATag + " " + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff") + "\t" +AMsg + "\r\n");
                        if ((AShowTime == false) || (AMsg.Contains("\r")))
                            sb.Append("\r\n");
                    }
                    
                }
                else
                {
                    lock (sb)
                    {
                        sb.Append(AMsg + "\r\n");
                    }
                }
            }
            catch (Exception ex)
            {
            }
        }

        public static void logSQL(String ASQL, String ATag = "[SQL     ]")
        {
            String m_exePath = LOGDIR;
          
            String sFile = m_exePath + "\\log\\logsql@" + DateTime.Now.ToString("yyMMdd") + ".txt";
            Log(sFile, "SQL", "--------------------------------------------------");
            Log(sFile, "SQL", ASQL);
           
        }

        public static void logError(Exception AError, String ATag = "[ERROR   ]")
        {
            String m_exePath = LOGDIR;
            try
            {
                String sFile = m_exePath + "\\log\\logerror@" + DateTime.Now.ToString("yyMMdd") + ".txt";
                Log(sFile, "ERROR", AError.Message);
                Log(sFile, "", AError.StackTrace);
            }
            catch (Exception ex)
            {
            }
        }

    }
}
