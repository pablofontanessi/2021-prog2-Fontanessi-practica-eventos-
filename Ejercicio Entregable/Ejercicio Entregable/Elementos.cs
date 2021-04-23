using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Entregable
{
    public abstract class Elementos
    {
        public string Modelo { get; set; }
        public string Marca { get; set; }
        public int NroSerie { get; set; }
        public string Identificador => Modelo + Marca + NroSerie;

    }
}
