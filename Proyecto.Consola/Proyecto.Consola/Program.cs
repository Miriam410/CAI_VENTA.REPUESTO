using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto.Libreria.Clases;
using Proyecto.Libreria.Clases.Helpers;

namespace Proyecto.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            bool Activo = true;

            string menu = ("1.Agregar Puesto" + Environment.NewLine + "2.Quitar Repuesto" + Environment.NewLine +
                "3.Modificar Precio" + Environment.NewLine + "4. Agregar Stock" + Environment.NewLine +
                "5. Quitar Stock" + Environment.NewLine + "6. Traer Por Categoria" + Environment.NewLine +
                "7. Salir");

            VentaRepuesto VR = new VentaRepuesto("Venta S.A");

            Console.WriteLine("Bienvenido a " + VR.NombreComercio);

            do
            {
                Console.WriteLine(menu);
                try
                {
                    string OpcionSeleccionada = Console.ReadLine();
                    if (ConsolaHelper.EsOpcionValida(OpcionSeleccionada, "1234567"))
                    {
                        if (OpcionSeleccionada.ToUpper() == "Salir")
                        {
                            Activo = false;
                            continue;
                        }
                        switch (OpcionSeleccionada)
                        {
                            case "1":
                                Program.AgregarRepuesto(VR);
                                break;
                            case "2":
                                Program.QuitarRepuesto(VR);
                                break;
                            case "3":
                                Program.ModificarPrecio(VR);
                                break;
                            case "4":
                                Program.AgregarStock(VR);
                                break;
                            case "5":
                                Program.QuitarStock(VR);
                                break;
                            case "6":
                                Program.TraerPorCategoria(VR);
                                break;
                            case "7":
                                Console.Clear();
                                break;
                            default:
                                Console.WriteLine("La opcion elegida no es válida");
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("La opcion elegida no es válida");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error durante la ejecucion del comando. Intente nuevamente" + ex.Message);
                }
                Console.WriteLine("Ingrese una tecla para salir");
                Console.ReadKey();
                Console.Clear();
            } while (Activo);
            Console.WriteLine("Gracias por usar la APP");
            Console.ReadKey();
        }

        public static void AgregarRepuesto(Repuesto repuesto)
        {
            try
            {
                int c = ConsolaHelper.PedirInt("Codigo");
                string n = ConsolaHelper.PedirString("Nombre");
                double p = ConsolaHelper.PedirDouble("Precio");
                int s = ConsolaHelper.PedirInt("Stock");

                repuesto.AgregarRepuesto(c,n,p,s);
                Console.WriteLine("Repuesto agregado");
            }
            catch (Exception ex)
            {
                Console.WriteLine("No ingreso bien. Vuelva a ingresar" + ex.Message);
            }
        }

        public static void QuitarRepuesto(codigo)
        {
        }

        public static void ModificarPecio(codigo, precio)
        {
            Console.WriteLine();
        }

        public static void AgregarStock(codigo, stock)
        { 
        }

        public static void QuitarStock(codido, stock)
        { 
        }

        public static List<Repuesto> TraerCategoriaPorRepuesto()
        {
            return  Proyecto.Libreria.Clases.Helpers.CategoriaHelper._Listacategoria;
        }

        public static Categoria TraerPorCategoria(int codigo)
        {
            Categoria Cat = null;
            foreach (Categoria C in _Listacategoria)
            {
                if (C.Codigo == codigo)
                {
                    Cat = C;
                }
            }
            return Cat;
        }
    }
}
