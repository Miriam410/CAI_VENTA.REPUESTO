using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Libreria.Clases
{
    public class VentaRepuesto
    {
        private List<Repuesto> _listaProductos;
        private string _nombreComercio;
        private string _direccion;

        public List<Repuesto> Repuestos
        {
            get 
            { 
                return this._listaProductos; 
            }
        }
        public string NombreComercio
        {
            get 
            {
                return _nombreComercio;
            }
        }
    
        public string Direccion
        {
            get
            {
                return _direccion;
            }
        }

        public VentaRepuesto()
        { 
        }
        public VentaRepuesto(string NombreComercio)
        {
            this._nombreComercio = NombreComercio;
            this._listaProductos = new List<Repuesto>();
            this._direccion = Direccion;
        }

        public void AgregarRepuesto(Repuesto repuesto)
        {
            if(this._listaProductos.SingleOrDefault(x=>x.Codigo == repuesto.Codigo) !=null)
            {
                throw new Exception("Hay repuesto");
            }
            this.Repuestos.Add(repuesto);  
        }

        public void AgregarRepuesto(int codigo, string nombre, double precio, int stock)
        {
            Repuesto R = new Repuesto(codigo, nombre, precio, stock);
            this.AgregarRepuesto(R);
        }
        
        public void QuitarRepuesto(int codigo)
        {
        }

        public void ModificarPecio(int codigo, double precio)
        {
        }

        public void AgregarStock(int codigo, int stock)
        {
            if (this._listaProductos.SingleOrDefault(x=>x.Codigo==codigo) != null)
            {
                throw new Exception("Hay producto");
            }
            this._listaProductos.Add(codigo);
        }

        public List<Repuesto> BuscarRepuesto(string txt)
        {
            return this._listaProductos.Where(x => x.Codigo().ToLower().Constains(txt).ToList());
        }
        public void QuitarStock(int codido, int stock)
        {
            
        }

        public List<Repuesto> TraerPorCategoria(int CodigoCategoria)
        {
            List<Repuesto> Lista = new List<Repuesto>;
            foreach (Repuesto R in _listaProductos)
            {
                if (CodigoCategoria == R.Codigo)
                {
                    Lista.Add(R);
                }
            }
            return Lista;
        }
    }

}
