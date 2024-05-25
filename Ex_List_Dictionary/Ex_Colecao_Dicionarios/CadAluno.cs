namespace Ex_List_Dictionary.Ex_Colecao_Dicionarios
{
    public class CadAluno
    {
        private int _ultimoIdAluno;
        private int _ultimoIdNota;
        private Dictionary<int, Aluno> alunos;

        public CadAluno()
        {
            _ultimoIdAluno = 0;
            _ultimoIdNota = 0;
            alunos = new Dictionary<int, Aluno>();
        }

        public void AdicionarAluno(string nome, int idade)
        {
            _ultimoIdAluno++;
            Aluno novoAluno = new Aluno(_ultimoIdAluno, nome, idade);
            alunos.Add(_ultimoIdAluno, novoAluno);
            Console.WriteLine($"'{nome}' foi adicionado ao dicionário!");
        }
        public void AdicionarNota(int idAluno, string materia, int valor)
        {
            if (!alunos.ContainsKey(idAluno))
            {
                Console.WriteLine($"Aluno com id '{idAluno}' não encontrado!");
                return;
            }

            _ultimoIdNota++;
            Nota novaNota = new Nota(_ultimoIdNota, materia, valor);
            alunos[idAluno].AdicionarNota(novaNota);
            Console.WriteLine($"Nota de '{materia}' adicionada à lista de notas do aluno '{alunos[idAluno].Nome}'!");
        }
        public void ListarAlunos()
        {
            Console.WriteLine("Alunos cadastrados:");
            foreach (Aluno aluno in alunos.Values)
            {
                Console.WriteLine("  ->" + aluno.Nome);
            }
        }
        public void BuscaInformacoesPeloId(int idAluno)
        {
            Aluno aluno = PesquisaAluno(idAluno);

            if (aluno != null)
            {
                Console.WriteLine(aluno);
                Console.WriteLine("Notas:");
                aluno.ListarNotas();
            }
            else
                Console.WriteLine($"Aluno com id {idAluno} não encontrado!");
        }
        public void AtualizarNota(int idAluno, int idNota = 0, int novaNota = 0)
        {
            Aluno aluno = PesquisaAluno(idAluno);

            aluno.AtualizarNota(idNota, novaNota);
        }
        public void Remover(int idAluno)
        {
            Aluno aluno = PesquisaAluno(idAluno);

            if (aluno != null)
            {
                alunos.Remove(aluno.Id);
                Console.WriteLine($"O aluno '{aluno.Nome}' foi removido da lista!");
            }
            else
                Console.WriteLine($"Id de aluno ('{idAluno}') não encontrado!");
        }

        private Aluno PesquisaAluno(int idAluno)
        {
            Aluno aluno = alunos.TryGetValue(idAluno, out aluno) ? aluno : null;
            return aluno;
        }
    }
}
