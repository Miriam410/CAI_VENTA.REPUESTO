using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Libreria.Clases
{
    public class Repuesto
    {
        private int _codigo;
        private string _nombre;
        private double _precio;
        private int _stock;
        private Categoria _categoria;

        public int Codigo
        {
            get
            {
                return _codigo;
            }
            set
            {
                _codigo = value;    
            }
        }
        public string Nombre
        {
            get
            {
                return _nombre;
            }
            set
            {
                _nombre = value;
            }
        }

        public double Precio
        {
            get
            {
                return _precio;
            }
            set
            {
                this._precio = value;
            }
        }

        public Categoria Categoriaa
        {
            get 
            { 
                return _categoria; 
            }
            set
            {
                this._categoria = value;
            }
        }

        public Repuesto(int codigo, string nombre, double precio, int stock)
        {
            this._codigo = codigo;
            this._nombre = nombre;
            this._precio = precio;
            this._stock = stock;
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
