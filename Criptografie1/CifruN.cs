using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Criptografie1
{
    class CifruN : Crypto
    {
        public override string Decriptare(string cript_text)
        {
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\Dragos\source\repos\Criptografie1\Criptografie1\20k.txt");
            string[] words = cript_text.Split(' ');
            StringBuilder solutie = new StringBuilder();         
            key = 0;
            for (int j=1; j<=26;j++)
            {  
                key++;
                Console.WriteLine(key);
                for (int i = 0; i < words.Length; i++)
                {
                    solutie.Clear();
                    for (int p = 0; p < words[i].Length; p++)
                    {
                        int valoare= (int)(words[i][p]);
                        valoare = valoare - 1;
                        valoare = Exces.EliminaExces(valoare);
                        solutie.Append((char)(valoare));
                    }
                    Console.WriteLine(solutie);
                    words[i] = solutie + "";
                }
                Console.WriteLine();
               
                if(words.All(s => lines.Contains(s, StringComparer.OrdinalIgnoreCase)))
                {
                    Console.WriteLine("Cheia este:: "+key);
                    StringBuilder decript = new StringBuilder();
                    foreach (var w in words)
                    {
                        decript.Append(w);
                        decript.Append(" ");
                    }
                    return decript + "";
                }
                   
            }
 
            return "eroare nu avem solutie";

        }

        public override string Encriptare(string clear_text)
        {
            throw new NotImplementedException();
        }
    }
}
