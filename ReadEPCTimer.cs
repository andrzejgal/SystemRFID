using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

//#define DefTimeReachedEvent


//https://www.intertech.com/Blog/c-sharp-tutorial-understanding-c-events/
//https://www.c-sharpcorner.com/UploadFile/8b7513/custom-events-in-C-Sharp/


namespace SystemRFID

{
    //   public event EventHandler OnTimeIsReached;
    public partial class FormCzasPomiaru : Form
    {
        private static string ClassName = MethodBase.GetCurrentMethod().DeclaringType.ToString();
        private static Boolean czas = false;

        public FormCzasPomiaru()
        {
            InitializeComponent();
            ProgressBar progressBarCzas = new ProgressBar();
            progressBarCzas.Visible = true;
            timerCzasPomiaru.Start();
        }


        private void timerCzasPomiaru_Tick(object sender, EventArgs e)
        {
            string MethodeName = MethodBase.GetCurrentMethod().ToString();
            progressBarCzas.PerformStep();
            if (progressBarCzas.Value == progressBarCzas.Maximum)
            {
                timerCzasPomiaru.Stop();
                czas = true;
#if DefTimeReachedEvent
                TimeReachedEventArgs args = new TimeReachedEventArgs();
                //               args.Threshold = threshold;
                args.TimeReached = true;
                OnTimeReached(args);
#endif
                this.Dispose();
            }
        }

        public static Boolean CzytajCzas()
        {
            return czas;
        }


#if DefTimeReachedEvent
        protected virtual void OnTimeReached(TimeReachedEventArgs e)
        {
            EventHandler<TimeReachedEventArgs> handler = TimedReached;
            if (handler != null)
            {
                handler(this, e);
            }
        }


        public class TimeReachedEventArgs : EventArgs
        {
            public Boolean TimeR { get; set; }
//            public  int Threshold { get; set; }
 //           public DateTime TimeReached { get; set; }
        }

        public event EventHandler<TimeReachedEventArgs> TimeReached;
    }
#endif
    }
}
