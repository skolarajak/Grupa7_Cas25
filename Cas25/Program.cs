using System;
using System.Collections.Generic;
using System.IO;


namespace Cas25
{
    class Program
    {
        static void Main(string[] args)
        {
            Zadatak1();
            Zadatak2();
            Console.ReadKey();
        }

        static void Zadatak1()
        {
            string Ime, Prezime, Email;

            Console.Write("Unesite ime > ");
            Ime = Console.ReadLine();

            Console.Write("Unesite prezime > ");
            Prezime = Console.ReadLine();

            Console.Write("Unesite email > ");
            Email = Console.ReadLine();

            //FileManagement.Write(Ime, Prezime, Email);
            // *** ili ***

            string FileName = @"C:\Kurs\cas25_zadatak1.txt";
            using (StreamWriter FileHandle = new StreamWriter(FileName, true))
            {
                FileHandle.WriteLine("{0};{1};{2}", Ime, Prezime, Email);
            }
        }

        static void Zadatak2()
        {
            List<int> Brojevi = new List<int>();
            string Unos;

            do
            {
                Console.Write("Unesite broj. (Ostaviti prazno za prekid) > ");
                Unos = Console.ReadLine();
                if (Unos != "")
                {
                    Brojevi.Add(Convert.ToInt32(Unos));
                }
            } while (Unos != "");

            foreach (int Broj in Brojevi)
            {
                if (Broj % 2 == 0)
                {
                    Console.WriteLine(Broj);
                }
            }
        }
    }
}
