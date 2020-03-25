using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemRFID
{
 //   public class Typy
 //   {
        enum TypSerwera { SqlServer, MySqlServer };
        public enum RodzajDzialania { Sprzedaz, Przyjęcie,JedenEPC };
        public enum RodzajZrodla { IdPos,Antena };
        public enum JakWczytywacEPC {OknoPotemOdczyt, OknoIOdczyt, BezpDoBazy };
        public enum Urzadzenie { Zadne, Antena, IdPos, IdReader };
        public enum RodzajGenNumerowSeryjnych { LiczbyLosowe,LiczbySekwencyjne,NumerzTIG};
        public enum RodzajAktywacjiDezaltywacji {Samodzielny, Niesamodzielny };
    //OknoPotemOdczyt 
    //   }
}
