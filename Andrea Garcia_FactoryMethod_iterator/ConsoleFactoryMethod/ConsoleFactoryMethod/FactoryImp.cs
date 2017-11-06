using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleFactoryMethod
{
    public class FactoryImp: Ifactory
    {

        public Imoto CrearMoto(String tipo, int ruedas)
        {
            switch(tipo){
                case "agua": return new MotoAgua(ruedas);
                case "campo": return new MotoCampo(ruedas);
                   
                default: return null;
            }
        }
    }
}
