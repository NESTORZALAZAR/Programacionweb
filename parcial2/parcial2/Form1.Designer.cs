namespace parcial2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnCiudades = new System.Windows.Forms.Button();
            this.btnProductos = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(395, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "CONSULTAS";
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Location = new System.Drawing.Point(104, 164);
            this.btnUsuarios.Margin = new System.Windows.Forms.Padding(4);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(220, 58);
            this.btnUsuarios.TabIndex = 1;
            this.btnUsuarios.Text = "USUARIOS";
            this.btnUsuarios.UseVisualStyleBackColor = true;
            this.btnUsuarios.Click += new System.EventHandler(this.btnusuarios_Click);
            // 
            // btnCiudades
            // 
            this.btnCiudades.Location = new System.Drawing.Point(403, 164);
            this.btnCiudades.Margin = new System.Windows.Forms.Padding(4);
            this.btnCiudades.Name = "btnCiudades";
            this.btnCiudades.Size = new System.Drawing.Size(220, 58);
            this.btnCiudades.TabIndex = 2;
            this.btnCiudades.Text = "CIUDADES";
            this.btnCiudades.UseVisualStyleBackColor = true;
            this.btnCiudades.Click += new System.EventHandler(this.btnciudades_Click);
            // 
            // btnProductos
            // 
            this.btnProductos.Location = new System.Drawing.Point(684, 164);
            this.btnProductos.Margin = new System.Windows.Forms.Padding(4);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(220, 58);
            this.btnProductos.TabIndex = 3;
            this.btnProductos.Text = "PRODUCTOS";
            this.btnProductos.UseVisualStyleBackColor = true;
            this.btnProductos.Click += new System.EventHandler(this.btnproductos_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.Location = new System.Drawing.Point(403, 290);
            this.btnClientes.Margin = new System.Windows.Forms.Padding(4);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(220, 58);
            this.btnClientes.TabIndex = 4;
            this.btnClientes.Text = "CLIENTES";
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnclientes_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(104, 290);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(220, 58);
            this.button1.TabIndex = 5;
            this.button1.Text = "PROVEEDORES";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(684, 290);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(220, 58);
            this.button2.TabIndex = 6;
            this.button2.Text = "COMPRA";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(104, 397);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(220, 58);
            this.button3.TabIndex = 7;
            this.button3.Text = "VENTA";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(402, 397);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(220, 58);
            this.button4.TabIndex = 8;
            this.button4.Text = "COBRO";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnClientes);
            this.Controls.Add(this.btnProductos);
            this.Controls.Add(this.btnCiudades);
            this.Controls.Add(this.btnUsuarios);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Button btnCiudades;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

