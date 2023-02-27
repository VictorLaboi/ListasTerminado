using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasCircularesT
{
    internal class Lista
    {
        public Nodo nodoInicial;
        public Nodo ultimoNodo;

        public Lista()
        {
            nodoInicial = null;
            ultimoNodo = null;
        }
        public void IniciarNodo(String dato)
        {
            Nodo nuevoNodo = new Nodo(dato);
            if (nodoInicial == null)
            {
                nodoInicial = nuevoNodo;
                nodoInicial.Siguiente = nodoInicial;
                ultimoNodo = nodoInicial;
                //Asignamos a nodo inicial el valor recogido en nuevo nodo. El nodo incial, en su propiedad siguiente sera igual a nodoInicial.
                //El ultimo nodo tendra el valor de nodoInicial.
            }
            else
            {
                ultimoNodo.Siguiente = nuevoNodo;
                nuevoNodo.Siguiente = nodoInicial;
                ultimoNodo = nuevoNodo;
                //El ultimo nodo en su propiedad siguiente, apuntara hacia nuevoNodo.
                //El nuevo nodo, hara referencia a su nodo Inicial, despues al ultimo nodo le asignamos el valor de nuevoNodo
                //Anteriormente ultimo nodo = Dato anterior (Antes de if, en caso de no cumplir condicion, se le asigna el nuevo valor.) 
            }

        }
        public void DespliegueLista()
        {
            Nodo desp = new Nodo();
            desp = nodoInicial;
            if (desp != null)
            {
                //Recorrido de lista
                do
                {
                    Console.WriteLine("DATOS EN LISTA :" + desp.dato);
                    desp = desp.Siguiente;

                } while (desp != nodoInicial);
            }
            else
            {
                Console.WriteLine("La lista esta vacia");
            }

        }
        public void BuscarNodo(String datos)
        {
            Nodo desp = new Nodo();
            desp = nodoInicial;
            bool foundit = false;
            if (desp != null)
            {
                //Recorrido de lista
                do
                {
                    if (desp.dato == datos)
                    {
                        Console.WriteLine("Se ha encontrado el nodo: " + desp.dato);
                        foundit = true;
                    }
                    desp = desp.Siguiente;
                } while (desp != nodoInicial && foundit != true);
                if (!foundit)
                {
                    Console.WriteLine("NODO NO ENCONTRADO!");
                }
            }
            else
            {
                Console.WriteLine("La lista esta vacia");
            }
        }
        public void EliminarNodo(String datos)
        {
            Nodo actual = new Nodo();
            Nodo anterior = new Nodo();
            actual = nodoInicial;
            anterior = null;
            bool foundit = false;
            if (actual != null)
            {
                do
                {
                    if (actual.dato == datos)
                    {

                        if (actual == nodoInicial)
                        {
                            nodoInicial = nodoInicial.Siguiente;
                            ultimoNodo.Siguiente = nodoInicial;
                        }
                        else if (actual == ultimoNodo)
                        {
                            anterior.Siguiente = nodoInicial;
                            ultimoNodo = anterior;
                        }
                        else
                        {
                            anterior.Siguiente = actual.Siguiente;
                        }
                        Console.WriteLine("Nodo eliminado correctamente!");
                        foundit = true;
                    }
                    anterior = actual;
                    actual = actual.Siguiente;
                } while (actual != nodoInicial && foundit != true);
                if (!foundit)
                {
                    Console.WriteLine("NO ENCONTRADO!");
                }
            }
            else { Console.WriteLine("LISTA VACIA!"); }
        }



    }
}
