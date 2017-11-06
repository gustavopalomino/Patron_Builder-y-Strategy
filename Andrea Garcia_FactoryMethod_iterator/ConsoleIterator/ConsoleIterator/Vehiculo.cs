using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleIterator
{
    public class Vehiculo
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public DateTime FechaFabricacion { get; set; }
        public double Precio { get; set; }

        public Vehiculo(string marca, string modelo, 
            DateTime fechaFabricacion, double precio) 
        {
            this.Marca = marca;
            this.Modelo = modelo;
            this.FechaFabricacion = fechaFabricacion;
            this.Precio = precio;
        }

    }
}
