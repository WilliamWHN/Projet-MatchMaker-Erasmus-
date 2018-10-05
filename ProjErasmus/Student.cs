using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    public class Eleve
    {
        #region private attributs
        private string name;
        private Boolean isCapt;
        private List<int> listOfChoices = null;
        #endregion private attributs

        #region constructor
        public Eleve(string name, Boolean isCapt, List<int> listOfChoices)
        {
            this.name = name;
            this.isCapt = isCapt;
            this.listOfChoices = listOfChoices;
        }
        #endregion constructor

        #region public accesors and mutators (get/set)
        public string Name
        {
            get { return this.name; }
        }
        public Boolean IsCapt
        {
            get { return this.isCapt; }
        }
        public List<int> ListOfChoices
        {
            get { return this.listOfChoices; }
        }
        #endregion public accesors and mutators (get/set)
    }
}
