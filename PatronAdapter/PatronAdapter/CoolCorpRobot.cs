using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronAdapter
{
    class CoolCorpRobot : CoolCorpInterface
    {
        private USRobot robot;

        public CoolCorpRobot()
        {
            this.robot = new USRobot();
        }

        public float VelocidadActualEnKilometroPorHora
        {
            get
            {
                return this.robot.VelocidadActualEnMillasPorHora * 1.6093f;
            }
            set
            {
                this.robot.VelocidadActualEnMillasPorHora = value * 0.62137f;
            }
        }

        public void Saltar(float metros)
        {
            this.robot.Saltar(metros * 0.3048f);
        }
    }
}
