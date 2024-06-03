using Ex_List_Dictionary.Ex_Colecao_Dicionarios;
using Ex_List_Dictionary.Ex_Colecao_Dicionarios_Listas;
using Ex_List_Dictionary.Ex_Colecao_Listas;

namespace Ex_List_Dictionary
{
    public class ExecutorDeExercicios
    {
        public void ExColecaoDeListas()
        {
            Separador();
            Console.WriteLine("Exercício de Listas:");
            CadProdutos cadProdutos = new CadProdutos();

            Produto tv = new Produto("TV", 900.00, 10);
            Produto videogame = new Produto("Video Game", 1300.00, 5);
            Produto notebook = new Produto("Notebook", 1200.00, 20);

            Console.WriteLine("Adicionando produtos à lista...");
            cadProdutos.Adicionar(tv);
            cadProdutos.Adicionar(videogame);
            cadProdutos.Adicionar(notebook);

            Console.WriteLine();
            cadProdutos.BuscaInformacoesPeloNome("TV");
            cadProdutos.BuscaInformacoesPeloNome("Smartphone");

            Console.WriteLine();
            cadProdutos.AtualizarPreco("TV", 1000.00);

            Console.WriteLine();
            cadProdutos.Remover("Smartphone");
            cadProdutos.Remover("TV");

            Console.WriteLine();
            cadProdutos.Listar();
            Separador();
        }
        public void ExColecaoDeDicionarios()
        {
            Separador();
            Console.WriteLine("Exercício de Dicionários:");
            CadAluno cadAlunos = new CadAluno();

            Console.WriteLine("\nAdicionando alunos ao dicionário...");
            cadAlunos.AdicionarAluno("Gustavo", 22);
            cadAlunos.AdicionarAluno("Igor", 23);
            cadAlunos.AdicionarAluno("Victor", 26);

            Console.WriteLine("\nAdicionando notas...");
            cadAlunos.AdicionarNota(1, "Matemática", 10);
            cadAlunos.AdicionarNota(1, "Português", 9);
            cadAlunos.AdicionarNota(2, "Matemática", 8);
            cadAlunos.AdicionarNota(2, "Português", 7);
            cadAlunos.AdicionarNota(3, "Matemática", 6);
            cadAlunos.AdicionarNota(3, "Português", 5);
            cadAlunos.AdicionarNota(4, "Português", 5);

            Console.WriteLine();
            cadAlunos.ListarAlunos();

            Console.WriteLine("\nBusca de Informações...");
            cadAlunos.BuscaInformacoesPeloId(1);
            cadAlunos.BuscaInformacoesPeloId(15);

            Console.WriteLine("\nAtualização de notas...");
            cadAlunos.AtualizarNota(1, 10, 8);
            cadAlunos.AtualizarNota(1, 1, 2);
            cadAlunos.BuscaInformacoesPeloId(1);

            Console.WriteLine("\nRemoção de alunos...");
            cadAlunos.Remover(3);
            cadAlunos.Remover(15);

            Console.WriteLine();
            cadAlunos.ListarAlunos();
            Separador();
        }
        public void ExColecaoDeListasEDicionarios()
        {
            Separador();
            Console.WriteLine("Exercício de Dicionários e Listas:");
            CadPedido cadPedido = new CadPedido();

            Console.WriteLine("\nAdicionando pedidos...");

            Cliente gustavo = new Cliente("Gustavo", "Rua 1", "(54) 99999-9999");
            List<Item> itensGustavo = new List<Item>
            {
                new Item("TV", 900.00, 1),
                new Item("Notebook", 1200.00, 2)
            };

            cadPedido.Adicionar(gustavo, itensGustavo);

            Console.WriteLine();
            cadPedido.Listar();

            Console.WriteLine("\nBusca de informações...");
            cadPedido.PesquisarPeloId(1);
            cadPedido.PesquisarPeloId(15);

            Console.WriteLine("\nAtualização de pedidos...");
            cadPedido.TrocarCliente(1, new Cliente("Igor", "Rua 2", "(54) 99999-9998"));
            cadPedido.TrocarTodosOsItens(1, new List<Item>
            {
                new Item("Smartphone", 1500.00, 1),
                new Item("Tablet", 800.00, 1)
            });

            cadPedido.InserirItemNoPedido(1, new Item("Fone de Ouvido", 50.00, 2));
            cadPedido.InserirItemNoPedido(1, new Item("Carregador", 30.00, 1));
            cadPedido.RemoverItemDoPedido(1, "TV");
            cadPedido.RemoverItemDoPedido(1, "Carregador");

            Console.WriteLine("\nRemoção de pedidos...");
            cadPedido.ExcluirPedido(1);
            cadPedido.ExcluirPedido(15);

            Console.WriteLine();
            cadPedido.Listar();
            Separador();
        }
        private void Separador() => Console.WriteLine("\n----------------------------------------\n");
    }
}