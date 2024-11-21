using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeTeams1
{
    internal class _06
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Escolha uma bebida entre: \r\n\r\n  (1) Café \r\n\r\n (2) Chá  \r\n\r\n e (3) Àgua");
            string cafeteria = Console.ReadLine();
            switch (cafeteria)
            {
                case "1":
                    Console.WriteLine("Seu cafézinho está sendo preparado");
                    break;

                case "2":
                    Console.WriteLine("Seu cházinho está a caminho");
                    break;

                case "3":
                    Console.WriteLine("Sua água faz bem pros rins, muito bem!!");
                    break;
            }
        }
    }
}
