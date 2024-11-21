using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeTeams1
{
    internal class _09
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Qual a clasificação do filme que você esta assistindo: \r\n\r\n G  \r\n\r\n PG \r\n\r\n PG-13 \r\n\r\n R ");
            string classificacao = Console.ReadLine();
            switch (classificacao)
            {
                case "G":
                    Console.WriteLine("Classificação: Livre ");
                    break;

                case "PG":
                    Console.WriteLine("Classificação: Maior de 10 anos ");
                    break;

                case "PG-13":
                    Console.WriteLine("Classificação: Maior de 13 anos ");
                    break;

                case "R":
                    Console.WriteLine("Classificação: Maior de 18 anos ");
                    break;
            }
        }
    }
}
