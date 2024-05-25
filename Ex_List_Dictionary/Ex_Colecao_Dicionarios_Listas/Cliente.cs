namespace Ex_List_Dictionary.Ex_Colecao_Dicionarios_Listas
{
    public class Cliente
    {
        private string nome;
        private string endereco;
        private string telefone;
        public Cliente(string nome, string endereco, string telefone)
        {
            this.nome = nome;
            this.endereco = endereco;
            this.telefone = telefone;
        }
        public Cliente()
        {
            nome = string.Empty;
            endereco = string.Empty;
            telefone = string.Empty;
        }
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public string Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }
        public string Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }
        public override string ToString()
        {
            return $"[Nome: {nome}; Endereço: {endereco}; Telefone: {telefone}]";
        }
    }
}
