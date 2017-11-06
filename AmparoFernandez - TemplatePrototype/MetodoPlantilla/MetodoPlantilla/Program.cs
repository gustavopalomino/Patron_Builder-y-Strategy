using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoPlantilla
{
    class Program
    {
        static void Main(string[] args)
        {
            DataExporter exporter = null;

            //Exportamos los datos al archivo de Excel
            exporter = new ExcelExporter();
            exporter.ExportFormatedData();

            Console.WriteLine();

            //Exportemos los datos al archivo PDF
            exporter = new PDFExporter();
            exporter.ExportFormatedData();

            //Esperando autorización del usuario
            Console.ReadKey();
        }
    }
}
