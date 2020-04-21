using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nedap.IdReader;
using Nedap.IdReader.Exceptions;
using Nedap.IdReader.Protocol;
using Nedap.IdReader.Protocol.Responses;
using Nedap.IdReader.Protocol.Commands;


namespace SystemRFID
{
    public struct StatusOperacji
    {
        public byte kod_bledu;
        public String opis_bledu;
    }

    public struct wynik_czytania_bankow
    {
        public byte[] EPCbin;                       //ws1
        public short Count;     
        public byte[] Data;
        public byte EPCLength;                      //ws2
        public EPCGen2MemoryBank mb;                //ws3
        public short Offset;                        //ws4
        public EPCGen2TagAccessStatus status;       //ws5
        public String HexEPC;                       //ws6
        public Boolean zakonczenie;                 //ws7
    }

    public struct wynik_zapisu_do_banku
    {
        public byte[] EPCbin;                    //ws1
        public byte EPCLength;                  //ws2
        public short Length;
        public EPCGen2MemoryBank mb;            //ws3
        public short Offset;                    //ws4
        public EPCGen2TagAccessStatus status;   //ws5
        public String HexEPC;                   //ws6
        public Boolean zakonczenie;             //ws7
    }

    public class WerbalizujWspolne : WerbalizacjaWynikow
    {
        public static wynik_czytania_bankow operacje_na_bankach;
   
        static void UstawStruktureCzytania(wynik_czytania_bankow aCzyt_banki)
        {
            operacje_na_bankach = aCzyt_banki;
        }

        public static String CzytajEPCbin()
        {
            return Encoding.UTF8.GetString(operacje_na_bankach.EPCbin);
        }

    }


    public class WerbalizacjaWynikow
    {
        protected static StatusOperacji SO;

        protected static StatusOperacji NazwaStatusu(EPCGen2TagAccessStatus status)
        {
 //           StatusOperacji SO;
            switch (status)
            {
                case EPCGen2TagAccessStatus.NoError:
                    {
                        SO.kod_bledu = (byte)EPCGen2TagAccessStatus.NoError;
                        SO.opis_bledu = "Nie ma błędu";
                        break;
                    }
                case EPCGen2TagAccessStatus.HandleMismatch:
                    {
                        SO.kod_bledu = (byte)EPCGen2TagAccessStatus.HandleMismatch;
                        SO.opis_bledu = "Błąd handle";
                        break;
                    }
                case EPCGen2TagAccessStatus.CRCErrorOnTagResponse:
                    {
                        SO.kod_bledu = (byte)EPCGen2TagAccessStatus.CRCErrorOnTagResponse;
                        SO.opis_bledu = "Błąd CRC w odpowiedzi ";
                        break;
                    }
                case EPCGen2TagAccessStatus.NoTagReply:
                    {
                        SO.kod_bledu = (byte)EPCGen2TagAccessStatus.NoTagReply;
                        SO.opis_bledu = "Brak odpowiedzi od taga";
                        break;
                    }
                case EPCGen2TagAccessStatus.InvalidPassword:
                    {
                        SO.kod_bledu = (byte)EPCGen2TagAccessStatus.InvalidPassword;
                        SO.opis_bledu = "Błędne hasło";
                        break;
                    }
                case EPCGen2TagAccessStatus.ZeroKillPassword:
                    {
                        SO.kod_bledu = (byte)EPCGen2TagAccessStatus.ZeroKillPassword;
                        SO.opis_bledu = "Nie jest ustawione hasło do niszczenia tagu";
                        break;
                    }
                case EPCGen2TagAccessStatus.TagLost:
                    {
                        SO.kod_bledu = (byte)EPCGen2TagAccessStatus.TagLost;
                        SO.opis_bledu = "Komunikacja z tagem przerwana";
                        break;
                    }
                case EPCGen2TagAccessStatus.CommandFormatError:
                    {
                        SO.kod_bledu = (byte)EPCGen2TagAccessStatus.CommandFormatError;
                        SO.opis_bledu = "Błąd w formacie komendy";
                        break;
                    }
                case EPCGen2TagAccessStatus.ReadCountFailed:
                    {
                        SO.kod_bledu = (byte)EPCGen2TagAccessStatus.ReadCountFailed;
                        SO.opis_bledu = "Nieudany odczyt licznika powtórzeń";
                        break;
                    }
                case EPCGen2TagAccessStatus.OutOfRetries:
                    {
                        SO.kod_bledu = (byte)EPCGen2TagAccessStatus.OutOfRetries;
                        SO.opis_bledu = "Przekroczono ilość powtórzeń";
                        break;
                    }
                case EPCGen2TagAccessStatus.GeneralBackscatterError:
                    {
                        SO.kod_bledu = (byte)EPCGen2TagAccessStatus.GeneralBackscatterError;
                        SO.opis_bledu = "Ogólny błąd rozpraszania";
                        break;
                    }
                case EPCGen2TagAccessStatus.SpecifiedMemoryLocationDoesNotExist:
                    {
                        SO.kod_bledu = (byte)EPCGen2TagAccessStatus.SpecifiedMemoryLocationDoesNotExist;
                        SO.opis_bledu = "Wybrana pamięć nie istnieje";
                        break;
                    }
                case EPCGen2TagAccessStatus.SpecifiedMemoryLocationIsLocked:
                    {
                        SO.kod_bledu = (byte)EPCGen2TagAccessStatus.SpecifiedMemoryLocationIsLocked;
                        SO.opis_bledu = "Wybrana pamięć jest zablokowana";
                        break;
                    }
                case EPCGen2TagAccessStatus.TagHasInsufficientPower:
                    {
                        SO.kod_bledu = (byte)EPCGen2TagAccessStatus.TagHasInsufficientPower;
                        SO.opis_bledu = "Tag dostaje za małą moc";
                        break;
                    }
                case EPCGen2TagAccessStatus.TagDoesNotSupportErrorSpecificCodes:
                    {
                        SO.kod_bledu = (byte)EPCGen2TagAccessStatus.TagDoesNotSupportErrorSpecificCodes;
                        SO.opis_bledu = "Tag nie obsługuje wymienionego kodu błęd";
                        break;
                    }
                default:
                    {
                        SO.kod_bledu = (byte)0;
                        SO.opis_bledu = null;
                        break;
                    }
            }
            return SO;
        }

        protected static String NazwaBankuPamieci(EPCGen2MemoryBank mb)
        {
            String wyj = null;
            switch(mb)
            {
                case EPCGen2MemoryBank.EPCBank:
                    {
                        wyj = "Bank EPC";
                        break ;
                    }
                case EPCGen2MemoryBank.ReservedBank:
                    {
                        wyj = "Bank Reserved";
                        break;
                    }
                case EPCGen2MemoryBank.TIDBank:
                    {
                        wyj = "Bank TID";
                        break;
                    }
                case EPCGen2MemoryBank.UserBank:
                    {
                        wyj = "Bank User";
                        break;
                    }
                default:
                    {
                        wyj = null;
                        break;
                    }
            }
            return wyj;
        }
    }

    public class WynikiCzytaniaBankow: WerbalizacjaWynikow
    {
        public static wynik_czytania_bankow wCzyt_banki;

        static void UstawStruktureCzytania(wynik_czytania_bankow aCzyt_banki)
        {
            wCzyt_banki = aCzyt_banki;
        }

        public static  String CzytajNazweBanku()
        {
            return NazwaBankuPamieci(wCzyt_banki.mb);
        }

        public static StatusOperacji  CzytajStatus()
        {
            return NazwaStatusu(wCzyt_banki.status);
        }

        public static String EPCbin()
        {
            return 
        }

    }


 


    //   class Struktury_wynikow_operacji
    //    {
    //    }
}
