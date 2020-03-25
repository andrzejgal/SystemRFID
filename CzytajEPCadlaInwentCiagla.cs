    using System;
    using System.Collections;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Nedap.IdReader.Exceptions;
    using System.Windows.Forms;
    using System.Reflection;
//    using SystemRFID.Klasy_IdReader;


    namespace SystemRFID
    {

        class CzytajEPCadlaInwentCiagla : ClassReadEPCs
        {
            private readonly static string ClassName = MethodBase.GetCurrentMethod().DeclaringType.ToString();
            private ListOfReadEPCs lst;
            private readonly short Czas_pol;
            private Boolean inwentaryzacja = false;

            public CzytajEPCadlaInwentCiagla(ListOfReadEPCs lstA, short czas) : base(lstA, czas)
            {
                lst = lstA;
                Czas_pol = czas;
            }

            public Boolean Inwent
                {
                get {return inwentaryzacja;}
                set { inwentaryzacja = value; }
                }

            public override void ReadEPCsFromReader()
            {
                string MethodeName = MethodBase.GetCurrentMethod().ToString();
                ArrayList alp = new ArrayList();
                try
                {
                    while (/*true*/inwentaryzacja)
                    {
                        alp = Czytaj();
                        if (alp == null)
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
                        alp.Clear();
                    Application.DoEvents();
                    }
                }
                catch (IdReaderException eId)
                {
                    MessageBox.Show("Wyjątek", "Brak połączenia z IdReaderem");
                    //                 log.Fatal(eId.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Wyjątek", ex.Message);
                    //                  log.Fatal(ex.Message);
                }


            }
        }//ClassReadEPC

    }

