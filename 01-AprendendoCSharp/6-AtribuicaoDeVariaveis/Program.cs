﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_AtribuicaoDeVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 6 - Atribuição de variáveis");

            int idade = 32;
            int idadeGustavo = idade;

            idade = 20;

            Console.WriteLine(idade);
            Console.WriteLine(idadeGustavo);

            Console.WriteLine("A execução acabou. Tecle enter para sair. . .");
            Console.ReadLine();
        }
    }
}
