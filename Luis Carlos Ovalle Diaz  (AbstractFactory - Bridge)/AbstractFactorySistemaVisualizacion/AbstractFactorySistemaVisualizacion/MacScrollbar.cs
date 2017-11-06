using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactorySistemaVisualizacion
{
    // Producto Concreto (Scrollbar para Mac)
    public class MacScrollbar : Scrollbar
    {
        public override void Render()
        {
            Console.WriteLine("Pintando Scrollbar de Mac...");
        }

    }
}
