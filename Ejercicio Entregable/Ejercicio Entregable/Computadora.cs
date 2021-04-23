using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Entregable
{
    public class Computadora : Elementos
    {
        public string DescProcesador { get; set; }
        public enum CantidadRAM { dosGB, cuatroGB, ochoGB, dieciseisGB }
        public string NombreFabricante { get; set; }

        
    }
}
