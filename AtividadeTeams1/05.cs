using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeTeams1
{
    internal class _05
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite uma nota de 0 a 10");
            int nota = Convert.ToInt16(Console.ReadLine());
            switch (nota)
            {

                case >= 0 and <= 2:
                    Console.WriteLine("F");
                    break;

                case >= 3 and <= 4:
                    Console.WriteLine("D");
                    break;

                case >= 5 and <= 6:
                    Console.WriteLine("C");
                    break;

                case >= 7 and <= 8:
                    Console.WriteLine("B");
                    break;

                case >= 9 and <= 10:
                    Console.WriteLine("A");
                    break;
            }
        }
    }
}