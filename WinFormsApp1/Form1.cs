using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtClave.Clear();
            txtUsuario.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "administrador" && txtClave.Text == "administrador")
            {
                Mantenimiento Mantenimiento = new Mantenimiento();
                this.Hide();
                Mantenimiento.Show();

            }
            else
            {
                MessageBox.Show("datos ingresados incorrectos");
                txtUsuario.Clear();
                txtClave.Clear();

            }
        }

        private void lblUsuario_Click(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
