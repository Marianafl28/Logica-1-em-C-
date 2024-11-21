using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeTeams1
{
    internal class _10
    {
        public static void Main(string[] args)

        {
            Console.WriteLine("Digite um número inteiro não negativo para calcular o fatorial:");
            int numero = Convert.ToInt32(Console.ReadLine());

            if (numero < 0)
            {
                Console.WriteLine("Não é possível calcular o fatorial de números negativos.");
                return;
            }

            int fatorial = 1;

            for (int i = 1; i <= numero; i++)
            {
                switch (i)
                {
                    case 1:
                        fatorial *= 1;
                        break;

                    case 2:
                        fatorial *= 2;
                        break;

                    case 3:
                        fatorial *= 3;
                        break;

                    case 4:
                        fatorial *= 4;
                        break;

                    case 5:
                        fatorial *= 5;
                        break;

                    
                    default:
                        fatorial *= i;
                        break;
                }
            }

            Console.WriteLine("O fatorial de " + numero + " é: " + fatorial);
        }
    }
}