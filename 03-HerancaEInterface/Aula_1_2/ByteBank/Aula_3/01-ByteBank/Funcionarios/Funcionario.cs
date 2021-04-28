using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public abstract class Funcionario
    {
        public static int TotalDeFuncionarios { get; set; }

        public string Nome { get; set; }
        public string CPF { get; private set; }
        public double Salario { get; protected set; }

        //construtor
        public Funcionario(double salario, string cpf)
        {
            Console.WriteLine("Criando um FUNCIONÁRIO");
            TotalDeFuncionarios++;
            CPF = cpf;
            Salario = salario;
        }
        //sobrecarga de constrututor
        public Funcionario(string cpf) : this(1500, cpf)
        {
            //salario base, 1500 quando não for sobrescrita pela classe derivada
        }

        //public virtual double GetBonificacao()
        //{
        //    return Salario * 0.10;
        //}

        //public virtual void AumentarSalario()
        //{
        //    //Salario = Salario + (Salario * 0.1);
        //    //Salario = Salario * 1.1;
        //    Salario *= 1.1;
        //}

        //métodos abstratos
        public abstract void AumentarSalario();

        public abstract double GetBonificacao();
    }
}