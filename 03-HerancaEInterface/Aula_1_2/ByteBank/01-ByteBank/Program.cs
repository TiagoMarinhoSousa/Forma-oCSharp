using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            Funcionario carlos = new Funcionario(2000.00, "546.879.157-20");
            carlos.Nome = "Carlos";
            //carlos.CPF = "546.879.157-20";
            //carlos.Salario = 2000;
                   

            gerenciador.Registrar(carlos);

            Console.WriteLine("Total de funcionários é: " + Funcionario.TotalDeFuncionarios);

            Console.WriteLine("Nome: " + carlos.Nome);
            Console.WriteLine("O salário de Carlos é: R$ " + carlos.Salario);
            Console.WriteLine("A bonificação de Carlos é: R$ " + carlos.GetBonificacao());
            carlos.AumentarSalario();
            Console.WriteLine("Após aumento, novo salário de Carlos é: R$ " + carlos.Salario);
            Console.WriteLine();

            Diretor roberta = new Diretor(5000.00, "454.658.148-3");
            roberta.Nome = "Roberta";
            //roberta.CPF = "454.658.148-3";
            //roberta.Salario = 5000;

            gerenciador.Registrar(roberta);
            Console.WriteLine("Total de funcionários é: " + Funcionario.TotalDeFuncionarios);

            Console.WriteLine("Nome: " + roberta.Nome);
            Console.WriteLine("O salário de Roberta é: R$ " + roberta.Salario);
            Console.WriteLine("A bonificação de Roberta é: R$ " + roberta.GetBonificacao());
            
            roberta.AumentarSalario();
            Console.WriteLine("Após aumento, novo salário de Roberta é: R$ " + roberta.Salario);
            Console.WriteLine();


            Console.WriteLine("Total de bonificações: R$ " + gerenciador.GetTotalBonificacao());
            Console.WriteLine();

            Funcionario robertaTeste = roberta;

            Console.WriteLine("Bonificação de uma referência de Diretor: R$ " + roberta.GetBonificacao());
            Console.WriteLine("Bonificação de uma referência de Funcionário: R$ " + robertaTeste.GetBonificacao());

            

            Console.ReadLine();
        }
    }
}