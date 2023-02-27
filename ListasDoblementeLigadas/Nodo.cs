using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasDoblementeLigadas
{
    internal class Nodo
    {
        public String datos;
        public Nodo anterior;
        public Nodo Siguiente;
        public Nodo(String dat = "", Nodo ant = null, Nodo sig = null) { 
            this.anterior = ant;
            this.datos = dat;
            this.Siguiente = sig;
        }
    }
}
