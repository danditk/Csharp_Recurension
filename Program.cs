using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Recurension
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"PlikProgramuEsharp_Recurension.txt"; // relatywnie                  //"d:\\TeporatyFiles\\PlikProgramuEsharp_Recurension.txt" = @"d:\TeporatyFiles\PlikProgramuEsharp_Recurension.txt"
            StreamWriter sw;
            if (!File.Exists(path))
            {
                sw = File.CreateText(path);
                Console.WriteLine("Plik został utworzony!");
            }
            else
            {
                sw = new StreamWriter(path, true);
                Console.WriteLine("Plik został otwarty");
            }

            Console.ReadKey();
            Console.WriteLine("\nKliknij, aby rozpocząć pomiar");

            const int NUMBER = 8;
            Stopwatch time = new Stopwatch();
            time.Start();
            string strong = Strong(NUMBER).ToString();
            //Console.WriteLine(Strong(NUMBER));
            time.Stop();
            string strongTime = time.ElapsedTicks.ToString();
            //Console.WriteLine(time.ElapsedTicks);

            time.Reset();
            //Console.WriteLine();

            time.Start();
            string strongRec = StrongRec(NUMBER).ToString();
            //Console.WriteLine(StrongRec(NUMBER));
            time.Stop();
            string strongRecTime = time.ElapsedTicks.ToString();
            //Console.WriteLine(time.ElapsedTicks);

            time.Reset();


            Console.WriteLine("Wpisz dowolny tytuł pomiaru lub zostaw puste pole i zatwierdź");
            string textToFile = Console.ReadLine() + "\n";
            textToFile += strong + "\nWyniki porównania \n";
            textToFile += strong + " - ";
            textToFile += strongTime + " j.p. \n";
            textToFile += strongRec + " - ";
            textToFile += strongRecTime + " j.p. \n";

            sw.WriteLine(textToFile);
            sw.Close();
            Console.WriteLine("Dane zostały zapisane w pliku i zamknięty");

            StreamReader sr = File.OpenText(path);
            string insideFile = "";
            int i = 0;

            Console.WriteLine("\nZawartość pliku:");
            while ((insideFile = sr.ReadLine()) != null)
            {
                Console.WriteLine(i++ + ". " + insideFile);
            }
            sr.Close();

            Console.WriteLine("Czy usunąć plik? [T/t]");
            string userDec = Console.ReadLine();
            if (userDec == "T" || userDec == "t")
            {
                File.Delete(path);
                Console.WriteLine("Plik został usunięty!");
            }

            Console.WriteLine("Proces zakończony");
            Console.ReadKey();

        }

        private static long StrongRec(int x)
        {
            if (x <= 1)
            {
                return 1;
            }
            else
            {
                return StrongRec(x - 1) * x;
            }
        }

        private static long Strong(int x)
        {
            long result = 1;

            while (x > 1)
            {
                result *= x;
                x--;
            }

            return result;
        }
    }
}
