using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeTeams1
{
    internal class _07
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Qual seu salario? ");
            int salario = Convert.ToInt16(Console.ReadLine());

            int imposto;

            if (salario <= 1500)
                imposto = 5;
            else if (salario <= 3000)
                imposto = 10;
            else
                imposto = 15;

           double ValorFinal = 0;

            switch (imposto)
            {
                case 5:
                    ValorFinal = salario + (salario * 0.05);
                    Console.WriteLine("O seu novo salario é de: " + ValorFinal);
                    break;

                case 10:
                    ValorFinal = salario + (salario * 0.10);
                    Console.WriteLine("O seu novo salario é de: " + ValorFinal);
                    break;

                case 15:
                    ValorFinal = salario + (salario * 0.15);
                    Console.WriteLine("O seu novo salario é de: " + ValorFinal);
                    break;

            }
        }
    }
}
