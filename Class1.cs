using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NVSprojekt
{
    public class Trojuholnik
    {
            public double stranaA;     /**< Strana A trojúholníka */
            public double stranaB;     /**< Strana B trojúholníka */
            public double stranaC;     /**< Strana C trojúholníka */
            public bool zostrojitelnost;
            public Trojuholnik(double stranaA, double stranaB, double stranaC)
            {
                this.stranaA = stranaA;
                this.stranaB = stranaB;
                this.stranaC = stranaC;
            }

            public static double vypocitejPreponu(double stranaA, double stranaB)
            {
                return Math.Round(Math.Sqrt(Math.Pow(stranaA, 2) + Math.Pow(stranaB, 2)), 3);
            }

            public static double vypocitejOdvesnuA(double stranaB, double stranaC)
            {
                return Math.Round(Math.Sqrt(Math.Pow(stranaC, 2) - Math.Pow(stranaB, 2)), 3);
            }

            public static double vypocitejOdvesnuB(double stranaA, double stranaC)
            {
                return Math.Round(Math.Sqrt(Math.Pow(stranaC, 2) - Math.Pow(stranaA, 2)), 3);
            }

            public static double Obvod(double stranaA, double stranaB, double stranaC)
            {
                double obvod = stranaA + stranaB + stranaC;
                return obvod;
            }

            public static double Obsah(double stranaA, double stranaB, double stranaC)
            {
                double s = (stranaA + stranaB + stranaC) / 2;
                double obsah = Math.Sqrt(s * (s - stranaA) * (s - stranaB) * (s - stranaC));
                return Math.Round(obsah, 3);
            }

            public static bool Zostrojitelnost(double stranaA, double stranaB, double stranaC)
            {
                bool zostrojitelnost = ((stranaA + stranaB > stranaC) && (stranaC + stranaA > stranaB) && (stranaC + stranaB > stranaA));
                return zostrojitelnost;
            }

    }
}

