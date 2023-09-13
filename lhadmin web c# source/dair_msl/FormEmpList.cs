using cubemeslight;
using cubemesweb.dair_mobile;
using System;
using System.Data;
using Wisej.Web;


namespace cubemesweb.dair_msl
{
    public partial class FormEmpList : Page
    {
        DataTable dtEmpList = null;
        DataRow drEmpDataLast = null;
        DMDB db;

        public FormEmpList()
        {
            InitializeComponent();
            db = new DMDB();
        }

        private void reload()
        {
            try
            {
                
                string sql = "select * from ecg_raw_history_last  ";
                if(chkOrderID.Checked) { sql += " order by eq asc "; }
                else if (chkOrderTime.Checked) { sql += " order by writetime desc "; }
                dtEmpList = db.sqlToDT(sql);
                gvEmpList.RowCount = 0;
                gvEmpList.Invalidate();
                gvEmpList.RowCount = dtEmpList.Rows.Count;
                gvEmpList.Invalidate();
            }
            catch (Exception E)
            {
                cs.logError(E);
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

                if(dtEmpList!=null)
                {
                    string col = gvEmpList.Columns[c].HeaderText;
                    if (gvEmpList.Columns[c].ToolTipText != "")
                        col = gvEmpList.Columns[c].ToolTipText;
                    string sv = "";

                    DataRow dr = dtEmpList.Rows[r];
                    
                    if (col.ToLower() == "distanceKM".ToLower())
                    {
                        double dM = cs.strToDouble(dr["distanceKM"].ToString()) / 1000.0;
                        sv = dM.ToString("0.0##");
                    }
                    else
                    {
                        sv = dr[col].ToString();
                    }

                    e.Value = sv;
                }
            }
            catch (Exception E)
            {
                cs.logError(E);
            }
        }

        private void FormEmpList_Load(object sender, EventArgs e)
        {
            timerTick.Enabled = true;    
            reload();
        }                

        private void btnReload_Click(object sender, EventArgs e)
        {
            reload();
        }

        private void gvEmpList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int r = e.RowIndex;
                int c = e.ColumnIndex;

                if (r < 0) return;
                if (c < 0) return;

                if (dtEmpList != null)
                {
                    string col = gvEmpList.Columns[c].HeaderText;
                    DataRow dr = dtEmpList.Rows[r];

                    string id = dr["eq"].ToString();

                    Application.Session["empid"] = id;

                    FormEmpOverview ff = new FormEmpOverview() { Name = Application.SessionId + ".FormEmpOverview" };
                    ff.Show();                    
                }
            }
            catch (Exception E)
            {
                cs.logError(E);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Application.OpenPages[Application.SessionId + ".FormLoginMobile"].Show();
        }

        private void btnNotice_Click(object sender, EventArgs e)
        {
            FormTableViewer ff = new FormTableViewer();
            ff.Show();
        }

        private void timerTick_Tick(object sender, EventArgs e)
        {
            if(Visible)
            {
                if (chkAutoReload.Checked)
                {
                    reload();
                }
            }
        }
    }
}
