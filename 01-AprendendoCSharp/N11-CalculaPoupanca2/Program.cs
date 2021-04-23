using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N11_CalculaPoupanca2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 11 - Calcula poupança 2");

            double valorInvestido = 1000;
            for (int contadorMes = 1; contadorMes <= 12; contadorMes++)
            {
                valorInvestido *= 1.0036;
                Console.WriteLine("Após " + contadorMes + " mes(es), você terá R$" + valorInvestido);
            }         


            Console.WriteLine("A execuação terminou. Pressione enter. . .");
            Console.ReadLine();
        }
    }
}