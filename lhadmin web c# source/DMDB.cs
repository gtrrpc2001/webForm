using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using Wisej.Web;

namespace cubemeslight
{
    public class DMDB
    {
        private string server;
        public string db;
        private string uid;
        private string password;
        public DataGridView datagv;        
        static public string loginname = "";        
        public string connectionString;

        private bool _connectionChecked = false;

        public bool connectionChecked
        {
            get { return _connectionChecked; }
            set { _connectionChecked = value; }
        }

        private MySqlConnection connection;

        public MySqlConnection Connection
        {
            get { return connection; }
            set { connection = value; }
        }

        public DMDB(string dbname = "")
        {
            if (dbname != "")
            {
                cs.APP = dbname;
            }

            if (_connectionChecked == false)
            {
                connectinit(cs.APP);
            }
        }

        public void connectinit(string database)
        {
            try
            {
                db = database;
                uid = "dairadmin";
                password = "!eogksehrflqakstp!";
                server = "db.medsyslab.co.kr";
                connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";Charset=utf8;Allow Zero Datetime=True;";
                connection = new MySqlConnection(connectionString);
                connection.Open();
                _connectionChecked = true;
            }
            catch
            {
                _connectionChecked = false;
            }

        }        

       

        public DataTable sqlToDT(string sql)
        {
            cs.logSQL(sql);
            DataTable dT = new DataTable();
            using (MySqlCommand cmd = new MySqlCommand { Connection = connection, CommandText = sql })
            {
                using (MySqlDataAdapter da = new MySqlDataAdapter { SelectCommand = cmd })
                {
                    da.Fill(dT);
                }
            }            
            return dT;
        }

        public DataRow sqlToDR(string sql)
        {
            DataRow rr = null;
            try
            {
                DataTable dT = sqlToDT(sql);
                rr = dT.Rows[0];
            }
            catch (Exception E)
            {
                cs.logError(E);
            }
            return rr;
        }

        public int login(string id, string pw)
        {
            int myCount = 0;

            if (this.OpenConnection() == true)
            {
                string data = "select count(*)  from emp_list where id = '" + id + "' and pw = '" + pw + "'";
                MySqlCommand count = new MySqlCommand(data, connection);
                myCount = Convert.ToInt32(count.ExecuteScalar());

                if (myCount != 0)
                {
                    MySqlCommand cmd = new MySqlCommand("select emp_name from emp_list where emp_id = '" + id + "' and emp_pw = '" + pw + "'", connection);
                    MySqlDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        loginname = rdr["emp_name"].ToString();
                    }
                    rdr.Close();
                }
                this.CloseConnection();
            }
            return myCount;
        }

        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {                
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server. Contact administrator");
                        break;
                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                    default:
                        MessageBox.Show(ex.Message);
                        break;
                }
                return false;
            }
        }

        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public string insertDic(string table, Dictionary<string, string> dic)
        {
            string r = "";
            try
            {
                string sql = "insert into " + table;

                List<string> lCol = new List<string>();
                List<string> lValue = new List<string>();

                foreach (KeyValuePair<string, string> kv in dic)
                {
                    if (kv.Value == null)
                        continue;
                    if (kv.Key == "#ROW#")
                    {

                    }
                    else
                    {
                        lCol.Add("`" + kv.Key + "`");

                        if (kv.Value.Contains("#"))
                        {
                            string si = kv.Value.Replace("#", "");
                            long ii = 0;
                            if (long.TryParse(si, out ii))
                            {
                                lValue.Add(ii.ToString());
                            }
                            else
                            {
                                lValue.Add("'" + kv.Value + "'");
                            }
                        }

                        else
                        {
                            lValue.Add("'" + kv.Value + "'");
                        }
                    }
                }
                sql += ("(" + string.Join(",", lCol) + ")");
                sql += (" values (" + string.Join(",", lValue) + ");");

                cs.logSQL(sql);
                lock (connection)
                {
                    r = DataExeCute(sql);                   
                }
            }
            catch (Exception E)
            {
                cs.logError(E);
            }
            return r;
        }

        private String DataExeCute(string sql) 
        {
            int auto = 0;
            using (MySqlCommand cmd = new MySqlCommand {Connection = connection , CommandText = sql }) 
            {
                cmd.ExecuteNonQuery();
                auto = (int)cmd.LastInsertedId;
            }
            return auto.ToString();
        }

               
    }
}
