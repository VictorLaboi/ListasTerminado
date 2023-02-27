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
        public Nodo anterior;
        public Lista() {
            siguiente = null;
            anterior = null;
        }
        public bool ValidaVacio() { 
            return siguiente == null;
        }
        public void VaciarLista() {
            siguiente = null;
            anterior = null;
        }
        public void IngresoDatos() { 
            Nodo dat = new Nodo();
            if (siguiente == null)
            {
                siguiente = dat;
                anterior = dat;
            }
            else
            {
                dat.Siguiente = siguiente;
                anterior.anterior = dat;
                anterior = dat;
            }
        }
        public void AgregarFinal(string datos)
        {
            Nodo nuevoNodo = new Nodo(datos);

            if (siguiente == null)
            {   
                siguiente = nuevoNodo;
                anterior = nuevoNodo;
            }
            else
            {
                nuevoNodo.anterior = anterior;
                anterior.Siguiente = nuevoNodo;
                anterior = nuevoNodo;
            }
        }
        public void EliminarNodo(String datos)
        {
            Nodo actual = new Nodo();
            Nodo anteriori = new Nodo();
            actual = siguiente;
            anteriori = null;
            bool foundit = false;
            if (actual != null)
            {
                do
                {
                    if (actual.datos == datos)
                    {

                        if (actual == siguiente)
                        {
                            siguiente = siguiente.Siguiente;
                            anterior.Siguiente = siguiente;
                        }
                        else if (actual == anterior)
                        {
                            anterior.Siguiente = siguiente;
                            anterior = anteriori;
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
                } while (actual != siguiente && foundit != true);
                if (!foundit)
                {
                    Console.WriteLine("NO ENCONTRADO!");
                }
            }
            else { Console.WriteLine("LISTA VACIA!"); }
        }
    }
}
