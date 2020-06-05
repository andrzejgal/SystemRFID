using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace SystemRFID
{
    class globals
    {
        public enum TypSerwera { SqlServer, MySqlServer };
        public static TypSerwera TypSer = TypSerwera.SqlServer;
        public static byte unsold=0;
        public static byte sold=1;
        public static String TableName = "etykiety";
        public static Thread serwerAsyn;
        public static short czas_polaczenia=100;
        public static  int MaxDlugoscEPC = 24;
        public static long MaxDlugoscNumeruSeryjnego = 274877906943;
//        public static string PlikKonfSystemRFID = "SystemRFIDconfig.xml";
 //       public static RodzajDzialania RDZ;
    }
}
