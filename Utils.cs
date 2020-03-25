using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace SystemRFID
{
    class Utils
    {

        static public Boolean isHexChar(char c)
        {
            return (c >= '0') && (c <= '9') ||
                   (c >= 'a') && (c <= 'f') ||
                   (c >= 'A') && (c <= 'F');
        }


        static public string ConvertIntToSoldUnsold(int wej)
        {
            Debug.Assert((wej == globals.sold) && (wej == globals.unsold));
            if (wej == globals.unsold) return "unsold";
            else
            if (wej == globals.sold) return "sold";
            else return null;
        }

        static public int ConvertSoldUnsoldToInt(string wej)
        {
            //           Debug.Assert((wej.Equals("unsold") && (wej.Equals("sold"))));
            if (Equals(wej, "unsold")) return 0;
            else
            if (Equals(wej, "sold")) return 1;
            else return (-1);

        }

        static public string ConvertUtf16ToASCii(string wej)
        {
            string wyj = null;
            byte[] utf16Bytes = Encoding.Unicode.GetBytes(wej);
            byte[] utf8Bytes = Encoding.Convert(Encoding.Unicode, Encoding.UTF8, utf16Bytes);
            char[] chars = (char[])Array.CreateInstance(typeof(char), utf8Bytes.Length);
            for (int i = 0; i < utf8Bytes.Length; i++)
            {
                chars[i] = BitConverter.ToChar(new byte[2] { utf8Bytes[i], 0 }, 0);
            }
            wyj = new string(chars);
            return wyj;
        }

        static public Boolean TestCzyCiagDziesietny(String wej, ref byte pozycja_bledu)
        {
            Boolean wyj = true;
            char ch = (char)0;
            int dlug = wej.Length;
            for (int n = 0; n < dlug; n++)
            {
                ch = wej[n];
                if (char.IsDigit(ch)) continue;
                else
                {
                    wyj = false;
                    pozycja_bledu = (byte)n;
                    break;
                }
            }
            return wyj;
        }

        static public Boolean TestCzyCiagToHex(String wej, ref byte pozycja_bledu)
        {
            Boolean wyj = true;
            char ch = (char)0;
            int dlug = wej.Length;
            for (int n = 0; n < dlug; n++)
            {
                ch = wej[n];
                if (TestujCzyCyfraDzLubHex(ch)) continue;
                else
                {
                    wyj = false;
                    pozycja_bledu = (byte)n;
                    break;
                }
            }
            return wyj;
        }

        static public Boolean TestujCzyCyfraDzLubHex(char c)
        {
            return (isHexChar(c) || Char.IsDigit(c));
        }

        static public long LongRandom(long min, long max, Random rand)
        {
            byte[] buf = new byte[8];
            rand.NextBytes(buf);
            long longRand = BitConverter.ToInt64(buf, 0);
            return (Math.Abs(longRand % (max - min)) + min);
        }






        static public void DisplayExceptionMessage(string opis)
        {
            MessageBox.Show("Wystąpił poważny błąd systemu i system zostanie zamknięty");
            Application.Exit();
        }

        static public string DisplayExceptionMessage(Exception e, string methodname, string filename, string simplemessage)
        {
            string outt = null;
            StringBuilder SB = new StringBuilder();
//#if DEBUG
             SB.Append(e.Message);
            SB.Append("\n\r");
            SB.Append(e.Source);
            SB.Append("\n\r");
            SB.Append(e.HResult.ToString());
            SB.Append("\n\r");
            SB.Append("Nazwa metody :");
            SB.Append(methodname);
            SB.Append("\n\r");
            SB.Append("Nazwa klasy :");
            SB.Append(filename);
            SB.Append("\n\r");
            SB.Append(simplemessage);
            outt = SB.ToString();

//#else
//
//            SB.Append("Nazwa klasy :");
//            SB.Append(filename);
//            SB.Append("\n\r");
//            SB.Append(simplemessage);
//            outt = SB.ToString();
//#endif
            return outt;
        }

        static public string UtworzKomunikat(String nazwa_metody,
                                              String opis_logu
                                            )
        {
            StringBuilder SB = new StringBuilder();
            SB.Append("Nazwa klasy");
            SB.Append(nazwa_metody);
            SB.Append("\n\r");
            SB.Append("Treść logu: ");
            SB.Append(opis_logu);
            return SB.ToString();
        }

        static public string UtworzKomunikat(String nazwa_klasy,
                                              String opis_logu,
                                              String string_return
                                            )
        {
            StringBuilder SB = new StringBuilder();
            SB.Append("Nazwa klasy  :");
            SB.Append(nazwa_klasy);
 //           SB.Append("\n\r");
            SB.Append("Treść logu  :");
 //           SB.Append("\n\r");
            SB.Append(opis_logu);
            SB.Append("\n\r");
            SB.Append("Warość zwrócona  :");
            SB.Append(string_return);
            return SB.ToString();
        }

 //       static public String CzytajWprowadzonyText()
 //       {
//
 //       }


    }
}