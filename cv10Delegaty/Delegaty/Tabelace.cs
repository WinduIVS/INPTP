using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Delegaty
{
    // deklarace typu delegátu:
    public delegate double FunkceCallback(double x);
    class Tabelace
    {
        public void Tabulka(FunkceCallback f, double od, double @do, double krok)
        {
            Console.WriteLine("x f(x)");
            for (double x = od; x <= @do; x += krok)
            {
                Console.WriteLine("{0:F1} {1:F5}", x, f(x));
            }
            Console.ReadKey();
        }
        public double Mocnina(double x)
        {
            return x * x;
        }
    }
}


