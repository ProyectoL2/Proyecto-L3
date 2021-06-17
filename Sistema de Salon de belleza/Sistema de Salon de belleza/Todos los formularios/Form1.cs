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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox1.Checked == true)
            TextBox2.UseSystemPasswordChar = false;
            else
                TextBox2.UseSystemPasswordChar = true;
            
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Panel1.BackColor = Color.FromArgb(100, 0, 0, 0);

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string usuario1,usuario2;
            string contraseña1, contraseña2;

            usuario1 = "Henry"; usuario2 = "Gladis";
            contraseña1 = "Henry19"; contraseña2 = "Gladis15";
            
            if ((TextBox1.Text == usuario1 && TextBox2.Text == contraseña1) || (TextBox1.Text == usuario2 && TextBox2.Text == contraseña2))
            {
                MessageBox.Show ("--- BIENVENIDO ---");
               
                this.Close();
                
            }             
        else
            {
                MessageBox.Show("--Contraseña o usuario incorrecto--");
            }

        }
    }
}
