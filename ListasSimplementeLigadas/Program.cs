using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasSimplementeLigadas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lista l = new Lista();
            int character = 0;
            do
            {
                Console.WriteLine("\nLISTAS SIMPLES CIRCULARES!\nINGRESA OPCION.\n1:INSERTAR DATOS \n2:BUSCAR NODO\n3:ELIMINAR NODO.\n4:MOSTRAR LISTA\nINGRESA '6' PARA SALIR");
                character = int.Parse(Console.ReadLine());
                switch (character)
                {
                    case 1:
                        char op;
                        int des;
                        do
                        {
                            Console.WriteLine("1:AGREGAR FINAL/2:AGREGAR INICIO");
                            des = int.Parse(Console.ReadLine());
                            if (des == 1)
                            {
                                Console.WriteLine("INGRESA EL DATO");
                                string dat = Console.ReadLine();
                                l.Agregar(dat);
                            }
                            else if (des == 2)
                            {
                                Console.WriteLine("INGRESA EL DATO");
                                string dat = Console.ReadLine();
                                l.AgregarNodoInicio(dat);
                            }
                            Console.WriteLine("DESEA TERMINAR? N: NO|| S:SI");
                            op = Convert.ToChar(Console.ReadLine().ToLower());
                        } while (op == 'n' || op == 'N');
                        break;
                    case 2:
                        do
                        {
                            Console.WriteLine("1:BUSCAR NODO/2:BUSCAR INDICE/3:BUSCAR ANTERIOR A 'X' VALOR ");
                            des = int.Parse(Console.ReadLine());
                            if (des == 1)
                            {
                                Console.WriteLine("INGRESA NODO A BUSCAR!");
                                string dat1 = Console.ReadLine();
                                l.Buscar(dat1);
                            }
                            else if (des == 2)
                            {
                                Console.WriteLine("INGRESA INDICE A BUSCAR!");
                                int dat2 = int.Parse(Console.ReadLine());
                                l.BuscarPorIndice(dat2) ;
                            }
                            else if (des == 3)
                            {
                                Console.WriteLine("INGRESA INDICE A BUSCAR!");
                                String dat2 = Console.ReadLine();
                                l.BuscarAnterior(dat2);
                            }
                            else {
                                Console.WriteLine("OPCION INEXISTENTE!");
                            }
                            Console.WriteLine("DESEA TERMINAR? N: NO|| S:SI");
                            op = Convert.ToChar(Console.ReadLine().ToLower());
                        } while (op == 'n' || op == 'N');
                        break;
                    case 3:
                        do
                        {
                            Console.WriteLine("1:BORRAR POR NODO/2:BORRAR LISTA FULL");
                            des = int.Parse(Console.ReadLine());
                            if (des == 1)
                            {
                                Console.WriteLine("INGRESE NODO A BORRAR");
                                String es = (Console.ReadLine());
                                l.BorrarNodo(es);
                            }
                            else if (des == 2)
                            {
                                l.VaciarLista();
                            }
                            else { Console.WriteLine("OPCION NO DISPONIBLE!"); }
                            Console.WriteLine("DESEA TERMINAR? N: NO|| S:SI");
                            op = Convert.ToChar(Console.ReadLine().ToLower());
                        } while (op == 'n' || op == 'N');
                        break;
                    case 4:
                        l.Recorrer();
                        break;
                }
            } while (character != 6);
            Console.ReadKey();
        }
    }
}
