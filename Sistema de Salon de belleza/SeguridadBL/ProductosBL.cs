using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Rentas 
{
   public  class ProductosBL
    {
        public BindingList<Producto> ListaProductos { get; set;  }

        public ProductosBL()
        {
            ListaProductos = new BindingList<Producto>();

            var Producto1 = new Producto();
            Producto1.Id = 001;
            Producto1.Descripcion = "Plancha de Ceramica";
            Producto1.Marca = "Remington S9500 Pearl";
            Producto1.Precio = 5000;
            Producto1.Existencia = 5;
            Producto1.Activo = true;

            ListaProductos.Add(Producto1);

            var Producto2 = new Producto();
            Producto2.Id = 002;
            Producto2.Descripcion = "Delantal para estilistas.";
            Producto2.Marca = "LCL Beauty ";
            Producto2.Precio = 50;
            Producto2.Existencia = 100;
            Producto2.Activo = true;

            ListaProductos.Add(Producto2);

            var Producto3 = new Producto();
            Producto3.Id = 003;
            Producto3.Descripcion = "Sillón reclinable hidráulico.";
            Producto3.Marca = "Heavy Duty  ";
            Producto3.Precio = 1500;
            Producto3.Existencia = 4;
            Producto3.Activo = true;

            ListaProductos.Add(Producto3);
        }
        public BindingList<Producto> ObtenerProductos()
        {
            return ListaProductos;
        }
    }
public class Producto
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public string Marca { get; set; }
        public double Precio { get; set; }
        public int Existencia { get; set; }
        public bool Activo { get; set; }
    }
}

