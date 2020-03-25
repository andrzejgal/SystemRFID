//#define ZEZWOLENIE
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Reflection;

namespace SystemRFID
{
    public class FifoClass
    {
        private static string ClassName = MethodBase.GetCurrentMethod().DeclaringType.ToString();
        private static volatile Boolean reading = false;
        private static volatile Boolean writting = false;
        private static List<String> EPCList= new List<String>();
        private static readonly log4net.ILog logFifoClass = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        private static String ms;

        public static Boolean GetReadingStatus()
        {
            Object b = new object();
             string MethodeName = MethodBase.GetCurrentMethod().ToString();
            try
            {
                Monitor.Enter(b);
 #if DEBUG && ZEZWOLENIE
                ms = Utils.UtworzKomunikat(MethodeName, "Wejście do monitora");
                logFifoClass.Info(ms);
                ms = Utils.UtworzKomunikat(MethodeName, "Wartość zwrócona", reading.ToString());
                logFifoClass.Info(ms);
#endif
                return reading;
            }
            catch (Exception e)
            { 
                ms = Utils.UtworzKomunikat(MethodeName, "Wyjątek");
                logFifoClass.Info(ms);
                throw e;
            }
            finally
            {
 #if DEBUG && ZEZWOLENIE
                ms = Utils.UtworzKomunikat(MethodeName, "Wyjście z monitora");
                logFifoClass.Info(ms);
#endif
                Monitor.Exit(b);
            }
        }

        public static Boolean GetWritingStatus()
        {
            Object b = new object();
            string MethodeName = MethodBase.GetCurrentMethod().ToString();
            try
            {
                Monitor.Enter(b);
 #if DEBUG && ZEZWOLENIE
                ms = Utils.UtworzKomunikat(MethodeName, "Wejście do monitora");
                logFifoClass.Info(ms);
                ms = Utils.UtworzKomunikat(MethodeName, "Wartość zwrócona", writting.ToString());
                logFifoClass.Info(ms);
#endif
                return writting;
            }
            catch(Exception e)
            {
                ms = Utils.UtworzKomunikat(MethodeName, "Wyjątek");
                logFifoClass.Info(ms);
                throw e;
            }
            finally
            {
 #if DEBUG && ZEZWOLENIE
                ms = Utils.UtworzKomunikat(MethodeName, "Wyjście z monitora");
                logFifoClass.Info(ms);
#endif
                Monitor.Exit(b);
            }
         }

        public static  void AddToList(String EPC)
        {
            Object b = new object();
            if (EPCList==null) EPCList = new List<String>();
            string MethodeName = MethodBase.GetCurrentMethod().ToString();
            try
            {
                Monitor.Enter(b);
                writting = true;
 #if DEBUG && ZEZWOLENIE
                ms = Utils.UtworzKomunikat(MethodeName, "Wejście do monitora");
                logFifoClass.Info(ms);
#endif
                if (!EPCList.Contains(EPC))
                {
                    EPCList.Add(EPC);
                }
                writting = false;
            }
           catch(Exception e)
            {
                ms = Utils.UtworzKomunikat(MethodeName, "Wyjątek");
                logFifoClass.Info(ms);
                throw e;
            }
            finally
            {
 #if DEBUG && ZEZWOLENIE
                ms = Utils.UtworzKomunikat(MethodeName, "Wyjście z monitora");
                logFifoClass.Info(ms);
#endif
                Monitor.Exit(b);
            };
        }

        public static  String ReadFromList()
        {
            Object b = new object();
            string MethodeName = MethodBase.GetCurrentMethod().ToString();
            String rr = "";
            try
            {
                Monitor.Enter(b);
                reading = true;
                if ((EPCList.Count() > 0) && (EPCList != null))
                {
                    rr = EPCList[0];
                    EPCList.RemoveAt(0);
                }
                reading = false;
 #if DEBUG && ZEZWOLENIE
                ms = Utils.UtworzKomunikat(MethodeName, "Wartość zwrócona", rr);
                logFifoClass.Info(ms);
#endif
                return rr;
            }
            catch(Exception e)
            {
                ms = Utils.UtworzKomunikat(MethodeName, "Wyjątek");
                logFifoClass.Info(ms);
                throw e;
            }
            finally
            {
 #if DEBUG && ZEZWOLENIE
                ms = Utils.UtworzKomunikat(MethodeName, "Wyjście z monitora");
                logFifoClass.Info(ms);
#endif
                Monitor.Exit(b);
            }
             return rr;
        }

        public static int Getsize()
        {
            Object b = new object();
            string MethodeName = MethodBase.GetCurrentMethod().ToString();
            try
            {
 #if DEBUG && ZEZWOLENIE
               ms = Utils.UtworzKomunikat(MethodeName, "Wejście do monitora");
                logFifoClass.Info(ms);
#endif
                Monitor.Enter(b);
                return EPCList.Count();
            }
            catch(Exception e)
            {
                ms = Utils.UtworzKomunikat(MethodeName, "Wyjątek");
                logFifoClass.Info(ms);
                throw e;

            }
            finally
            {
 #if DEBUG && ZEZWOLENIE
                ms = Utils.UtworzKomunikat(MethodeName, "Wyjście z monitora");
                logFifoClass.Info(ms);
#endif
                Monitor.Exit(b);
            }
            return 0;
        }  
        
        public static void CzyscFifo()
        {
            if (EPCList!=null)
            {
                EPCList.Clear();
            }
        }



    }
   
}

