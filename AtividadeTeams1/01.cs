using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeTeams1
{
    internal class _01
    {
        public static void Main(string[] args)

        {

            Console.WriteLine("Digite um valor");
            int numero = Convert.ToInt16(Console.ReadLine());
            switch (numero)
            {
                case 1:
                    Console.WriteLine("Domingo");
                    break;


                case 2:
                    Console.WriteLine("Segunda");
                    break;

                case 3:
                    Console.WriteLine("Terça");
                    break;

                case 4:
                    Console.WriteLine("Quarta");
                    break;

                case 5:
                    Console.WriteLine("Quinta");
                    break;

                case 6:
                    Console.WriteLine("Sexta");
                    break;

                case 7:
                    Console.WriteLine("Sábado");
                    break;
                default:
                    Console.WriteLine("Não há dia correspondente");
                    break;

            }
        }
    }
}
