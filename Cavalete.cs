using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obj
{
    public class Cavalete : Objeto
    {
        public Cavalete()
        {
            Nome = "Cavalete";
            Marca = "Leroy Merlin";
            Peso = 2.65;
            Utilidade = "Objeto de madeira ideal para servir de suporte e sustentar um tampo.";
        }

        public override void Exibir()
        {
            Console.WriteLine("Nome do objeto: " + Nome);
            Console.WriteLine("Marca do objeto: " + Marca);
            Console.WriteLine("Peso: " + Peso);
            Console.WriteLine("Utilidade: " + Utilidade);
        }

        public override void  Agir()
        {
            Console.WriteLine(Nome + " está apoaindo. ");
        }
    }
}
