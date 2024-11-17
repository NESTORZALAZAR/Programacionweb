using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace parcial2
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string password = txtPassword.Text;

            using (var conn = DatabaseConnection.Connect()) // Usamos la clase de conexión
            {
                // Consulta para validar las credenciales del usuario
                string query = "SELECT COUNT(*) FROM usuario WHERE usu_nombre = @usuario AND usu_password = @password";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@usuario", usuario);
                    cmd.Parameters.AddWithValue("@password", password);

                    // Ejecutamos la consulta
                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    if (count > 0)
                    {
                        // Si la consulta devuelve 1, el usuario es válido
                        MessageBox.Show("Inicio de sesión exitoso");

                        // Cerrar el formulario de login y abrir el formulario principal
                        this.Hide();
                        Form1 mainForm = new Form1();  // Asegúrate de tener este formulario creado.
                        mainForm.Show();
                    }
                    else
                    {
                        // Si no, las credenciales son incorrectas
                        MessageBox.Show("Nombre de usuario o contraseña incorrectos");
                    }
                }

                DatabaseConnection.CloseConnection(conn); // Cerrar conexión
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
