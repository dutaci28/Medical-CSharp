
namespace Proiect_PAW
{
    partial class MeniuDragDropClipboard
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
            this.lvPrescriptii = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lvCopie = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvPrescriptii
            // 
            this.lvPrescriptii.Activation = System.Windows.Forms.ItemActivation.TwoClick;
            this.lvPrescriptii.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader3,
            this.columnHeader4});
            this.lvPrescriptii.ContextMenuStrip = this.contextMenuStrip1;
            this.lvPrescriptii.FullRowSelect = true;
            this.lvPrescriptii.HideSelection = false;
            this.lvPrescriptii.Location = new System.Drawing.Point(25, 96);
            this.lvPrescriptii.Name = "lvPrescriptii";
            this.lvPrescriptii.Size = new System.Drawing.Size(317, 262);
            this.lvPrescriptii.TabIndex = 11;
            this.lvPrescriptii.UseCompatibleStateImageBehavior = false;
            this.lvPrescriptii.View = System.Windows.Forms.View.Details;
            this.lvPrescriptii.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lvPrescriptii_MouseDown);
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
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(103, 26);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // lvCopie
            // 
            this.lvCopie.Activation = System.Windows.Forms.ItemActivation.TwoClick;
            this.lvCopie.AllowDrop = true;
            this.lvCopie.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader5,
            this.columnHeader6});
            this.lvCopie.ContextMenuStrip = this.contextMenuStrip2;
            this.lvCopie.FullRowSelect = true;
            this.lvCopie.HideSelection = false;
            this.lvCopie.Location = new System.Drawing.Point(436, 96);
            this.lvCopie.Name = "lvCopie";
            this.lvCopie.Size = new System.Drawing.Size(317, 262);
            this.lvCopie.TabIndex = 12;
            this.lvCopie.UseCompatibleStateImageBehavior = false;
            this.lvCopie.View = System.Windows.Forms.View.Details;
            this.lvCopie.DragDrop += new System.Windows.Forms.DragEventHandler(this.lvCopie_DragDrop);
            this.lvCopie.DragEnter += new System.Windows.Forms.DragEventHandler(this.lvCopie_DragEnter);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "ID Prescriptie";
            this.columnHeader2.Width = 85;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Numele medicului";
            this.columnHeader5.Width = 105;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Medicamente";
            this.columnHeader6.Width = 102;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pasteToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(103, 26);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // MeniuDragDropClipboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lvCopie);
            this.Controls.Add(this.lvPrescriptii);
            this.Name = "MeniuDragDropClipboard";
            this.Text = "MeniuDragDropClipboard";
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvPrescriptii;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ListView lvCopie;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
    }
}