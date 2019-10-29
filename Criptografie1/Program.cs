using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Criptografie1
{
    class Program
    {
        static void Main(string[] args)
        {
            Cezar cezar = new Cezar();
            CifruN cifrun = new CifruN();
            SubstitutieMonoAlfabetica substitutieMonoAlfabetica = new SubstitutieMonoAlfabetica();
            Console.WriteLine(cezar.Encriptare("IMPOSSIBLE IS NOTHING"));
            Console.WriteLine(cezar.Decriptare("LPSRVVLEOH LV QRWKLQJ"));

            Console.WriteLine(cifrun.Decriptare("LPSRVVLEOH LV QRWKLQJ"));
            Console.WriteLine(cifrun.Decriptare("JAJW YWNJI JAJW KFNQJI ST RFYYJW YWD FLFNS KFNQ FLFNS KFNQ GJYYJW"));
            Console.WriteLine("===============================");

            Console.WriteLine(substitutieMonoAlfabetica.Encriptare("ABCD EFGHI JKL"));
            
             string text = File.ReadAllText(@"C:\Users\Dragos\source\repos\Criptografie1\Criptografie1\text.txt");
            // Console.WriteLine(substitutieMonoAlfabetica.Decriptare(text));

        }
    }
}
