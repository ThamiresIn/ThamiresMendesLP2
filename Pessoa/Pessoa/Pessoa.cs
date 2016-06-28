using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pessoa
{
    class Pessoa
    {
        public string nome { get; set; }
        public string sobrenome { get; set; }
        public string cpf { get; set; }
        public string telefone { get; set; }
        public DateTime dataNascimento { get; set; }

        public Pessoa() { }
        public Pessoa( string nome , string sobrenome)
        {
            this.nome = nome;
            this.sobrenome = sobrenome;
        }
        public Pessoa (string cpf)
        {
            this.cpf = cpf;
        }

    }
}
