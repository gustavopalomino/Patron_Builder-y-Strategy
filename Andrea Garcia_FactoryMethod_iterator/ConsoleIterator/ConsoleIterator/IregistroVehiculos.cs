using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleIterator
{
    public interface IregistroVehiculos
    {
        void InsertarVehiculo(string marca, string modelo, double precio);
        Vehiculo MostrarInformacionVehiculo(int indice);
        ArrayList MostrarTodo();
    }
}
