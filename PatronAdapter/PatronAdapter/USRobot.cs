using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronAdapter
{
    class USRobot : USRobotsInterface
    {
        private float VelocidadActual;

        public float VelocidadActualEnMillasPorHora
        {
            get { return VelocidadActual; }
            set { VelocidadActual = value; }
        }

        public USRobot()
        {
            this.VelocidadActual = 0;
        }

        public void HabilitarElModoDePrimeraLeyParcial()
        {
            Console.WriteLine("Primera ley parcial habilitada");
        }

        public void Saltar(float pies)
        {
            Console.WriteLine("Saltar !!");
        }
    }
}
