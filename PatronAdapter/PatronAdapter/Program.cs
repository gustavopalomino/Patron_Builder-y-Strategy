using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronAdapter
{
    class Program
    {
        static void Main(string[] args)
        {
            CoolCorpInterface robot = new CoolCorpRobot();
            robot.VelocidadActualEnKilometroPorHora = 3;
            robot.Saltar(12);
            Console.ReadKey();
        }
    }
}
