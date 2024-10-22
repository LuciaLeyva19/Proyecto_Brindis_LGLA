using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Brindis_LGLA
{
    internal class Program
    {
        static void Main()
        {
            Lista lista = new Lista();
            int opcion;

            do
            {
                Console.WriteLine("MENU LISTAS");
                Console.WriteLine("---------------------------------");
                Console.WriteLine("1.- Insertar Nodo");
                Console.WriteLine("2.- Imprimir Tamaño");
                Console.WriteLine("3.- Buscar Nodo");
                Console.WriteLine("4.- Borrar Nodo");
                Console.WriteLine("5.- Modificar Nodo");
                Console.WriteLine("6.- Buscar Valor por Posición");
                Console.WriteLine("7.- Imprimir Lista");
                Console.WriteLine("8.- Salir");
                Console.WriteLine("_____________________");
                Console.Write("Seleccionar Opción => ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.Write("Ingrese el valor del nodo: ");
                        int valor = int.Parse(Console.ReadLine());
                        lista.InsertarNodo(valor);
                        break;

                    case 2:
                        Console.WriteLine("Tamaño de la lista: " + lista.ImprimirTamaño());
                        break;

                    case 3:
                        Console.Write("Ingrese el valor a buscar: ");
                        valor = int.Parse(Console.ReadLine());
                        Nodo encontrado = lista.BuscarNodo(valor);
                        Console.WriteLine(encontrado != null ? "Nodo encontrado: " + encontrado.Valor : "Nodo no encontrado.");
                        break;

                    case 4:
                        Console.Write("Ingrese el valor a borrar: ");
                        valor = int.Parse(Console.ReadLine());
                        bool borrado = lista.BorrarNodo(valor);
                        Console.WriteLine(borrado ? "Nodo borrado." : "Nodo no encontrado.");
                        break;

                    case 5:
                        Console.Write("Ingrese el valor del nodo a modificar: ");
                        int viejoValor = int.Parse(Console.ReadLine());
                        Console.Write("Ingrese el nuevo valor: ");
                        int nuevoValor = int.Parse(Console.ReadLine());
                        bool modificado = lista.ModificarNodo(viejoValor, nuevoValor);
                        Console.WriteLine(modificado ? "Nodo modificado." : "Nodo no encontrado.");
                        break;

                    case 6:
                        Console.Write("Ingrese la posición del nodo: ");
                        int posicion = int.Parse(Console.ReadLine());
                        lista.BuscarValor(posicion);
                        break;

                    case 7:
                        Console.WriteLine("Elementos de la lista:");
                        lista.ImprimirLista();
                        break;

                    case 8:
                        Console.WriteLine("Saliendo...");
                        break;

                    default:
                        Console.WriteLine("Opción inválida, intenta nuevamente.");
                        break;
                }

                Console.WriteLine();
            } while (opcion != 8);
        }
    }
}
