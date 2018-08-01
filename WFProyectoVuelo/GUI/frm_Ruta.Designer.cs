namespace WFProyectoVuelo.GUI
{
    partial class frm_Ruta
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
            this.btn_NuevaRuta = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_Destino = new System.Windows.Forms.ComboBox();
            this.cmb_Origen = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_BuscarRuta = new System.Windows.Forms.Button();
            this.txt_ClaveRuta = new System.Windows.Forms.TextBox();
            this.dgv_Ruta = new System.Windows.Forms.DataGridView();
            this.COD_CURSO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numpasajeros = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.origen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detalle = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Ruta)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_NuevaRuta);
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
            this.label1.Size = new System.Drawing.Size(86, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Rutas";
            // 
            // btn_NuevaRuta
            // 
            this.btn_NuevaRuta.BackColor = System.Drawing.Color.Blue;
            this.btn_NuevaRuta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NuevaRuta.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_NuevaRuta.Location = new System.Drawing.Point(13, 13);
            this.btn_NuevaRuta.Margin = new System.Windows.Forms.Padding(4);
            this.btn_NuevaRuta.Name = "btn_NuevaRuta";
            this.btn_NuevaRuta.Size = new System.Drawing.Size(159, 53);
            this.btn_NuevaRuta.TabIndex = 0;
            this.btn_NuevaRuta.Text = "Nueva ruta";
            this.btn_NuevaRuta.UseVisualStyleBackColor = false;
            this.btn_NuevaRuta.Click += new System.EventHandler(this.btn_NuevaRuta_Click);
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
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.cmb_Destino);
            this.tabPage1.Controls.Add(this.cmb_Origen);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.btn_BuscarRuta);
            this.tabPage1.Controls.Add(this.txt_ClaveRuta);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1091, 122);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "     Administrar     ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(476, 31);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 17);
            this.label4.TabIndex = 120;
            this.label4.Text = "Aeropuerto destino:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(132, 31);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 17);
            this.label3.TabIndex = 119;
            this.label3.Text = "Aeropuerto origen:";
            // 
            // cmb_Destino
            // 
            this.cmb_Destino.FormattingEnabled = true;
            this.cmb_Destino.Location = new System.Drawing.Point(479, 52);
            this.cmb_Destino.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_Destino.Name = "cmb_Destino";
            this.cmb_Destino.Size = new System.Drawing.Size(313, 24);
            this.cmb_Destino.TabIndex = 118;
            // 
            // cmb_Origen
            // 
            this.cmb_Origen.FormattingEnabled = true;
            this.cmb_Origen.Location = new System.Drawing.Point(135, 52);
            this.cmb_Origen.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_Origen.Name = "cmb_Origen";
            this.cmb_Origen.Size = new System.Drawing.Size(313, 24);
            this.cmb_Origen.TabIndex = 117;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Clave:";
            // 
            // btn_BuscarRuta
            // 
            this.btn_BuscarRuta.BackColor = System.Drawing.Color.Blue;
            this.btn_BuscarRuta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BuscarRuta.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_BuscarRuta.Location = new System.Drawing.Point(858, 44);
            this.btn_BuscarRuta.Margin = new System.Windows.Forms.Padding(4);
            this.btn_BuscarRuta.Name = "btn_BuscarRuta";
            this.btn_BuscarRuta.Size = new System.Drawing.Size(159, 37);
            this.btn_BuscarRuta.TabIndex = 2;
            this.btn_BuscarRuta.Text = "Buscar";
            this.btn_BuscarRuta.UseVisualStyleBackColor = false;
            this.btn_BuscarRuta.Click += new System.EventHandler(this.btn_BuscarRuta_Click);
            // 
            // txt_ClaveRuta
            // 
            this.txt_ClaveRuta.Location = new System.Drawing.Point(22, 52);
            this.txt_ClaveRuta.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ClaveRuta.Name = "txt_ClaveRuta";
            this.txt_ClaveRuta.Size = new System.Drawing.Size(87, 22);
            this.txt_ClaveRuta.TabIndex = 4;
            // 
            // dgv_Ruta
            // 
            this.dgv_Ruta.AllowUserToAddRows = false;
            this.dgv_Ruta.AllowUserToDeleteRows = false;
            this.dgv_Ruta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Ruta.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Ruta.ColumnHeadersHeight = 30;
            this.dgv_Ruta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.COD_CURSO,
            this.numpasajeros,
            this.origen,
            this.destino,
            this.Detalle});
            this.dgv_Ruta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Ruta.Location = new System.Drawing.Point(0, 231);
            this.dgv_Ruta.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_Ruta.Name = "dgv_Ruta";
            this.dgv_Ruta.ReadOnly = true;
            this.dgv_Ruta.Size = new System.Drawing.Size(1099, 336);
            this.dgv_Ruta.TabIndex = 6;
            this.dgv_Ruta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Ruta_CellContentClick);
            // 
            // COD_CURSO
            // 
            this.COD_CURSO.DataPropertyName = "Id_Ruta";
            this.COD_CURSO.HeaderText = "Código";
            this.COD_CURSO.Name = "COD_CURSO";
            this.COD_CURSO.ReadOnly = true;
            // 
            // numpasajeros
            // 
            this.numpasajeros.DataPropertyName = "Distancia";
            this.numpasajeros.HeaderText = "Distancia";
            this.numpasajeros.Name = "numpasajeros";
            this.numpasajeros.ReadOnly = true;
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
            // Detalle
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkGreen;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.Detalle.DefaultCellStyle = dataGridViewCellStyle1;
            this.Detalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Detalle.HeaderText = "";
            this.Detalle.Name = "Detalle";
            this.Detalle.ReadOnly = true;
            this.Detalle.Text = "Modificar";
            this.Detalle.UseColumnTextForButtonValue = true;
            // 
            // frm_Ruta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 567);
            this.Controls.Add(this.dgv_Ruta);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Name = "frm_Ruta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Ruta";
            this.Load += new System.EventHandler(this.frm_Ruta_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Ruta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_NuevaRuta;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_BuscarRuta;
        private System.Windows.Forms.TextBox txt_ClaveRuta;
        private System.Windows.Forms.DataGridView dgv_Ruta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_Destino;
        private System.Windows.Forms.ComboBox cmb_Origen;
        private System.Windows.Forms.DataGridViewTextBoxColumn COD_CURSO;
        private System.Windows.Forms.DataGridViewTextBoxColumn numpasajeros;
        private System.Windows.Forms.DataGridViewTextBoxColumn origen;
        private System.Windows.Forms.DataGridViewTextBoxColumn destino;
        private System.Windows.Forms.DataGridViewButtonColumn Detalle;
    }
}