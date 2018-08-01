namespace WFProyectoVuelo.GUI
{
    partial class frm_Asiento
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNuevaClase = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtFila = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Clave = new System.Windows.Forms.TextBox();
            this.dgv_Asiento = new System.Windows.Forms.DataGridView();
            this.Id_Asiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fila = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.letra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vuelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ver = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Asiento)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnNuevaClase);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1207, 73);
            this.panel1.TabIndex = 116;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(1052, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Asiento";
            // 
            // btnNuevaClase
            // 
            this.btnNuevaClase.BackColor = System.Drawing.Color.Blue;
            this.btnNuevaClase.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevaClase.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNuevaClase.Location = new System.Drawing.Point(13, 13);
            this.btnNuevaClase.Margin = new System.Windows.Forms.Padding(4);
            this.btnNuevaClase.Name = "btnNuevaClase";
            this.btnNuevaClase.Size = new System.Drawing.Size(159, 53);
            this.btnNuevaClase.TabIndex = 0;
            this.btnNuevaClase.Text = "Nuevo Asiento";
            this.btnNuevaClase.UseVisualStyleBackColor = false;
            this.btnNuevaClase.Click += new System.EventHandler(this.btnNuevaClase_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Blue;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscar.Location = new System.Drawing.Point(825, 43);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(159, 39);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 73);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1207, 151);
            this.tabControl1.TabIndex = 117;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel3);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1199, 122);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Aeropuerto";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gray;
            this.panel3.Controls.Add(this.btnBuscar);
            this.panel3.Controls.Add(this.txtFila);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txt_Clave);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(4, 4);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1191, 116);
            this.panel3.TabIndex = 112;
            // 
            // txtFila
            // 
            this.txtFila.Location = new System.Drawing.Point(337, 46);
            this.txtFila.Margin = new System.Windows.Forms.Padding(4);
            this.txtFila.Name = "txtFila";
            this.txtFila.Size = new System.Drawing.Size(337, 22);
            this.txtFila.TabIndex = 112;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(257, 45);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 21);
            this.label5.TabIndex = 111;
            this.label5.Text = "Posicion:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(13, 42);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 21);
            this.label3.TabIndex = 107;
            this.label3.Text = "Clave:";
            // 
            // txt_Clave
            // 
            this.txt_Clave.Location = new System.Drawing.Point(78, 43);
            this.txt_Clave.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Clave.Name = "txt_Clave";
            this.txt_Clave.Size = new System.Drawing.Size(100, 22);
            this.txt_Clave.TabIndex = 108;
            // 
            // dgv_Asiento
            // 
            this.dgv_Asiento.AllowUserToAddRows = false;
            this.dgv_Asiento.AllowUserToDeleteRows = false;
            this.dgv_Asiento.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Asiento.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Asiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Asiento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Asiento,
            this.Fila,
            this.letra,
            this.numero,
            this.estado,
            this.precio,
            this.Vuelo,
            this.seccion,
            this.Ver});
            this.dgv_Asiento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Asiento.Location = new System.Drawing.Point(0, 224);
            this.dgv_Asiento.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_Asiento.Name = "dgv_Asiento";
            this.dgv_Asiento.ReadOnly = true;
            this.dgv_Asiento.Size = new System.Drawing.Size(1207, 316);
            this.dgv_Asiento.TabIndex = 118;
            this.dgv_Asiento.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Clase_CellContentClick);
            // 
            // Id_Asiento
            // 
            this.Id_Asiento.DataPropertyName = "Id_Asiento";
            this.Id_Asiento.HeaderText = "Clave";
            this.Id_Asiento.Name = "Id_Asiento";
            this.Id_Asiento.ReadOnly = true;
            // 
            // Fila
            // 
            this.Fila.DataPropertyName = "posicion";
            this.Fila.HeaderText = "Posicion";
            this.Fila.Name = "Fila";
            this.Fila.ReadOnly = true;
            // 
            // letra
            // 
            this.letra.DataPropertyName = "letra";
            this.letra.HeaderText = "Letra";
            this.letra.Name = "letra";
            this.letra.ReadOnly = true;
            // 
            // numero
            // 
            this.numero.DataPropertyName = "numero";
            this.numero.HeaderText = "Número";
            this.numero.Name = "numero";
            this.numero.ReadOnly = true;
            // 
            // estado
            // 
            this.estado.DataPropertyName = "estado";
            this.estado.HeaderText = "Estado";
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            // 
            // precio
            // 
            this.precio.DataPropertyName = "precio";
            this.precio.HeaderText = "Precio";
            this.precio.Name = "precio";
            this.precio.ReadOnly = true;
            // 
            // Vuelo
            // 
            this.Vuelo.DataPropertyName = "Id_Vuelo";
            this.Vuelo.HeaderText = "Vuelo";
            this.Vuelo.Name = "Vuelo";
            this.Vuelo.ReadOnly = true;
            // 
            // seccion
            // 
            this.seccion.DataPropertyName = "Id_Seccion";
            this.seccion.HeaderText = "Clase";
            this.seccion.Name = "seccion";
            this.seccion.ReadOnly = true;
            // 
            // Ver
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkGreen;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.Ver.DefaultCellStyle = dataGridViewCellStyle1;
            this.Ver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ver.HeaderText = "";
            this.Ver.Name = "Ver";
            this.Ver.ReadOnly = true;
            this.Ver.Text = "Modificar";
            this.Ver.UseColumnTextForButtonValue = true;
            // 
            // frm_Asiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 540);
            this.Controls.Add(this.dgv_Asiento);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frm_Asiento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Asiento";
            this.Load += new System.EventHandler(this.frm_Asiento_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Asiento)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNuevaClase;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtFila;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Clave;
        private System.Windows.Forms.DataGridView dgv_Asiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Asiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fila;
        private System.Windows.Forms.DataGridViewTextBoxColumn letra;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vuelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn seccion;
        private System.Windows.Forms.DataGridViewButtonColumn Ver;
    }
}