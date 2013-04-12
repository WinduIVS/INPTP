using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fei.BaseLib
{
    /// <summary>
    /// Struktura dvou celých čísel typu <see cref="int"/>.
    /// </summary>
    public struct DvojiceInt
    {
        int x, y;

        public DvojiceInt(int x, int y)
        {
            this.x = x;
            this.y = y;

        }

        /// <summary>
        /// Vrací první hodnotu
        /// </summary>
        /// <returns>Vrací první hodnotu</returns>
        public int DejX()
        {
            return x;
        }

        /// <summary>
        /// Vrací druhou hodnotu
        /// </summary>
        /// <returns>Vrací druhou hodnotu</returns>

        public int DejY()
        {
            return y;
        }
    }
}
