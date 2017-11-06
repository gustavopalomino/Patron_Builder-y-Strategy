using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleFactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {

            string tipoMoto = "campo";
            int numeroRuedas = 2;

            Ifactory miFabrica = new FactoryImp();
            Imoto miMoto = miFabrica.CrearMoto(tipoMoto,numeroRuedas);

            Console.WriteLine("es una moto de "+miMoto.getRuedas()+" ruedas");
            Console.ReadKey();

        }
    }
}
