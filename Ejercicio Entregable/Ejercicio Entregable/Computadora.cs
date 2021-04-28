using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Entregable
{
    public class Computadora : Elementos
    {
       
        
        public Computadora(string modelo, string marca, int nroSerie, string descProcesador, int pCantidadRAM, string nombreFabricante)
        {
            Modelo = modelo;
            Marca = marca;
            NroSerie = nroSerie;
            DescProcesador = descProcesador;
            CantidadRAM = pCantidadRAM;
            NombreFabricante = nombreFabricante;
            
        }

        public string DescProcesador { get; set; }
        public int CantidadRAM { get; set; }
        public string NombreFabricante { get; set; }

        
    }
}
