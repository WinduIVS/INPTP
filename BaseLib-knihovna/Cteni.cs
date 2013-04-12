using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fei.BaseLib
{
    /// <summary>
    /// Obsahuje metody pro čtení z klávesnice.
    /// </summary>
    public class Cteni
    {
        /// <summary>
        /// Vypíše zadaný text na obrazovku a doplní jej o dvojtečku a mezeru.
        /// Následně načte číslo typu double.<see cref="double"/>.
        /// </summary>
        /// <param name="vyzva">Text, který se vypisuje na obrazovku.</param>
        /// <exception cref="FormatException">Načtené číslo není ve správném formátu.</exception>
        /// <exception cref="OverflowException">Načtené číslo je menší než
        /// <see cref="double.MinValue"/> nebo větší než <see cref="double.MaxValue"/>.</exception>
        /// <returns>Načtené číslo typu <see cref="double"/></returns>
       
        public static double NactiDouble(string vyzva)
        {
            Console.Write(vyzva + ": ");
            return double.Parse(Console.ReadLine());
        }
        /// <summary>
        /// Vypíše zadaný text na obrazovku a doplní jej o dvojtečku a mezeru.
        /// Následně načte číslo typu int.<see cref="int"/>.
        /// </summary>
        /// <param name="vyzva">Text, který se vypisuje na obrazovku.</param>
        /// <exception cref="FormatException">Načtené číslo není ve správném formátu.</exception>
        /// <exception cref="OverflowException">Načtené číslo je menší než
        /// <see cref="int.MinValue"/> nebo větší než <see cref="int.MaxValue"/>.</exception>
        /// <returns>Načtené číslo typu <see cref="int"/></returns>
        
        public static int NactiInt(string vyzva)
        {
            Console.Write(vyzva + ": ");
            return int.Parse(Console.ReadLine());
        }

        /// <summary>
        /// Vypíše zadaný text na obrazovku a doplní jej o dvojtečku a mezeru.
        /// Následně načte číslo typu double.<see cref="char"/>.
        /// </summary>
        /// <param name="vyzva">Text, který se vypisuje na obrazovku.</param>
        /// <returns>Načtené číslo typu <see cref="char"/></returns>
        public static char NactiChar(string vyzva)
        {
            Console.Write(vyzva + ": ");
            return char.Parse(Console.ReadLine());
        }

        public static string NactiString(string vyzva)
        {
            Console.Write(vyzva + ": ");
            return (Console.ReadLine());
        }
    }
}
