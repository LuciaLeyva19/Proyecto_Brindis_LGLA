using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Brindis_LGLA
{
    internal class Lista
    {
        private Nodo cabeza;

        public Lista()
        {
            cabeza = null;
        }

        public void InsertarNodo(int valor)
        {
            Nodo nuevoNodo = new Nodo(valor); //Creacion de un nuevo nodo con el valor que el usuario ingresp
            if (cabeza == null) //Verificamos si la lista esta vacia (es decir, si cabeza es null)
            {
                cabeza = nuevoNodo; //Si esta vacia, el nuevo nodo se convierte en la cabeza de la lista
            }
            else //Si la lista no está vacía, usamos la variable temp para recorrerla.
            {
                Nodo temp = cabeza;
                while (temp.Sig != null) //Recorremos los nodos hasta llegar al ultimo
                {
                    temp = temp.Sig; 
                }
                temp.Sig = nuevoNodo; //Una vez en el ultimo nodo, enlazamos su campo siguiente con el nuevo nodo
            }
            Console.WriteLine($"Nodo con valor {valor} insertado.");
        }

        public int ImprimirTamaño()
        {
            int tamaño = 0; //Inicializamos una variable tamaño en 0 para llevar la cuenta de los nodos
            Nodo temp = cabeza; //Empezamos a recorrer desde la cabeza de la lista
            while (temp != null) //Mientras no lleguemos al final de la lista (temp != null), seguimos recorriendo 
            {
                tamaño++; //Aumentamos el contador por cada nodo encontrado
                temp = temp.Sig;
            }
            return tamaño; //Al final, devolvemos el tamaño total de la lista
        }

        public Nodo BuscarNodo(int valor)
        {
            Nodo temp = cabeza; //Empezamos desde la cabeza
            while (temp != null) //Recorremos la lista hasta llegar al final
            {
                if (temp.Valor == valor) //Si encontramos un nodo con el valor que buscamos, lo devolvemos
                    return temp;
                temp = temp.Sig; //Si no es el nodo que buscamos, avanzamos al siguiente
            }
            return null; //Si no encontramos el nodo con el valor indicado, devolvemos null
        }

        public bool BorrarNodo(int valor)
        {
            if (cabeza == null) return false; //Si la lista esta vacia, no hay nada que borrar

            if (cabeza.Valor == valor) //Si el valor del primer nodo coincide, lo eliminamos cambiando la cabeza al siguiente nodo
            {
                cabeza = cabeza.Sig;
                return true;
            }

            Nodo temp = cabeza; //Si no es el primer nodo, recorremos la lista usando temp
            while (temp.Sig != null) //Recorremos los nodos hasta encontrar el que queremos borrar
            {
                if (temp.Sig.Valor == valor)
                {
                    temp.Sig = temp.Sig.Sig; //Si encontramos el nodo, lo eliminamos haciendo que el nodo anterior apunte al siguiente
                    return true; //Si se borra el nodo, devolvemos true
                }
                temp = temp.Sig;
            }
            return false;
        }

        public bool ModificarNodo(int viejoValor, int nuevoValor)
        {
            Nodo nodo = BuscarNodo(viejoValor);
            if (nodo != null) //Verificamos si el nodo fue encontrado, si nodo no es null, significa que el valor viejoValor existia en la lista
            {
                nodo.Valor = nuevoValor; //Si encontramos el nodo, modificamos su valor y le asignamos nuevoValor
                return true; //Si se pudo modificar devolvemos true
            }
            return false; //Si no se encontro el nodo con el calor buscado, devolvemos false
        }

        public void BuscarValor(int posicion)
        {
            int indice = 0; //Usamos indice para llevar la cuenta de la posicion actual
            Nodo temp = cabeza; //Emepzamos a recorrer desde la cabeza

            while (temp != null) //Recorremos la lista hasta llegar al final
            {
                if (indice == posicion) //Si encontramos el nodo en la posicion indicada, mostrando su valor
                {
                    Console.WriteLine($"El valor en la posición {posicion} es: {temp.Valor}");
                    return;
                }
                temp = temp.Sig; //Si no es la posicion que buscamos, avanzamos al siguiente nodo
                indice++; //Aumentamos en indice
            }
            Console.WriteLine("Posición fuera de rango.");
        }

        public void ImprimirLista()
        {
            Nodo temp = cabeza; //Empezamos desde la cabeza
            if (temp == null) //Si la lista esta vacia, mostramos un mensaje y terminamos
            {
                Console.WriteLine("La lista está vacía.");
                return;
            }
            while (temp != null) //Recorremos la lista hasta llegar al final
            {
                Console.Write(temp.Valor + " "); //Imprimimos el valor del nodo actual
                temp = temp.Sig; //Avanzamos al siguiente nodo
            }
            Console.WriteLine();
        }
    }
}
