using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using System.IO;
using System.Windows.Forms;

namespace ProjErasmus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            GuiCreateStudent f2 = new GuiCreateStudent();
            f2.ShowDialog();
        }


        private void btnCSV_Click(object sender, EventArgs e)
        {
            ProjErasmus.RwCSV ImportMethod = new ProjErasmus.RwCSV();
            string text = ImportMethod.Import();
            MessageBox.Show(text);
        }
    }
}
