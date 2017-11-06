using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactorySistemaVisualizacion
{
    //Fabrica Concreta Mac
    public class MacWidgetFactory : IWidgetFactory
    {
        public Window CreateWindow()
        {
            return new MacWindow();
        }

        public Scrollbar CreateScrollbar()
        {
            return new MacScrollbar();
        }
    }
}
