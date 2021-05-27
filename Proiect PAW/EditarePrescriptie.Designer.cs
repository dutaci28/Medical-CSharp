
namespace Proiect_PAW
{
    partial class EditarePrescriptie
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
            this.tbIdPrescriptie = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCurata = new System.Windows.Forms.Button();
            this.btnAdauga = new System.Windows.Forms.Button();
            this.tbMedicamente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNumeMedic = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbIdPrescriptie
            // 
            this.tbIdPrescriptie.Location = new System.Drawing.Point(12, 32);
            this.tbIdPrescriptie.Name = "tbIdPrescriptie";
            this.tbIdPrescriptie.ReadOnly = true;
            this.tbIdPrescriptie.Size = new System.Drawing.Size(338, 20);
            this.tbIdPrescriptie.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "ID Prescriptie";
            // 
            // btnCurata
            // 
            this.btnCurata.Location = new System.Drawing.Point(276, 414);
            this.btnCurata.Name = "btnCurata";
            this.btnCurata.Size = new System.Drawing.Size(75, 23);
            this.btnCurata.TabIndex = 20;
            this.btnCurata.Text = "Curata";
            this.btnCurata.UseVisualStyleBackColor = true;
            this.btnCurata.Click += new System.EventHandler(this.btnCurata_Click);
            // 
            // btnAdauga
            // 
            this.btnAdauga.Location = new System.Drawing.Point(16, 414);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(75, 23);
            this.btnAdauga.TabIndex = 19;
            this.btnAdauga.Text = "Modifica";
            this.btnAdauga.UseVisualStyleBackColor = true;
            this.btnAdauga.Click += new System.EventHandler(this.btnAdauga_Click);
            // 
            // tbMedicamente
            // 
            this.tbMedicamente.Location = new System.Drawing.Point(11, 110);
            this.tbMedicamente.Name = "tbMedicamente";
            this.tbMedicamente.ReadOnly = true;
            this.tbMedicamente.Size = new System.Drawing.Size(338, 20);
            this.tbMedicamente.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Medicamente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Numele medicului";
            // 
            // tbNumeMedic
            // 
            this.tbNumeMedic.Location = new System.Drawing.Point(12, 71);
            this.tbNumeMedic.Name = "tbNumeMedic";
            this.tbNumeMedic.Size = new System.Drawing.Size(337, 20);
            this.tbNumeMedic.TabIndex = 23;
            // 
            // EditarePrescriptie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 450);
            this.Controls.Add(this.tbNumeMedic);
            this.Controls.Add(this.tbIdPrescriptie);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCurata);
            this.Controls.Add(this.btnAdauga);
            this.Controls.Add(this.tbMedicamente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "EditarePrescriptie";
            this.Text = "EditarePrescriptie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbIdPrescriptie;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCurata;
        private System.Windows.Forms.Button btnAdauga;
        private System.Windows.Forms.TextBox tbMedicamente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNumeMedic;
    }
}