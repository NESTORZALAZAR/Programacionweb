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
    public partial class DatosForm : Form
    {
        public DatosForm()
        {
            InitializeComponent();
        }

        private void DatosForm_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }
        public void CargarDatos(string query)
        {
            using (var conn = DatabaseConnection.Connect())
            {
                try
                {
                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        DataTable dt = new DataTable();
                        NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                        da.Fill(dt);
                        dataGridView2.DataSource = dt;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los datos: " + ex.Message);
                }
                finally
                {
                    DatabaseConnection.CloseConnection(conn);
                }
            }
        }
    }
}

       
    

