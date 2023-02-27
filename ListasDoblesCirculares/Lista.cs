using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasDoblesCirculares
{
    internal class Lista
    {
        private Nodo sig;
        private Nodo ant;

        public Lista() {
            sig = null;
            ant = null;
        }
        public bool ValidaVacio() {
            return sig == null;
        }
        public void Agregar(String datos)
        {
            var newNode = new Nodo(datos);

            if (ValidaVacio())
            {
                sig = newNode;
                ant = newNode;
                sig.siguiente = ant;
                ant.anterior = sig;
            }
            else
            {
                newNode.siguiente = sig;
                sig.anterior = newNode;
                sig = newNode;
                sig.anterior = ant;
                ant.siguiente = sig;
            }
        }
        public void AgregarFinal(String datos)
        {
            var newNode = new Nodo(datos);

            if (ValidaVacio())
            {
                sig = newNode;
                ant = newNode;
                sig.siguiente = ant;
                ant.anterior = sig;
            }
            else
            {
                newNode.anterior = ant;
                ant.siguiente = newNode;
                ant = newNode;
                sig.anterior = ant;
                ant.siguiente = sig;
            }
        }

        public void EliminarInicio()
        {
            if (ValidaVacio())
            {
                throw new InvalidOperationException("La lista esta vacia.");
            }
            else
            {
                sig = sig.siguiente;
                sig.anterior = ant;
                ant.siguiente = sig;
            }

            
        }

        public void EliminarFinal()
        {
            if (ValidaVacio())
            {
                throw new InvalidOperationException("La lista esta vacia.");
            }

            else
            {
                ant = ant.anterior;
                ant.siguiente = sig;
                sig.anterior = ant;
            }
        }

        public Nodo EncontrarNodo(String datos)
        {
            if (ValidaVacio())
            {
                return null;
            }

            var currentNode = sig;

            do
            {
                if (currentNode.dato.Equals(datos))
                {
                    datos = currentNode.dato;
                    Console.WriteLine(datos);
                }

                currentNode = currentNode.siguiente;
            }
            while (currentNode != sig);

            return null;
        }

        public void Recorrer()
        {
            if (ValidaVacio())
            {
                Console.WriteLine("La lista esta vacia.");
                return;
            }
            var currentNode = sig;
            do
            {
                Console.WriteLine(currentNode.dato);
                currentNode = currentNode.siguiente;
            } while (currentNode != sig);
        }
    }
}
