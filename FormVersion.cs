using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemRFID
{
    public partial class FormVersion : Form
    {
        public FormVersion()
        {
            InitializeComponent();
        }

        private void buttonZamknij_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonKopiuj_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(labelVersion.Text);
        }

        public void UstawWersje(String wersja)
        {
            labelVersion.Text = wersja;
        }
    }
}
