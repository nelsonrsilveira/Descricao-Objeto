using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obj
{
    public abstract class Objeto 
    {
        private string nome;

        protected string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        private string marca;

        protected string Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        private double peso;

        protected double Peso
        {
            get { return peso; }
            set { peso = value; }
        }

        private string utilidade;

        protected string Utilidade
        {
            get { return utilidade; }
            set { utilidade = value; }
        }

        public Objeto()
        {
            this.Nome = nome;
            this.Marca = marca;
            this.Peso = peso;
            this.Utilidade = utilidade;
        }

        public abstract void Exibir();
        public abstract void Agir();
    }
}
