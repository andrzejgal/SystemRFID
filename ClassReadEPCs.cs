using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nedap.IdReader.Exceptions;
using System.Windows.Forms;
using System.Reflection;
using SystemRFID.Klasy_IdReader;


namespace SystemRFID
{

     class ClassReadEPCs:KlasaCzytanie 
    {
        private readonly static string  ClassName = MethodBase.GetCurrentMethod().DeclaringType.ToString();
        private ListOfReadEPCs lst;
        private readonly short Czas_pol;

        public ClassReadEPCs(ListOfReadEPCs lstA,short czas):base(czas/*,zamk_pol*/) 
        {
            lst = lstA;
            Czas_pol = czas;
        }

        public virtual void ReadEPCsFromReader()
        {
            string MethodeName = MethodBase.GetCurrentMethod().ToString();
            try
            { 
               FormCzasPomiaru czas = new FormCzasPomiaru();
               czas.Visible = true;
                while(!FormCzasPomiaru.CzytajCzas())
                {
                    Application.DoEvents();
                }
               ArrayList alp = new ArrayList();
               alp=Czytaj();
//               alp = ListReadEPCs(); //przekazanie listy odczytanych etykiet
               if (alp==null)
               {
                    String kp = "Nie odczytano żadnej etykiety";
                    MessageBox.Show(kp);
                    return;

               }
                lst.Visible = true;
                foreach (Object ob in alp)
                {
                   lst.AddEPCToList(ob.ToString()); //ukazanie odczytanych etykiet w oknie
                }
                lst.Refresh();
            }
            catch(IdReaderException eId)
            {
                   MessageBox.Show("Wyjątek","Brak połączenia z IdReaderem");
 //                 log.Fatal(eId.Message);
            }
            catch(Exception ex)
            {
                   MessageBox.Show("Wyjątek", ex.Message);
 //                  log.Fatal(ex.Message);
            }


        }
    }//ClassReadEPC

}
