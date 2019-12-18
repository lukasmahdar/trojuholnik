/**
 * \file Class1.cs
 * \brief Trieda obsahuje metódy na výpočet strán, Obsahu, Obvodu a Zostrojitelnosti
 *   
 * 
 * 
*/



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NVSprojekt
{
    /**
    *\brief Trieda Trojuholník obsahuje metódy na výpočet strán, Obsahu, Obvodu a Zostrojitelnosti
    */
    public class Trojuholnik
    {
            public double stranaA;     /**< Dĺžka strany A */
            public double stranaB;     /**< Dĺžka strany B */
            public double stranaC;     /**< Dĺžka strany C */
            public bool zostrojitelnost;   /**< bool pre Zostrojiteľnosť */


        /**
        * \brief Konstruktor triedy Trojuholnik
        * \param strana A
        * \param strana B
        * \param strana C
        */
        public Trojuholnik(double stranaA, double stranaB, double stranaC)
            {
                this.stranaA = stranaA;
                this.stranaB = stranaB;
                this.stranaC = stranaC;
            }

        /**
	    * \brief Metoda vracia výpočet prepony trojuholníka
	    * \return Veľkosť Prepony (strana C)
	    */
        public static double vypocitejPreponu(double stranaA, double stranaB)
            {
                return Math.Round(Math.Sqrt(Math.Pow(stranaA, 2) + Math.Pow(stranaB, 2)), 3);
            }

        /**
	    * \brief Metoda vracia výpočet odvesny trojuholníka
	    * \return Veľkosť Odvesny (strana A)
	    */
        public static double vypocitejOdvesnuA(double stranaB, double stranaC)
            {
                return Math.Round(Math.Sqrt(Math.Pow(stranaC, 2) - Math.Pow(stranaB, 2)), 3);
            }

        /**
	    * \brief Metoda vracia výpočet prepony trojuholníka
	    * \return Veľkosť Prepony (strana B)
	    */
        public static double vypocitejOdvesnuB(double stranaA, double stranaC)
            {
                return Math.Round(Math.Sqrt(Math.Pow(stranaC, 2) - Math.Pow(stranaA, 2)), 3);
            }

        /**
	    * \brief Metoda vracia Obvod výpočet Obvodu trojuholníka
	    * \return Veľkosť Obvodu
	    */
        public static double Obvod(double stranaA, double stranaB, double stranaC)
            {
                double obvod = stranaA + stranaB + stranaC;
                return obvod;
            }

        /**
	    * \brief Metoda Obsah vracia výpočet Obvodu trojuholníka
	    * \return Veľkosť Obsahu
	    */
        public static double Obsah(double stranaA, double stranaB, double stranaC)
            {
                double s = (stranaA + stranaB + stranaC) / 2;
                double obsah = Math.Sqrt(s * (s - stranaA) * (s - stranaB) * (s - stranaC));
                return Math.Round(obsah, 3);
            }

        /**
	    * \brief Metoda Zostrojiteľnosť vracia true alebo false
	    * \return Zsotrojiteľnosť trojúholníka (true, false)
	    */
        public static bool Zostrojitelnost(double stranaA, double stranaB, double stranaC)
            {
                bool zostrojitelnost = ((stranaA + stranaB > stranaC) && (stranaC + stranaA > stranaB) && (stranaC + stranaB > stranaA));
                return zostrojitelnost;
            }

    }
}

