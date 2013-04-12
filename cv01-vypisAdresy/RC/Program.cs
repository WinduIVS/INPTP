using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RC
{
    class Program
    {
        static void Main(string[] args)
        {
            string adresa = "Josef Novak\nJindrisska 16\n111 50, Praha 1\n \n";
            string jmeno = "karel";
            string prijmeni = "novak";

            Console.WriteLine(adresa);
            Console.WriteLine(jmeno + " " + prijmeni);

            Console.Write("Josef Novak\nJindrisska 16\n111 50, Praha 1\n \n");


            Console.ReadKey();

            for (int i = 65; i < 90; i++)
            {

                Console.WriteLine((char)i);
            }


            Console.Write("Zadej rodné číslo: ");
            string rodneCislo = Console.ReadLine();
            if (int.Parse(rodneCislo.Substring(2, 2)) > 12)
                Console.WriteLine("toto RČ patří ženě!");
            else
                Console.WriteLine("toto RČ patří muži!");
            Console.ReadKey();
        }
    }
}
