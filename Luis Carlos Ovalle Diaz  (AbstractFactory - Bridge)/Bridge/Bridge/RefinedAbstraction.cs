using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class RefinedAbstraction : Abstraction
    {
        Implementor implementacion = null;
        public RefinedAbstraction(Implementor imp)
        {
            this.implementacion = imp;
        }
        public int operar(int num1, int num2)
        {
            return implementacion.operacion(num1, num2);
        }
    }
}
