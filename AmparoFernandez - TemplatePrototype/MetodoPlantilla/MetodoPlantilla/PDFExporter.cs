using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoPlantilla
{
    class PDFExporter : DataExporter
    {
        public override void ExportData()
        {
            Console.WriteLine("Exportar los datos a un archivo PDF.");
        }
    }
}
