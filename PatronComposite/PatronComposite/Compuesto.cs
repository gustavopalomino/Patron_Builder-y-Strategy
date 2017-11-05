using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronComposite
{
    public class Compuesto : Componente
    {
        private List<Componente> hijo = new List<Componente>();
        public Compuesto(string nombre) : base(nombre) { }
        public override void Agregar(Componente componente)
        {
            hijo.Add(componente);
        }
        public override void Eliminar(Componente componente)
        {
            hijo.Remove(componente);
        }
        public override void Mostrar(int profundidad)
        {
            Console.WriteLine(string.Format("{0} nivel: {1}", nombre, profundidad));
            for (int i = 0; i < hijo.Count; i++)
                hijo[i].Mostrar(profundidad + 1);
        }
    }
}
