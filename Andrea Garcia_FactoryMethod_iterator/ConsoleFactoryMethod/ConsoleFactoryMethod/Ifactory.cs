using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleFactoryMethod
{
    public interface Ifactory
    {
        Imoto CrearMoto(String tipo, int ruedas);
    }
}
