namespace Ex_List_Dictionary.Ex_Colecao_Listas
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
            Console.WriteLine($"'{produto.Nome}' foi adicionado à lista!");
        }
        public void Listar()
        {
            Console.WriteLine("Listando produtos...");
            foreach (Produto produto in produtos)
            {
                Console.WriteLine(produto);
            }
        }
        public void BuscaInformacoesPeloNome(string nomeProduto)
        {
            Produto produto = PesquisaProduto(nomeProduto);
            string resultado = produto != null ? produto.ToString() : "Produto não encontrado!";

            Console.WriteLine($"Resultado da busca pelo produto '{nomeProduto}': {resultado}");
        }
        public void AtualizarPreco(string nomeProduto, double novoValor)
        {
            produtos.ForEach(p =>
            {
                if (p.Nome.ToUpper().Equals(nomeProduto.ToUpper()))
                {
                    p.Preco = novoValor;
                    Console.WriteLine($"O produto {nomeProduto} teve seu preço atualizado para R${novoValor}");
                }
            });
        }
        public void Remover(string nomeProduto)
        {
            Produto produto = PesquisaProduto(nomeProduto);
            if (produto != null)
            {
                produtos.Remove(produto);
                Console.WriteLine($"O produto '{nomeProduto}' foi removido da lista!");
            }
            else
                Console.WriteLine($"Produto '{nomeProduto}' não encontrado!");
        }
        private Produto PesquisaProduto(string nomeProduto)
        {
            return produtos.Find(p => p.Nome.ToUpper() == nomeProduto.ToUpper());
        }
    }
}
