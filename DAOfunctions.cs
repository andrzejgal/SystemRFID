using System;
using System.Reflection;
using System.Data;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Diagnostics;

namespace SystemRFID
{
    public class DAOfunctions
    {
        private static string ClassName = MethodBase.GetCurrentMethod().DeclaringType.ToString();
        private MySqlConnection MyConn;
        private String server;
        private String database_name;
        private String uid;
        private String password;
        private String ConnectionString;
        private MySqlDataAdapter mySqlDataAdapter;

        public DAOfunctions(String Server,
                             String DatabaseName,
                             String UID,    //nazwa użytkownika
                             String Pass

                            )
        {
            server = Server;
            database_name = DatabaseName;
            uid = UID;
            password = Pass;
        }

        public bool OpenConnection()
        {
            string MethodeName = MethodBase.GetCurrentMethod().ToString();
            ConnectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database_name + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
            MyConn = new MySqlConnection(ConnectionString);
            Debug.Assert(MyConn != null);
            try
            {
                MyConn.Open();
                return true;
            }
            catch (MySqlException e)
            {
                Console.Out.WriteLine(e.Message);
                Application.Exit();
                return false;
            }//catch
        }//Openconnection

        public bool CloseConnection()
        {
            string MethodeName = MethodBase.GetCurrentMethod().ToString();
            try
            {
                MyConn.Close();
                return true;
            }
            catch (MySqlException e)
            {
                Console.Out.WriteLine(e.Message);
                return false;
            }
        }//CloseConnection

        public void LoadDataBaseTableToGrid(DataGridView VD)
        {
            string MethodeName = MethodBase.GetCurrentMethod().ToString();
            string st;
            if (this.OpenConnection())
            {
    
                mySqlDataAdapter = new MySqlDataAdapter("select * from etykiety", MyConn);
                DataSet DS = new DataSet();
                mySqlDataAdapter.Fill(DS);
                DataTable dtable = DS.Tables[0];
                 
                          for (int i=0;i<dtable.Rows.Count;i++)
                            {
                              int rowId = VD.Rows.Add();
                               DataGridViewRow row = VD.Rows[rowId];

                           for (int j=0;j<dtable.Columns.Count;j++)
                              {
                                  object ob = dtable.Rows[i].ItemArray[j];
                                  if (j == 2)
                                  {
                                      st = Convert.ToString(ob);
                                      if (Equals(st, "0")) st = "unsold"; else st = "sold";

                                  }
                                  else
                                  {
                                      st=Convert.ToString(ob);
                                  }

                                  row.Cells[j].Value = st;
                                  
                              }
 
                }
                 

            };
            this.CloseConnection();
        }




    }//class

}//namespace
