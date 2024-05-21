using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_List_Dictionary
{
    public class Nota
    {
        private int id;
        private string materia;
        private int valor;
        public Nota(int id, string materia, int valor)
        {
            this.id = id;
            this.materia = materia;
            this.valor = valor;
        }
        public Nota()
        {
            id = 0;
            materia = string.Empty;
            valor = 0;
        }
        public int Id { get { return id; } set { id = value; } }
        public string Materia { get { return materia; } set { materia = value; } }
        public int Valor { get { return valor; } set { valor = value; } }
    }
}
