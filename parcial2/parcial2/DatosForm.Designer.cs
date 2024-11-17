namespace parcial2
{
    partial class DatosForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private System.Windows.Forms.DataGridView dataGridViewDatos;

        private void InitializeComponent()
        {
            this.dataGridViewDatos = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDatos
            // 
            this.dataGridViewDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDatos.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewDatos.Name = "dataGridView2";
            this.dataGridViewDatos.Size = new System.Drawing.Size(776, 426);
            this.dataGridViewDatos.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(13, 23);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(667, 452);
            this.dataGridView2.TabIndex = 0;
            // 
            // DatosForm
            // 
            this.ClientSize = new System.Drawing.Size(696, 491);
            this.Controls.Add(this.dataGridView2);
            this.Name = "DatosForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}