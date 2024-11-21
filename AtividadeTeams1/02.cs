using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeTeams1
{
    internal class _02
    {
        public static void Main(string[] args)

        {

            Console.WriteLine("Escreva um numero");
            int numero = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("escreva um outro numero");
            int numero2 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Agora escolha um operador ( +, -, *, /)");
            string operadores = Console.ReadLine();

            switch (operadores) {
                case "+":
                    Console.WriteLine(numero + numero2 );
                break;

                case "-":
                    Console.WriteLine(numero - numero2);
                    break;

                case "*":
                    Console.WriteLine(numero * numero2);
                    break;

                case "/":
                    Console.WriteLine(numero / numero2);
                    break;
            }
           
        }
    }
}




