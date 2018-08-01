namespace WFProyectoVuelo.GUI
{
    partial class frm_Precio
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_NuevaPrecio = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_BuscarAerolinea = new System.Windows.Forms.Button();
            this.txt_ClavePrecio = new System.Windows.Forms.TextBox();
            this.txt_Precio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbo_Avion = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbo_Destino = new System.Windows.Forms.ComboBox();
            this.cbo_Origen = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbo_Clase = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dgv_Precio = new System.Windows.Forms.DataGridView();
            this.Código = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Avión = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Origen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Destino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detalle = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Precio)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_NuevaPrecio);
            this.panel1.Controls.Add(this.btn_BuscarAerolinea);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 65);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(317, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Precio";
            // 
            // btn_NuevaPrecio
            // 
            this.btn_NuevaPrecio.BackColor = System.Drawing.Color.Blue;
            this.btn_NuevaPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NuevaPrecio.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_NuevaPrecio.Location = new System.Drawing.Point(10, 11);
            this.btn_NuevaPrecio.Name = "btn_NuevaPrecio";
            this.btn_NuevaPrecio.Size = new System.Drawing.Size(119, 43);
            this.btn_NuevaPrecio.TabIndex = 0;
            this.btn_NuevaPrecio.Text = "Nueva Precio";
            this.btn_NuevaPrecio.UseVisualStyleBackColor = false;
            this.btn_NuevaPrecio.Click += new System.EventHandler(this.btn_NuevaPrecio_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 65);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 132);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.cbo_Clase);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.cbo_Destino);
            this.tabPage1.Controls.Add(this.cbo_Origen);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.cbo_Avion);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txt_Precio);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txt_ClavePrecio);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 106);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "     Administrar     ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Clave:";
            this.label2.Visible = false;
            // 
            // btn_BuscarAerolinea
            // 
            this.btn_BuscarAerolinea.BackColor = System.Drawing.Color.Blue;
            this.btn_BuscarAerolinea.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BuscarAerolinea.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_BuscarAerolinea.Location = new System.Drawing.Point(158, 17);
            this.btn_BuscarAerolinea.Name = "btn_BuscarAerolinea";
            this.btn_BuscarAerolinea.Size = new System.Drawing.Size(119, 30);
            this.btn_BuscarAerolinea.TabIndex = 2;
            this.btn_BuscarAerolinea.Text = "Buscar";
            this.btn_BuscarAerolinea.UseVisualStyleBackColor = false;
            this.btn_BuscarAerolinea.Click += new System.EventHandler(this.btn_BuscarAerolinea_Click);
            // 
            // txt_ClavePrecio
            // 
            this.txt_ClavePrecio.Location = new System.Drawing.Point(18, 26);
            this.txt_ClavePrecio.Name = "txt_ClavePrecio";
            this.txt_ClavePrecio.Size = new System.Drawing.Size(67, 20);
            this.txt_ClavePrecio.TabIndex = 4;
            this.txt_ClavePrecio.Visible = false;
            // 
            // txt_Precio
            // 
            this.txt_Precio.Location = new System.Drawing.Point(139, 26);
            this.txt_Precio.Name = "txt_Precio";
            this.txt_Precio.Size = new System.Drawing.Size(100, 20);
            this.txt_Precio.TabIndex = 108;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(151, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Precio:";
            // 
            // cbo_Avion
            // 
            this.cbo_Avion.FormattingEnabled = true;
            this.cbo_Avion.Location = new System.Drawing.Point(282, 25);
            this.cbo_Avion.Name = "cbo_Avion";
            this.cbo_Avion.Size = new System.Drawing.Size(217, 21);
            this.cbo_Avion.TabIndex = 118;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(279, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Avion:";
            // 
            // cbo_Destino
            // 
            this.cbo_Destino.FormattingEnabled = true;
            this.cbo_Destino.Location = new System.Drawing.Point(434, 74);
            this.cbo_Destino.Name = "cbo_Destino";
            this.cbo_Destino.Size = new System.Drawing.Size(327, 21);
            this.cbo_Destino.TabIndex = 125;
            // 
            // cbo_Origen
            // 
            this.cbo_Origen.FormattingEnabled = true;
            this.cbo_Origen.Location = new System.Drawing.Point(34, 74);
            this.cbo_Origen.Name = "cbo_Origen";
            this.cbo_Origen.Size = new System.Drawing.Size(327, 21);
            this.cbo_Origen.TabIndex = 123;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 126;
            this.label6.Text = "Origen:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(431, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Destino:";
            // 
            // cbo_Clase
            // 
            this.cbo_Clase.FormattingEnabled = true;
            this.cbo_Clase.Location = new System.Drawing.Point(545, 25);
            this.cbo_Clase.Name = "cbo_Clase";
            this.cbo_Clase.Size = new System.Drawing.Size(187, 21);
            this.cbo_Clase.TabIndex = 124;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(542, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Seccion:";
            // 
            // dgv_Precio
            // 
            this.dgv_Precio.AllowUserToAddRows = false;
            this.dgv_Precio.AllowUserToDeleteRows = false;
            this.dgv_Precio.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Precio.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Precio.ColumnHeadersHeight = 30;
            this.dgv_Precio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Código,
            this.Precio,
            this.Avión,
            this.Origen,
            this.Destino,
            this.Clase,
            this.Detalle});
            this.dgv_Precio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Precio.Location = new System.Drawing.Point(0, 197);
            this.dgv_Precio.Name = "dgv_Precio";
            this.dgv_Precio.ReadOnly = true;
            this.dgv_Precio.Size = new System.Drawing.Size(800, 253);
            this.dgv_Precio.TabIndex = 4;
            this.dgv_Precio.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Precio_CellContentClick);
            // 
            // Código
            // 
            this.Código.DataPropertyName = "Id_Precio";
            this.Código.HeaderText = "Código";
            this.Código.Name = "Código";
            this.Código.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.DataPropertyName = "Precio";
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // Avión
            // 
            this.Avión.DataPropertyName = "Avion";
            this.Avión.HeaderText = "Avión";
            this.Avión.Name = "Avión";
            this.Avión.ReadOnly = true;
            // 
            // Origen
            // 
            this.Origen.DataPropertyName = "Origen";
            this.Origen.HeaderText = "Origen";
            this.Origen.Name = "Origen";
            this.Origen.ReadOnly = true;
            // 
            // Destino
            // 
            this.Destino.DataPropertyName = "Destino";
            this.Destino.HeaderText = "Destino";
            this.Destino.Name = "Destino";
            this.Destino.ReadOnly = true;
            // 
            // Clase
            // 
            this.Clase.DataPropertyName = "Clase";
            this.Clase.HeaderText = "Clase";
            this.Clase.Name = "Clase";
            this.Clase.ReadOnly = true;
            // 
            // Detalle
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DarkGreen;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            this.Detalle.DefaultCellStyle = dataGridViewCellStyle4;
            this.Detalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Detalle.HeaderText = "";
            this.Detalle.Name = "Detalle";
            this.Detalle.ReadOnly = true;
            this.Detalle.Text = "Modificar";
            this.Detalle.UseColumnTextForButtonValue = true;
            // 
            // frm_Precio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgv_Precio);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Name = "frm_Precio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Precio";
            this.Load += new System.EventHandler(this.frm_Precio_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Precio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_NuevaPrecio;
        private System.Windows.Forms.Button btn_BuscarAerolinea;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbo_Clase;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbo_Destino;
        private System.Windows.Forms.ComboBox cbo_Origen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbo_Avion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Precio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_ClavePrecio;
        private System.Windows.Forms.DataGridView dgv_Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Código;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Avión;
        private System.Windows.Forms.DataGridViewTextBoxColumn Origen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Destino;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clase;
        private System.Windows.Forms.DataGridViewButtonColumn Detalle;
    }
}