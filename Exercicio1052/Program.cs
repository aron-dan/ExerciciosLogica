using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1052
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercicio1052();
        }

        public static void Exercicio1052()
        {
            int number;

            number = int.Parse(Console.ReadLine());

            string[] mouths = new string[] { "empt", "january", "february", "march", "april", "may",
                "june", "july", "august", "september", "october", "november", "december"};

            Console.WriteLine(mouths[number]);

            Console.ReadKey();
            
        }
    }
}
