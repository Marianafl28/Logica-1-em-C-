using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeTeams1
{
    internal class _08
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Diga a temperatura: ");
            int temperatura = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Diga se você quer converter de \r\n\r\n (1) Celsius para Fahrenheit ou (2) \r\n\r\nFahrenheit para Celsius  ");
            int tipo = Convert.ToInt16(Console.ReadLine());

            switch (tipo)
            {
                case 1:
                    double fahrenheit = (1.8 * temperatura) + 32;
                    Console.WriteLine("A temperatura em Fahrenheit é de: " + fahrenheit);
                    break;

                case 2:
                    double celsius = (temperatura - 32) / 1.8;
                    Console.WriteLine("A temperatura em celsius é de: " + celsius);
                    break;
            }
        }
    }
}
