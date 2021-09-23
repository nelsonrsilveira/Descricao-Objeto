using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obj
{
    public class Mesa : Objeto
    {
        public Mesa()
        {
            Nome = "Mesa";
            Marca = "Tok Stok";
            Peso = 30;
            Utilidade = "Móvel de madeira formada por uma tábua horizontal assentada sobre quatro pés ou mais, onde se serve refeições.";
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
            Console.WriteLine(Nome + " está sustentando os pratos e talheres. ");
        }
    }
}
