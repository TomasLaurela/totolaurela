using Microsoft.VisualBasic.ApplicationServices;
using System.Collections.Generic;
using System.Data.OleDb;

namespace Programa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Inicio Ini = new Inicio(); 
            Form1 F1 = new Form1();

            string usuario = txtUsuario.Text; //se guarda lo que haya en el textbox txtusuario a la variable usuario
            string contraseña = txtContraseña.Text; //guardo lo que haya en el textbox txtcontraseña en la variable contraseña

            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\TomasLaurela\Desktop\trabajo\Base de datos2.accdb;Persist Security Info=False;"; //creamos la cadena de conexion
            OleDbConnection connection = new OleDbConnection(connectionString); //creamos la conexion con nuestra base de datos access

            string consulta = "SELECT * FROM Usuarios WHERE Usuario=@txtUsuario AND Contraseña=@txtContraseña";  //realizamos y guardamos nuestra consulta en la variable consulta
            OleDbCommand command = new OleDbCommand(consulta, connection); //ejecutamos la consulta para que busque en la base de datos
            connection.Open(); //abrimos la conexión
            command.Parameters.AddWithValue("@Usuario", usuario); //agregamos los valores de nuestra consulta, en este caso el usuario y contraseña que estan en los textbox
            command.Parameters.AddWithValue("@Contraseña", contraseña);

            OleDbDataReader reader = command.ExecuteReader(); //ejecutamos nuestra consulta 
            bool loginExitoso = reader.Read(); //funcion read que guardara un true en loginexitoso para validar nuestros datos de usuario
            reader.Close();
            connection.Close();


            if (loginExitoso) //si el login es exitoso nos dara la bienvenida con el nombre de usuario, nos ocultara la ventana actual y nos abrira un formulario nuevo
            {
                Hide();
                MessageBox.Show("Bienvenido, " + usuario + ".");
                Ini.Show();
            }
            else //si el login tiene datos incorrectos nos mostrara un mensaje de usuario o contraseña incorrectas
            {
                MessageBox.Show("Usuario o contraseña incorrectos.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}