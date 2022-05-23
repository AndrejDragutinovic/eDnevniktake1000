
namespace eDnevnik
{
    partial class Glavna2
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
            this.obradaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raspodelaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oceneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.upisniceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sifarnicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izvestajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.obradaToolStripMenuItem,
            this.sifarnicaToolStripMenuItem,
            this.izvestajToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // obradaToolStripMenuItem
            // 
            this.obradaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.raspodelaToolStripMenuItem,
            this.oceneToolStripMenuItem,
            this.upisniceToolStripMenuItem});
            this.obradaToolStripMenuItem.Name = "obradaToolStripMenuItem";
            this.obradaToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.obradaToolStripMenuItem.Text = "Obrada";
            // 
            // raspodelaToolStripMenuItem
            // 
            this.raspodelaToolStripMenuItem.Name = "raspodelaToolStripMenuItem";
            this.raspodelaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.raspodelaToolStripMenuItem.Text = "Raspodela";
            // 
            // oceneToolStripMenuItem
            // 
            this.oceneToolStripMenuItem.Name = "oceneToolStripMenuItem";
            this.oceneToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.oceneToolStripMenuItem.Text = "Ocene";
            // 
            // upisniceToolStripMenuItem
            // 
            this.upisniceToolStripMenuItem.Name = "upisniceToolStripMenuItem";
            this.upisniceToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.upisniceToolStripMenuItem.Text = "Upisnice";
            this.upisniceToolStripMenuItem.Click += new System.EventHandler(this.upisniceToolStripMenuItem_Click);
            // 
            // sifarnicaToolStripMenuItem
            // 
            this.sifarnicaToolStripMenuItem.Name = "sifarnicaToolStripMenuItem";
            this.sifarnicaToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.sifarnicaToolStripMenuItem.Text = "Sifarnica";
            // 
            // izvestajToolStripMenuItem
            // 
            this.izvestajToolStripMenuItem.Name = "izvestajToolStripMenuItem";
            this.izvestajToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.izvestajToolStripMenuItem.Text = "Izvestaj";
            // 
            // Glavna2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Glavna2";
            this.Text = "Glavna2";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem obradaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem raspodelaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oceneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem upisniceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sifarnicaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izvestajToolStripMenuItem;
    }
}