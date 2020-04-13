/*
 * Created by SharpDevelop.
 * User: dell
 * Date: 2019-03-31
 * Time: 13:17
 * 
 * 17.11.2019
 * Do menu głownego dodaję wybór źródła etykiet, które bedą zapisane do bazy.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 * 
 * 
 */
 //#define DefTimeReachedEvent
//#define WYLACZ_SPRAW_TRWALOSCI

using System;
using System.Text;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using Nedap.IdReader.Exceptions;
using System.Threading;
using System.Reflection;
using SystemRFID.Zmiana_statusu;
using SystemRFID.formularz_niszczenia_tagu;
using SystemRFID.Klasy_IdReader;
using SystemRFID.formularz_wybory_dezaktywacji;
using Nedap.IdReader.Protocol;
using SystemRFID.Encode_dekode_EPC;
using SystemRFID.formularz_okienka_tekstowego;
using SystemRFID.formularz_dodaj_nowe_etykiety;
using SystemRFID.Klasy_IdReader;
using SystemRFID.formularz_inwentaryzacji;
using SystemRFID.formularz_wybory_dezaktywacji;
using SystemRFID.Klasy_IdReader;



namespace SystemRFID
{


    public partial class MainForm : Form
    {
        //
        private static string ClassName = MethodBase.GetCurrentMethod().DeclaringType.ToString();
        private String EPCSelected = "";
        public static Thread serwerAsyn;
        private static readonly log4net.ILog MainFormlog = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        private static Boolean pierwsza_aktywacja = false;

        public MainForm()
        {
            AppDomain currentDomain = AppDomain.CurrentDomain;
            currentDomain.UnhandledException += new UnhandledExceptionEventHandler(Handler);

            InitializeComponent();
            DAOMsSql.UtworzPulePolaczen();
            //wątek do czytania z anten
            Thread thread = new Thread(Serwer_asynchroniczny.StartListening);
            globals.serwerAsyn = thread;
            globals.serwerAsyn.Priority = ThreadPriority.AboveNormal;
            globals.serwerAsyn.Start();
            //           CheckOnClick = true;
        }

        public void UstawSymbolePolaczen(Boolean stan) // true - jest połączenie
        {
            if (stan)
            {
                pictureBoxPolaczenie.BackColor = System.Drawing.Color.Green;
                labelPolaczenieKomunikat.Text = "IdPos jest połączony";
            }
            else
            {
                pictureBoxPolaczenie.BackColor = System.Drawing.Color.Red;
                labelPolaczenieKomunikat.Text = "IdPos nie jest połączony";

            }
        }

        public void UstawFirmwareVersion(String version)
        {
            toolStripStatusFirmwareVersionTresc.Text = version;
        }

        public void UstawHarwareVersion(String version)
        {
            toolStripStatusLabelHaadwareVersionTresc.Text = version;
        }

        public void UstawRegion(String region)
        {
            toolStripStatusLabelRegionTresc.Text = region;
        }




        private void MainForm_Load(object sender, EventArgs e)
        {
            string MethodeName = MethodBase.GetCurrentMethod().ToString();
            TypSerwera TypSer = TypSerwera.SqlServer;
            if (TypSer == TypSerwera.MySqlServer)
            {

                DAOfunctions daof = new DAOfunctions("localhost", "rfid", "root", "");
                daof.LoadDataBaseTableToGrid(TabelaGridView);
            }
            else
            {
                DAOMsSql.LoadTableToDataGrid(/*conn, */TabelaGridView, globals.TableName);
            }
        }


        public void RefreshGridView()
        {
            string MethodeName = MethodBase.GetCurrentMethod().ToString();
            try
            {
                MainFormlog.Debug("Wchodzę do :" + MethodeName);
                TabelaGridView.Rows.Clear();
                DAOMsSql.LoadTableToDataGrid(TabelaGridView, globals.TableName);
                TabelaGridView.Refresh();
                TabelaGridView.Update();
                MainFormlog.Debug("Wychodzę z :" + MethodeName);
            }
            catch (Exception e3)
            {
                String km = Utils.DisplayExceptionMessage(e3, MethodeName, ClassName, "Wyjątek w metodzie RefreshGrid");
                MainFormlog.Debug(km);
                throw e3;
            }
        }

        //dodanie do bazy etykiet odczytanych z anteny

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            SqlConnection.ClearAllPools();
            Serwer_asynchroniczny.StopServer();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        /* METDOTY WYWOŁYWANE PRZEZ MENU RECZNA EDYCJA BAZY*/
        private void usuńRekordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ///           UsunRekord();
        }

        private void UsunRekord()
        {
            string MethodeName = MethodBase.GetCurrentMethod().ToString();
            try
            {
                MainFormlog.Debug("Wchodzę do :" + MethodeName);
                int SelectedRow = TabelaGridView.CurrentCell.RowIndex;
                DataGridViewRow row = TabelaGridView.Rows[SelectedRow];
                string EPC = row.Cells[1].Value.ToString();
                DAOMsSql.DeleteRow(globals.TableName, EPC);
                TabelaGridView.Rows.RemoveAt(SelectedRow);
                MainFormlog.Debug("Wychodzę z :" + MethodeName);
            }
            catch (Exception e)
            {
                String km = Utils.DisplayExceptionMessage(e, MethodeName, ClassName, "Wyjątek w metodzie usuń rekord");
                MainFormlog.Debug(km);
                throw e;
            }
        }

        public void SetEPCSelected(String EPCS)
        {
            string MethodeName = MethodBase.GetCurrentMethod().ToString();
            MainFormlog.Debug("Wchodzę do :" + MethodeName);
            EPCSelected = EPCS;
            MainFormlog.Debug("Wychodzę z :" + MethodeName);
        }

        public String GetEPCSelected()
        {
            //           string MethodeName = MethodBase.GetCurrentMethod().ToString();
            //           MainFormlog.Debug("Wchodzę do :" + MethodeName);
            //           MainFormlog.Debug("Wychodzę z :" + MethodeName);
            return EPCSelected;
        }

        private void buttonCzytajStatus_Click(object sender, EventArgs e)
        {
            string MethodeName = MethodBase.GetCurrentMethod().ToString();
            try
            {
                MainFormlog.Debug("Wchodzę do :" + MethodeName);
                FormaSprawdzStatus fss = new FormaSprawdzStatus();
                ClassReadEPCs crr = new ClassReadEPCs(fss, globals.czas_polaczenia);
                crr.ReadEPCsFromReader();
                MainFormlog.Debug("Wychodzę z :" + MethodeName);
            }
            catch (Exception e4)
            {
                String km = Utils.DisplayExceptionMessage(e4, MethodeName, ClassName, "Wyjątek w metodzie czytania statusu");
                MainFormlog.Debug(km);
                throw e4;

            }
        }

        private void toolStripZadenp_Click(object sender, EventArgs e)
        {
        }

        private void toolStripAntena_Click(object sender, EventArgs e)
        {
            /*
                        toolStripAntena.Checked = true;
                        toolStripZadenp.Checked = false;
                        toolStripIdPos.Checked = false;
             //           toolStripIdReader.Checked = false;
                        Konfig.URZ = Urzadzenie.Antena;
                        KlasaZapiszDoBazyZUrzadzenia.ZapiszDoBazyZUrzadzenia();
            */
        }

        private void toolStripIdPos_Click(object sender, EventArgs e)
        {

        }
        private void sprawdźStatusWBazieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SprawdzStatus();

        }

        private void zniszczEtykieteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string MethodeName = MethodBase.GetCurrentMethod().ToString();
            try
            {
                MainFormlog.Debug("Wchodzę do :" + MethodeName);
                FormNiszczenieTagu fss = new FormNiszczenieTagu();
                ClassReadEPCs crr = new ClassReadEPCs(fss, globals.czas_polaczenia);
                //               fss.UstawWskaznikNaKlaseNiszczenia(crr);
                crr.ReadEPCsFromReader();
                //              crr.ZniszczTag(crr.)
                MainFormlog.Debug("Wychodzę z :" + MethodeName);
            }
            catch (Exception e4)
            {
                String km = Utils.DisplayExceptionMessage(e4, MethodeName, ClassName, "Wyjątek w metodzie czytania statusu");
                MainFormlog.Debug(km);
                throw e4;

            }
        }

        private void SprawdzStatus()
        {
            string MethodeName = MethodBase.GetCurrentMethod().ToString();
            try
            {
                MainFormlog.Debug("Wchodzę do :" + MethodeName);
                FormaSprawdzStatus fss = new FormaSprawdzStatus();
                ClassReadEPCs crr = new ClassReadEPCs(fss, globals.czas_polaczenia);
                crr.ReadEPCsFromReader();
                MainFormlog.Debug("Wychodzę z :" + MethodeName);
            }
            catch (Exception e4)
            {
                String km = Utils.DisplayExceptionMessage(e4, MethodeName, ClassName, "Wyjątek w metodzie czytania statusu");
                MainFormlog.Debug(km);
                MessageBox.Show(km);
                //                throw e4;

            }
        }

        private void ZmienStatusZMenu(Boolean akcja)
        {
            string MethodeName = MethodBase.GetCurrentMethod().ToString();
            try
            {
                MainFormlog.Debug("Wchodzę do :" + MethodeName);
                FormZmianaStatus fzs = new FormZmianaStatus(akcja);
                ClassReadEPCs crr = new ClassReadEPCs(fzs, globals.czas_polaczenia);
                crr.ReadEPCsFromReader();
                MainFormlog.Debug("Wychodzę z :" + MethodeName);
            }
            catch (Exception e4)
            {
                String km = Utils.DisplayExceptionMessage(e4, MethodeName, ClassName, "Wyjątek w metodzie czytania statusu");
                MainFormlog.Debug(km);
                MessageBox.Show(km);
                //                throw e4;

            }
        }

        private void deaktywacjaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string MethodeName = MethodBase.GetCurrentMethod().ToString();
        }




        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            try
            {
                FormDekodujEPC fde = new FormDekodujEPC();
                fde.Visible = true;

            }
            catch (Exception ef)
            {

            }
        }

        //       private void dodajNoweEtykietyDoBazyToolStripMenuItem_Click(object sender, EventArgs e)
        //       {
        //       }

        private void WyswietlWersjeToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Assembly thisAssem = typeof(MainForm).Assembly;
            AssemblyName thisAssemName = thisAssem.GetName();
            Version ver = thisAssemName.Version;
            String kom = String.Format("Wersja {0} Nazwa: {1} ", ver, thisAssemName.Name);
            FormVersion formVersion = new FormVersion();
            FormVersion fv = formVersion;
            fv.Visible = true;
            fv.UstawWersje(kom);
        }

        private void sprawdźStatusWBazieToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            SprawdzStatus();
        }

        private void buttonPolacz_Click(object sender, EventArgs e)
        {
            try
            {

                if (!KlasaPP.StanPolaczenia)
                {
                    InicjujIdPos ifd = new InicjujIdPos();

                }
                Thread.Sleep(200);
#if !WYLACZ_SPRAW_TRWALOSCI
                //sprawdzemie,czy jest w stanie trwałym
                CzytajStandalomeMode ccsm = new CzytajStandalomeMode();
                String ww=ccsm.CzytajStand();
                if (ccsm.CzytajStandaloneStatus())
                {
                    if (MessageBox.Show("IdPos jest w trybie aktywcji/dezaktywaci trwałej\n\r" + "Kontynuować ?",
                     "Informacja",
                        MessageBoxButtons.YesNo,
                     MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        FormDezaktywacja.UstawStanTrwala(true);
                        if (ccsm.CzytajAdditionalInfo()==(byte)0)
                        {
                            FormDezaktywacja.UstawStanDeaktywacji(false);
                        }
                        ZacznijAktywacjeDezaktywacje();
                    }
                    else
                    {
                        KlasaAktDez.ResetWithRecovery();
                    }
                }
#endif
            }
            catch (IdReaderException en)
            {
                MessageBox.Show(en.Message);
            }
        }

        private void zniszczEtykieteToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            string MethodeName = MethodBase.GetCurrentMethod().ToString();
            try
            {
                MainFormlog.Debug("Wchodzę do :" + MethodeName);
                FormNiszczenieTagu fss = new FormNiszczenieTagu();
                ClassReadEPCs crr = new ClassReadEPCs(fss, globals.czas_polaczenia);
                //               fss.UstawWskaznikNaKlaseNiszczenia(crr);
                crr.ReadEPCsFromReader();
                //              crr.ZniszczTag(crr.)
                MainFormlog.Debug("Wychodzę z :" + MethodeName);
            }
            catch (Exception e4)
            {
                String km = Utils.DisplayExceptionMessage(e4, MethodeName, ClassName, "Wyjątek w metodzie czytania statusu");
                MainFormlog.Debug(km);
                MessageBox.Show(km);
            }

        }

        private void buttonRozlacz_Click(object sender, EventArgs e)
        {
            if (KlasaPP.Sreader != null)
            {
                trackBarReset();
            }
        }

        private void ZakonczMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void sprzedajtoolStripMenuItem_Click(object sender, EventArgs e)
        {
            ZmienStatusZMenu(true);
        }

        private void zwrocProduktToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ZmienStatusZMenu(false);
        }

        private void ZacznijAktywacjeDezaktywacje()
        {
            string MethodeName = MethodBase.GetCurrentMethod().ToString();
            if (MessageBox.Show("Aktywacja/dezaktywacja dotyczy wszystkich tagów znajdujących się w zasięgu IdPos\n\r" + "Kontynuować ?",
                                 "Ostrzeżenie",
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Warning) == DialogResult.No)
            {
                return;
            }
            try
            {
                FormDezaktywacja fdz = new FormDezaktywacja();
                fdz.Visible = true;

            }
            catch (Exception ed)
            {
                String km = Utils.DisplayExceptionMessage(ed, MethodeName, ClassName, "Wyjątek w metodzie aktywacji/dezaktywacji etykiety");
                MainFormlog.Debug(km);
                MessageBox.Show(km);

            }

        }

        private void deaktywacjaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ZacznijAktywacjeDezaktywacje();
/*
            string MethodeName = MethodBase.GetCurrentMethod().ToString();
            if (MessageBox.Show("Aktywacja/dezaktywacja dotyczy wszystkich tagów znajdujących się w zasięgu IdPos\n\r" + "Kontynuować ?",
                                 "Ostrzeżenie",
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Warning) == DialogResult.No)
            {
                return;
            }
            try
            {
                FormDezaktywacja fdz = new FormDezaktywacja();
                fdz.Visible = true;

            }
            catch (Exception ed)
            {
                String km = Utils.DisplayExceptionMessage(ed, MethodeName, ClassName, "Wyjątek w metodzie aktywacji/dezaktywacji etykiety");
                MainFormlog.Debug(km);
                MessageBox.Show(km);

            }
 */
        }

        private void dodajNoweEtykietyDoBazyToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FormDodajNoweEtykiety fne = new FormDodajNoweEtykiety();
            fne.Visible = true;
        }

        private void toolStripAntena_Click_1(object sender, EventArgs e)
        {
            toolStripAntena.Checked = true;
            toolStripZadenp.Checked = false;
            toolStripIdPos.Checked = false;
            //           toolStripIdReader.Checked = false;
            Konfig.URZ = Urzadzenie.Antena;
            KlasaZapiszDoBazyZUrzadzenia kadz = new KlasaZapiszDoBazyZUrzadzenia();
            /*           KlasaZapiszDoBazyZUrzadzenia.ZapiszDoBazyZUrzadzenia();*/
            kadz.ZapiszDoBazyZUrzadzenia();
            trackBarReset();

        }

        private void toolStripZadenp_Click_1(object sender, EventArgs e)
        {
            toolStripZadenp.Checked = true;
            toolStripAntena.Checked = false;
            toolStripIdPos.Checked = false;
            //           toolStripIdReader.Checked = false;
            Konfig.URZ = Urzadzenie.Zadne;
            trackBarReset();

        }

        private void toolStripIdPos_Click_1(object sender, EventArgs e)
        {
            toolStripIdPos.Checked = true;
            toolStripAntena.Checked = false;
            toolStripZadenp.Checked = false;
            //            toolStripIdReader.Checked = false;
            Konfig.URZ = Urzadzenie.IdPos;

        }

        private void ciagłaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //           ZapiszDoBazyInwentaryzacje zdi = new ZapiszDoBazyInwentaryzacje();
            //            FormaInwentaryzacji fjc = new FormaInwentaryzacji();
            //            fjc.Visible = true;
        }

        private void jednorazowaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void usuńRekordToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            UsunRekord();
        }

        private void dodajRekordToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            string MethodeName = MethodBase.GetCurrentMethod().ToString();
            try
            {
                MainFormlog.Debug("Wchodzę do :" + MethodeName);
                FormDodajRecznieJedenRekord rkd = new FormDodajRecznieJedenRekord
                {
                    Visible = true
                };
                MainFormlog.Debug("Wychodzę z :" + MethodeName);
                //               rkd.Dispose();
            }
            catch (Exception et)
            {
                String km = Utils.DisplayExceptionMessage(et, MethodeName, ClassName, "Wyjątek w metodzie dodaj rekord");
                MainFormlog.Debug(km);
                throw et;

            }

        }

        private void zmieńStatusToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            string MethodeName = MethodBase.GetCurrentMethod().ToString();
            int status;
            try
            {
                MainFormlog.Debug("Wchodzę do :" + MethodeName);
                DataGridViewRow row;
                if (TabelaGridView.Rows.Count == 1)
                {
                    row = TabelaGridView.Rows[0];
                    if (row.Cells[0].Value == null)
                    {
                        MessageBox.Show("Wiersz jest pusty - nie można zmienić statusu");
                        MainFormlog.Debug("Wychodzę po komunikacie z :" + MethodeName);
                    }

                }
                int SelectedRow = TabelaGridView.CurrentCell.RowIndex;
                row = TabelaGridView.Rows[SelectedRow];
                int record_number = int.Parse(row.Cells[0].Value.ToString());
                string WEPC = row.Cells[1].Value.ToString();
                string status_val = row.Cells[2].Value.ToString();
                int stat = Utils.ConvertSoldUnsoldToInt(status_val);

                if (stat == globals.sold) status = globals.unsold; else status = globals.sold;

                DAOMsSql.ChangeStatus(WEPC, status, globals.TableName);
                this.RefreshGridView();
                MainFormlog.Debug("Wychodzę z :" + MethodeName);

            }
            catch (Exception ec)
            {
                String km = Utils.DisplayExceptionMessage(ec, MethodeName, ClassName, "Wyjątek w metodzie zmiany statusu");
                MainFormlog.Debug(km);
                throw ec;
            }

        }

        private void WyczyscMenuItem_Click_1(object sender, EventArgs e)
        {
            string MethodeName = MethodBase.GetCurrentMethod().ToString();
            try
            {
                MainFormlog.Debug("Wchodzę do :" + MethodeName);
                DAOMsSql.CzyscTabele(globals.TableName);
                TabelaGridView.Rows.Clear();
                MainFormlog.Debug("Wychodzę z :" + MethodeName);
            }
            catch (Exception ew)
            {
                //                MessageBox.Show(e1.Message);
                String km = Utils.DisplayExceptionMessage(ew, MethodeName, ClassName, "Wyjątek w metodzie wyczyść bazę");
                MainFormlog.Debug(km);
                throw ew;
            }
            MessageBox.Show("Baza została wyczyszczona");
            MainFormlog.Debug("Wychodzę z :" + MethodeName);

        }

        private void czytajStanStandaloneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            const String mes = "Odczytany stan : ";
            try
            {
                CzytajStandalomeMode csdl = new CzytajStandalomeMode();
                String ww = csdl.CzytajStand();
                MessageBox.Show(mes + ww);
            }
            catch (NotConnectedException em)
            {
                MessageBox.Show(em.Message);
            }
        }

        private void Handler(object sender, UnhandledExceptionEventArgs args)
        {
            Exception e = (Exception)args.ExceptionObject;
            MainFormlog.Debug("Niebsłużony wyjątek :" + e.Message);
            MainFormlog.Debug("Źródło wyjątku :" + e.Source);
            //            MainFormlog.Debug("Zakończenie progamu : {0}", args.IsTerminating.ToString());



            //            Console.WriteLine("MyHandler caught : " + e.Message);
            //           Console.WriteLine("Runtime terminating: {0}", args.IsTerminating);

        }

        private void inwentaryzacjaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                FormaInwentaryzacji antn = new FormaInwentaryzacji();
                antn.Visible = true;

            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        //STEROWANIE REGULACJĄ MOCY

        public void UstawStanTrackBarMoc(Boolean stan)
        {
            trackBarMoc.Enabled = stan;
        }

        public void UstawTrackBarMocMin(short min)
        {
            trackBarMoc.Minimum = min;
        }

        public void UstawTrackBarMax(short max)
        {
            trackBarMoc.Maximum = max;
        }

        public short Moc
        {
            get => (short)trackBarMoc.Value;
            set { trackBarMoc.Value = value; }
        }

        private void trackBarReset()
        {
            if (KlasaPP.Sreader != null)
            {
                KlasaPP.Sreader.Disconnect();
                KlasaPP.Sreader = null;
            }
            trackBarMoc.Value = 0;
            trackBarMoc.Enabled = false;
        }
    }
}
