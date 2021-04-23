using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpcionalIf
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario = 3300.0;

            if (salario >= 1900.0 && salario <= 2800.0)
            {
                Console.WriteLine("Alíquota 7.5%");
                Console.WriteLine("Pode deduzir R$142,00");
            }
            else if (salario > 2800.0 && salario <= 3751.0)
            {
                Console.WriteLine("Alíquota 15%");
                Console.WriteLine("Pode deduzir R$350,00");
            }
            else if (salario > 3751.0 && salario <= 4664.0)
            {
                Console.WriteLine("Alíquota 22.5%");
                Console.WriteLine("Pode deduzir R$636,00");
            }



            Console.WriteLine("A execução terminou. Pressione enter. . .");
            Console.ReadLine();
        }
    }
}
