using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_List_Dictionary
{
    public class CadProdutos
    {
        private List<Produto> produtos;
        public CadProdutos()
        {
            produtos = new List<Produto>();
        }
        public void Adicionar(Produto produto)
        {
            produtos.Add(produto);
        }

        public void Listar()
        {
            foreach(Produto produto in produtos)
            {
                Console.WriteLine(produto);
            }
        }

        public string Pesquisar(string nomeProduto)
        {
            Produto produto = produtos.Find(p => p.Nome == nomeProduto);

            return produto != null ? produto.ToString() : "Produto não encontrado!";
        }

        public void AtualizarPreco(string nomeProduto, double novoValor)
        {
            produtos.ForEach(p =>
            {
                if (p.Nome.Equals(nomeProduto))
                {
                    p.Preco = novoValor;
                }
            });
        }

        public void Remover(string nomeProduto)
        {
            produtos.Remove(produtos.Find(p => p.Nome.Equals(nomeProduto)));
        }
    }
}
