using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Libreria.Clases
{
    public class Categoria
    {
        private int _codigo;
        private string _nombre;

        public int Codigo
        {
            get 
            {
                return _codigo;
            }
          
        }

        public string Nombre
        {
            get
            {
                return _nombre;
            }

        }

        public Categoria(int codigo, string nombre)
        {
            this._codigo = codigo;
            this._nombre = nombre;
        }

        public override string ToString()
        {
            return this.Nombre;
        }
    }
}
