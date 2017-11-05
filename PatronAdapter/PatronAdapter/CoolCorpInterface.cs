using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronAdapter
{
    interface CoolCorpInterface
    {
        float VelocidadActualEnKilometroPorHora { get; set; }
        void Saltar(float metros);
    }
}
