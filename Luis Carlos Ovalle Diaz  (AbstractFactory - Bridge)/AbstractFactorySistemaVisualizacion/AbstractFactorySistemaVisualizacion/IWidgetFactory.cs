using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactorySistemaVisualizacion
{
    // Interface de la Fabrica Abstracta
    public interface IWidgetFactory
    {
        Window CreateWindow();
        Scrollbar CreateScrollbar();
    }
}
