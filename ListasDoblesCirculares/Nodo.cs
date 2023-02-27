using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ListasDoblesCirculares
{
    internal class Nodo
    {
        public String dato;
        public Nodo siguiente;
        public Nodo anterior;
        public Nodo(String dat = "", Nodo ant = null, Nodo siguientea = null) {
            this.dato= dat;
            this.siguiente = siguientea;
            this.anterior = ant;
        }
    }
}
