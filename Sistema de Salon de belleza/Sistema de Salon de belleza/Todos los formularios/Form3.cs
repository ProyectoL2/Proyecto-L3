using BL.Rentas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Salon_de_belleza.Todos_los_formularios
{
    public partial class FormProductos : Form
    {

        ProductosBL _productos;

        public FormProductos() 
        {
            InitializeComponent();

            _productos = new ProductosBL();
            ListaProductosBindingSource.DataSource = _productos.ObtenerProductos();
        }

        private void Productos_Load(object sender, EventArgs e)
        {

        }

        private void productoBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
