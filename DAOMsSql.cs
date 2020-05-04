using System;
using System.Diagnostics;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Threading;

namespace SystemRFID

{

    class DAOMsSqlException:Exception
    {
        public DAOMsSqlException(string ExMess) : base(ExMess)
        {
        }
    }

    class DAOMsSql
    {
        private static readonly log4net.ILog DAOMlog = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        private static string ClassName = MethodBase.GetCurrentMethod().DeclaringType.ToString();
        //       private static SqlConnection Nconn = new SqlConnection(CreateConnectionString());
        public static SqlConnection Nconn;
        const int DuplicationError = -2146232060;

        static public String CreateConnectionString()
        {
            string MethodeName = MethodBase.GetCurrentMethod().ToString();
            try
             {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = "localhost";   
                builder.UserID = "sa";              
                builder.Password = "A1drz2e3j4g";      
                builder.InitialCatalog = "rfid";
                builder.Pooling = true;
                builder.MinPoolSize = 50;
                builder.MaxPoolSize = 100;
               builder.ConnectTimeout = 0;
                return builder.ToString();

            }
            catch (Exception e)
            {
                DAOMlog.Fatal(e.Message);
                string mess = Utils.DisplayExceptionMessage(e, MethodeName, ClassName, "Wyjątek przy tworzeniu łańcucha połączeń");
                throw new DAOMsSqlException(mess);
                //     
                return null;
            }
        }//static public void CreateConnectionString()

        static public void UsunPulePolaczen()
        {
            string MethodeName = MethodBase.GetCurrentMethod().ToString();
            SqlConnection.ClearAllPools();
       }

        static public void UtworzPulePolaczen()
        {
            string MethodeName = MethodBase.GetCurrentMethod().ToString();
            try
            {

                SqlConnection Nconn = new SqlConnection(CreateConnectionString());
                Nconn.Open();
                Nconn.Close();
 //               Nconn.Close();
            }
            catch(Exception e)
            {
                Console.Out.WriteLine(e.Message);
            }
         }


        static public bool LoadTableToDataGrid(DataGridView grid,String ITableName)
        {
           bool wyn = true;
                      String st = null;
                      string queryString = "Select * from "+ITableName;
                      string MethodeName = MethodBase.GetCurrentMethod().ToString();
                    SqlConnection Nconn = new SqlConnection(CreateConnectionString());
            try
                      {
                          SqlCommand command = new SqlCommand(queryString, Nconn);
                          Nconn.Open();
                          SqlDataReader reader = command.ExecuteReader();
                          if (reader.HasRows)
                          {
                              while (reader.Read())
                              {
                                  int cc = reader.FieldCount;
                                  int rowId = grid.Rows.Add();
                                  DataGridViewRow row = grid.Rows[rowId];
                                  for (int ind = 0; ind < cc; ind++)
                                  {
                                      switch (ind)
                                      {
                                          case 0:
                                              {
                                                  int war = reader.GetInt32(ind);
                                                  st = war.ToString();
                                                  break;
                                              };
                                          case 2:
                                              {
                                                  int war = reader.GetByte(ind);
                                                  if (war == globals.unsold) st = "unsold"; else st = "sold";
                                                  //                                    st = war.ToString();
                                                  break;
                                              };
                                          case 3:
                                              {
                                                  DateTime day = reader.GetDateTime(ind);
                                                  st = day.ToString();
                                                  break;
                                              };
                                          case 1:
                                          case 4:
                                          case 5:
                                          case 6:
                                              {
                                                  st = reader.GetString(ind);
                                                  break;
                                              }

                                      }

                                      row.Cells[ind].Value = st;

                                  }
                              }

                          }
                      }
                      catch (Exception e)
                      {
                               string mess = Utils.DisplayExceptionMessage(e, MethodeName, ClassName,
                               "Wyjątek ładowaniu bazy do wyświetlacza");
                DAOMlog.Fatal(mess);
                               throw new DAOMsSqlException(mess);
                     }
                    finally
                      {
                        Nconn.Close();


                      }
                       return wyn;

        }

        static public String ReadStatus(String IEPC,String ITableName,SqlConnection Nconn)
        {
            string MethodeName = MethodBase.GetCurrentMethod().ToString();
            String st = null;
            Object obj = new object();
            Stopwatch a1 = new Stopwatch();
             lock (obj)
             {
                string queryString = "Select * from "+ITableName+" WHERE EPC="+"'"+IEPC+"'";
                 try
                {
                    SqlCommand command = new SqlCommand(queryString, Nconn);
                    a1.Start();
                    SqlDataReader reader = command.ExecuteReader();
                    a1.Stop();
                    Console.Out.WriteLine("czas w funkcji ReadStatus : " + a1.ElapsedMilliseconds.ToString());
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            int ba = reader.GetByte(2);
                            st = ba.ToString();
                             reader.Close();
//                            reader.Dispose();
                            return st;
                        }
                    }
                     reader.Close();
 //                   reader.Dispose();
                }
                catch (SqlException e)
                {
                    DAOMlog.Fatal(e.Message);
                    string mess = Utils.DisplayExceptionMessage(e, MethodeName, ClassName,
                        "Wyjątek przy odczycie statusu");
                    throw new DAOMsSqlException(mess);
                }
                catch (Exception e)
                {
                    DAOMlog.Fatal(e.Message);
                    string mess = Utils.DisplayExceptionMessage(e, MethodeName, ClassName,
                        "Wyjątek przy odczycie statusu");
                    throw new DAOMsSqlException(mess);
                }
    //            finally
    //            {
                    //               Monitor.Exit(obj);
  //                                   Nconn.Close();
//                    reader

    //            }
               
            }
            return "1";
        }
/*
        static public String ReadStatus(String IEPC, String ITableName)
        {
            String st = null;
            Object obj = new object();
            lock (obj)
            {
                string queryString = "Select * from " + ITableName + " WHERE EPC=" + "'" + IEPC + "'";
                string MethodeName = MethodBase.GetCurrentMethod().ToString();
                //               DAOMlog.Debug("przed otwarciem Nconn");
                                SqlConnection Nconn = new SqlConnection(CreateConnectionString());
                //               DAOMlog.Debug("po zamknięciu Nconn");
                try
                {
                    SqlCommand command = new SqlCommand(queryString, Nconn);
                    Nconn.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            int ba = reader.GetByte(2);
                            st = ba.ToString();
                            //                       Monitor.Exit(obj);
                            return st;
                        }
                    }
                }
                catch (SqlException e)
                {
                    //               Console.Out.WriteLine(e.Message);
                    DAOMlog.Fatal(e.Message);
                    string mess = Utils.DisplayExceptionMessage(e, MethodeName, ClassName,
                        "Wyjątek przy odczycie statusu");
                    throw new DAOMsSqlException(mess);
                }
                catch (Exception e)
                {
                    DAOMlog.Fatal(e.Message);
                    string mess = Utils.DisplayExceptionMessage(e, MethodeName, ClassName,
                        "Wyjątek przy odczycie statusu");
                    throw new DAOMsSqlException(mess);
                }
                finally
                {
                    //               Monitor.Exit(obj);
                    Nconn.Close();

                }

            }
            return "1";
        }
*/
        static public String ReadStatus(String IEPC, String ITableName)
        {
            string MethodeName = MethodBase.GetCurrentMethod().ToString();
            String st = null;
            Object obj = new object();
            lock (obj)
            {
                string queryString = "Select * from " + ITableName + " WHERE EPC=" + "'" + IEPC + "'";
                //               DAOMlog.Debug("przed otwarciem Nconn");
                SqlConnection Nconn = new SqlConnection(CreateConnectionString());
                //               DAOMlog.Debug("po zamknięciu Nconn");
                try
                {
                    SqlCommand command = new SqlCommand(queryString, Nconn);
                    Nconn.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            int ba = reader.GetByte(2);
                            st = ba.ToString();
                            //                       Monitor.Exit(obj);
                            return st;
                        }
                    }
                }
                catch (SqlException e)
                {
                    //               Console.Out.WriteLine(e.Message);
                    DAOMlog.Fatal(e.Message);
                    string mess = Utils.DisplayExceptionMessage(e, MethodeName, ClassName,
                        "Wyjątek przy odczycie statusu");
                    throw new DAOMsSqlException(mess);
                }
                catch (Exception e)
                {
                    DAOMlog.Fatal(e.Message);
                    string mess = Utils.DisplayExceptionMessage(e, MethodeName, ClassName,
                        "Wyjątek przy odczycie statusu");
                    throw new DAOMsSqlException(mess);
                }
                finally
                {
                    //               Monitor.Exit(obj);
                    Nconn.Close();

                }

            }
            return st;
        }



        int ReadColumnsCount(SqlConnection conn)
           {
            int wyn = 0;
            return wyn;
            }

        static public void ChangeStatus(String IEPC, int status,String ITableName)
           {
            string MethodeName = MethodBase.GetCurrentMethod().ToString();
            String update = "UPDATE "+ITableName+" SET Status=" + status + " WHERE EPC=" + "'" + IEPC + "'";
            SqlConnection Nconn = new SqlConnection(CreateConnectionString()); try
            {
 //               SqlConnection cnn = ConnectionToDatabase.CreateConnection();
                SqlCommand command = new SqlCommand(update, Nconn);
                Nconn.Open();
                command.ExecuteNonQuery();
 
            }
            catch (Exception e)
            {
                DAOMlog.Fatal(e.Message);
                string mess = Utils.DisplayExceptionMessage(e, MethodeName, ClassName,
                    "Wyjątek przy zmianie statusu");
                throw new DAOMsSqlException(mess);
            }
            finally
            {
                Nconn.Close();
            }
        }


        static public bool AddToDataBase(String WEPC,String WNazwa,String WRozmiar,String WKolor)
           {
            string MethodeName = MethodBase.GetCurrentMethod().ToString();
            SqlConnection Nconn = new SqlConnection(CreateConnectionString()); try
            {
                       DateTime dt = DateTime.Now;
                StringBuilder nb = new StringBuilder();
                nb.Append("INSERT INTO etykiety (EPC,Status,Data,Nazwa,Rozmiar,Kolor");
                nb.Append(") ");
                nb.Append(" VALUES ( ");
                nb.Append("'" + WEPC + "'");
                nb.Append(",");
                nb.Append("'" + globals.unsold + "'");
                nb.Append(",");
                nb.Append("'" + dt + "'");
                nb.Append(",");
                nb.Append("'" + WNazwa + "'");
                nb.Append(",");
                nb.Append("'" + WRozmiar + "'");
                nb.Append(",");
                nb.Append("'" + WKolor + "'");
                nb.Append(")");
                String queryString = nb.ToString();

 //               String queryString = "INSERT INTO etykiety (EPC,Status,Data,Nazwa,Rozmiar,Kolor)" +
 //                   " VALUES ( "+"'"+IEPC+"'" + " ," + globals.unsold +"," +"'"+dt+"'"+","+INazwa+","+IRozmiar+","+IKolor+")";
 //               SqlConnection cnn = ConnectionToDatabase.CreateConnection();
                SqlCommand command = new SqlCommand(queryString, Nconn);
                       Nconn.Open();
                        command.ExecuteNonQuery();
 //               cnn.Close();

                   }
                catch(Exception e)
                    { 
                        DAOMlog.Fatal(e.Message);
                        if (e.HResult == DuplicationError)
                        {
                            return false;
                        }
                              string mess = Utils.DisplayExceptionMessage(e, MethodeName, ClassName, "Wyjątek przy dodawaniu do bazy");
                               throw new DAOMsSqlException(mess);
                    }

            finally
                   {
                     Nconn.Close();
                   }
            return true;
        }

        static public Boolean AddToDataBase(String IEPC)
        {
            
            string MethodeName= MethodBase.GetCurrentMethod().ToString();
            SqlConnection Nconn = new SqlConnection(CreateConnectionString());
            //           string currentFile = new System.Diagnostics.StackTrace(true).GetFrame(0).GetFileName();
            try
            {
                DateTime dt = DateTime.Now;
                String queryString = "INSERT INTO etykiety (EPC,Status,Data)" +
                                    " VALUES ( " + "'" + IEPC + "'" + " ," + globals.unsold + "," + "'" + dt + "'" + ")";
 
                 SqlCommand command = new SqlCommand(queryString, Nconn);
                Nconn.Open();
                command.ExecuteNonQuery();
 
            }
            catch (Exception e)
            {
                DAOMlog.Fatal(e.Message);
                if (e.HResult== DuplicationError)
                {
                    return false;
                }
                string mess = Utils.DisplayExceptionMessage(e, MethodeName, ClassName, "Wyjątek przy dodawaniu do bazy");
                 throw new DAOMsSqlException(mess);
             }
            finally
            {
                Nconn.Close();
            }
            return true;

        }


        static public void DeleteRow(String ITableName,String IEPC)
           {
            string MethodeName = MethodBase.GetCurrentMethod().ToString();
            SqlConnection Nconn = new SqlConnection(CreateConnectionString());
            try
            {
                String queryString = "DELETE from "+ ITableName +" WHERE EPC=" + "'" + IEPC + "'";
 //               SqlConnection cnn = ConnectionToDatabase.CreateConnection();
                SqlCommand commd = new SqlCommand(queryString, Nconn);
                Nconn.Open();
                commd.ExecuteNonQuery();
 //               cnn.Close();
            }
            catch (SqlException e)
            {
                DAOMlog.Fatal(e.Message);
                string mess = Utils.DisplayExceptionMessage(e, MethodeName, ClassName,
                    "Wyjątek przy kasowaniu rzędu");
                throw new DAOMsSqlException(mess);
            }
            catch (Exception e)
            {
                DAOMlog.Fatal(e.Message);
                string mess = Utils.DisplayExceptionMessage(e, MethodeName, ClassName,
                   "Wyjątek przy kasowaniu rzędu");
                throw new DAOMsSqlException(mess);
            }
            finally
            {
                Nconn.Close();
            }

        }

    static public void CzyscTabele(String ITableName)
        {
            string MethodeName = MethodBase.GetCurrentMethod().ToString();
            SqlConnection Nconn = new SqlConnection(CreateConnectionString());
            try
            {
                String queryString = "TRUNCATE TABLE "+ ITableName;
                SqlCommand commd = new SqlCommand(queryString, Nconn);
                Nconn.Open();
                commd.ExecuteNonQuery();
             }
            catch (SqlException e)
            {
                DAOMlog.Fatal(e.Message);
                string mess = Utils.DisplayExceptionMessage(e, MethodeName, ClassName,
                    "Wyjątek przy czyszczeniu tabeli");
                throw new DAOMsSqlException(mess);
            }
            catch (Exception e)
            {
                DAOMlog.Fatal(e.Message);
                string mess = Utils.DisplayExceptionMessage(e, MethodeName, ClassName,
                    "Wyjątek przy czyszczeniu tabeli");
                throw new DAOMsSqlException(mess);
            }
            finally
            {
                Nconn.Close();
            }

        }

    }
}
