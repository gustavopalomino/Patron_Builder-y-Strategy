using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleIterator
{
    public class RegistroVehiculos : IregistroVehiculos
    {
        private ArrayList listaVehiculos;

        public RegistroVehiculos()
        {
            this.listaVehiculos = new ArrayList();
        }

        public void InsertarVehiculo(string marca, string modelo, double precio)
        {
            Vehiculo v = new Vehiculo(marca, modelo, DateTime.Now, precio);
            listaVehiculos.Add(v);         
        }

        public ArrayList MostrarTodo()
        {
            return this.listaVehiculos;
        }

        public Vehiculo MostrarInformacionVehiculo(int indice)
        {
            return (Vehiculo)listaVehiculos[indice];
        }
  
    }
}
