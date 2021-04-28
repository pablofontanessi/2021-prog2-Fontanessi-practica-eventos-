using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Entregable
{
    public class Monitor : Elementos
    {
        private int anioFabricacion;

        public int AnioFabricaicon { get; set; }
        public bool EsNuevo { get 
            {
                if (AnioFabricaicon == DateTime.Today.Year)
                {
                    return true;
                }
                return false;
            } 
        }
        public int? Pulgadas { get; set; }

        public Monitor(string modelo, string marca, int nroSerie, int anioFabricacion, int? pulgadas)
        {
            Modelo = modelo;
            Marca = marca;
            NroSerie = nroSerie;
            this.anioFabricacion = anioFabricacion;
            Pulgadas = pulgadas;
            
        }
    }
}
