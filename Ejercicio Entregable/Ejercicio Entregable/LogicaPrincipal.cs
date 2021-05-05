using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Entregable
{
    public class LogicaPrincipal
    {
        public EventHandler<Agregado_de_elemento> ElementoAgregadoEvet;
        public EventHandler<EliminarElementoHandler> ElementoEliminadoEvent;
        private static LogicaPrincipal singleton = null;
        private LogicaPrincipal()
        { 
        }
        public static LogicaPrincipal Singleton
        {
            get
            {
                if (singleton == null)
                {
                    singleton = new LogicaPrincipal();

                }
                return singleton;
            }
        }
        List<Elementos> ListaElementos = new List<Elementos>();

        public void AgregarElemento (string Modelo, string Marca, int NroSerie, int AnioFabricacion, int? Pulgadas )
        {
            Monitor monitor = new Monitor(Modelo, Marca, NroSerie, AnioFabricacion, Pulgadas);
            ListaElementos.Add(monitor);
            this.ElementoAgregadoEvet(this, new Agregado_de_elemento() {elementos = monitor });
        }
        public void AgregarElemento(string Modelo, string Marca, int NroSerie, string DescProcesador, int CantidadRAM, string NombreFabricante)
        {
            Computadora computadora = new Computadora(Modelo, Marca, NroSerie, DescProcesador, CantidadRAM, NombreFabricante);
            ListaElementos.Add(computadora);
            this.ElementoAgregadoEvet(this, new Agregado_de_elemento() { elementos = computadora });
        }
        public void EliminarElemento(string ID)
        {
            if ((ListaElementos.Find(x => x.Identificador == ID) != null))
            {
                ListaElementos.Remove((ListaElementos.Find(x => x.Identificador == ID)));
            } 
        }
       
        public List<string> ObtenerListadoElementos()
        {
            List<string> ListaDescElementos = new List<string>();
            foreach (var elemento in ListaElementos)
            {
                ListaDescElementos.Add(elemento.ObtenerDescripcionElemento());
            }
            ListaDescElementos.Sort();
            return ListaDescElementos;
        }
    }
}
