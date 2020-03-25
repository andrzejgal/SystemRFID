using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace SystemRFID
{
    class KlasaZapiszDoBazyZUrzadzenia
    {   
        private static string ClassName = MethodBase.GetCurrentMethod().DeclaringType.ToString();
        private static readonly log4net.ILog MainFormlog = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        private static  MainForm frm;
        private  int ilosc = 0;

        public  void ZapiszDoBazyZUrzadzenia()
        {
            DialogResult odp;
            frm =(MainForm) Application.OpenForms[0];
            string MethodeName = MethodBase.GetCurrentMethod().ToString();
            try
            {
                MainFormlog.Debug("Wchodzę do :" + MethodeName);
                int wymiar = FifoClass.Getsize();
                FormDodajDoBazy antn = new FormDodajDoBazy();
                antn.Visible = true;
                do
                {
                    while (FifoClass.GetWritingStatus()) { };
                    while (FifoClass.Getsize() == 0) { Application.DoEvents(); };
                    while (FifoClass.Getsize() > 0)
                    {
                        String wr = FifoClass.ReadFromList();
                        if (wr.Length > 0) 
                        {
                            antn.AddEPCToList(wr);
                            ilosc++;
                            antn.WpiszCalkowitaIloscOdczytanychEtykiet(ilosc);
                        }
                    }
//                }
                    while (!FormDodajDoBazy.CzytajCzyDodano()) { Application.DoEvents(); };
                    FormDodajDoBazy.UstawDodano(false);
                    FifoClass.CzyscFifo();
                    ilosc = 0;
                    antn.WpiszCalkowitaIloscOdczytanychEtykiet(ilosc);
                    frm.RefreshGridView();
                    MessageBoxIcon ik = MessageBoxIcon.Question;
                    MessageBoxButtons bt = MessageBoxButtons.YesNo;
                    odp = MessageBox.Show(null, "", "Czytamy następne etykiety", bt, ik);
                    if (odp == DialogResult.Yes) antn.KasujZawartoscListBoksow();
                } while (odp == DialogResult.Yes);
                //             if (odp==mrYes)
                antn.WpiszCalkowitaIloscOdczytanychEtykiet(ilosc);
                MainFormlog.Debug("Wychodzę z :" + MethodeName);
            }
            catch (Exception eg)
            {
                String km = Utils.DisplayExceptionMessage(eg, MethodeName, ClassName, "Wyjątek w metodzie czytaj z anten");
                MainFormlog.Debug(km);
                throw eg;
            }

        } 
      
    }
}
