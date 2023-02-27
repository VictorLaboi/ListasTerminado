using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasCircularesT
{
    internal class Nodo
    {
        public Nodo Siguiente;
        public String dato;

        public Nodo(String dat = "", Nodo siguiente = null)
        {
            dato = dat;
            Siguiente = siguiente;
        }
    }
}
