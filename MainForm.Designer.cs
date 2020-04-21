/*
 * Created by SharpDevelop.
 * User: dell
 * Date: 2019-03-31
 * Time: 13:17
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 * 
 */

using System;

namespace SystemRFID
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
  //      private String EPCSelected = "";

        /// <summary>
        /// Disposes resources used by the form.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.TabelaGridView = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EPC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nazwa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rozmiar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kolor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ZakonczMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bazaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuńRekordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajRekordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zmieńStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WyczyscMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripWybierzUrzadzenie = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripZadenp = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripAntena = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripIdPos = new System.Windows.Forms.ToolStripMenuItem();
            this.sprzedajtoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zwrocProduktToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sprawdźStatusWBazieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deaktywacjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zniszczEtykieteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inwentaryzacjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajNoweEtykietyDoBazyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.czytajStanStandaloneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.WyswietlWersjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBoxPolaczenie = new System.Windows.Forms.PictureBox();
            this.labelPolaczenieKomunikat = new System.Windows.Forms.Label();
            this.buttonPolacz = new System.Windows.Forms.Button();
            this.buttonRozlacz = new System.Windows.Forms.Button();
            this.statusStrip2 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelFirwareVersionOpis = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusFirmwareVersionTresc = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripStatusLabelHardwareVersionOpis = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelHaadwareVersionTresc = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripSplitButton2 = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripStatusLabelRegionOpis = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelRegionTresc = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.trackBarMoc = new System.Windows.Forms.TrackBar();
            this.labelzero = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.labelRegulacjaMocy = new System.Windows.Forms.Label();
            this.testyFunkciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.czytajBankEPCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.TabelaGridView)).BeginInit();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPolaczenie)).BeginInit();
            this.statusStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMoc)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // TabelaGridView
            // 
            this.TabelaGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TabelaGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.EPC,
            this.Status,
            this.Data,
            this.Nazwa,
            this.Rozmiar,
            this.Kolor});
            resources.ApplyResources(this.TabelaGridView, "TabelaGridView");
            this.TabelaGridView.Name = "TabelaGridView";
            this.TabelaGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // Id
            // 
            resources.ApplyResources(this.Id, "Id");
            this.Id.Name = "Id";
            // 
            // EPC
            // 
            resources.ApplyResources(this.EPC, "EPC");
            this.EPC.Name = "EPC";
            // 
            // Status
            // 
            resources.ApplyResources(this.Status, "Status");
            this.Status.Name = "Status";
            // 
            // Data
            // 
            resources.ApplyResources(this.Data, "Data");
            this.Data.Name = "Data";
            // 
            // Nazwa
            // 
            resources.ApplyResources(this.Nazwa, "Nazwa");
            this.Nazwa.Name = "Nazwa";
            // 
            // Rozmiar
            // 
            resources.ApplyResources(this.Rozmiar, "Rozmiar");
            this.Rozmiar.Name = "Rozmiar";
            // 
            // Kolor
            // 
            resources.ApplyResources(this.Kolor, "Kolor");
            this.Kolor.Name = "Kolor";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem,
            this.bazaToolStripMenuItem,
            this.toolStripWybierzUrzadzenie,
            this.toolStripMenuItem1,
            this.WyswietlWersjeToolStripMenuItem,
            this.testyFunkciToolStripMenuItem});
            resources.ApplyResources(this.menuStrip2, "menuStrip2");
            this.menuStrip2.Name = "menuStrip2";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ZakonczMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            resources.ApplyResources(this.plikToolStripMenuItem, "plikToolStripMenuItem");
            // 
            // ZakonczMenuItem
            // 
            this.ZakonczMenuItem.Name = "ZakonczMenuItem";
            resources.ApplyResources(this.ZakonczMenuItem, "ZakonczMenuItem");
            this.ZakonczMenuItem.Click += new System.EventHandler(this.ZakonczMenuItem_Click_1);
            // 
            // bazaToolStripMenuItem
            // 
            this.bazaToolStripMenuItem.Checked = true;
            this.bazaToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.bazaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuńRekordToolStripMenuItem,
            this.dodajRekordToolStripMenuItem,
            this.zmieńStatusToolStripMenuItem,
            this.WyczyscMenuItem});
            this.bazaToolStripMenuItem.Name = "bazaToolStripMenuItem";
            resources.ApplyResources(this.bazaToolStripMenuItem, "bazaToolStripMenuItem");
            // 
            // usuńRekordToolStripMenuItem
            // 
            this.usuńRekordToolStripMenuItem.Name = "usuńRekordToolStripMenuItem";
            resources.ApplyResources(this.usuńRekordToolStripMenuItem, "usuńRekordToolStripMenuItem");
            this.usuńRekordToolStripMenuItem.Click += new System.EventHandler(this.usuńRekordToolStripMenuItem_Click_1);
            // 
            // dodajRekordToolStripMenuItem
            // 
            this.dodajRekordToolStripMenuItem.Name = "dodajRekordToolStripMenuItem";
            resources.ApplyResources(this.dodajRekordToolStripMenuItem, "dodajRekordToolStripMenuItem");
            this.dodajRekordToolStripMenuItem.Click += new System.EventHandler(this.dodajRekordToolStripMenuItem_Click_1);
            // 
            // zmieńStatusToolStripMenuItem
            // 
            this.zmieńStatusToolStripMenuItem.Name = "zmieńStatusToolStripMenuItem";
            resources.ApplyResources(this.zmieńStatusToolStripMenuItem, "zmieńStatusToolStripMenuItem");
            this.zmieńStatusToolStripMenuItem.Click += new System.EventHandler(this.zmieńStatusToolStripMenuItem_Click_1);
            // 
            // WyczyscMenuItem
            // 
            this.WyczyscMenuItem.Name = "WyczyscMenuItem";
            resources.ApplyResources(this.WyczyscMenuItem, "WyczyscMenuItem");
            this.WyczyscMenuItem.Click += new System.EventHandler(this.WyczyscMenuItem_Click_1);
            // 
            // toolStripWybierzUrzadzenie
            // 
            this.toolStripWybierzUrzadzenie.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripZadenp,
            this.toolStripAntena,
            this.toolStripIdPos});
            this.toolStripWybierzUrzadzenie.Name = "toolStripWybierzUrzadzenie";
            resources.ApplyResources(this.toolStripWybierzUrzadzenie, "toolStripWybierzUrzadzenie");
            this.toolStripWybierzUrzadzenie.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            // 
            // toolStripZadenp
            // 
            this.toolStripZadenp.Checked = true;
            this.toolStripZadenp.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripZadenp.Name = "toolStripZadenp";
            resources.ApplyResources(this.toolStripZadenp, "toolStripZadenp");
            this.toolStripZadenp.Click += new System.EventHandler(this.toolStripZadenp_Click_1);
            // 
            // toolStripAntena
            // 
            this.toolStripAntena.Name = "toolStripAntena";
            resources.ApplyResources(this.toolStripAntena, "toolStripAntena");
            this.toolStripAntena.Click += new System.EventHandler(this.toolStripAntena_Click_1);
            // 
            // toolStripIdPos
            // 
            this.toolStripIdPos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sprzedajtoolStripMenuItem,
            this.zwrocProduktToolStripMenuItem,
            this.sprawdźStatusWBazieToolStripMenuItem,
            this.deaktywacjaToolStripMenuItem,
            this.zniszczEtykieteToolStripMenuItem,
            this.inwentaryzacjaToolStripMenuItem,
            this.dodajNoweEtykietyDoBazyToolStripMenuItem,
            this.czytajStanStandaloneToolStripMenuItem});
            this.toolStripIdPos.Name = "toolStripIdPos";
            resources.ApplyResources(this.toolStripIdPos, "toolStripIdPos");
            this.toolStripIdPos.Click += new System.EventHandler(this.toolStripIdPos_Click_1);
            // 
            // sprzedajtoolStripMenuItem
            // 
            this.sprzedajtoolStripMenuItem.Name = "sprzedajtoolStripMenuItem";
            resources.ApplyResources(this.sprzedajtoolStripMenuItem, "sprzedajtoolStripMenuItem");
            this.sprzedajtoolStripMenuItem.Click += new System.EventHandler(this.sprzedajtoolStripMenuItem_Click);
            // 
            // zwrocProduktToolStripMenuItem
            // 
            this.zwrocProduktToolStripMenuItem.Name = "zwrocProduktToolStripMenuItem";
            resources.ApplyResources(this.zwrocProduktToolStripMenuItem, "zwrocProduktToolStripMenuItem");
            this.zwrocProduktToolStripMenuItem.Click += new System.EventHandler(this.zwrocProduktToolStripMenuItem_Click_1);
            // 
            // sprawdźStatusWBazieToolStripMenuItem
            // 
            this.sprawdźStatusWBazieToolStripMenuItem.Name = "sprawdźStatusWBazieToolStripMenuItem";
            resources.ApplyResources(this.sprawdźStatusWBazieToolStripMenuItem, "sprawdźStatusWBazieToolStripMenuItem");
            this.sprawdźStatusWBazieToolStripMenuItem.Click += new System.EventHandler(this.sprawdźStatusWBazieToolStripMenuItem_Click_1);
            // 
            // deaktywacjaToolStripMenuItem
            // 
            this.deaktywacjaToolStripMenuItem.Name = "deaktywacjaToolStripMenuItem";
            resources.ApplyResources(this.deaktywacjaToolStripMenuItem, "deaktywacjaToolStripMenuItem");
            this.deaktywacjaToolStripMenuItem.Click += new System.EventHandler(this.deaktywacjaToolStripMenuItem_Click_1);
            // 
            // zniszczEtykieteToolStripMenuItem
            // 
            this.zniszczEtykieteToolStripMenuItem.Name = "zniszczEtykieteToolStripMenuItem";
            resources.ApplyResources(this.zniszczEtykieteToolStripMenuItem, "zniszczEtykieteToolStripMenuItem");
            this.zniszczEtykieteToolStripMenuItem.Click += new System.EventHandler(this.zniszczEtykieteToolStripMenuItem_Click_1);
            // 
            // inwentaryzacjaToolStripMenuItem
            // 
            this.inwentaryzacjaToolStripMenuItem.Name = "inwentaryzacjaToolStripMenuItem";
            resources.ApplyResources(this.inwentaryzacjaToolStripMenuItem, "inwentaryzacjaToolStripMenuItem");
            this.inwentaryzacjaToolStripMenuItem.Click += new System.EventHandler(this.inwentaryzacjaToolStripMenuItem_Click);
            // 
            // dodajNoweEtykietyDoBazyToolStripMenuItem
            // 
            this.dodajNoweEtykietyDoBazyToolStripMenuItem.Name = "dodajNoweEtykietyDoBazyToolStripMenuItem";
            resources.ApplyResources(this.dodajNoweEtykietyDoBazyToolStripMenuItem, "dodajNoweEtykietyDoBazyToolStripMenuItem");
            this.dodajNoweEtykietyDoBazyToolStripMenuItem.Click += new System.EventHandler(this.dodajNoweEtykietyDoBazyToolStripMenuItem_Click_1);
            // 
            // czytajStanStandaloneToolStripMenuItem
            // 
            this.czytajStanStandaloneToolStripMenuItem.Name = "czytajStanStandaloneToolStripMenuItem";
            resources.ApplyResources(this.czytajStanStandaloneToolStripMenuItem, "czytajStanStandaloneToolStripMenuItem");
            this.czytajStanStandaloneToolStripMenuItem.Click += new System.EventHandler(this.czytajStanStandaloneToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            resources.ApplyResources(this.toolStripMenuItem1, "toolStripMenuItem1");
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            resources.ApplyResources(this.toolStripMenuItem2, "toolStripMenuItem2");
            // 
            // WyswietlWersjeToolStripMenuItem
            // 
            this.WyswietlWersjeToolStripMenuItem.Name = "WyswietlWersjeToolStripMenuItem";
            resources.ApplyResources(this.WyswietlWersjeToolStripMenuItem, "WyswietlWersjeToolStripMenuItem");
            this.WyswietlWersjeToolStripMenuItem.Click += new System.EventHandler(this.WyswietlWersjeToolStripMenuItem_Click_1);
            // 
            // pictureBoxPolaczenie
            // 
            this.pictureBoxPolaczenie.BackColor = System.Drawing.Color.Red;
            resources.ApplyResources(this.pictureBoxPolaczenie, "pictureBoxPolaczenie");
            this.pictureBoxPolaczenie.Name = "pictureBoxPolaczenie";
            this.pictureBoxPolaczenie.TabStop = false;
            // 
            // labelPolaczenieKomunikat
            // 
            resources.ApplyResources(this.labelPolaczenieKomunikat, "labelPolaczenieKomunikat");
            this.labelPolaczenieKomunikat.Name = "labelPolaczenieKomunikat";
            // 
            // buttonPolacz
            // 
            resources.ApplyResources(this.buttonPolacz, "buttonPolacz");
            this.buttonPolacz.Name = "buttonPolacz";
            this.buttonPolacz.UseVisualStyleBackColor = true;
            this.buttonPolacz.Click += new System.EventHandler(this.buttonPolacz_Click);
            // 
            // buttonRozlacz
            // 
            resources.ApplyResources(this.buttonRozlacz, "buttonRozlacz");
            this.buttonRozlacz.Name = "buttonRozlacz";
            this.buttonRozlacz.UseVisualStyleBackColor = true;
            this.buttonRozlacz.Click += new System.EventHandler(this.buttonRozlacz_Click);
            // 
            // statusStrip2
            // 
            resources.ApplyResources(this.statusStrip2, "statusStrip2");
            this.statusStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.statusStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelFirwareVersionOpis,
            this.toolStripStatusFirmwareVersionTresc,
            this.toolStripSplitButton1,
            this.toolStripStatusLabelHardwareVersionOpis,
            this.toolStripStatusLabelHaadwareVersionTresc,
            this.toolStripSplitButton2,
            this.toolStripStatusLabelRegionOpis,
            this.toolStripStatusLabelRegionTresc,
            this.toolStripProgressBar});
            this.statusStrip2.Name = "statusStrip2";
            // 
            // toolStripStatusLabelFirwareVersionOpis
            // 
            this.toolStripStatusLabelFirwareVersionOpis.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            resources.ApplyResources(this.toolStripStatusLabelFirwareVersionOpis, "toolStripStatusLabelFirwareVersionOpis");
            this.toolStripStatusLabelFirwareVersionOpis.Name = "toolStripStatusLabelFirwareVersionOpis";
            this.toolStripStatusLabelFirwareVersionOpis.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            // 
            // toolStripStatusFirmwareVersionTresc
            // 
            resources.ApplyResources(this.toolStripStatusFirmwareVersionTresc, "toolStripStatusFirmwareVersionTresc");
            this.toolStripStatusFirmwareVersionTresc.Name = "toolStripStatusFirmwareVersionTresc";
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.toolStripSplitButton1, "toolStripSplitButton1");
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            // 
            // toolStripStatusLabelHardwareVersionOpis
            // 
            this.toolStripStatusLabelHardwareVersionOpis.Name = "toolStripStatusLabelHardwareVersionOpis";
            resources.ApplyResources(this.toolStripStatusLabelHardwareVersionOpis, "toolStripStatusLabelHardwareVersionOpis");
            // 
            // toolStripStatusLabelHaadwareVersionTresc
            // 
            resources.ApplyResources(this.toolStripStatusLabelHaadwareVersionTresc, "toolStripStatusLabelHaadwareVersionTresc");
            this.toolStripStatusLabelHaadwareVersionTresc.Name = "toolStripStatusLabelHaadwareVersionTresc";
            // 
            // toolStripSplitButton2
            // 
            this.toolStripSplitButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.toolStripSplitButton2, "toolStripSplitButton2");
            this.toolStripSplitButton2.Name = "toolStripSplitButton2";
            // 
            // toolStripStatusLabelRegionOpis
            // 
            this.toolStripStatusLabelRegionOpis.Name = "toolStripStatusLabelRegionOpis";
            resources.ApplyResources(this.toolStripStatusLabelRegionOpis, "toolStripStatusLabelRegionOpis");
            // 
            // toolStripStatusLabelRegionTresc
            // 
            resources.ApplyResources(this.toolStripStatusLabelRegionTresc, "toolStripStatusLabelRegionTresc");
            this.toolStripStatusLabelRegionTresc.Name = "toolStripStatusLabelRegionTresc";
            // 
            // toolStripProgressBar
            // 
            this.toolStripProgressBar.Name = "toolStripProgressBar";
            resources.ApplyResources(this.toolStripProgressBar, "toolStripProgressBar");
            this.toolStripProgressBar.Step = 1;
            // 
            // trackBarMoc
            // 
            resources.ApplyResources(this.trackBarMoc, "trackBarMoc");
            this.trackBarMoc.Name = "trackBarMoc";
            this.trackBarMoc.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            // 
            // labelzero
            // 
            resources.ApplyResources(this.labelzero, "labelzero");
            this.labelzero.Name = "labelzero";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // labelRegulacjaMocy
            // 
            resources.ApplyResources(this.labelRegulacjaMocy, "labelRegulacjaMocy");
            this.labelRegulacjaMocy.Name = "labelRegulacjaMocy";
            // 
            // testyFunkciToolStripMenuItem
            // 
            this.testyFunkciToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.czytajBankEPCToolStripMenuItem});
            this.testyFunkciToolStripMenuItem.Name = "testyFunkciToolStripMenuItem";
            resources.ApplyResources(this.testyFunkciToolStripMenuItem, "testyFunkciToolStripMenuItem");
            // 
            // czytajBankEPCToolStripMenuItem
            // 
            this.czytajBankEPCToolStripMenuItem.Name = "czytajBankEPCToolStripMenuItem";
            resources.ApplyResources(this.czytajBankEPCToolStripMenuItem, "czytajBankEPCToolStripMenuItem");
            this.czytajBankEPCToolStripMenuItem.Click += new System.EventHandler(this.czytajBankEPCToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelRegulacjaMocy);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.labelzero);
            this.Controls.Add(this.trackBarMoc);
            this.Controls.Add(this.statusStrip2);
            this.Controls.Add(this.buttonRozlacz);
            this.Controls.Add(this.buttonPolacz);
            this.Controls.Add(this.labelPolaczenieKomunikat);
            this.Controls.Add(this.pictureBoxPolaczenie);
            this.Controls.Add(this.TabelaGridView);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TabelaGridView)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPolaczenie)).EndInit();
            this.statusStrip2.ResumeLayout(false);
            this.statusStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.DataGridView TabelaGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn EPC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nazwa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rozmiar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kolor;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ZakonczMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bazaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuńRekordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajRekordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zmieńStatusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem WyczyscMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripWybierzUrzadzenie;
        private System.Windows.Forms.ToolStripMenuItem toolStripZadenp;
        private System.Windows.Forms.ToolStripMenuItem toolStripAntena;
        private System.Windows.Forms.ToolStripMenuItem toolStripIdPos;
        public System.Windows.Forms.ToolStripMenuItem sprzedajtoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zwrocProduktToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sprawdźStatusWBazieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deaktywacjaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zniszczEtykieteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inwentaryzacjaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajNoweEtykietyDoBazyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem WyswietlWersjeToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBoxPolaczenie;
        private System.Windows.Forms.Label labelPolaczenieKomunikat;
        private System.Windows.Forms.Button buttonPolacz;
        private System.Windows.Forms.Button buttonRozlacz;
        private System.Windows.Forms.StatusStrip statusStrip2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelFirwareVersionOpis;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusFirmwareVersionTresc;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelHardwareVersionOpis;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelHaadwareVersionTresc;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton2;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelRegionOpis;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelRegionTresc;
        private System.Windows.Forms.ToolStripMenuItem czytajStanStandaloneToolStripMenuItem;
        private System.Windows.Forms.TrackBar trackBarMoc;
        private System.Windows.Forms.Label labelzero;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labelRegulacjaMocy;
        private System.Windows.Forms.ToolStripMenuItem testyFunkciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem czytajBankEPCToolStripMenuItem;
    }
}
