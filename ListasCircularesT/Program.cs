using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasCircularesT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lista l = new Lista();
            Console.WriteLine("LISTAS SIMPLES CIRCULARES!\nINGRESA OPCION.\nA:INSERTAR DATOS \nB:BUSCAR NODO\nC:ELIMINAR NODO.\nD:MOSTRAR LISTA");
            char eleccion= (char)Console.Read();
            switch (eleccion) {
                case 'A': {
                        Console.WriteLine("INGRESA EL DATO");
                        string dat = Console.ReadLine();
                        l.IniciarNodo(dat);
                        break;
                    }
                case 'B':{
                        Console.WriteLine("INGRESA NODO A BUSCAR!");
                        string dat = Console.ReadLine(); 
                        l.BuscarNodo(dat);
                        break;
                    }
                case 'C':
                    {
                        Console.WriteLine("INGRESA EL NODO A ELIMINAR");
                        string dat = Console.ReadLine();
                        l.EliminarNodo(dat);
                        break;
                    }
                case 'D': {
                        l.DespliegueLista();
                        break;
                    }
                default: { 
                    Console.WriteLine("NOT ALLOWE INSTRUCTION");
                        break;
                    }
            }
        }
    }
}
