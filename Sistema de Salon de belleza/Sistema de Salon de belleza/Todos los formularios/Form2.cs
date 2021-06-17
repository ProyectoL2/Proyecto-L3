using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Salon_de_belleza
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //var form1 = new Form1();
           //form1.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form3 = new Todos_los_formularios.Productos();
            form3.ShowDialog();
        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void seguridadToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form1 = new Form1();
            form1.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var form4 = new Todos_los_formularios.Reportes();
            form4.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var form6 = new Todos_los_formularios.Proveedores();
            form6.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var form5 = new Todos_los_formularios.Clientes();
            form5.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var form7 = new Todos_los_formularios.Citas();
            form7.ShowDialog();
        }

        private void salirToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            
        }
    }
}
