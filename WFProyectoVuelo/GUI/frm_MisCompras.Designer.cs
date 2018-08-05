namespace WFProyectoVuelo.GUI
{
    partial class frm_MisCompras
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
        private void InitializeComponent()
        {
            this.dgv_Compras = new System.Windows.Forms.DataGridView();
            this.idcompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.origen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.letra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.posicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Compras)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Compras
            // 
            this.dgv_Compras.AllowUserToAddRows = false;
            this.dgv_Compras.AllowUserToDeleteRows = false;
            this.dgv_Compras.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Compras.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Compras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Compras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idcompra,
            this.nomus,
            this.origen,
            this.destino,
            this.fecha,
            this.numero,
            this.letra,
            this.posicion,
            this.precio});
            this.dgv_Compras.Location = new System.Drawing.Point(99, 244);
            this.dgv_Compras.Name = "dgv_Compras";
            this.dgv_Compras.ReadOnly = true;
            this.dgv_Compras.RowTemplate.Height = 24;
            this.dgv_Compras.Size = new System.Drawing.Size(1161, 371);
            this.dgv_Compras.TabIndex = 1;
            // 
            // idcompra
            // 
            this.idcompra.DataPropertyName = "Id_Boleto";
            this.idcompra.HeaderText = "Clave";
            this.idcompra.Name = "idcompra";
            this.idcompra.ReadOnly = true;
            // 
            // nomus
            // 
            this.nomus.DataPropertyName = "NombreUsuario";
            this.nomus.HeaderText = "Nombre del usuario";
            this.nomus.Name = "nomus";
            this.nomus.ReadOnly = true;
            // 
            // origen
            // 
            this.origen.DataPropertyName = "Origen";
            this.origen.HeaderText = "Origen";
            this.origen.Name = "origen";
            this.origen.ReadOnly = true;
            // 
            // destino
            // 
            this.destino.DataPropertyName = "Destino";
            this.destino.HeaderText = "Destino";
            this.destino.Name = "destino";
            this.destino.ReadOnly = true;
            // 
            // fecha
            // 
            this.fecha.DataPropertyName = "Fecha_compra";
            this.fecha.HeaderText = "Fecha";
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
            // 
            // numero
            // 
            this.numero.DataPropertyName = "numero";
            this.numero.HeaderText = "Numero";
            this.numero.Name = "numero";
            this.numero.ReadOnly = true;
            // 
            // letra
            // 
            this.letra.DataPropertyName = "letra";
            this.letra.HeaderText = "Letra";
            this.letra.Name = "letra";
            this.letra.ReadOnly = true;
            // 
            // posicion
            // 
            this.posicion.DataPropertyName = "posicion";
            this.posicion.HeaderText = "Posicion";
            this.posicion.Name = "posicion";
            this.posicion.ReadOnly = true;
            // 
            // precio
            // 
            this.precio.DataPropertyName = "precio";
            this.precio.HeaderText = "Precio";
            this.precio.Name = "precio";
            this.precio.ReadOnly = true;
            // 
            // frm_MisCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1387, 660);
            this.Controls.Add(this.dgv_Compras);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_MisCompras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_MisCompras";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Compras)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Compras;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomus;
        private System.Windows.Forms.DataGridViewTextBoxColumn origen;
        private System.Windows.Forms.DataGridViewTextBoxColumn destino;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn letra;
        private System.Windows.Forms.DataGridViewTextBoxColumn posicion;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
    }
}