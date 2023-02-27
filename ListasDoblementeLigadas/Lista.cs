using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasDoblementeLigadas
{
    internal class Lista
    {
        public Nodo siguiente;
        public Nodo anterioris;
        public Lista() {
            siguiente = null;
            anterioris = null;
        }
        public bool ValidaVacio() { 
            return siguiente == null;
        }
        public void VaciarLista() {
            siguiente = null;
            anterioris = null;
        }
        public int Indice(String datos)
        {
            int Indice = 0;
            Nodo actual = siguiente;
            while (actual != null)
            {
                if (actual.datos == datos)
                {
                    return Indice;
                }
                actual = actual.Siguiente;
                Indice++;
            }
            return -1;
        }
        public void IngresoDatos(String dat) { 
            Nodo dato = new Nodo(dat);
            if (siguiente == null)
            {
                siguiente = dato;
                anterioris = dato;
            }
            else
            {
                dato.Siguiente = siguiente;
                anterioris.anterior = dato;
                anterioris = dato;
            }
        }
        public void AgregarFinal(string datos)
        {
            Nodo nuevoNodo = new Nodo(datos);

            if (siguiente == null)
            {   
                siguiente = nuevoNodo;
                anterioris = nuevoNodo;
            }
            else
            {
                nuevoNodo.anterior = anterioris;
                anterioris.Siguiente = nuevoNodo;
                anterioris = nuevoNodo;
            }
        }
        public void EliminarNodo(String datos) {
            if (ValidaVacio())
            {
                Console.WriteLine("La lista esta vacia");
                return;
            }
            Nodo actual = siguiente;

            while (actual != null && actual.datos != datos)
            {
                actual = actual.Siguiente;
            }
            if (actual == null)
            {
                Console.WriteLine("El nodo {0} no se encontró en la lista", datos);
                return;
            }

            if (actual.anterior == null)
            {
                siguiente = actual.Siguiente;
            }
            else
            {
                actual.anterior.Siguiente = actual.Siguiente;
            }

            if (actual.Siguiente == null)
            {
                anterioris = actual.anterior;
            }
            else
            {
                actual.Siguiente.anterior = actual.anterior;
            }
        }
        public void RecorrerLista()
        {
            Nodo actual = siguiente;
            while (actual != null)
            {
                Console.WriteLine(actual.datos + " ");
                actual = actual.Siguiente;
            }
            Console.WriteLine();
        }
        public void NodoSiguiente(Nodo nodo)
        {
            if (nodo == null || nodo.Siguiente == null)
            {
                Console.WriteLine("El nodo no tiene nodo siguiente");
            }
            else
            {
                Console.WriteLine("El nodo siguiente es: " + nodo.Siguiente.datos);
            }
        }
        public void NodoPrevio(Nodo nodo)
        {
            if (nodo == null || nodo.anterior == null)
            {
                Console.WriteLine("El nodo no tiene nodo anterior");
            }
            else
            {
                Console.WriteLine("El nodo anterior es: " + nodo.anterior.datos);
            }
        }
        public Nodo Buscar(string datos)
        {
            Nodo actual = siguiente;

            while (actual != null)
            {
                if (actual.datos == datos)
                {
                    return actual;
                }
                actual = actual.Siguiente;
            }

            return null;
        }

    }
}
