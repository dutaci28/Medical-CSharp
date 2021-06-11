
namespace Proiect_PAW
{
    partial class MeniuSpitale
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
            this.lvSpitale = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvZone = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNumeSpital = new System.Windows.Forms.TextBox();
            this.tbCodSpital = new System.Windows.Forms.TextBox();
            this.tbCodZona = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbCodZona1 = new System.Windows.Forms.TextBox();
            this.tbNumeZona = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvSpitale
            // 
            this.lvSpitale.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvSpitale.HideSelection = false;
            this.lvSpitale.Location = new System.Drawing.Point(52, 12);
            this.lvSpitale.Name = "lvSpitale";
            this.lvSpitale.Size = new System.Drawing.Size(277, 264);
            this.lvSpitale.TabIndex = 0;
            this.lvSpitale.UseCompatibleStateImageBehavior = false;
            this.lvSpitale.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nume Spital";
            this.columnHeader1.Width = 96;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Cod Spital";
            this.columnHeader2.Width = 83;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Cod Zona";
            // 
            // lvZone
            // 
            this.lvZone.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader6});
            this.lvZone.HideSelection = false;
            this.lvZone.Location = new System.Drawing.Point(417, 12);
            this.lvZone.Name = "lvZone";
            this.lvZone.Size = new System.Drawing.Size(306, 264);
            this.lvZone.TabIndex = 1;
            this.lvZone.UseCompatibleStateImageBehavior = false;
            this.lvZone.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Nume Zona";
            this.columnHeader4.Width = 96;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Cod Zona";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 295);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "NumeSpital";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 335);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "CodSpital";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 374);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "CodZona";
            // 
            // tbNumeSpital
            // 
            this.tbNumeSpital.Location = new System.Drawing.Point(52, 312);
            this.tbNumeSpital.Name = "tbNumeSpital";
            this.tbNumeSpital.Size = new System.Drawing.Size(100, 20);
            this.tbNumeSpital.TabIndex = 5;
            // 
            // tbCodSpital
            // 
            this.tbCodSpital.Location = new System.Drawing.Point(52, 351);
            this.tbCodSpital.Name = "tbCodSpital";
            this.tbCodSpital.Size = new System.Drawing.Size(100, 20);
            this.tbCodSpital.TabIndex = 6;
            // 
            // tbCodZona
            // 
            this.tbCodZona.Location = new System.Drawing.Point(52, 390);
            this.tbCodZona.Name = "tbCodZona";
            this.tbCodZona.Size = new System.Drawing.Size(100, 20);
            this.tbCodZona.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(52, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Insereaza";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(414, 295);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "NumeZona";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(414, 335);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "CodZona";
            // 
            // tbCodZona1
            // 
            this.tbCodZona1.Location = new System.Drawing.Point(417, 351);
            this.tbCodZona1.Name = "tbCodZona1";
            this.tbCodZona1.Size = new System.Drawing.Size(100, 20);
            this.tbCodZona1.TabIndex = 11;
            // 
            // tbNumeZona
            // 
            this.tbNumeZona.Location = new System.Drawing.Point(417, 312);
            this.tbNumeZona.Name = "tbNumeZona";
            this.tbNumeZona.Size = new System.Drawing.Size(100, 20);
            this.tbNumeZona.TabIndex = 12;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(417, 415);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Insereaza";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MeniuSpitale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tbNumeZona);
            this.Controls.Add(this.tbCodZona1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbCodZona);
            this.Controls.Add(this.tbCodSpital);
            this.Controls.Add(this.tbNumeSpital);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvZone);
            this.Controls.Add(this.lvSpitale);
            this.Name = "MeniuSpitale";
            this.Text = "MeniuSpitale";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvSpitale;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ListView lvZone;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNumeSpital;
        private System.Windows.Forms.TextBox tbCodSpital;
        private System.Windows.Forms.TextBox tbCodZona;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbCodZona1;
        private System.Windows.Forms.TextBox tbNumeZona;
        private System.Windows.Forms.Button button2;
    }
}