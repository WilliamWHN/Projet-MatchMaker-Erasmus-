using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestErasmus
{
    [TestClass]
    public class TestRwCSV
    {
        ProjErasmus.RwCSV testImport = new ProjErasmus.RwCSV();

        /*
        [TestMethod]
        public void TestMethod1()      
        {
            string path = @"C:\Users\william.hausmann\source\repos\Projet-MatchMaker-Erasmus-\README.md";            
            testImport.OpenFile(path);
        }*/

        [TestMethod]
        public void TestMethod2()
        {
            string path = @"C:\Users\william.hausmann\Desktop\TestData.csv";
            string texteattendu = "";
            string texte;
            texte = testImport.ReadCSV(path);

            Assert.AreEqual(texteattendu, texte);

        }
    }
}
