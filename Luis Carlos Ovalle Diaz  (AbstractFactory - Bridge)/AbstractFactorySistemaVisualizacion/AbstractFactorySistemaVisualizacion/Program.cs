using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactorySistemaVisualizacion
{
    //Cliente
    class Program
    {
        static void Main(string[] args)
        {
            /// Creo los objetos para windows
            IWidgetFactory factory = new WindowsWidgetFactory();
            Scrollbar scrollbar = factory.CreateScrollbar();
            Window window = factory.CreateWindow();
            window.Render();
            scrollbar.Render();

            /// Ahora, lo mismo pero para Mac. 
            /// Al cambiar el tipo del factory, todos los objetos que 
            /// se crean mediante ella son de la misma familia
            factory = new MacWidgetFactory();
            scrollbar = factory.CreateScrollbar();
            window = factory.CreateWindow();
            window.Render();
            scrollbar.Render();

            Console.ReadKey();
        }
    }
}
