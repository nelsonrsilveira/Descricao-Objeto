using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obj
{
    public class Lapis : Objeto
    {
        public Lapis()
        {
            Nome = "Lápis";
            Marca = "Faber Castell";
            Peso = 0.5;
            Utilidade = "Instrumento, de madeira e grafite, de escrita.";
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
            Console.WriteLine(Nome + " está escrevendo. ");
        }
    }
}
