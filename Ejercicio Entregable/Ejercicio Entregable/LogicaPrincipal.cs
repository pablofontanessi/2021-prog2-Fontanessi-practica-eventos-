using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Entregable
{
    public class LogicaPrincipal
    {
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
        private  List<Elementos> ListaElementos { get; set; }

        public void AgregarElemento (Elementos elementos)
        {
            ListaElementos.Add(elementos);
        }
        public void EliminarElemento(string ID)
        {
            if ((ListaElementos.Find(x => x.Identificador == ID) != null))
            {
                ListaElementos.Remove((ListaElementos.Find(x => x.Identificador == ID)));
            } 
        }
        public string ObtenerDescripcionProductos()
        {

        }
    }
}
