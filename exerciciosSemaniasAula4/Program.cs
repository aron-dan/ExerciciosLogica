using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerciciosSemaniasAula4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor da Hora inicial e final do jogo?");
            String[] valores = Console.ReadLine().Split(' ');

            int startHour, endHour, resultHour;

            startHour = int.Parse(valores[0]);
            endHour = int.Parse(valores[1]);

            if (startHour > endHour)
            {
                resultHour = (12 - startHour) + endHour;
                Console.WriteLine("O tempo total do jogo foi de " + resultHour + " horas");
                Console.ReadKey();
            }
            else
            {
                resultHour = endHour - startHour;

                Console.WriteLine("O tempo total do jogo foi de " + resultHour + " horas");

                Console.ReadKey();
            }

        }
    }
}
