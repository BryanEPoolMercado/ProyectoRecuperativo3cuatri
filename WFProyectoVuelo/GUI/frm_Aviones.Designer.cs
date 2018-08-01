namespace WFProyectoVuelo.GUI
{
    partial class frm_Aviones
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
            this.btn_NuevoAvion = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txt_ModeloAvion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_BuscarAvion = new System.Windows.Forms.Button();
            this.txt_ClaveAvion = new System.Windows.Forms.TextBox();
            this.dgv_Aviones = new System.Windows.Forms.DataGridView();
            this.COD_CURSO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numpasajeros = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ETAPA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detalle = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Aviones)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_NuevoAvion);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1099, 80);
            this.panel1.TabIndex = 2;
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
            this.label1.Size = new System.Drawing.Size(111, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Aviones";
            // 
            // btn_NuevoAvion
            // 
            this.btn_NuevoAvion.BackColor = System.Drawing.Color.Blue;
            this.btn_NuevoAvion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NuevoAvion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_NuevoAvion.Location = new System.Drawing.Point(13, 13);
            this.btn_NuevoAvion.Margin = new System.Windows.Forms.Padding(4);
            this.btn_NuevoAvion.Name = "btn_NuevoAvion";
            this.btn_NuevoAvion.Size = new System.Drawing.Size(159, 53);
            this.btn_NuevoAvion.TabIndex = 0;
            this.btn_NuevoAvion.Text = "Nuevo avion";
            this.btn_NuevoAvion.UseVisualStyleBackColor = false;
            this.btn_NuevoAvion.Click += new System.EventHandler(this.btn_NuevoAvion_Click);
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
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txt_ModeloAvion);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.btn_BuscarAvion);
            this.tabPage1.Controls.Add(this.txt_ClaveAvion);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1091, 122);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "     Administrar     ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txt_ModeloAvion
            // 
            this.txt_ModeloAvion.Location = new System.Drawing.Point(166, 52);
            this.txt_ModeloAvion.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ModeloAvion.Name = "txt_ModeloAvion";
            this.txt_ModeloAvion.Size = new System.Drawing.Size(590, 22);
            this.txt_ModeloAvion.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(163, 31);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Modelo:";
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
            // btn_BuscarAvion
            // 
            this.btn_BuscarAvion.BackColor = System.Drawing.Color.Blue;
            this.btn_BuscarAvion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BuscarAvion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_BuscarAvion.Location = new System.Drawing.Point(857, 44);
            this.btn_BuscarAvion.Margin = new System.Windows.Forms.Padding(4);
            this.btn_BuscarAvion.Name = "btn_BuscarAvion";
            this.btn_BuscarAvion.Size = new System.Drawing.Size(159, 37);
            this.btn_BuscarAvion.TabIndex = 2;
            this.btn_BuscarAvion.Text = "Buscar";
            this.btn_BuscarAvion.UseVisualStyleBackColor = false;
            this.btn_BuscarAvion.Click += new System.EventHandler(this.btn_BuscarAvion_Click);
            // 
            // txt_ClaveAvion
            // 
            this.txt_ClaveAvion.Location = new System.Drawing.Point(35, 52);
            this.txt_ClaveAvion.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ClaveAvion.Name = "txt_ClaveAvion";
            this.txt_ClaveAvion.Size = new System.Drawing.Size(88, 22);
            this.txt_ClaveAvion.TabIndex = 4;
            // 
            // dgv_Aviones
            // 
            this.dgv_Aviones.AllowUserToAddRows = false;
            this.dgv_Aviones.AllowUserToDeleteRows = false;
            this.dgv_Aviones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Aviones.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Aviones.ColumnHeadersHeight = 30;
            this.dgv_Aviones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.COD_CURSO,
            this.numpasajeros,
            this.ETAPA,
            this.modelo,
            this.Detalle});
            this.dgv_Aviones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Aviones.Location = new System.Drawing.Point(0, 231);
            this.dgv_Aviones.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_Aviones.Name = "dgv_Aviones";
            this.dgv_Aviones.ReadOnly = true;
            this.dgv_Aviones.Size = new System.Drawing.Size(1099, 336);
            this.dgv_Aviones.TabIndex = 4;
            this.dgv_Aviones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Aviones_CellContentClick);
            // 
            // COD_CURSO
            // 
            this.COD_CURSO.DataPropertyName = "Id_Avion";
            this.COD_CURSO.HeaderText = "Código";
            this.COD_CURSO.Name = "COD_CURSO";
            this.COD_CURSO.ReadOnly = true;
            // 
            // numpasajeros
            // 
            this.numpasajeros.DataPropertyName = "NumeroPasajeros";
            this.numpasajeros.HeaderText = "Numero de pasajeros";
            this.numpasajeros.Name = "numpasajeros";
            this.numpasajeros.ReadOnly = true;
            // 
            // ETAPA
            // 
            this.ETAPA.DataPropertyName = "Nombre";
            this.ETAPA.HeaderText = "Aerolinea";
            this.ETAPA.Name = "ETAPA";
            this.ETAPA.ReadOnly = true;
            // 
            // modelo
            // 
            this.modelo.DataPropertyName = "NombreModelo";
            this.modelo.HeaderText = "Modelo";
            this.modelo.Name = "modelo";
            this.modelo.ReadOnly = true;
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
            // frm_Aviones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 567);
            this.Controls.Add(this.dgv_Aviones);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Name = "frm_Aviones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Aviones";
            this.Load += new System.EventHandler(this.frm_Aviones_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Aviones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_NuevoAvion;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_BuscarAvion;
        private System.Windows.Forms.TextBox txt_ClaveAvion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgv_Aviones;
        private System.Windows.Forms.TextBox txt_ModeloAvion;
        private System.Windows.Forms.DataGridViewTextBoxColumn COD_CURSO;
        private System.Windows.Forms.DataGridViewTextBoxColumn numpasajeros;
        private System.Windows.Forms.DataGridViewTextBoxColumn ETAPA;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelo;
        private System.Windows.Forms.DataGridViewButtonColumn Detalle;
    }
}