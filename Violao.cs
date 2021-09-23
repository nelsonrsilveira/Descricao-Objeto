using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obj
{
    public class Violao : Objeto
    {
        public Violao()
        {
            Nome = "Violão";
            Marca = "Gianini";
            Peso = 4.03;
            Utilidade = "Instrumento musical de cordas com uma caixa geralmente feita de madeira.";
        }

        public override void Exibir()
        {
            Console.WriteLine("Nome do objeto: " + Nome);
            Console.WriteLine("Marca do objeto: " + Marca);
            Console.WriteLine("Peso: " + Peso);
            Console.WriteLine("Utilidade: " + Utilidade);
        }

        public override void Agir()
        {
            Console.WriteLine(Nome + " está tocando. ");
        }
    }
}
