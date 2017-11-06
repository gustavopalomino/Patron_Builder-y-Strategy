using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleFactoryMethod
{
    public class MotoAgua : Imoto 
    {
        private int ruedas;

        //constructor inyectado
        public MotoAgua (int ruedas){
            this.ruedas = ruedas;
        }

        //metodo que me obliga a implementar la interfaz moto
        public int getRuedas()
        {
           return this.ruedas;
        }

    }
}
