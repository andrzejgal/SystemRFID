namespace SystemRFID
{
    partial class FormCzasPomiaru
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.progressBarCzas = new System.Windows.Forms.ProgressBar();
            this.timerCzasPomiaru = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // progressBarCzas
            // 
            this.progressBarCzas.Location = new System.Drawing.Point(21, 12);
            this.progressBarCzas.Name = "progressBarCzas";
            this.progressBarCzas.Size = new System.Drawing.Size(409, 23);
            this.progressBarCzas.Step = 1;
            this.progressBarCzas.TabIndex = 1;
            this.progressBarCzas.UseWaitCursor = true;
            // 
            // timerCzasPomiaru
            // 
            this.timerCzasPomiaru.Interval = 1;
            this.timerCzasPomiaru.Tick += new System.EventHandler(this.timerCzasPomiaru_Tick);
            // 
            // FormCzasPomiaru
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(461, 60);
            this.Controls.Add(this.progressBarCzas);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCzasPomiaru";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "PROSZĘ UMIEŚCIĆ ETYKIETĘ ZANIM PASEK DOJDZIE DO KOŃCA";
            this.TopMost = true;
            this.UseWaitCursor = true;
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timerCzasPomiaru;
        private System.Windows.Forms.ProgressBar progressBarCzas;
    }
}