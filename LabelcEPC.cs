#define DEFAbstractLabelcEPCTest

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
using System.Windows.Forms;
using System.Reflection;




namespace SystemRFID
{
/*

#if DEFAbstractLabelcEPCTest
    class LabelcEPC : AbstractLabelcEPCOminReader
#else
    class LabelcEPC : ReadEPCfromIdReader
#endif
    {
        private static readonly string  ClassName = MethodBase.GetCurrentMethod().DeclaringType.ToString();
        private readonly Form form = Application.OpenForms[0];
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        //      private String EPCA;

        public ArrayList ReadTagEPC()
        {
            string MethodeName = MethodBase.GetCurrentMethod().ToString();
            base.ReadTagEPC();
            ArrayList ListE = new ArrayList();
            ListE = base.ListReadEPCs();
            if (ListE.Count == 0)
            {
                //               throw new System.Exception("Nie odczytano żadnej etykiety");
 //               String kp = "Nie odczytano żadnej etykiety";
 //               MessageBox.Show(kp);
 //               log.Info(kp);
                return null;
            }
            else return ListE;
         }

        override public String ReadStatusFromBase(String EPC)
        {
            String wyn = "";

            return wyn;
        }

        override public void ChangeTagStatus(String EPC, Boolean status)
        {

        }
  
    }
*/
}
