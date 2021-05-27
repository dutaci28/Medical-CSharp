
namespace Proiect_PAW
{
    partial class MeniuPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adaugareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pacientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prescriptieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serializariToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serializarePrescriptiiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serializarePrescriptieXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deserializariToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deserializarePrescriptiiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deserializarePrescriptiiXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fisierTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exempleDDClipboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lvPrescriptii = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.updateazaListViewuriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lvPacienti = new System.Windows.Forms.ListView();
            this.Nume = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CNP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.lvMedici = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.graficToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adaugareToolStripMenuItem,
            this.serializariToolStripMenuItem,
            this.deserializariToolStripMenuItem,
            this.exportToolStripMenuItem,
            this.exempleDDClipboardToolStripMenuItem,
            this.graficToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1327, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adaugareToolStripMenuItem
            // 
            this.adaugareToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.medicToolStripMenuItem,
            this.pacientToolStripMenuItem,
            this.prescriptieToolStripMenuItem});
            this.adaugareToolStripMenuItem.Name = "adaugareToolStripMenuItem";
            this.adaugareToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.adaugareToolStripMenuItem.Text = "Adaugare";
            // 
            // medicToolStripMenuItem
            // 
            this.medicToolStripMenuItem.Name = "medicToolStripMenuItem";
            this.medicToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.medicToolStripMenuItem.Text = "Medic";
            this.medicToolStripMenuItem.Click += new System.EventHandler(this.medicToolStripMenuItem_Click);
            // 
            // pacientToolStripMenuItem
            // 
            this.pacientToolStripMenuItem.Name = "pacientToolStripMenuItem";
            this.pacientToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.pacientToolStripMenuItem.Text = "Pacient";
            this.pacientToolStripMenuItem.Click += new System.EventHandler(this.pacientToolStripMenuItem_Click);
            // 
            // prescriptieToolStripMenuItem
            // 
            this.prescriptieToolStripMenuItem.Name = "prescriptieToolStripMenuItem";
            this.prescriptieToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.prescriptieToolStripMenuItem.Text = "Prescriptie";
            this.prescriptieToolStripMenuItem.Click += new System.EventHandler(this.prescriptieToolStripMenuItem_Click);
            // 
            // serializariToolStripMenuItem
            // 
            this.serializariToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serializarePrescriptiiToolStripMenuItem,
            this.serializarePrescriptieXMLToolStripMenuItem});
            this.serializariToolStripMenuItem.Name = "serializariToolStripMenuItem";
            this.serializariToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.serializariToolStripMenuItem.Text = "Serializari";
            // 
            // serializarePrescriptiiToolStripMenuItem
            // 
            this.serializarePrescriptiiToolStripMenuItem.Name = "serializarePrescriptiiToolStripMenuItem";
            this.serializarePrescriptiiToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.serializarePrescriptiiToolStripMenuItem.Text = "&Serializare prescriptii";
            this.serializarePrescriptiiToolStripMenuItem.Click += new System.EventHandler(this.serializarePrescriptiiToolStripMenuItem_Click);
            // 
            // serializarePrescriptieXMLToolStripMenuItem
            // 
            this.serializarePrescriptieXMLToolStripMenuItem.Name = "serializarePrescriptieXMLToolStripMenuItem";
            this.serializarePrescriptieXMLToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.serializarePrescriptieXMLToolStripMenuItem.Text = "Serializare prescriptii XML";
            this.serializarePrescriptieXMLToolStripMenuItem.Click += new System.EventHandler(this.serializarePrescriptieXMLToolStripMenuItem_Click);
            // 
            // deserializariToolStripMenuItem
            // 
            this.deserializariToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deserializarePrescriptiiToolStripMenuItem,
            this.deserializarePrescriptiiXMLToolStripMenuItem});
            this.deserializariToolStripMenuItem.Name = "deserializariToolStripMenuItem";
            this.deserializariToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.deserializariToolStripMenuItem.Text = "Deserializari";
            // 
            // deserializarePrescriptiiToolStripMenuItem
            // 
            this.deserializarePrescriptiiToolStripMenuItem.Name = "deserializarePrescriptiiToolStripMenuItem";
            this.deserializarePrescriptiiToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.deserializarePrescriptiiToolStripMenuItem.Text = "&Deserializare prescriptii";
            this.deserializarePrescriptiiToolStripMenuItem.Click += new System.EventHandler(this.deserializarePrescriptiiToolStripMenuItem_Click);
            // 
            // deserializarePrescriptiiXMLToolStripMenuItem
            // 
            this.deserializarePrescriptiiXMLToolStripMenuItem.Name = "deserializarePrescriptiiXMLToolStripMenuItem";
            this.deserializarePrescriptiiXMLToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.deserializarePrescriptiiXMLToolStripMenuItem.Text = "Deserializare prescriptii XML";
            this.deserializarePrescriptiiXMLToolStripMenuItem.Click += new System.EventHandler(this.deserializarePrescriptiiXMLToolStripMenuItem_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fisierTextToolStripMenuItem});
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.exportToolStripMenuItem.Text = "Export";
            // 
            // fisierTextToolStripMenuItem
            // 
            this.fisierTextToolStripMenuItem.Name = "fisierTextToolStripMenuItem";
            this.fisierTextToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.fisierTextToolStripMenuItem.Text = "Fisier text prescriptii";
            this.fisierTextToolStripMenuItem.Click += new System.EventHandler(this.fisierTextToolStripMenuItem_Click);
            // 
            // exempleDDClipboardToolStripMenuItem
            // 
            this.exempleDDClipboardToolStripMenuItem.Name = "exempleDDClipboardToolStripMenuItem";
            this.exempleDDClipboardToolStripMenuItem.Size = new System.Drawing.Size(156, 20);
            this.exempleDDClipboardToolStripMenuItem.Text = "Exemple DnD + Clipboard";
            this.exempleDDClipboardToolStripMenuItem.Click += new System.EventHandler(this.exempleDDClipboardToolStripMenuItem_Click);
            // 
            // lvPrescriptii
            // 
            this.lvPrescriptii.Activation = System.Windows.Forms.ItemActivation.TwoClick;
            this.lvPrescriptii.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader3,
            this.columnHeader4});
            this.lvPrescriptii.FullRowSelect = true;
            this.lvPrescriptii.HideSelection = false;
            this.lvPrescriptii.Location = new System.Drawing.Point(12, 120);
            this.lvPrescriptii.Name = "lvPrescriptii";
            this.lvPrescriptii.Size = new System.Drawing.Size(357, 488);
            this.lvPrescriptii.TabIndex = 10;
            this.lvPrescriptii.UseCompatibleStateImageBehavior = false;
            this.lvPrescriptii.View = System.Windows.Forms.View.Details;
            this.lvPrescriptii.ItemActivate += new System.EventHandler(this.lvPrescriptii_ItemActivate_1);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID Prescriptie";
            this.columnHeader1.Width = 85;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Numele medicului";
            this.columnHeader3.Width = 105;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Medicamente";
            this.columnHeader4.Width = 102;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Prescriptii";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateazaListViewuriToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(194, 26);
            // 
            // updateazaListViewuriToolStripMenuItem
            // 
            this.updateazaListViewuriToolStripMenuItem.Name = "updateazaListViewuriToolStripMenuItem";
            this.updateazaListViewuriToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.updateazaListViewuriToolStripMenuItem.Text = "Updateaza list view-uri";
            this.updateazaListViewuriToolStripMenuItem.Click += new System.EventHandler(this.updateazaListViewuriToolStripMenuItem_Click);
            // 
            // lvPacienti
            // 
            this.lvPacienti.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nume,
            this.CNP,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.lvPacienti.HideSelection = false;
            this.lvPacienti.Location = new System.Drawing.Point(375, 120);
            this.lvPacienti.Name = "lvPacienti";
            this.lvPacienti.Size = new System.Drawing.Size(476, 488);
            this.lvPacienti.TabIndex = 13;
            this.lvPacienti.UseCompatibleStateImageBehavior = false;
            this.lvPacienti.View = System.Windows.Forms.View.Details;
            // 
            // Nume
            // 
            this.Nume.Text = "Nume";
            // 
            // CNP
            // 
            this.CNP.Text = "CNP";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Sex";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Data nasterii";
            this.columnHeader6.Width = 93;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Prescriptii";
            this.columnHeader7.Width = 81;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(372, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Pacienti";
            // 
            // lvMedici
            // 
            this.lvMedici.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader8,
            this.columnHeader9});
            this.lvMedici.HideSelection = false;
            this.lvMedici.Location = new System.Drawing.Point(857, 120);
            this.lvMedici.Name = "lvMedici";
            this.lvMedici.Size = new System.Drawing.Size(458, 488);
            this.lvMedici.TabIndex = 17;
            this.lvMedici.UseCompatibleStateImageBehavior = false;
            this.lvMedici.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nume";
            this.columnHeader2.Width = 74;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Specializare";
            this.columnHeader8.Width = 78;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Pacienti";
            this.columnHeader9.Width = 244;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(857, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Medici";
            // 
            // graficToolStripMenuItem
            // 
            this.graficToolStripMenuItem.Name = "graficToolStripMenuItem";
            this.graficToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.graficToolStripMenuItem.Text = "Grafic";
            this.graficToolStripMenuItem.Click += new System.EventHandler(this.graficToolStripMenuItem_Click);
            // 
            // MeniuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1327, 620);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lvMedici);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lvPacienti);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvPrescriptii);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MeniuPrincipal";
            this.Text = "Meniu Principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adaugareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medicToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pacientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prescriptieToolStripMenuItem;
        private System.Windows.Forms.ListView lvPrescriptii;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem serializariToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serializarePrescriptiiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deserializariToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deserializarePrescriptiiToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem updateazaListViewuriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serializarePrescriptieXMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deserializarePrescriptiiXMLToolStripMenuItem;
        private System.Windows.Forms.ListView lvPacienti;
        private System.Windows.Forms.ColumnHeader Nume;
        private System.Windows.Forms.ColumnHeader CNP;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lvMedici;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fisierTextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exempleDDClipboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem graficToolStripMenuItem;
    }
}

