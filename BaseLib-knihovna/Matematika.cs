using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fei.BaseLib
{
    /// <summary>
    /// Obsahuje metody pro matematické operace.
    /// </summary>
    public class Matematika
    {
        /// <summary>
        /// Vypočte zadaný kořen kvadratické rovnice
        /// </summary>
        /// <param name="a">Koeficient a.</param>
        /// <param name="b">Koeficient b.</param>
        /// <param name="c">Koeficient c.</param>
        /// <param name="prvniKoren">Určuje zda vypočítáme první nebo druhý kořen kvadratické rovnice.</param>
        /// <returns>Je-li <paramref name="prvniKoren"/> roven <c>true</c>, vrací první kořen kv. rce. Jinak vrací druhý kořen kv.rce. </returns>
        public static double KorenKvadrRovnice(double a, double b, double c, bool prvniKoren)
        {
            if (a == 0) return -c / b;
            double d = Math.Pow(b, 2) - 4 * a * c; 
            if (prvniKoren) return (-b + Math.Sqrt(d)) / (2 * a);
            else return (-b - Math.Sqrt(d)) / (2 * a);
        }

        /// <summary>
        /// Vygeneruje pseudonáhodné reálné číslo v zadaném rozsahu.
        /// </summary>
        /// <param name="rnd">Generátor náh. čísel.</param>
        /// <param name="min">Dolní hranice generovaných čísel.</param>
        /// <param name="max">Horní hranice generovaných čísel.</param>
        /// <returns>Náhodné reálné číslo v rozsahu <paramref name="min"/> až <paramref name="max"/></returns>
        public static double DejNahodneDouble(Random rnd, double min, double max)
        {
            return ((max - min) * rnd.NextDouble()) + min;
        }
    }
}
