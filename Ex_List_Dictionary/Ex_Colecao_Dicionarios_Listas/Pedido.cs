namespace Ex_List_Dictionary.Ex_Colecao_Dicionarios_Listas
{
    public class Pedido
    {
        private int id;
        private List<Item> itens;
        private Cliente cliente;

        public Pedido(int id, Cliente cliente, List<Item> itens)
        {
            this.id = id;
            this.cliente = cliente;
            this.itens = itens;
        }
        public Pedido(int id, Cliente cliente)
        {
            this.id = id;
            this.cliente = cliente;
            itens = new List<Item>();
        }
        public Pedido()
        {
            id = 0;
            cliente = new Cliente();
            itens = new List<Item>();
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public List<Item> Itens
        {
            get { return itens; }
            set { itens = value; }
        }
        public Cliente Cliente
        {
            get { return cliente; }
            set { cliente = value; }
        }

        public override string ToString()
        {
            string itensDetalhes = string.Join(", ", itens);
            return $"[Id: {id}; Cliente: {cliente}; Items: \n ->[{itensDetalhes}]]";
        }
    }
}
