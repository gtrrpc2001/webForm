using cubemeslight;
using cubemesweb.dair_msl;
using System;
using System.Data;
using Wisej.Web;

namespace cubemesweb.dair_mobile
{
    public partial class FormTableViewer : Page
    {
        public string table = "board_notice";
        DataTable dt;
        public string order = "";
        public FormTableViewer()
        {
            InitializeComponent();
        }

        private void reload()
        {
            try
            {
                DMDB db = new DMDB();
                string sql = "select * from " + table + " ";
                if (order != "")
                    sql += order;
                dt = db.sqlToDT(sql);

                gv.DataSource = dt;
            }
            catch (Exception E)
            {
                cs.logError(E);
            }
        }

        private void FormTableViewer_Load(object sender, EventArgs e)
        {
            reload();
        }       

        private void button1_Click(object sender, EventArgs e)
        {
            FormEmpList ff = (FormEmpList)Application.OpenPages[Application.SessionId + ".FormEmpList"];
            ff.Show();
        }
    }
}
