using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {

            //o valor atribuido no objeto se sobrepõe ao da classe
            ContaCorrente conta = new ContaCorrente();
            //na classe o saldo está 100, se não atribuir valor esse será o valor default
            conta.saldo = 200;

            Console.WriteLine(conta.saldo);

            Console.ReadLine();
        }
    }
}
