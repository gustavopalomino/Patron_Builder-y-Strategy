using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoPlantilla
{
    abstract class DataExporter
    {
        //Esto no variará ya que los datos se leen solo desde sql
        public void ReadData()
        {
            Console.WriteLine("Lectura de los datos del servidor Sql");
        }

        //Esto no variará ya que el formato del informe es fijo.
        public void FormatData()
        {
            Console.WriteLine("Formateando los datos según los requisitos.");
        }

        //Esto puede variar según el tipo de archivo de destino elegido
        public abstract void ExportData();

        //Este es el método de plantilla que usará el cliente.
        public void ExportFormatedData()
        {
            this.ReadData();
            this.FormatData();
            this.ExportData();
        }
    }
}
