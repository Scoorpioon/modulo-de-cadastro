using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fase5.Classes
{
    internal class Produto
    {
        private string idProduto;
        private string nomeProduto;
        private int quantidadeEstoque;
        private string categoria;
        private string descricao;

        public string NomeProduto { get; set; }
        public int QuantidadeEstoque { get; set; }
        public string Categoria { get; set; }
        public string Descricao { get; set; }
    }
}