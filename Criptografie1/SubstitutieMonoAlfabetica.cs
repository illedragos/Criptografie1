using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Criptografie1
{
    class SubstitutieMonoAlfabetica : Crypto
    {
        public override string Decriptare(string cript_text)
        {
            char [] ascii_frecventa = { 'E', 'T', 'A', 'O', 'I', 'N', 'S', 'R', 'H', 'L', 'D', 'C', 'U', 'M', 'F', 'P', 'G', 'W', 'Y', 'B', 'V', 'K', 'X', 'J', 'Q', 'Z'};
            Dictionary<char, int> Perechi = new Dictionary<char, int>();
            for(int i=1;i<=26;i++)
                Perechi.Add((char)(64 + i), 0);

            //foreach (KeyValuePair<char, Int32> pereche in Perechi.OrderBy(key => key.Value))
            //{
            //    Console.WriteLine("Key: {0}, Value: {1}", pereche.Key, pereche.Value);
            //}
            //Console.WriteLine("=============");
            for (int i = 0; i < cript_text.Length; i++)
            {
                char litera = cript_text[i];
                if (litera != ' ' && litera != ',' && litera != ':' && litera != '?' && litera != '/' && litera != '\\' && litera != '/')
                    foreach (char key in Perechi.Keys.ToList())
                    {
                        if (key == litera)
                            Perechi[key] += 1;
                    }
            }

            foreach (KeyValuePair<char, Int32> pereche in Perechi.OrderByDescending(key => key.Value))
            {
                Console.WriteLine("Key: {0}, Value: {1}", pereche.Key, pereche.Value);
            }
            Console.WriteLine("=============");

            StringBuilder str = new StringBuilder();
            //for (int i = 0; i < cript_text.Length; i++)
            //{
            //    int j = 0;
            //    foreach (char key in Perechi.Keys)
            //    {
            //        if (key == cript_text[i])
            //            str.Append(ascii_frecventa[j]);
            //        j++;
            //    }
            //}

                return str+"eroare";
        }

        public override string Encriptare(string clear_text)
        {
            int[] aleator = new int[26]; //vectorul aleator
            int[] asci = new int[26]; // vectorul fix cu valorile ascii crescatoare
            int aval = 65;

            for (int i = 0; i < 26; i++)
            {
                aleator[i] = aval;
                asci[i] = aval;
                aval++;
            }

            Random rand = new Random();
            //amestecam vectorul aleator
            for (int i = 0; i < aleator.Length - 1; i++)
            {
                int j = rand.Next(i, aleator.Length);
                int temp = aleator[i];
                aleator[i] = aleator[j];
                aleator[j] = temp;
            }

            //tiparesc vectorul aleator care este cheia de ENCRIPTARE
            for( int i=0;i<aleator.Length;i++)
                Console.Write((char)(aleator[i])+" ");
            Console.WriteLine();

            StringBuilder str = new StringBuilder();
            for(int i=0;i<clear_text.Length;i++)
            {
                int asci_cifra = (int)(clear_text[i]);
                if (asci_cifra == 32)
                    str.Append(" ");
                else
                {
                    for(int j=0;j<asci.Length;j++)
                        if(asci_cifra==asci[j])
                        {
                            str.Append((char)(aleator[j]));
                        }
                }
            }
            return str + "";     
        }  
    }
}
