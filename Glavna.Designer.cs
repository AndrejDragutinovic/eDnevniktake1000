
namespace eDnevnik
{
    partial class Glavna
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.jednaBezToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.osobeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jedanSaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabelaBEzFkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabelaSaFkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izvestajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raspodelaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jednaBezToolStripMenuItem,
            this.jedanSaToolStripMenuItem,
            this.tabelaBEzFkToolStripMenuItem,
            this.tabelaSaFkToolStripMenuItem,
            this.izvestajToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // jednaBezToolStripMenuItem
            // 
            this.jednaBezToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.osobeToolStripMenuItem});
            this.jednaBezToolStripMenuItem.Name = "jednaBezToolStripMenuItem";
            this.jednaBezToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.jednaBezToolStripMenuItem.Text = "Jedna Bez";
            // 
            // osobeToolStripMenuItem
            // 
            this.osobeToolStripMenuItem.Name = "osobeToolStripMenuItem";
            this.osobeToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.osobeToolStripMenuItem.Text = "Osobe";
            this.osobeToolStripMenuItem.Click += new System.EventHandler(this.osobeToolStripMenuItem_Click);
            // 
            // jedanSaToolStripMenuItem
            // 
            this.jedanSaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.raspodelaToolStripMenuItem});
            this.jedanSaToolStripMenuItem.Name = "jedanSaToolStripMenuItem";
            this.jedanSaToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.jedanSaToolStripMenuItem.Text = "Jedan SaFK";
            // 
            // tabelaBEzFkToolStripMenuItem
            // 
            this.tabelaBEzFkToolStripMenuItem.Name = "tabelaBEzFkToolStripMenuItem";
            this.tabelaBEzFkToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.tabelaBEzFkToolStripMenuItem.Text = "Tabela BEzFk";
            // 
            // tabelaSaFkToolStripMenuItem
            // 
            this.tabelaSaFkToolStripMenuItem.Name = "tabelaSaFkToolStripMenuItem";
            this.tabelaSaFkToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.tabelaSaFkToolStripMenuItem.Text = "Tabela SaFk";
            // 
            // izvestajToolStripMenuItem
            // 
            this.izvestajToolStripMenuItem.Name = "izvestajToolStripMenuItem";
            this.izvestajToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.izvestajToolStripMenuItem.Text = "Izvestaj";
            // 
            // raspodelaToolStripMenuItem
            // 
            this.raspodelaToolStripMenuItem.Name = "raspodelaToolStripMenuItem";
            this.raspodelaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.raspodelaToolStripMenuItem.Text = "Raspodela";
            this.raspodelaToolStripMenuItem.Click += new System.EventHandler(this.raspodelaToolStripMenuItem_Click);
            // 
            // Glavna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Glavna";
            this.Text = "Glavna";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem jednaBezToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem osobeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jedanSaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tabelaBEzFkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tabelaSaFkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izvestajToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem raspodelaToolStripMenuItem;
    }
}