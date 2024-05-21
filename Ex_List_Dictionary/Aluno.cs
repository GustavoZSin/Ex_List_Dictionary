using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_List_Dictionary
{
    public class Aluno
    {
        private int id;
        private string nome;
        private int idade;
        List<Nota> notas;
        public Aluno(int id, string nome, int idade)
        {
            this.id = id;
            this.nome = nome;
            this.idade = idade;
            notas = new List<Nota>();
        }
        public Aluno()
        {
            id = 0;
            nome = string.Empty;
            idade = 0;
            notas = new List<Nota>();
        }
        public int Id { get { return id; } set { id = value; } }
        public string Nome { get { return nome; } set { nome = value; } }
        public int Idade { get { return idade; } set { idade = value; } }
        public void AdicionarNota(Nota nota)
        {
            notas.Add(nota);
        }
        public void ListarNotas()
        {
            foreach (Nota nota in notas)
            {
                Console.WriteLine(nota);
            }
        }
        public void AtualizarNota(int idNota, int novoValor)
        {
            notas.ForEach(n =>
            {
                if (n.Id == idNota)
                {
                    n.Valor = novoValor;
                }
            });
        }
        public override string ToString()
        {
            return $"[Id: {id}; Nome: {nome}; Idade: {idade}]";
        }
    }
}
