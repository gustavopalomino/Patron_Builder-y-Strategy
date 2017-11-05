using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronComposite
{
    public class Hoja : Componente
    {
        public Hoja(string nombre) : base(nombre) { }
        public override void Agregar(Componente componente)
        {
            Console.WriteLine("no se puede agregar la hoja");
        }
        public override void Eliminar(Componente componente)
        {
            Console.WriteLine("no se puede eliminar la hoja");
        }
        public override void Mostrar(int profundidad)
        {
            Console.WriteLine(string.Format("-{0}", nombre));
        }
    }
}
