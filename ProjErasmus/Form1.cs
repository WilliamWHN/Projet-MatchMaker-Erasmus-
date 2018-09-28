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
        {   //Utilisation de la librairie System.IO
            //Creation d'un nouvel objet ofd
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select a CSV file";
            ofd.Filter = "CSV files (*.csv)|*.csv";
            if (ofd.ShowDialog() == DialogResult.OK) {
                string ext = Path.GetExtension(ofd.FileName);
                if(ext != ".csv")
                {
                    MessageBox.Show(ext + "Ce n'est pas la bonne extension");
                }
                else {
                    string path = ofd.FileName;
                    MessageBox.Show(path);
                }
                
            }
        }
    }
}
