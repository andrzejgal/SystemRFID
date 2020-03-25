using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nedap.IdReader;
using Nedap.IdReader.Exceptions;
using Nedap.IdReader.Protocol;
using Nedap.IdReader.Protocol.Responses;
using System.Reflection;

namespace SystemRFID
{ 
    class IdReaderExc:Exception
    {
        private static string ClassName = MethodBase.GetCurrentMethod().DeclaringType.ToString();
        public IdReaderExc(String message) : base(message)
        {
           
        }
    }

   /* abstract */ public class ReadEPCfromIdReader
    {
         private  Boolean IdPosConnectionActive = false;
         private ArrayList ArrayListEPCs= new ArrayList();

         private void reader_ConnectionSucceeded(Reader sender, EventArgs e)
        {
            string MethodeName = MethodBase.GetCurrentMethod().ToString();
            //            Console.WriteLine("We're connected!");
            IdPosConnectionActive = true;
        }

        
        private void reader_ConnectionClosed(Reader sender, EventArgs e)
        {
            string MethodeName = MethodBase.GetCurrentMethod().ToString();
            //            Console.WriteLine("Connection closed!");
            IdPosConnectionActive = false;
        }


        
        private void reader_ErrorReceived(Reader sender, ErrorReceivedEventArgs e)
        {
            string MethodeName = MethodBase.GetCurrentMethod().ToString();
            Console.WriteLine("Received error: " + e.ErrorCategory.ToString() + " code " + e.ErrorCode);
        }


        
        private void reader_ResponseReceived(Reader sender, ResponseReceivedEventArgs e)
        {
            string MethodeName = MethodBase.GetCurrentMethod().ToString();
            if (e.Message is VersionResponse)
            {
                VersionResponse r = (VersionResponse)e.Message;
                Console.WriteLine("Hardware version = " + r.HardwareVersion);
                Console.WriteLine("Firmware version = " + r.FirmwareVersion);
            }
            else if (e.Message is RegionResponse)
            {
                RegionResponse r = (RegionResponse)e.Message;
                Console.WriteLine("Region " + r.Region.ToString() + " set. Regions supported by this reader:");
                foreach (Region region in r.SupportedRegions)
                {
                    Console.WriteLine("- " + region.ToString());
                }
            }
        }

        
         private void reader_ObservationReceived(Reader sender, ObservationReceivedEventArgs e)
        {
            string MethodeName = MethodBase.GetCurrentMethod().ToString();
            foreach (Observation o in e.ObservationList)
            {
                //               Console.WriteLine("Observation: " + o.EPC + " with rssi " + (o.RSSI / 10).ToString("F1") + "dbm");
                ArrayListEPCs.Add(o.EPC);
            }
        }



        
        public void ReadTagEPC()
            {

            string MethodeName = MethodBase.GetCurrentMethod().ToString();
            //       string wyn = "";
            // use USB autodetect
            SimpleReader reader = new SimpleReader();
            // or connect to reader at specified COM port
            // SimpleReader reader = new SimpleReader("serial://COM10");
            // or connect to reader at specified IP address
            // SimpleReader reader = new SimpleReader("tcp://10.1.2.3");
            try
            {
                reader.ResponseReceived += reader_ResponseReceived;
                reader.ObservationReceived += reader_ObservationReceived;
                reader.ErrorReceived += reader_ErrorReceived;
                reader.ConnectionClosed += reader_ConnectionClosed;
                reader.ConnectionSucceeded += reader_ConnectionSucceeded;
                reader.Connect(Region.Europe);
                reader.ReadBlocking(100);   // 0,1 sekundy
 //               Console.ReadKey();
                reader.Disconnect();
 //               return wyn;
            }
            catch (IdReaderException e)
            {
                throw e;
 //               throw new IdReaderExc(e.Message);
//                Console.WriteLine(e.Message);
//               Console.ReadKey();
            }

 //           return wyn;
           }

        
 //       abstract public String ReadStatusFromBase(String EPC);


 //       abstract public void ChangeTagStatus(String EPC,Boolean status);
 
        
        public  Boolean GetConnectionStatus()
        {
            return IdPosConnectionActive;
        }

        
        public  ArrayList ListReadEPCs()
        {
            return ArrayListEPCs;
        }
    }
}
