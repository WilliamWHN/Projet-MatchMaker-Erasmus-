using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestErasmus
{
    /// <summary>
    /// Summary description for TestStudent
    /// </summary>
    [TestClass]
    public class TestStudent { 

        [TestMethod]
        public void Student_Create_Succes()
        {
            //given
            //je déclare un objet de type "student"
            //Je déclare les parametres pour le test
            Student.Eleve teststudent;
            string testNameExcepted = "Jul";
            Boolean testIsCaptExcepted = true;
            List<int> testListOfChoiceExcepted = new List<int> { 1, 2, 3, 4 };

            //then
            //J'instancie mon objet student
            teststudent = new Student.Eleve(testNameExcepted, testIsCaptExcepted, testListOfChoiceExcepted);

            //when
            //je compare mes variables de test avec celle de mon objet
            Assert.AreEqual(testNameExcepted, teststudent.Name);
            Assert.AreEqual(testIsCaptExcepted, teststudent.IsCapt);
            Assert.AreEqual(testListOfChoiceExcepted, teststudent.ListOfChoices);
        }
    }
}
