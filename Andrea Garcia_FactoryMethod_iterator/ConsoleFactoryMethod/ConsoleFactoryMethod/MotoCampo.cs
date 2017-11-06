using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleFactoryMethod
{
    class MotoCampo : Imoto
    {
        private int ruedas;

        //constructor inyectado
        public MotoCampo (int ruedas){
            this.ruedas = ruedas;
        }

        //metodo que me obliga a implementar la interfaz moto
        public int getRuedas()
        {
           return this.ruedas;
        }
    }
}
