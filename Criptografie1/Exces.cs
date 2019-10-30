using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Criptografie1
{
    class Exces
    {
        /// <summary>
        /// aduce pe val in intervalul 'A' - 'Z'
        /// </summary>
        /// <param name="val"></param>
        /// <returns></returns>
        public static int EliminaExces(int val)
        {
            val = val - 'A';
            if (val < 0)
                val += 26;
            else
                val = val % 26;

            return val + 'A';
        }

    }
}
