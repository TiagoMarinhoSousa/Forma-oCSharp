using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Bytebank
{
    public class Cliente
    {
        private string _cpf;
        //atributos com métodos geters e seters
        //utilizado o prop para otimizar o trabalho
        public string Nome { get; set; }
        public string CPF
        {
            get
            {
                return _cpf;
            }
            set
            {
                //coloco minha lógica de validação de CPF
                _cpf = value;
            }
        }
        public string Profissao { get; set; }



        //public string nome;
        //public string cpf;
        //public string profissao;
    }
}
