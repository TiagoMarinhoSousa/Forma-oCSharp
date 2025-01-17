﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N12_CalculaInvestimentoLongoPrazo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 12 - Calcula investimento longo prazo");

            double fatorRendimento = 1.0036;
            double valorInvestido = 1000;


            for (int contadorAno = 1; contadorAno <= 5; contadorAno++)
            {
                for (int contadorMes = 1; contadorMes <= 12; contadorMes++)
                {
                    valorInvestido *= fatorRendimento;
                    
                }

                fatorRendimento += 0.0010;
            }
            Console.WriteLine("Ao término do investimento, você terá R$ " + valorInvestido);

            Console.WriteLine("A execuação terminou. Pressione enter. . .");
            Console.ReadLine();
        }
    }
}
