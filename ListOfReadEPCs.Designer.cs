namespace SystemRFID
{
    partial class ListOfReadEPCs
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
            this.listBoxEPCs = new System.Windows.Forms.ListBox();
            this.Zamknij = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxEPCs
            // 
            this.listBoxEPCs.FormattingEnabled = true;
            this.listBoxEPCs.Location = new System.Drawing.Point(12, 55);
            this.listBoxEPCs.Name = "listBoxEPCs";
            this.listBoxEPCs.Size = new System.Drawing.Size(324, 199);
            this.listBoxEPCs.TabIndex = 0;
            // 
            // Zamknij
            // 
            this.Zamknij.Location = new System.Drawing.Point(261, 270);
            this.Zamknij.Name = "Zamknij";
            this.Zamknij.Size = new System.Drawing.Size(75, 23);
            this.Zamknij.TabIndex = 2;
            this.Zamknij.Text = "Zamknij";
            this.Zamknij.UseVisualStyleBackColor = true;
            this.Zamknij.Click += new System.EventHandler(this.Zamknij_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(86, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Etykiety odczytane";
            // 
            // ListOfReadEPCs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 309);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Zamknij);
            this.Controls.Add(this.listBoxEPCs);
            this.Name = "ListOfReadEPCs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista odczytanych EPC";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.ListBox listBoxEPCs;
        protected System.Windows.Forms.Button Zamknij;
        private System.Windows.Forms.Label label1;
    }
}