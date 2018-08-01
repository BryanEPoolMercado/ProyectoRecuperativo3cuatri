namespace WFProyectoVuelo.GUI
{
    partial class frm_Tarjeta
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_NuevaTarjeta = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_BuscarTarjeta = new System.Windows.Forms.Button();
            this.dgv_Tarjeta = new System.Windows.Forms.DataGridView();
            this.txt_ApePat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtm_VenciTarje = new System.Windows.Forms.DateTimePicker();
            this.txt_TipoTarjeta = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_NumCuenta = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Id_TarjetaCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Num_TarjetaColu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo_TarjetaCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_VenCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cvcColum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom_TitularColum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Tarjeta)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_NuevaTarjeta);
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
            this.label1.Size = new System.Drawing.Size(113, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tarjetas";
            // 
            // btn_NuevaTarjeta
            // 
            this.btn_NuevaTarjeta.BackColor = System.Drawing.Color.Blue;
            this.btn_NuevaTarjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NuevaTarjeta.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_NuevaTarjeta.Location = new System.Drawing.Point(13, 13);
            this.btn_NuevaTarjeta.Margin = new System.Windows.Forms.Padding(4);
            this.btn_NuevaTarjeta.Name = "btn_NuevaTarjeta";
            this.btn_NuevaTarjeta.Size = new System.Drawing.Size(159, 53);
            this.btn_NuevaTarjeta.TabIndex = 0;
            this.btn_NuevaTarjeta.Text = "Nueva tarjeta";
            this.btn_NuevaTarjeta.UseVisualStyleBackColor = false;
            this.btn_NuevaTarjeta.Click += new System.EventHandler(this.btn_NuevaTarjeta_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 80);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1099, 183);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txt_ApePat);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txt_Nombre);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.dtm_VenciTarje);
            this.tabPage1.Controls.Add(this.txt_TipoTarjeta);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.txt_NumCuenta);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.btn_BuscarTarjeta);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1091, 154);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "     Administrar     ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_BuscarTarjeta
            // 
            this.btn_BuscarTarjeta.BackColor = System.Drawing.Color.Blue;
            this.btn_BuscarTarjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BuscarTarjeta.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_BuscarTarjeta.Location = new System.Drawing.Point(909, 49);
            this.btn_BuscarTarjeta.Margin = new System.Windows.Forms.Padding(4);
            this.btn_BuscarTarjeta.Name = "btn_BuscarTarjeta";
            this.btn_BuscarTarjeta.Size = new System.Drawing.Size(159, 37);
            this.btn_BuscarTarjeta.TabIndex = 2;
            this.btn_BuscarTarjeta.Text = "Buscar";
            this.btn_BuscarTarjeta.UseVisualStyleBackColor = false;
            this.btn_BuscarTarjeta.Click += new System.EventHandler(this.btn_BuscarTarjeta_Click);
            // 
            // dgv_Tarjeta
            // 
            this.dgv_Tarjeta.AllowUserToAddRows = false;
            this.dgv_Tarjeta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Tarjeta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Tarjeta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_TarjetaCol,
            this.Num_TarjetaColu,
            this.Tipo_TarjetaCol,
            this.Fecha_VenCol,
            this.cvcColum,
            this.Nom_TitularColum,
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgv_Tarjeta.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_Tarjeta.Location = new System.Drawing.Point(0, 271);
            this.dgv_Tarjeta.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_Tarjeta.Name = "dgv_Tarjeta";
            this.dgv_Tarjeta.Size = new System.Drawing.Size(1099, 296);
            this.dgv_Tarjeta.TabIndex = 194;
            this.dgv_Tarjeta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Tarjeta_CellContentClick);
            // 
            // txt_ApePat
            // 
            this.txt_ApePat.Location = new System.Drawing.Point(580, 97);
            this.txt_ApePat.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ApePat.Name = "txt_ApePat";
            this.txt_ApePat.Size = new System.Drawing.Size(283, 22);
            this.txt_ApePat.TabIndex = 228;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(577, 76);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 17);
            this.label4.TabIndex = 227;
            this.label4.Text = "Apellido Paterno:";
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(308, 97);
            this.txt_Nombre.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(249, 22);
            this.txt_Nombre.TabIndex = 226;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(305, 76);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 17);
            this.label5.TabIndex = 225;
            this.label5.Text = "Nombre:";
            // 
            // dtm_VenciTarje
            // 
            this.dtm_VenciTarje.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtm_VenciTarje.Location = new System.Drawing.Point(25, 97);
            this.dtm_VenciTarje.Margin = new System.Windows.Forms.Padding(4);
            this.dtm_VenciTarje.Name = "dtm_VenciTarje";
            this.dtm_VenciTarje.Size = new System.Drawing.Size(236, 22);
            this.dtm_VenciTarje.TabIndex = 224;
            // 
            // txt_TipoTarjeta
            // 
            this.txt_TipoTarjeta.Location = new System.Drawing.Point(25, 35);
            this.txt_TipoTarjeta.Margin = new System.Windows.Forms.Padding(4);
            this.txt_TipoTarjeta.Name = "txt_TipoTarjeta";
            this.txt_TipoTarjeta.Size = new System.Drawing.Size(236, 22);
            this.txt_TipoTarjeta.TabIndex = 223;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 14);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 17);
            this.label7.TabIndex = 222;
            this.label7.Text = "Tipo de Tarjeta:";
            // 
            // txt_NumCuenta
            // 
            this.txt_NumCuenta.Location = new System.Drawing.Point(308, 35);
            this.txt_NumCuenta.Margin = new System.Windows.Forms.Padding(4);
            this.txt_NumCuenta.Name = "txt_NumCuenta";
            this.txt_NumCuenta.Size = new System.Drawing.Size(555, 22);
            this.txt_NumCuenta.TabIndex = 221;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(305, 12);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(131, 17);
            this.label10.TabIndex = 220;
            this.label10.Text = "Número de Cuenta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 69);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 17);
            this.label3.TabIndex = 219;
            this.label3.Text = "Fecha de Vencimiento:";
            // 
            // Id_TarjetaCol
            // 
            this.Id_TarjetaCol.DataPropertyName = "Id_Tarjeta";
            this.Id_TarjetaCol.HeaderText = "Clave";
            this.Id_TarjetaCol.Name = "Id_TarjetaCol";
            // 
            // Num_TarjetaColu
            // 
            this.Num_TarjetaColu.DataPropertyName = "Num_Cuenta";
            this.Num_TarjetaColu.HeaderText = "Número de Tarjeta";
            this.Num_TarjetaColu.Name = "Num_TarjetaColu";
            // 
            // Tipo_TarjetaCol
            // 
            this.Tipo_TarjetaCol.DataPropertyName = "Tipo_Tarjeta";
            this.Tipo_TarjetaCol.HeaderText = "Tipo de Tarjeta";
            this.Tipo_TarjetaCol.Name = "Tipo_TarjetaCol";
            // 
            // Fecha_VenCol
            // 
            this.Fecha_VenCol.DataPropertyName = "Fecha_Venc";
            this.Fecha_VenCol.HeaderText = "Fecha de Vencimiento";
            this.Fecha_VenCol.Name = "Fecha_VenCol";
            // 
            // cvcColum
            // 
            this.cvcColum.DataPropertyName = "CVC";
            this.cvcColum.HeaderText = "CVC";
            this.cvcColum.Name = "cvcColum";
            // 
            // Nom_TitularColum
            // 
            this.Nom_TitularColum.DataPropertyName = "Nombre";
            this.Nom_TitularColum.HeaderText = "Nombre";
            this.Nom_TitularColum.Name = "Nom_TitularColum";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Apellido_Pat";
            this.Column1.HeaderText = "Apellido Paterno";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Apellido_Mat";
            this.Column2.HeaderText = "Apellido Materno";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Green;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Column3.HeaderText = "";
            this.Column3.Name = "Column3";
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column3.Text = "Modificar";
            this.Column3.UseColumnTextForButtonValue = true;
            // 
            // frm_Tarjeta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 567);
            this.Controls.Add(this.dgv_Tarjeta);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Name = "frm_Tarjeta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Tarjeta";
            this.Load += new System.EventHandler(this.frm_Tarjeta_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Tarjeta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_NuevaTarjeta;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btn_BuscarTarjeta;
        private System.Windows.Forms.DataGridView dgv_Tarjeta;
        private System.Windows.Forms.TextBox txt_ApePat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtm_VenciTarje;
        private System.Windows.Forms.TextBox txt_TipoTarjeta;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_NumCuenta;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_TarjetaCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Num_TarjetaColu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo_TarjetaCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_VenCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn cvcColum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom_TitularColum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewButtonColumn Column3;
    }
}