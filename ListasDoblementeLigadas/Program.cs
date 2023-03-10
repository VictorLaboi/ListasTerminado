using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasDoblementeLigadas
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
                            Console.WriteLine("1:AGREGAR INICIO/2:AGREGAR FINAL");
                            des = int.Parse(Console.ReadLine());
                            if (des == 1)
                            {
                                Console.WriteLine("INGRESA EL DATO");
                                string dat = Console.ReadLine();
                                l.IngresoDatos(dat);
                            }
                            else if (des == 2)
                            {
                                Console.WriteLine("INGRESA EL DATO");
                                string dat = Console.ReadLine();
                                l.AgregarFinal(dat);
                            }
                            Console.WriteLine("DESEA TERMINAR? N: NO|| S:SI");
                            op = Convert.ToChar(Console.ReadLine().ToLower());
                        } while (op == 'n' || op == 'N');
                        break;
                    case 2:
                        do
                        {
                            Console.WriteLine("INGRESA NODO A BUSCAR!");
                            string dat1 = Console.ReadLine();
                            l.Buscar(dat1);
                            Console.WriteLine("DESEA TERMINAR? N: NO|| S:SI");
                            op = Convert.ToChar(Console.ReadLine().ToLower());
                        } while (op == 'n' || op == 'N');
                        break;
                    case 3:
                        do
                        {
                            Console.WriteLine("INGRESA NODO A ELIMINAR");
                            String valu = Console.ReadLine();
                            l.EliminarNodo(valu);
                            Console.WriteLine("DESEA TERMINAR? N: NO|| S:SI");
                            op = Convert.ToChar(Console.ReadLine().ToLower());
                        } while (op == 'n' || op == 'N');
                        break;
                    case 4:
                        l.RecorrerLista();
                        break;
                }
            } while (character != 6);
            Console.ReadKey();
            Console.ReadKey();
        }
    }
}
