using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronComposite
{
    class Program
    {
        static void Main(string[] args)
        {
            Compuesto raiz = new Compuesto("root");
            raiz.Agregar(new Hoja("hoja A"));
            raiz.Agregar(new Hoja("hoja B"));
            Compuesto comp = new Compuesto("compuesto X");
            comp.Agregar(new Hoja("hoja XA"));
            comp.Agregar(new Hoja("hoja XB"));
            raiz.Agregar(comp);
            raiz.Agregar(new Hoja("hoja C"));
            Hoja l = new Hoja("hoja D");
            raiz.Agregar(l);
            raiz.Eliminar(l);
            raiz.Mostrar(1);

            Console.ReadKey();
        }
    }
}
