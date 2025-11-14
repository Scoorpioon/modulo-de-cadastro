using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fase5.Classes
{
    internal class Cliente
    {
        private int idCliente;
        private string nome;
        private string endereco;
        private string cpf;

        public Cliente(int idCliente, string nome, string endereco,  string cpf)
        {
            this.idCliente = idCliente;
            this.nome = nome;
            this.endereco = endereco;
            this.cpf = cpf;
        }

        public string Nome {  get { return nome; } }
        public string Endereco { get { return endereco; } }
        public string Cpf { get { return cpf; } }
    }
}