using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronAdapter
{
    interface USRobotsInterface
    {
        float VelocidadActualEnMillasPorHora { get; set; }
        void HabilitarElModoDePrimeraLeyParcial();
        void Saltar(float pies);
    }
}
