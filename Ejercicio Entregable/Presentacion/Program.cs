using Ejercicio_Entregable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Presentacion
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            LogicaPrincipal.Singleton.ElementoAgregadoEvet += AccionesElementosSuscriptor.ElementoAgregado;
            LogicaPrincipal.Singleton.ElementoEliminadoEvent += AccionesElementosSuscriptor.ElementoEliminado;
            do
            {
                Console.WriteLine("Ingrese el nro de la operacion que quiere realizar. 1 para agregar elemento. 2 para eliminar elemento. " +
                "3 para obtener listado monitores. 4 Obtener listado Computadoras. 5 Listado elementos. 6 salir.");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Ingrese 1 para Monitor, 2 para PC");
                        int elemento = int.Parse(Console.ReadLine());
                        if (elemento == 1)
                        {
                           
                            Console.WriteLine("Ingrese Marca");
                            string marca = Console.ReadLine();
                            Console.WriteLine("Ingrese Modelo");
                            string modelo = Console.ReadLine();
                            Console.WriteLine("Ingrese nro serie");
                            int nroSerie = int.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese Año fabricacion");
                            int anio = int.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese pulgadas");
                            int? pulgadas = int.Parse(Console.ReadLine());
                            LogicaPrincipal.Singleton.AgregarElemento(modelo, marca, nroSerie, anio, pulgadas);
                        }
                        else
                        {
                            
                            Console.WriteLine("Ingrese Marca");
                            string marca = Console.ReadLine();
                            Console.WriteLine("Ingrese Modelo");
                            string modelo = Console.ReadLine();
                            Console.WriteLine("Ingrese nro serie");
                            int nroSerie = int.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese descProcesador");
                            string  descProcesador = Console.ReadLine();
                            Console.WriteLine("Ingrese CantidadRAM");
                            int cantidadRam = int.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese NombreFabricante");
                            string NombreFabricante = Console.ReadLine();
                            LogicaPrincipal.Singleton.AgregarElemento(modelo, marca, nroSerie, descProcesador, cantidadRam,NombreFabricante);
                        }
                        break;
                    case 2:
                        Console.WriteLine("ingrese id elemento a eliminar");
                        string id = Console.ReadLine();

                        break;
                    case 3:

                        break;
                    default:
                        break;
                }
            } while (opcion < 6);

                
            
        }
        public class AccionesElementosSuscriptor
        {

            public static void ElementoAgregado(object sender, Agregado_de_elemento args)
            {
                if (args.elementos is Monitor monitor)
                {
                    Console.WriteLine($"El monitor fue agregado. Detalle: {monitor.Identificador}");
                }
                else
                {
                    Console.WriteLine($"La computadora fue agregada. Detalle: {args.elementos.Identificador}");
                }
                Console.ReadKey();
                Console.Clear();
                List<string> listadoElementos = LogicaPrincipal.Singleton.ObtenerListadoElementos();
                foreach (var elemento in listadoElementos)
                {
                    if (args.elementos is Monitor monitor1)                     
                    {
                        if (elemento.Contains("Monitor") & elemento.Contains($"{args.elementos.Marca}") & elemento.Contains($"{args.elementos.Modelo}") & elemento.Contains($"{monitor1.Pulgadas}"))
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine(elemento);
                            Console.ForegroundColor = ConsoleColor.Gray;
                        }
                        else
                        {
                            Console.WriteLine(elemento);
                        }
                    }
                    else
                    {
                        if (args.elementos is Computadora computadora)
                        {
                            if (elemento.Contains("PC") & elemento.Contains($"{args.elementos.Marca}") & elemento.Contains($"{args.elementos.Modelo}") & elemento.Contains($"{computadora.DescProcesador}") & elemento.Contains($"{computadora.CantidadRAM}") & elemento.Contains($"{computadora.NombreFabricante}"))
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine(elemento);
                                Console.ForegroundColor = ConsoleColor.Gray;
                            }
                            else
                            {
                                Console.WriteLine(elemento);
                            }
                        }
                    }
                }

            }

            public static void ElementoEliminado(object sender, EliminarElementoHandler args)
            {
                Console.WriteLine($"El producto con id {args.elementos.Identificador} fue eliminado");
            }

            
        }
    }
}
