using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ListasCircularesT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lista l = new Lista();
            int character = 0;
            do {
                Console.WriteLine("\nLISTAS SIMPLES CIRCULARES!\nINGRESA OPCION.\n1:INSERTAR DATOS \n2:BUSCAR NODO\n3:ELIMINAR NODO.\n4:MOSTRAR LISTA\nINGRESA '6' PARA SALIR");
                character = int.Parse(Console.ReadLine());
                switch (character) 
                {
                    case 1:
                        char op;
                        do {
                            Console.WriteLine("INGRESA EL DATO");
                            string dat = Console.ReadLine();
                            l.IniciarNodo(dat);
                            Console.WriteLine("DESEA TERMINAR? N: NO|| S:SI");
                            op = Convert.ToChar(Console.ReadLine().ToLower());
                        } while (op == 'n' || op == 'N');
                        break;
                    case 2:
                        do
                        {
                            Console.WriteLine("INGRESA NODO A BUSCAR!");
                            string dat1 = Console.ReadLine();
                            l.BuscarNodo(dat1);
                            Console.WriteLine("DESEA TERMINAR? N: NO|| S:SI");
                            op = Convert.ToChar(Console.ReadLine().ToLower());
                        } while (op == 'n' || op == 'N');
                        break;

                    case 3:
                        do
                        {
                            Console.WriteLine("INGRESA EL NODO A ELIMINAR");
                            string dat2 = Console.ReadLine();
                            l.EliminarNodo(dat2);
                            Console.WriteLine("DESEA TERMINAR? N: NO|| S:SI");
                            op = Convert.ToChar(Console.ReadLine().ToLower());
                        } while (op == 'n' || op == 'N');
                        break;
                    case 4:
                        l.DespliegueLista();
                        break;
                }
            } while (character!=6);
            Console.ReadKey();
        }
    }
}
