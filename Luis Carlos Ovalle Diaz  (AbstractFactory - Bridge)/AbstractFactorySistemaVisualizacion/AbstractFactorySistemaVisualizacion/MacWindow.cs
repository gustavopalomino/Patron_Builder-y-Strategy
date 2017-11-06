using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactorySistemaVisualizacion
{
    // Producto Concreto (Ventana para Mac)
    public class MacWindow : Window
    {
        public override void Render()
        {
            Console.WriteLine("Pintando Ventana de Mac...");
        }
    }
}
