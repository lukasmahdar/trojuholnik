using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NVSprojekt
{
    class Program
    {
        static void Main(string[] args)
        {
        znova:
            Trojuholnik trojuholnik = new Trojuholnik(0, 0, 0);
            Console.WriteLine("Akú stranu pravouhlého trojuholníka chceš vypočítať? (a,b,c)");
            string side = Console.ReadLine();

            if (side == "a")
            {
                Console.WriteLine("Zadajte veľkost strany C ktorá je prepona:");
                trojuholnik.stranaC = double.Parse(Console.ReadLine());
                Console.WriteLine("Zadajte veľkost odvesny B");
                trojuholnik.stranaB = double.Parse(Console.ReadLine());
                trojuholnik.stranaA = Trojuholnik.vypocitejOdvesnuA(trojuholnik.stranaB, trojuholnik.stranaC);
                Console.WriteLine($"Strana A je: {trojuholnik.stranaA}");
                Console.WriteLine($"Obsah: {Trojuholnik.Obsah(trojuholnik.stranaA, trojuholnik.stranaB, trojuholnik.stranaC)}");
                Console.WriteLine($"Obvod: {Trojuholnik.Obvod(trojuholnik.stranaA, trojuholnik.stranaB, trojuholnik.stranaC)}");
                Console.WriteLine($"Je trojuholnik zostrojitelny?: {Trojuholnik.Zostrojitelnost(trojuholnik.stranaA, trojuholnik.stranaB, trojuholnik.stranaC)}");
            }
            else if (side == "b")
            {
                Console.WriteLine("Zadajte veľkost strany C ktorá je prepona:");
                trojuholnik.stranaC = double.Parse(Console.ReadLine());
                Console.WriteLine("Zadajte veľkost odvesny A");
                trojuholnik.stranaA = double.Parse(Console.ReadLine());
                trojuholnik.stranaB = Trojuholnik.vypocitejOdvesnuA(trojuholnik.stranaA, trojuholnik.stranaC);
                Console.WriteLine($"Strana B je: {trojuholnik.stranaB}");
                Console.WriteLine($"Obsah: {Trojuholnik.Obsah(trojuholnik.stranaA, trojuholnik.stranaB, trojuholnik.stranaC)}");
                Console.WriteLine($"Obvod: {Trojuholnik.Obvod(trojuholnik.stranaA, trojuholnik.stranaB, trojuholnik.stranaC)}");
                Console.WriteLine($"Je trojuholnik zostrojitelny?: {Trojuholnik.Zostrojitelnost(trojuholnik.stranaA, trojuholnik.stranaB, trojuholnik.stranaC)}");
            }
            else if (side == "c")
            {
                Console.WriteLine("Zadajte veľkost dovesny A");
                trojuholnik.stranaA = double.Parse(Console.ReadLine());
                Console.WriteLine("Zadajte veľkost odvesny B");
                trojuholnik.stranaB = double.Parse(Console.ReadLine());
                trojuholnik.stranaC = Trojuholnik.vypocitejPreponu(trojuholnik.stranaA, trojuholnik.stranaB);
                Console.WriteLine($"Strana C je: {trojuholnik.stranaC}");
                Console.WriteLine($"Obsah: {Trojuholnik.Obsah(trojuholnik.stranaA, trojuholnik.stranaB, trojuholnik.stranaC)}");
                Console.WriteLine($"Obvod: {Trojuholnik.Obvod(trojuholnik.stranaA, trojuholnik.stranaB, trojuholnik.stranaC)}");
                Console.WriteLine($"Je trojuholnik zostrojitelny?: {Trojuholnik.Zostrojitelnost(trojuholnik.stranaA, trojuholnik.stranaB, trojuholnik.stranaC)}");
            }
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
