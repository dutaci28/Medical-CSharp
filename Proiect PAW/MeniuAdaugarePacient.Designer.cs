
namespace Proiect_PAW
{
    partial class MeniuAdaugarePacient
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
            this.label1 = new System.Windows.Forms.Label();
            this.a = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbNume = new System.Windows.Forms.TextBox();
            this.tbCNP = new System.Windows.Forms.TextBox();
            this.tbSex = new System.Windows.Forms.TextBox();
            this.tbDataNasterii = new System.Windows.Forms.TextBox();
            this.btnAdauga = new System.Windows.Forms.Button();
            this.btnCurata = new System.Windows.Forms.Button();
            this.lvPacienti = new System.Windows.Forms.ListView();
            this.Nume = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CNP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAfisare = new System.Windows.Forms.Button();
            this.lvPrescriptii = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nume";
            // 
            // a
            // 
            this.a.AutoSize = true;
            this.a.Location = new System.Drawing.Point(12, 53);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(29, 13);
            this.a.TabIndex = 1;
            this.a.Text = "CNP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sex";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Data nasterii";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Prescriptii";
            // 
            // tbNume
            // 
            this.tbNume.Location = new System.Drawing.Point(13, 30);
            this.tbNume.Name = "tbNume";
            this.tbNume.Size = new System.Drawing.Size(331, 20);
            this.tbNume.TabIndex = 5;
            // 
            // tbCNP
            // 
            this.tbCNP.Location = new System.Drawing.Point(15, 70);
            this.tbCNP.Name = "tbCNP";
            this.tbCNP.Size = new System.Drawing.Size(329, 20);
            this.tbCNP.TabIndex = 6;
            this.tbCNP.TextChanged += new System.EventHandler(this.tbCNP_TextChanged);
            // 
            // tbSex
            // 
            this.tbSex.Location = new System.Drawing.Point(13, 110);
            this.tbSex.Name = "tbSex";
            this.tbSex.Size = new System.Drawing.Size(331, 20);
            this.tbSex.TabIndex = 7;
            // 
            // tbDataNasterii
            // 
            this.tbDataNasterii.Location = new System.Drawing.Point(13, 150);
            this.tbDataNasterii.Name = "tbDataNasterii";
            this.tbDataNasterii.Size = new System.Drawing.Size(331, 20);
            this.tbDataNasterii.TabIndex = 8;
            // 
            // btnAdauga
            // 
            this.btnAdauga.Location = new System.Drawing.Point(13, 415);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(75, 23);
            this.btnAdauga.TabIndex = 10;
            this.btnAdauga.Text = "Adauga";
            this.btnAdauga.UseVisualStyleBackColor = true;
            this.btnAdauga.Click += new System.EventHandler(this.btnAdauga_Click);
            // 
            // btnCurata
            // 
            this.btnCurata.Location = new System.Drawing.Point(95, 415);
            this.btnCurata.Name = "btnCurata";
            this.btnCurata.Size = new System.Drawing.Size(75, 23);
            this.btnCurata.TabIndex = 11;
            this.btnCurata.Text = "Curata";
            this.btnCurata.UseVisualStyleBackColor = true;
            this.btnCurata.Click += new System.EventHandler(this.btnCurata_Click);
            // 
            // lvPacienti
            // 
            this.lvPacienti.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nume,
            this.CNP,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvPacienti.HideSelection = false;
            this.lvPacienti.Location = new System.Drawing.Point(350, 9);
            this.lvPacienti.Name = "lvPacienti";
            this.lvPacienti.Size = new System.Drawing.Size(438, 379);
            this.lvPacienti.TabIndex = 12;
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
            // columnHeader3
            // 
            this.columnHeader3.Text = "Sex";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Data nasterii";
            this.columnHeader4.Width = 93;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Prescriptii";
            this.columnHeader5.Width = 81;
            // 
            // btnAfisare
            // 
            this.btnAfisare.Location = new System.Drawing.Point(712, 415);
            this.btnAfisare.Name = "btnAfisare";
            this.btnAfisare.Size = new System.Drawing.Size(75, 23);
            this.btnAfisare.TabIndex = 13;
            this.btnAfisare.Text = "Afisare";
            this.btnAfisare.UseVisualStyleBackColor = true;
            this.btnAfisare.Click += new System.EventHandler(this.btnAfisare_Click);
            // 
            // lvPrescriptii
            // 
            this.lvPrescriptii.Activation = System.Windows.Forms.ItemActivation.TwoClick;
            this.lvPrescriptii.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader6});
            this.lvPrescriptii.FullRowSelect = true;
            this.lvPrescriptii.HideSelection = false;
            this.lvPrescriptii.Location = new System.Drawing.Point(13, 197);
            this.lvPrescriptii.Name = "lvPrescriptii";
            this.lvPrescriptii.Size = new System.Drawing.Size(331, 120);
            this.lvPrescriptii.TabIndex = 15;
            this.lvPrescriptii.UseCompatibleStateImageBehavior = false;
            this.lvPrescriptii.View = System.Windows.Forms.View.Details;
            this.lvPrescriptii.ItemActivate += new System.EventHandler(this.lvPrescriptii_ItemActivate);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID Prescriptie";
            this.columnHeader1.Width = 85;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Numele medicului";
            this.columnHeader2.Width = 105;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Medicamente";
            this.columnHeader6.Width = 102;
            // 
            // MeniuAdaugarePacient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lvPrescriptii);
            this.Controls.Add(this.btnAfisare);
            this.Controls.Add(this.lvPacienti);
            this.Controls.Add(this.btnCurata);
            this.Controls.Add(this.btnAdauga);
            this.Controls.Add(this.tbDataNasterii);
            this.Controls.Add(this.tbSex);
            this.Controls.Add(this.tbCNP);
            this.Controls.Add(this.tbNume);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.a);
            this.Controls.Add(this.label1);
            this.Name = "MeniuAdaugarePacient";
            this.Text = "MeniuAdaugarePacient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label a;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbNume;
        private System.Windows.Forms.TextBox tbCNP;
        private System.Windows.Forms.TextBox tbSex;
        private System.Windows.Forms.TextBox tbDataNasterii;
        private System.Windows.Forms.Button btnAdauga;
        private System.Windows.Forms.Button btnCurata;
        private System.Windows.Forms.ListView lvPacienti;
        private System.Windows.Forms.ColumnHeader Nume;
        private System.Windows.Forms.ColumnHeader CNP;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button btnAfisare;
        private System.Windows.Forms.ListView lvPrescriptii;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}