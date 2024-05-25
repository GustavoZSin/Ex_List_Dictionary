namespace Ex_List_Dictionary.Ex_Colecao_Dicionarios
{
    public class Aluno
    {
        private int id;
        private string nome;
        private int idade;
        private Dictionary<int, Nota> notas;

        public Aluno(int id, string nome, int idade)
        {
            this.id = id;
            this.nome = nome;
            this.idade = idade;
            notas = new Dictionary<int, Nota>();
        }
        public Aluno()
        {
            id = 0;
            nome = string.Empty;
            idade = 0;
            notas = new Dictionary<int, Nota>();
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public int Idade
        {
            get { return idade; }
            set { idade = value; }
        }
        public Dictionary<int, Nota> Notas
        {
            get { return notas; }
        }

        public void AdicionarNota(Nota nota)
        {
            notas.Add(nota.Id, nota);
        }
        public void ListarNotas()
        {
            foreach (Nota nota in notas.Values)
            {
                Console.WriteLine("->" + nota);
            }
        }
        public void AtualizarNota(int idNota, int novoValor)
        {
            if (VerificaSeNotaExiste(idNota))
            {
                foreach (Nota nota in notas.Values)
                {
                    if (nota.Id == idNota)
                    {
                        nota.Valor = novoValor;
                        Console.WriteLine($"A nota de '{nota.Materia}' (ID:'{idNota}') foi atualizada para {novoValor}");
                    }
                }
            }
            else
                Console.WriteLine($"Nota de ID '{idNota}' não foi encontrada no cadastro do aluno '{nome}'!");
        }
        private bool VerificaSeNotaExiste(int idNota)
        {
            return notas.ContainsKey(idNota);
        }

        public override string ToString()
        {
            return $"[Id: {id}; Nome: {nome}; Idade: {idade}]";
        }
    }
}