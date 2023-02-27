using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasDoblesCirculares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lista Lista= new Lista();
            Console.WriteLine("Lista:");
            Lista.Agregar("Cuatro");
            Lista.Agregar("Tres");
            Lista.Agregar("Dos");
            Lista.AgregarFinal("Cinco");
            Lista.Agregar("Uno");
            Lista.Recorrer();
            Console.WriteLine("");
            Console.WriteLine("Buscar Nodo Tres:");
            Lista.EncontrarNodo("Tres");
            Console.WriteLine("");
            Console.WriteLine("Eliminar Ultimo Nodo:");
            Lista.EliminarFinal();
            Lista.Recorrer();
            Console.WriteLine("");
            Console.WriteLine("Eliminar Primer Nodo:");
            Lista.EliminarInicio();
            Lista.Recorrer();


            Console.ReadKey();
        }
    }
}
