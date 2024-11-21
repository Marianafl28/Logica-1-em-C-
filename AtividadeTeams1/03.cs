using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeTeams1
{
    internal class _03
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Qual a sua idade? ");
            int idade = Convert.ToInt16(Console.ReadLine());
            switch(idade)
            {
                case >= 5 and <= 10:
                     Console.WriteLine("Criança");
                break;

                case >= 13 and <= 17:
                    Console.WriteLine("Adolecente");
                    break;

                case >= 18 and <= 59:
                    Console.WriteLine("Adulto");
                    break;

                case >= 60:
                    Console.WriteLine("Idoso");
                    break;
            }
        }
    }
}
