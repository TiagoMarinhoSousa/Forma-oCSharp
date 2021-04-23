using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_CaracteresETexto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 5 - Caracteres e textos");

            //character
            char primeiraLetra = 'a';
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)65;
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)(primeiraLetra + 1);
            Console.WriteLine(primeiraLetra);

            string titulo = "Alura Cursos de Tecnologia " + 2020;
            Console.WriteLine(titulo);

            string vazia = "";
            Console.WriteLine(vazia);

            string cursosProgramacao = 
@" - .NET
 - Java 
 - Javascript";
            Console.WriteLine(cursosProgramacao);

            Console.WriteLine("A execução terminou. Pressione enter para continuar. . .");
            Console.ReadLine();
        }
    }
}
