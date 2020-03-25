/*
 * Created by SharpDevelop.
 * User: dell
 * Date: 2019-03-31
 * Time: 13:17
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Threading;
using System.Diagnostics;
using System.Windows.Forms;

namespace SystemRFID
{
	/// <summary>
	/// Class with program entry point.
	/// </summary>
	internal sealed class Program
	{
		/// <summary>
		/// Program entry point.
		/// </summary>
		[STAThread]
		private static void Main(string[] args)
		{
 
        Application.ThreadException += new ThreadExceptionEventHandler(Application_ThreadException);
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);
 //                    private static string ClassName = MethodBase.GetCurrentMethod().DeclaringType.ToString();
 //       private static readonly log4net.ILog Mainlog = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
            try
            {
                SerwerApplicationContext contex = new SerwerApplicationContext();

                //               Application.Run(new MainForm());
                Application.Run(contex);


            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                Application.Exit();
 //               return;
            }

        }

        static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            // Log the exception, display it, etc
            //           Debug.WriteLine(e.Exception.Message);
            Console.Out.WriteLine(e.Exception.Message);
        }

        static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            // Log the exception, display it, etc
            //           Debug.WriteLine((e.ExceptionObject as Exception).Message);
            Console.Out.WriteLine((e.ExceptionObject as Exception).Message);
        }

  }
  
}
