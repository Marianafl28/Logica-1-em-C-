using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeTeams1
{
    internal class _04
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Escolha entre uma das opções:  " +
                "Exibir (1) \" Olá, Mundo!\" \r\n\r\nExibir (2)  \" Bem-vindo ao C#\" \r\n\r\n (3) Sair do programa ");
            string tela = Console.ReadLine();
            switch (tela)
            {

                case "1":
                    Console.WriteLine("Ola mundo");
                    break;

                case "2":
                    Console.WriteLine("Bem-vindo ao C#");

                    break;

                case "3":
                    Console.WriteLine("Saindo do programa...");
                    break;

            }
        }
    }
}
