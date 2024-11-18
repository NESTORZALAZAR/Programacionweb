﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnusuarios_Click(object sender, EventArgs e)
        {
            DatosForm datosForm = new DatosForm();
            // Cargar los datos de la tabla 'usuario'
            string query = "SELECT * FROM usuario";
            datosForm.CargarDatos(query);
            datosForm.ShowDialog();
        }

        private void btnciudades_Click(object sender, EventArgs e)
        {
            DatosForm datosForm = new DatosForm();
            // Cargar los datos de la tabla 'ciudad'
            string query = "SELECT * FROM ciudad";
            datosForm.CargarDatos(query);
            datosForm.ShowDialog();
        }

        private void btnproductos_Click(object sender, EventArgs e)
        {
            DatosForm datosForm = new DatosForm();
            // Cargar los datos de la tabla 'producto'
            string query = "SELECT * FROM producto";
            datosForm.CargarDatos(query);
            datosForm.ShowDialog();
        }

        private void btnclientes_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario de datos
            DatosForm datosForm = new DatosForm();
            // Cargar los datos de la tabla 'cliente'
            string query = "SELECT * FROM cliente";
            datosForm.CargarDatos(query);
            datosForm.ShowDialog();
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario de datos
            DatosForm datosForm = new DatosForm();
            // Cargar los datos de la tabla 'proveedor'
            string query = "SELECT * FROM proveedor";
            datosForm.CargarDatos(query);
            datosForm.ShowDialog();
        }

        private void btnCompra_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario de datos
            DatosForm datosForm = new DatosForm();
            // Cargar los datos de la tabla 'compra'
            string query = "SELECT * FROM compra";
            datosForm.CargarDatos(query);
            datosForm.ShowDialog();
        }

        private void btnVenta_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario de datos
            DatosForm datosForm = new DatosForm();
            // Cargar los datos de la tabla 'venta'
            string query = "SELECT * FROM venta";
            datosForm.CargarDatos(query);
            datosForm.ShowDialog();
        }

        private void btnCobro_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario de datos
            DatosForm datosForm = new DatosForm();
            // Cargar los datos de la tabla 'cobro'
            string query = "SELECT * FROM cobro";
            datosForm.CargarDatos(query);
            datosForm.ShowDialog();
        }
    }
}
