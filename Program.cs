/*! \mainpage Programová dokumentácia
 *
 * \section intro Úvod
 * \author Lukáš Mahďar
 * \date December 2019
 * \section details Konzolová aplikáca - Výpočet trojúholníka
 *   - Uživateľ si zvolí ktorú stranu chce vypočítať
 *   - Uživatel zadá zvyšné strany trojuholníka
 *   - Program vypočítá zvolenú stranu, Obvod, Obsah a vráti True alebo False na zostrojiteľnosť trojuholníka
 *  
 *
 *  
 *
 * 
 */

/**
 * \file Program.cs
 * \brief Main programu a vyberanie strán trojuholníka
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
     * \brief Trieda program definuje Main konzolovej aplikácie trojuholník 
     */
    class Program
    {

        static void Main(string[] args)
        {
        znova:
            Trojuholnik trojuholnik = new Trojuholnik(0, 0, 0);
            Console.WriteLine("Akú stranu pravouhlého trojuholníka chceš vypočítať? (a,b,c)");
            string side = Console.ReadLine(); /**- string ktorý zadá úživateľ na konzoly */
            /**
             * \brief Ak si užívateľ zvolí stranu A tak sa spustí príkaz na výpočet strany A, Obsah, Obvod a Zostrojiteľnosť trojuholníka
             */
            if (side == "a") 
            {
                Console.WriteLine("Zadajte veľkost strany C ktorá je prepona:");
                trojuholnik.stranaC = double.Parse(Console.ReadLine()); /**- Užívateľ zadá stranu C */
                Console.WriteLine("Zadajte veľkost odvesny B");
                trojuholnik.stranaB = double.Parse(Console.ReadLine()); /**- Užívateľ zadá stranu B */
                trojuholnik.stranaA = Trojuholnik.vypocitejOdvesnuA(trojuholnik.stranaB, trojuholnik.stranaC);
                Console.WriteLine($"Strana A je: {trojuholnik.stranaA}");
                Console.WriteLine($"Obsah: {Trojuholnik.Obsah(trojuholnik.stranaA, trojuholnik.stranaB, trojuholnik.stranaC)}");
                Console.WriteLine($"Obvod: {Trojuholnik.Obvod(trojuholnik.stranaA, trojuholnik.stranaB, trojuholnik.stranaC)}");
                Console.WriteLine($"Je trojuholnik zostrojitelny?: {Trojuholnik.Zostrojitelnost(trojuholnik.stranaA, trojuholnik.stranaB, trojuholnik.stranaC)}");
            }
            /**
             * \brief Ak si užívateľ zvolí stranu B tak sa spustí príkaz na výpočet strany B, Obsah, Obvod a Zostrojiteľnosť trojuholníka
             */
            else if (side == "b")
            {
                Console.WriteLine("Zadajte veľkost strany C ktorá je prepona:");
                trojuholnik.stranaC = double.Parse(Console.ReadLine()); /**- Užívateľ zadá stranu C */
                Console.WriteLine("Zadajte veľkost odvesny A");
                trojuholnik.stranaA = double.Parse(Console.ReadLine()); /**- Užívateľ zadá stranu A */
                trojuholnik.stranaB = Trojuholnik.vypocitejOdvesnuA(trojuholnik.stranaA, trojuholnik.stranaC);
                Console.WriteLine($"Strana B je: {trojuholnik.stranaB}");
                Console.WriteLine($"Obsah: {Trojuholnik.Obsah(trojuholnik.stranaA, trojuholnik.stranaB, trojuholnik.stranaC)}");
                Console.WriteLine($"Obvod: {Trojuholnik.Obvod(trojuholnik.stranaA, trojuholnik.stranaB, trojuholnik.stranaC)}");
                Console.WriteLine($"Je trojuholnik zostrojitelny?: {Trojuholnik.Zostrojitelnost(trojuholnik.stranaA, trojuholnik.stranaB, trojuholnik.stranaC)}");
            }
            /**
             * \brief Ak si užívateľ zvolí stranu C tak sa spustí príkaz na výpočet strany C, Obsah, Obvod a Zostrojiteľnosť trojuholníka
             */
            else if (side == "c")
            {
                Console.WriteLine("Zadajte veľkost dovesny A");
                trojuholnik.stranaA = double.Parse(Console.ReadLine()); /**- Užívateľ zadá stranu A */
                Console.WriteLine("Zadajte veľkost odvesny B");
                trojuholnik.stranaB = double.Parse(Console.ReadLine()); /**- Užívateľ zadá stranu B */
                trojuholnik.stranaC = Trojuholnik.vypocitejPreponu(trojuholnik.stranaA, trojuholnik.stranaB);
                Console.WriteLine($"Strana C je: {trojuholnik.stranaC}");
                Console.WriteLine($"Obsah: {Trojuholnik.Obsah(trojuholnik.stranaA, trojuholnik.stranaB, trojuholnik.stranaC)}");
                Console.WriteLine($"Obvod: {Trojuholnik.Obvod(trojuholnik.stranaA, trojuholnik.stranaB, trojuholnik.stranaC)}");
                Console.WriteLine($"Je trojuholnik zostrojitelny?: {Trojuholnik.Zostrojitelnost(trojuholnik.stranaA, trojuholnik.stranaB, trojuholnik.stranaC)}");
            }
            /**
             * \brief Ak užívateľ zadá inú hodnotu ako A,B,C konzola vypíše Zle zadané a vráti ho späť na výber strany
             */
            else
            {
                Console.WriteLine("Zle zadane");
            }
            while (true)
            {
                Console.WriteLine("Zadajte 1 pre výpočet | Zadajte 2 pre koniec");
                int i = 0;
                try
                {
                    i = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Zle zadané");
                }
                if (i == 1)
                {
                    goto znova;
                }
                else if (i == 2)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Zadajte 1 alebo 2");
                }
            }

        }
    }
}
