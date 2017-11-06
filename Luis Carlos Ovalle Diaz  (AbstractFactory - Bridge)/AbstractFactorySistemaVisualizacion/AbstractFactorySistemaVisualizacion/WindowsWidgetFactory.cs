using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactorySistemaVisualizacion
{
    //Fabrica Concreta Windows
    public class WindowsWidgetFactory : IWidgetFactory
    {
        public Window CreateWindow()
        {
            return new WindowsWindow();
        }

        public Scrollbar CreateScrollbar()
        {
            return new WindowsScrollbar();
        }
    }
}
