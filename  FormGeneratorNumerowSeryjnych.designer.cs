namespace SystemRFID.formularz_dodaj_nowe_etykiety
{
    partial class FormGeneratorNumerowSeryjnych
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
            this.groupBoxGenerator = new System.Windows.Forms.GroupBox();
            this.radioButtonGenratorLiczbLosowych = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBoxGenerator.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxGenerator
            // 
            this.groupBoxGenerator.Controls.Add(this.radioButton2);
            this.groupBoxGenerator.Controls.Add(this.radioButtonGenratorLiczbLosowych);
            this.groupBoxGenerator.Location = new System.Drawing.Point(29, 25);
            this.groupBoxGenerator.Name = "groupBoxGenerator";
            this.groupBoxGenerator.Size = new System.Drawing.Size(161, 80);
            this.groupBoxGenerator.TabIndex = 0;
            this.groupBoxGenerator.TabStop = false;
            this.groupBoxGenerator.Text = "Wybierz generator";
            // 
            // radioButtonGenratorLiczbLosowych
            // 
            this.radioButtonGenratorLiczbLosowych.AutoSize = true;
            this.radioButtonGenratorLiczbLosowych.Location = new System.Drawing.Point(6, 28);
            this.radioButtonGenratorLiczbLosowych.Name = "radioButtonGenratorLiczbLosowych";
            this.radioButtonGenratorLiczbLosowych.Size = new System.Drawing.Size(141, 17);
            this.radioButtonGenratorLiczbLosowych.TabIndex = 1;
            this.radioButtonGenratorLiczbLosowych.TabStop = true;
            this.radioButtonGenratorLiczbLosowych.Text = "generator liczb losowych";
            this.radioButtonGenratorLiczbLosowych.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 51);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(147, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "sekwencyjne zwiększanie";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(287, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 1;
            // 
            // FormGeneratorNumerowSeryjnych
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBoxGenerator);
            this.Name = "FormGeneratorNumerowSeryjnych";
            this.Text = "Konfiguracja generatora numerów seryjnych";
            this.TopMost = true;
            this.groupBoxGenerator.ResumeLayout(false);
            this.groupBoxGenerator.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxGenerator;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButtonGenratorLiczbLosowych;
        private System.Windows.Forms.Panel panel1;
    }
}