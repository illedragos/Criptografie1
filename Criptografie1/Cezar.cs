using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//de la 65 la 90 inclusiv
namespace Criptografie1
{
    class Cezar : Crypto
    {
        public override string Decriptare(string cript_text)
        {
            key = 3;
            StringBuilder solutie = new StringBuilder();

            for (int i = 0; i < cript_text.Length; i++)
            {
                int val = (int)(cript_text[i]);
                if (val != ' ')
                {
                    val = val - key;
                    val = Exces.EliminaExces(val);
                }
                solutie.Append((char)(val));
            }
            return (solutie+"");
        }

        public override string Encriptare(string clear_text)
        {
            key = 3;
            StringBuilder solutie = new StringBuilder();

            clear_text = clear_text.ToUpper();
            for (int i = 0; i < clear_text.Length; i++)
            {
                int val = (int)(clear_text[i]);
                if (Char.IsLetter(clear_text[i]))
                {
                    val = val + key;
                    val = Exces.EliminaExces(val);
                }
                solutie.Append((char)(val));
            }
            return solutie.ToString();
        }

    }
}
