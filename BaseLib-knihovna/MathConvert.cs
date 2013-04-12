using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fei.BaseLib
{
    /// <summary>
    /// Třída sloužící k převodu mezi různými číselnými soustavami.
    /// </summary>
    public class MathConvert
    {

        /// <summary>
        /// Převádí číslo z desítkové do dvojkové soustavy.
        /// </summary>
        /// <param name="val">číslo v desítkové soustavě</param>
        /// <returns>číslo v binární soustavě, pokud <paramref name="val"/> není menší než nula
        /// jinak vrací <c>null</c>.
        /// </returns>
        public static string ToBinary(int val)
        {
            if (val < 0) return null;

            StringBuilder sb = new StringBuilder();
            do
            {
                sb.Insert(0, val % 2);
                val /= 2;

            } while (val != 0);

            return sb.ToString();
        }
        /// <summary>
        /// Převádí číslo z binární soustavy do desítkové.
        /// </summary>
        /// <param name="val">číslo v bin. soustavě</param>
        /// <returns>odpovídající číslo v desítkové soustavě nebo -1, pokud nelze provést převod.</returns>
        public static int FromBinary(string val)
        {
            if (string.IsNullOrEmpty(val)) return -1;

            int cislo = 0, cislice;
            for (int i = 0; i < val.Length; i++)
            {
                if (val[i] != '0' && val[i] != '1') return -1;
                cislice = int.Parse(val[i].ToString());
                cislo += cislice * (int)Math.Pow(2, val.Length - i - 1);

            }
            return cislo;
        }

        public static string ToRoman(int val)
        {
            StringBuilder sb = new StringBuilder();
            int cislo = 0;
            bool desitky = true;
            for (int i = 1000; i >= 1; i = desitky ? i/2 : i/5, desitky = !desitky)
            {
                cislo = val / i;
                if (cislo > 0) sb.Append(ToRomanDigit(i), cislo);
                val %= i;
                if (val == 0) return sb.ToString();
                for (int j = 0; j <= 100 && j<i; j*=10)
                {
                    if (i - val <= j)
                    {
                        sb.Append(ToRomanDigit(j));
                        sb.Append(ToRomanDigit(i));
                        val %= j;

                    }
                    
                }
            }
            return sb.ToString();

        }
        public static int FromRoman(string val)
        {

            return 0;

        }
        private static int FromRomanDigit(char val)
        {
            switch (val)
            {
                case 'M': return 1000;
                case 'D': return 500;
                case 'C': return 100;
                case 'L': return 50;
                case 'X': return 10;
                case 'V': return 5;
                case 'I': return 1;
                default: return 0;
            }

        }

        private static char ToRomanDigit(int val)
        {
            switch (val)
            {
                case 1000: return 'M';
                case 500: return 'D';
                case 100: return 'C';
                case 50: return 'L';
                case 10: return 'X';
                case 5: return 'V';
                case 1: return 'I';
                default: return '0';
            }
        }

    }
}
