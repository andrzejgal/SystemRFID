using System;
using System.Windows.Forms;
using System.Windows;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

/*
 * Umożliwia wybranie tylko jednej etykiety,kilku lub wszystkich etykiet.
 * Klasa nie wie skąd będą czytane etykiety.
 * Opis ListOfReadEPCs :
 * Jest to w zasadzie tylko ListBox z następującymi funkcjami:
 * - AddEPCToList(String EPC) 
 * - public String GetSelectedItem()
 * - protected void ListSelectAll()
 * - protected void ListDeselectAll()
 * - protected void ClearList()
 * - public int CzytajIloscEPCwLiscie()
*/

namespace SystemRFID
{
     public partial class ListOfReadEPCs : Form
    {
        private static string ClassName = MethodBase.GetCurrentMethod().DeclaringType.ToString();
        protected static int buttonX_length=75;
        protected static int buttonX_height = 23;
        protected static int buttonX_location_x = 12;
        protected static int buttonX_location_y = 270;

  //      private Button buttonX;
        public ListOfReadEPCs()
        {
            InitializeComponent();
            listBoxEPCs.Text = "";
            listBoxEPCs.SelectionMode = SelectionMode.One;
        }

 
        public void AddEPCToList(String EPC)
        {
            string MethodeName = MethodBase.GetCurrentMethod().ToString();
            lock (listBoxEPCs)
            {
                if (!listBoxEPCs.Items.Contains(EPC))
                {
                    listBoxEPCs.Items.Add(EPC);
                }

            }
        }

        public String GetSelectedItem()        {
            string MethodeName = MethodBase.GetCurrentMethod().ToString();
            if (listBoxEPCs.SelectedIndex >= 0)
            {
                return listBoxEPCs.SelectedItem.ToString();
            }
            else
            {
                return null;
            }
        }

        protected virtual void Zamknij_Click(object sender, EventArgs e)
        {
            string MethodeName = MethodBase.GetCurrentMethod().ToString();
            Close();
        }

        protected void ListSelectAll()
        {
            string MethodeName = MethodBase.GetCurrentMethod().ToString();
            int lngth = listBoxEPCs.Items.Count;
            listBoxEPCs.SelectionMode = SelectionMode.MultiSimple;
            for (int n=0;n<lngth;n++)
            {
                listBoxEPCs.SelectedIndex = n;
            }
 //           listBoxEPCs.SelectionMode = SelectionMode.One;
        }

        protected void ListDeselectAll()
        {
            string MethodeName = MethodBase.GetCurrentMethod().ToString();
            listBoxEPCs.ClearSelected(); 
        }

        protected void ClearList()
        {
            listBoxEPCs.Items.Clear();
        }

        public int CzytajIloscEPCwLiscie()
        {
            return listBoxEPCs.Items.Count;
        }

        public Boolean CzySaWybrane()
        {
            Boolean ww = true;
            if (listBoxEPCs.SelectedItems.Count==0) ww = false;
            return ww;
        }
    }
    
}
