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

    }
}
