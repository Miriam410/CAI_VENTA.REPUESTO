using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Libreria.Clases.Helpers
{
   
    public static class ConsolaHelper
    {
        public static string PedirString(string msg)
        {
            Console.WriteLine("Ingrese" + msg);
            string n = Console.ReadLine();
            return n;
        }
        public static int PedirInt(string msg)
        {
            Console.WriteLine("Ingrese" + msg);
            int c = Convert.ToInt32(Console.ReadLine());
            return c;
        }

        public static double PedirDouble(string msg)
        {
            Console.WriteLine("Ingrese" + msg);
            double p = Convert.ToSingle(Console.ReadLine());
            return p;
        }

        public static bool EsOpcionValida(string input, string OpcionValida)
        {
            try
            {
                if (string.IsNullOrEmpty(input) || input.Length > 1 || !OpcionValida.ToUpper().Contains(input.ToUpper()))
                {
                    return false;
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
