using System;
using System.Windows.Forms;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemRFID.formularz_inwentaryzacji;

namespace SystemRFID
{
    class ZapiszDoBazyInwentaryzacje
    {
        private static string ClassName = MethodBase.GetCurrentMethod().DeclaringType.ToString();
        private static readonly log4net.ILog ZapisDoBazyInwentaryzacjaLog = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        private static MainForm frm;
        private int ilosc = 0;
 
        public ZapiszDoBazyInwentaryzacje()
        {
            frm = (MainForm)Application.OpenForms[0];
            try
            {
                FormaInwentaryzacji antn = new FormaInwentaryzacji();
                antn.Visible = true;

            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void ZapiszDoBazy()
        {
        }
    }//class ZapiszDoBazyInwentaryzacje

}//namespace


    

