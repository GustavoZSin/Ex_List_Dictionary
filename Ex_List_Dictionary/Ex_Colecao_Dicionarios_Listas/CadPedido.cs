namespace Ex_List_Dictionary.Ex_Colecao_Dicionarios_Listas
{
    public class CadPedido
    {
        private int _ultimoId;
        private Dictionary<int, Pedido> _pedidos;
        public CadPedido()
        {
            _ultimoId = 0;
            _pedidos = new Dictionary<int, Pedido>();
        }

        public void Adicionar(Cliente cliente, List<Item> itens)
        {
            _ultimoId++;
            Pedido novoPedido = new Pedido(_ultimoId, cliente, itens);
            _pedidos.Add(_ultimoId, novoPedido);
        }
        public void Listar()
        {
            if (_pedidos.Count == 0)
            {
                Console.WriteLine("Nenhum pedido cadastrado!");
                return;
            }

            foreach (Pedido pedido in _pedidos.Values)
            {
                Console.WriteLine(pedido);
            }
        }
        public void PesquisarPeloId(int idPedido)
        {
            if (PedidoExiste(idPedido))
            {
                Console.WriteLine(_pedidos[idPedido]);
            }
            else
                Console.WriteLine($"Pedido com id {idPedido} não encontrado!");
        }
        public void TrocarCliente(int idPedido, Cliente novoCliente)
        {
            if (PedidoExiste(idPedido))
            {
                if (novoCliente != null)
                {
                    _pedidos[idPedido].Cliente = novoCliente;
                    Console.WriteLine($"Pedido '{idPedido}' foi alterado para o cliente {novoCliente.Nome}!");
                }
            }
            else
                Console.WriteLine($"Pedido com id {idPedido} não encontrado!");
        }
        public void TrocarTodosOsItens(int idPedido, List<Item> novosItens)
        {
            if (PedidoExiste(idPedido))
            {
                if (novosItens != null)
                {
                    _pedidos[idPedido].Itens = novosItens;
                    Console.WriteLine($"Pedido '{idPedido}' teve todos os seus itens atualizados!");
                }
            }
            else
                Console.WriteLine($"Pedido com id {idPedido} não encontrado!");
        }
        public void InserirItemNoPedido(int idPedido, Item item)
        {
            if (PedidoExiste(idPedido))
            {
                _pedidos[idPedido].Itens.Add(item);
                Console.WriteLine($"Item '{item.Nome}' adicionado ao pedido '{idPedido}'!");
            }
            else
                Console.WriteLine($"Pedido com id {idPedido} não encontrado!");
        }
        public void RemoverItemDoPedido(int idPedido, string nomeItem)
        {
            if (PedidoExiste(idPedido))
            {
                Item item = _pedidos[idPedido].Itens.Find(i => i.Nome.ToUpper().Equals(nomeItem.ToUpper()));
                if (item != null)
                {
                    _pedidos[idPedido].Itens.Remove(item);
                    Console.WriteLine($"Item '{nomeItem}' removido do pedido '{idPedido}'!");
                }
                else
                    Console.WriteLine($"Item '{nomeItem}' não encontrado no pedido '{idPedido}'!");
            }
            else
                Console.WriteLine($"Pedido com id {idPedido} não encontrado!");
        }
        public void ExcluirPedido(int idPedido)
        {
            if (PedidoExiste(idPedido))
            {
                _pedidos.Remove(idPedido);
                Console.WriteLine($"Pedido '{idPedido}' removido!");
            }
            else
                Console.WriteLine($"Pedido com id {idPedido} não encontrado!");
        }
        private bool PedidoExiste(int idPedido)
        {
            return _pedidos.ContainsKey(idPedido);
        }
    }
}