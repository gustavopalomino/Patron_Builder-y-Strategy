using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactorySistemaVisualizacion
{
    public class WindowsScrollbar : Scrollbar
    {
        // Producto Concreto (Scrollbar para Windows)
        public override void Render()
        {
            Console.WriteLine("Pintando Scrollbar de Windows...");
        }
    }
}
