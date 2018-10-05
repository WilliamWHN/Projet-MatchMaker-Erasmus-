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
using Student;
using System.Windows.Forms;


namespace ProjErasmus
{
    public class RwCSV
    {
        public List<Eleve> Import()
        {
            //Utilisation de la librairie System.IO
            //Creation d'un nouvel objet ofd
            List<string[]> data = new List<string[]>();
            List<Eleve> listOfStudent = new List<Eleve>();
            bool Succes = false;
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select a CSV file";
            ofd.Filter = "CSV files (*.csv)|*.csv";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Succes = OpenFile(ofd.FileName);              
            }
            if (Succes == true)
            {
                listOfStudent = ReadCSV(ofd.FileName);
            }
            else
            {
                //throw ("L'import a echoué");
            }
            return listOfStudent;

        }

        public bool OpenFile(string path)
        {
            string ext = Path.GetExtension(path);
            if (ext != ".csv")
            {
                MessageBox.Show(ext + "Ce n'est pas la bonne extension");
                return false;
            }
            else
            {
                MessageBox.Show(path);
                return true;
            }

        }

        public List<Eleve> ReadCSV(string path)
        {
            List<string[]> Data = new List<string[]>();
            List<int> listOfActivities;
            List<Eleve> listOfStudent = new List<Eleve>();
            string nameOF;
            int isCaptInt;

            StreamReader file;                      
            file =  new StreamReader(path); 
            while (!file.EndOfStream)
            {
                string[] text = file.ReadLine().Split(',')[0].Split(';');
                Data.Add(text);
            }
            Eleve student;       
            foreach(string[] donnee in Data)
            {
                listOfActivities = new List<int>();            
                foreach(string activities in donnee.Skip(2))
                {
                    listOfActivities.Add(int.Parse(activities));
                }

                nameOF = donnee[0];               
                isCaptInt = int.Parse(donnee[1]);
                if (isCaptInt == 1)
                {
                    isCaptInt = 0;
                }
                else if (isCaptInt == 2)
                {
                    isCaptInt = 1;
                }
                Boolean isCapt = Convert.ToBoolean(isCaptInt);
                student = new Eleve(nameOF, isCapt, listOfActivities);
                listOfStudent.Add(student);
            }

            return listOfStudent;
        }
    }
}
