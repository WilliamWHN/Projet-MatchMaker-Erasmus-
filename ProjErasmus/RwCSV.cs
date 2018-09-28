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
    public class RwCSV
    {
        public string Import()
        {
            //Utilisation de la librairie System.IO
            //Creation d'un nouvel objet ofd
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select a CSV file";
            ofd.Filter = "CSV files (*.csv)|*.csv";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                OpenFile(ofd.FileName);              
            }
            string text = ReadCSV(ofd.FileName);
            return text;

        }

        public void OpenFile(string path)
        {
            string ext = Path.GetExtension(path);
            if (ext != ".csv")
            {
                MessageBox.Show(ext + "Ce n'est pas la bonne extension");
            }
            else
            {
                MessageBox.Show(path);
            }

        }

        public string ReadCSV(string path)
        {
            string text = File.ReadAllText(path);
            return text;
        }
    }
}
