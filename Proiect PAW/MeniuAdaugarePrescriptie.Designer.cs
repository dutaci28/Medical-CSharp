
namespace Proiect_PAW
{
    partial class MeniuAdaugarePrescriptie
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNumeMedic = new System.Windows.Forms.TextBox();
            this.tbMedicamente = new System.Windows.Forms.TextBox();
            this.btnAdaugaMedicament = new System.Windows.Forms.Button();
            this.btnAdauga = new System.Windows.Forms.Button();
            this.btnCurata = new System.Windows.Forms.Button();
            this.lvPrescriptii = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label4 = new System.Windows.Forms.Label();
            this.tbIdPrescriptie = new System.Windows.Forms.TextBox();
            this.btnAfisare = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numele medicului";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Medicamente";
            // 
            // tbNumeMedic
            // 
            this.tbNumeMedic.Location = new System.Drawing.Point(12, 72);
            this.tbNumeMedic.Name = "tbNumeMedic";
            this.tbNumeMedic.Size = new System.Drawing.Size(338, 20);
            this.tbNumeMedic.TabIndex = 4;
            // 
            // tbMedicamente
            // 
            this.tbMedicamente.Location = new System.Drawing.Point(11, 111);
            this.tbMedicamente.Name = "tbMedicamente";
            this.tbMedicamente.Size = new System.Drawing.Size(338, 20);
            this.tbMedicamente.TabIndex = 5;
            // 
            // btnAdaugaMedicament
            // 
            this.btnAdaugaMedicament.Location = new System.Drawing.Point(11, 137);
            this.btnAdaugaMedicament.Name = "btnAdaugaMedicament";
            this.btnAdaugaMedicament.Size = new System.Drawing.Size(116, 23);
            this.btnAdaugaMedicament.TabIndex = 6;
            this.btnAdaugaMedicament.Text = "Adauga medicament";
            this.btnAdaugaMedicament.UseVisualStyleBackColor = true;
            this.btnAdaugaMedicament.Click += new System.EventHandler(this.btnAdaugaMedicament_Click);
            // 
            // btnAdauga
            // 
            this.btnAdauga.Location = new System.Drawing.Point(194, 415);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(75, 23);
            this.btnAdauga.TabIndex = 7;
            this.btnAdauga.Text = "Adauga";
            this.btnAdauga.UseVisualStyleBackColor = true;
            this.btnAdauga.Click += new System.EventHandler(this.btnAdauga_Click);
            // 
            // btnCurata
            // 
            this.btnCurata.Location = new System.Drawing.Point(275, 415);
            this.btnCurata.Name = "btnCurata";
            this.btnCurata.Size = new System.Drawing.Size(75, 23);
            this.btnCurata.TabIndex = 8;
            this.btnCurata.Text = "Curata";
            this.btnCurata.UseVisualStyleBackColor = true;
            this.btnCurata.Click += new System.EventHandler(this.btnCurata_Click);
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
            this.lvPrescriptii.Location = new System.Drawing.Point(357, 13);
            this.lvPrescriptii.Name = "lvPrescriptii";
            this.lvPrescriptii.Size = new System.Drawing.Size(431, 398);
            this.lvPrescriptii.TabIndex = 9;
            this.lvPrescriptii.UseCompatibleStateImageBehavior = false;
            this.lvPrescriptii.View = System.Windows.Forms.View.Details;
            this.lvPrescriptii.ItemActivate += new System.EventHandler(this.lvPrescriptii_ItemActivate);
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "ID Prescriptie";
            // 
            // tbIdPrescriptie
            // 
            this.tbIdPrescriptie.Location = new System.Drawing.Point(12, 33);
            this.tbIdPrescriptie.Name = "tbIdPrescriptie";
            this.tbIdPrescriptie.Size = new System.Drawing.Size(338, 20);
            this.tbIdPrescriptie.TabIndex = 11;
            this.tbIdPrescriptie.TextChanged += new System.EventHandler(this.tbIdPrescriptie_TextChanged);
            this.tbIdPrescriptie.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbIdPrescriptie_KeyPress);
            // 
            // btnAfisare
            // 
            this.btnAfisare.Location = new System.Drawing.Point(713, 415);
            this.btnAfisare.Name = "btnAfisare";
            this.btnAfisare.Size = new System.Drawing.Size(75, 23);
            this.btnAfisare.TabIndex = 12;
            this.btnAfisare.Text = "Afisare";
            this.btnAfisare.UseVisualStyleBackColor = true;
            this.btnAfisare.Click += new System.EventHandler(this.btnAfisare_Click);
            // 
            // MeniuAdaugarePrescriptie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAfisare);
            this.Controls.Add(this.tbIdPrescriptie);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lvPrescriptii);
            this.Controls.Add(this.btnCurata);
            this.Controls.Add(this.btnAdauga);
            this.Controls.Add(this.btnAdaugaMedicament);
            this.Controls.Add(this.tbMedicamente);
            this.Controls.Add(this.tbNumeMedic);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "MeniuAdaugarePrescriptie";
            this.Text = "MeniuAdaugarePrescriptie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNumeMedic;
        private System.Windows.Forms.TextBox tbMedicamente;
        private System.Windows.Forms.Button btnAdaugaMedicament;
        private System.Windows.Forms.Button btnAdauga;
        private System.Windows.Forms.Button btnCurata;
        private System.Windows.Forms.ListView lvPrescriptii;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbIdPrescriptie;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btnAfisare;
    }
}