namespace WFProyectoVuelo.GUI
{
    partial class frm_Vuelos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_NuevoVuelo = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_BuscarVuelos = new System.Windows.Forms.Button();
            this.txt_ClaveVuelos = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_Origen = new System.Windows.Forms.ComboBox();
            this.cmb_Destino = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgv_Vuelos = new System.Windows.Forms.DataGridView();
            this.COD_CURSO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numpasajeros = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horafin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.avion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ruta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detalle = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Vuelos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_NuevoVuelo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1099, 80);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(463, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Vuelos";
            // 
            // btn_NuevoVuelo
            // 
            this.btn_NuevoVuelo.BackColor = System.Drawing.Color.Blue;
            this.btn_NuevoVuelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NuevoVuelo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_NuevoVuelo.Location = new System.Drawing.Point(13, 13);
            this.btn_NuevoVuelo.Margin = new System.Windows.Forms.Padding(4);
            this.btn_NuevoVuelo.Name = "btn_NuevoVuelo";
            this.btn_NuevoVuelo.Size = new System.Drawing.Size(159, 53);
            this.btn_NuevoVuelo.TabIndex = 0;
            this.btn_NuevoVuelo.Text = "Nuevo avion";
            this.btn_NuevoVuelo.UseVisualStyleBackColor = false;
            this.btn_NuevoVuelo.Click += new System.EventHandler(this.btn_NuevoVuelo_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 80);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1099, 151);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cmb_Destino);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.cmb_Origen);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.btn_BuscarVuelos);
            this.tabPage1.Controls.Add(this.txt_ClaveVuelos);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1091, 122);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "     Administrar     ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Clave:";
            // 
            // btn_BuscarVuelos
            // 
            this.btn_BuscarVuelos.BackColor = System.Drawing.Color.Blue;
            this.btn_BuscarVuelos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BuscarVuelos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_BuscarVuelos.Location = new System.Drawing.Point(857, 44);
            this.btn_BuscarVuelos.Margin = new System.Windows.Forms.Padding(4);
            this.btn_BuscarVuelos.Name = "btn_BuscarVuelos";
            this.btn_BuscarVuelos.Size = new System.Drawing.Size(159, 37);
            this.btn_BuscarVuelos.TabIndex = 2;
            this.btn_BuscarVuelos.Text = "Buscar";
            this.btn_BuscarVuelos.UseVisualStyleBackColor = false;
            this.btn_BuscarVuelos.Click += new System.EventHandler(this.btn_BuscarVuelos_Click);
            // 
            // txt_ClaveVuelos
            // 
            this.txt_ClaveVuelos.Location = new System.Drawing.Point(35, 52);
            this.txt_ClaveVuelos.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ClaveVuelos.Name = "txt_ClaveVuelos";
            this.txt_ClaveVuelos.Size = new System.Drawing.Size(88, 22);
            this.txt_ClaveVuelos.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(177, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Origen";
            // 
            // cmb_Origen
            // 
            this.cmb_Origen.FormattingEnabled = true;
            this.cmb_Origen.Location = new System.Drawing.Point(180, 52);
            this.cmb_Origen.Name = "cmb_Origen";
            this.cmb_Origen.Size = new System.Drawing.Size(289, 24);
            this.cmb_Origen.TabIndex = 9;
            // 
            // cmb_Destino
            // 
            this.cmb_Destino.FormattingEnabled = true;
            this.cmb_Destino.Location = new System.Drawing.Point(502, 52);
            this.cmb_Destino.Name = "cmb_Destino";
            this.cmb_Destino.Size = new System.Drawing.Size(289, 24);
            this.cmb_Destino.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(499, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Destino";
            // 
            // dgv_Vuelos
            // 
            this.dgv_Vuelos.AllowUserToAddRows = false;
            this.dgv_Vuelos.AllowUserToDeleteRows = false;
            this.dgv_Vuelos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Vuelos.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Vuelos.ColumnHeadersHeight = 30;
            this.dgv_Vuelos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.COD_CURSO,
            this.fecha,
            this.numpasajeros,
            this.horafin,
            this.avion,
            this.ruta,
            this.Detalle});
            this.dgv_Vuelos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Vuelos.Location = new System.Drawing.Point(0, 231);
            this.dgv_Vuelos.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_Vuelos.Name = "dgv_Vuelos";
            this.dgv_Vuelos.ReadOnly = true;
            this.dgv_Vuelos.Size = new System.Drawing.Size(1099, 336);
            this.dgv_Vuelos.TabIndex = 6;
            this.dgv_Vuelos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Vuelos_CellContentClick);
            // 
            // COD_CURSO
            // 
            this.COD_CURSO.DataPropertyName = "Id_Vuelo";
            this.COD_CURSO.HeaderText = "Código";
            this.COD_CURSO.Name = "COD_CURSO";
            this.COD_CURSO.ReadOnly = true;
            // 
            // fecha
            // 
            this.fecha.DataPropertyName = "Fecha";
            this.fecha.HeaderText = "Fecha";
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
            // 
            // numpasajeros
            // 
            this.numpasajeros.DataPropertyName = "Hora_inicio";
            this.numpasajeros.HeaderText = "Hora de salida";
            this.numpasajeros.Name = "numpasajeros";
            this.numpasajeros.ReadOnly = true;
            // 
            // horafin
            // 
            this.horafin.DataPropertyName = "Hora_fin";
            this.horafin.HeaderText = "Hora de llegada";
            this.horafin.Name = "horafin";
            this.horafin.ReadOnly = true;
            // 
            // avion
            // 
            this.avion.DataPropertyName = "NombreModelo";
            this.avion.HeaderText = "Avion";
            this.avion.Name = "avion";
            this.avion.ReadOnly = true;
            // 
            // ruta
            // 
            this.ruta.DataPropertyName = "Id_Ruta";
            this.ruta.HeaderText = "Ruta";
            this.ruta.Name = "ruta";
            this.ruta.ReadOnly = true;
            // 
            // Detalle
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.DarkGreen;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            this.Detalle.DefaultCellStyle = dataGridViewCellStyle6;
            this.Detalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Detalle.HeaderText = "";
            this.Detalle.Name = "Detalle";
            this.Detalle.ReadOnly = true;
            this.Detalle.Text = "Modificar";
            this.Detalle.UseColumnTextForButtonValue = true;
            // 
            // frm_Vuelos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 567);
            this.Controls.Add(this.dgv_Vuelos);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Name = "frm_Vuelos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Vuelos";
            this.Load += new System.EventHandler(this.frm_Vuelos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Vuelos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_NuevoVuelo;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_BuscarVuelos;
        private System.Windows.Forms.TextBox txt_ClaveVuelos;
        private System.Windows.Forms.ComboBox cmb_Destino;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_Origen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgv_Vuelos;
        private System.Windows.Forms.DataGridViewTextBoxColumn COD_CURSO;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn numpasajeros;
        private System.Windows.Forms.DataGridViewTextBoxColumn horafin;
        private System.Windows.Forms.DataGridViewTextBoxColumn avion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ruta;
        private System.Windows.Forms.DataGridViewButtonColumn Detalle;
    }
}