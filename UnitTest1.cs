/**
 * \file UnitTest1.cs
 * \brief Testuje metódy použité v programe
 *   
 * 
 * 
*/
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NVSprojekt;

namespace UnitTestProject1
{
    /**
    *\brief Testuje metódy použité v programe
    */
    [TestClass]
    public class UnitTest1
    {
        /**
       *\brief Testovacia metóda testuje výstup Obvodu s predpokladanou hodnotou 60
        */
        [TestMethod]
        public void Obvod()
        {
            Trojuholnik trojuholnik = new Trojuholnik(24, 10, 26);
            Assert.AreEqual(60, Trojuholnik.Obvod(trojuholnik.stranaA, trojuholnik.stranaB, trojuholnik.stranaC));
        }

        /**
       *\brief Testovacia metóda testuje výstup Obsahu s predpokladanou hodnotou 30
        */
        [TestMethod]
        public void Obsah()
        {
            Trojuholnik trojuholnik = new Trojuholnik(5, 12, 13);
            Assert.AreEqual(30, Trojuholnik.Obsah(trojuholnik.stranaA, trojuholnik.stranaB, trojuholnik.stranaC));
        }

        /**
       *\brief Testovacia metóda testuje Zostrojiteľnosť s predpokladanými dvoma hodnotami True a False
        */
        [TestMethod]
        public void Zostrojitelnost()
        {
            Trojuholnik trojuholnik = new Trojuholnik(6, 8, 10);
            Assert.IsTrue(Trojuholnik.Zostrojitelnost(trojuholnik.stranaA, trojuholnik.stranaB, trojuholnik.stranaC));

            Trojuholnik trojuholnik2 = new Trojuholnik(25, 10, 6);
            Assert.IsFalse(Trojuholnik.Zostrojitelnost(trojuholnik2.stranaA, trojuholnik2.stranaB, trojuholnik2.stranaC));
        }
    }
}
