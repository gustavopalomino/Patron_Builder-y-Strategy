using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronComposite
{
    public abstract class Componente
    {
        protected string nombre;
        public Componente(string nombre)
        {
            this.nombre = nombre;
        }
        public abstract void Agregar(Componente componente);
        public abstract void Eliminar(Componente componente);
        public abstract void Mostrar(int profundidad);
    }
}
