using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Criptografie1
{
    class Exces
    {
        public static int EliminaExces(int val)
        {
            if (val > 90)
            {
                val = val % 90;
                val = 65 + val - 1;
            }
            else if (val< 65)
            {
                val = 65 % val;
                val = 90 + val - 1;
            }
            return val;
        }

    }
}
