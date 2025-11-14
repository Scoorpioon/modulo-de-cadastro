using Fase5.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fase5.Services
{
    internal class FuncoesProduto
    {
        private int idAtual = 0;

        public Produto CriarProduto(string nome, int quantidadeEstoque, string categoria, string descricao)
        {
            Produto novoProduto = new Produto(
                idAtual++,
                nome,
                quantidadeEstoque,
                categoria,
                descricao
            );

            return novoProduto;
        }
    }
}