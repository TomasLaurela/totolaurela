using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Mantenimiento : Form
    {
        //codigo de inicio principal
        int x = 0;
        ArrayList aProducto = new ArrayList();
        public Mantenimiento()
        {
            InitializeComponent();
        }
        public void generarCodigo()
        {
            x++;
            lblCodNumero.Text = "00" + x.ToString(); // el codigo se va a generar automaticamente y se le va a sumar uno al anterior, en la etiqueta codigo 

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Mantenimiento_Load(object sender, EventArgs e)
        {
            generarCodigo();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Producto objP = new Producto();
            objP.codigo = int.Parse(lblCodNumero.Text);
            objP.nombre = txtNombre.Text;
            objP.precio = double.Parse(txtPrecio.Text);
            objP.stock = int.Parse(txtStock.Text);

            foreach (Producto P in aProducto) //si hay un mismo producto ya guardado no pasa.
            {


                ///(p.nombre.Equals(objP.nombre));
            }

            aProducto.Add(objP);
            listado();
            generarCodigo();
        }

        public void listado()
        {
            lvProductos.Items.Clear();
            foreach (Producto p in aProducto)
            {
                ListViewItem fila = new ListViewItem(p.codigo.ToString());
                fila.SubItems.Add(p.nombre);
                fila.SubItems.Add(p.precio.ToString());
                fila.SubItems.Add(p.stock.ToString());
                lvProductos.Items.Add(fila);
            }

        }

        private void lvProductos_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewItem indice = lvProductos.GetItemAt(e.X, e.Y);

            lbCodigo.Text = indice.SubItems[0].Text;
            txtNombre.Text = indice.SubItems[1].Text;
            txtPrecio.Text = indice.SubItems[2].Text;
            txtStock.Text = indice.SubItems[3].Text;



        }

        private void btnModificar_click(object sender, EventArgs e)
        {
            foreach (Producto p in aProducto)
            {
                if (p.codigo == int.Parse(lbCodigo.Text))
                {
                    p.nombre = txtNombre.Text;
                    p.precio = double.Parse(txtPrecio.Text);
                    p.stock = int.Parse(txtStock.Text);
                }
                lvProductos.Items.Clear();
                listado();


            }
        }

        private void Mantenimiento_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }


        private void btnModificar_Click(object sender, EventArgs e)
        {
            foreach (Producto p in aProducto)
            {
                if (p.codigo == int.Parse(lbCodigo.Text))
                {
                    p.nombre = txtNombre.Text;
                    p.precio = double.Parse(txtPrecio.Text);
                    p.stock = int.Parse(txtStock.Text);
                }
                lvProductos.Items.Clear();
                listado();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            foreach (Producto p in aProducto)
            {
                if (p.codigo == int.Parse(lbCodigo.Text))
                {
                    aProducto.Remove(p);
                    break;

                }
            }
            lvProductos.Items.Clear();
            listado();

        }

    }
}
