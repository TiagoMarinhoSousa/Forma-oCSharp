using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N13_ForEncadeado
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 13 - For encadeado");

            //*
            //**
            //***
            //****
            //*****
            //******
            //*******

            //escrevendo asteriscos com o BREAK
            for (int contadorLinha = 0; contadorLinha < 10; contadorLinha++)
            {
                for (int contadorColuna = 0; contadorColuna < 10; contadorColuna++)
                {
                    Console.Write("*");
                    if (contadorColuna >= contadorLinha)
                    {
                        break;
                    }
                }

                Console.WriteLine();
            }

            //Uma forma diferente de fazer o desenho de asteriscos
            for (int contadorLinha = 0; contadorLinha < 10; contadorLinha++)
            {
                for (int contadorColuna = 0; contadorColuna <= contadorLinha; contadorColuna++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }


            int fatorial = 1;
            for (int i = 1; i < 11; i++)
            {
                fatorial *= i;
                Console.WriteLine("Fatorial de " + i + " = " + fatorial);
            }

            Console.WriteLine("A execuação terminou. Pressione enter. . .");
            Console.ReadLine();
        }
    }
}
