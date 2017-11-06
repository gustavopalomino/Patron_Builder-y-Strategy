using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactorySistemaVisualizacion
{
    // Producto Concreto (Ventana para Windows)
    public class WindowsWindow : Window
    {
        public override void Render()
        {
            Console.WriteLine("Pintando Ventana de Windows...");
        }
    }
}
