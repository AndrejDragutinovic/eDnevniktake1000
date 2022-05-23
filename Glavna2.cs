using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace eDnevnik
{
    public partial class Glavna2 : Form
    {
        public Glavna2()
        {
            InitializeComponent();
        }

        private void upisniceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Upisnica stagod = new Upisnica();
            stagod.Show();
        }
    }
}
