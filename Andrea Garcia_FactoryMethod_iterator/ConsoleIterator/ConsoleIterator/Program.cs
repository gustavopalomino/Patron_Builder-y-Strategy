using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleIterator
{
    class Program
    {
        static void Main(string[] args)
        {

            // Declaramos el registro
            IregistroVehiculos registro = new RegistroVehiculos();

            // Insertamos unos cuantos elementos
            registro.InsertarVehiculo("Volkswagen", "Polo", 42862300);
            registro.InsertarVehiculo("Volkswagen", "Golf GTI", 65861600);
            registro.InsertarVehiculo("Volkswagen", "Passat", 94088000);
            registro.InsertarVehiculo("Volkswagen", "Scirocco", 111860000);
            registro.InsertarVehiculo("Volkswagen", "Touareg", 75967400);

            // Obtenemos el iterator
            IEnumerator iterador = registro.MostrarTodo().GetEnumerator();

            // Mientras queden elementos
            while (iterador.MoveNext())
            {
                // Obtenemos el siguiente elemento
                Vehiculo v = (Vehiculo)iterador.Current;

                // Mostramos su contenido
                Console.WriteLine(v.Marca + " " + v.Modelo + " fabricado el " + v.FechaFabricacion.ToShortDateString() + " evaluado en $" + v.Precio);
            }
            Console.ReadKey();


        }
    }
}
