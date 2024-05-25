namespace Ex_List_Dictionary.Ex_Colecao_Dicionarios_Listas
{
    public class Item
    {
        private string nome;
        private double preco;
        private int quantidade;
        public Item(string nome, double preco, int quantidade)
        {
            this.nome = nome;
            this.preco = preco;
            this.quantidade = quantidade;
        }
        public Item()
        {
            nome = string.Empty;
            preco = 0.0;
            quantidade = 0;
        }
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public double Preco
        {
            get { return preco; }
            set { preco = value; }
        }
        public int Quantidade
        {
            get { return quantidade; }
            set { quantidade = value; }
        }
        public override string ToString()
        {
            return $"[Nome: {nome}; Preço: R${preco}; Quantidade: {quantidade}]";
        }
    }
}
