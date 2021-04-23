using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_ConversoesEOutrosTiposNumericos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 4 - Conversoes e outros tipos numéricos");

            double salario;
            salario = 1200.50;

            // o long é variavel de 32 bits
            int salarioEmInteiro = (int)salario;
            Console.WriteLine(salarioEmInteiro);
           

            // o long é variavel de 64 bits
            long idade = 1300000000000;
            Console.WriteLine(idade);


            // o long é variavel de 16 bits
            short quantidadeProdutos = 15000;
            Console.WriteLine(quantidadeProdutos);


            float altura = 1.80f;
            Console.WriteLine(altura);



            Console.WriteLine("A execução acabou. Tecle enter para sair. . .");
            Console.ReadLine();
        }
    }
}
