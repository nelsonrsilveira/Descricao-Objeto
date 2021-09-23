using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obj
{
    class Program
    {
        static void Main(string[] args)
        {
            Violao vio = new Violao();
            Lapis la = new Lapis();
            Mesa me = new Mesa();
            Cavalete cav = new Cavalete();

            vio.Exibir();
            vio.Agir();
            Console.WriteLine();
            la.Exibir();
            la.Agir();
            Console.WriteLine();
            me.Exibir();
            me.Agir();
            Console.WriteLine();   
            cav.Exibir();
            cav.Agir();

            Console.ReadKey();            
        }
    }
}
