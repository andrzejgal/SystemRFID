//#define ZEZWOLENIE
using System;
using System.Windows.Forms;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemRFID
{
    public class SerwerApplicationContext : ApplicationContext
    {
        private MainForm _mainform;
        private static readonly log4net.ILog SerwerContextlog = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SerwerApplicationContext()
        {
            // Handle the ApplicationExit event to know when the application is exiting.
            Application.ApplicationExit += new EventHandler(this.OnApplicationExit);
            _mainform = new MainForm();
            _mainform.Show();

        }

        private void OnApplicationExit(object sender, EventArgs e)
        {
#if DEBUG && ZEZWOLENIE
            SerwerContextlog.Debug("Jestem w OnApplicationExi");
#endif
//            Serwer_asynchroniczny.StopServer();

         }

    }
    
}
