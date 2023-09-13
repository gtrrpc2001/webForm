using cubemeslight;
using cubemesweb.dair_msl;
using System;
using System.Collections.Generic;
using System.Data;
using Wisej.Web;


namespace cubemesweb
{
    public partial class FormLoginMobile : Page
    {
        public FormLoginMobile()
        {
            InitializeComponent();
        }

        private void FormLoginMobile_Resize(object sender, EventArgs e)
        {
            uiResize();
        }
        public void uiResize()
        {
            pBackTop.Height = Height / 2;
            uiCenter(pLogin);
        }

        public void uiCenter(Control obj)
        {
            obj.Location = new System.Drawing.Point((Width - obj.Width) / 2, (Height - obj.Height) / 2);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                DMDB db = new DMDB();

                DataTable dt;
                string sql = "select * from 인원_목록 where 아이디 = '" + edtID.Text + "' and 패스워드 = '" + edtPW.Text + "' ";
                dt = db.sqlToDT(sql);

                if (dt.Rows.Count > 0 || cs.isDebug())
                {
                    DataRow dr = dt.Rows[0];

                    if(dr["승인여부"].ToString() == "승인")
                    {

                    }
                    else
                    {
                        MessageBox.Show("관리자의 로그인 승인이 필요합니다.");
                        return;
                    }

                    if (chkAutoLogin.Checked)
                        cs.LocalParamSet("autologin", "1");
                    else
                        cs.LocalParamSet("autologin", "0");

                    cs.LocalParamSet("lastid", edtID.Text);

                    Application.Session["아이디"] = dr["아이디"].ToString();
                    Application.Session["성명"] = dr["성명"].ToString();
                    Application.Session["권한"] = dr["권한"].ToString();
                    Application.Session["구분"] = dr["구분"].ToString();
                    

                    try
                    {
                        Dictionary<string, string> dic = new Dictionary<string, string>();
                        dic.Add("구분", dr["구분"].ToString());
                        dic.Add("아이디", dr["아이디"].ToString());
                        dic.Add("성명", dr["성명"].ToString());
                        dic.Add("날짜", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                        dic.Add("활동", "로그인");                        
                        db.insertDic("admin_login_log", dic);
                    }
                    catch (Exception E)
                    {
                        cs.logError(E);
                    }

                    if (cs.APP == "dair_msl")
                    {
                        Application.MainPage = new FormEmpList() { Name = Application.SessionId + ".FormEmpList" };
                    }
                }
                else
                {
                    MessageBox.Show("ID 또는 비밀번호가 맞지 않습니다.");
                }
            }
            catch (Exception E)
            {
                MessageBox.Show("서버 또는 네트워크 오류입니다.");
                cs.logError(E);
            }
        }
    }
}
