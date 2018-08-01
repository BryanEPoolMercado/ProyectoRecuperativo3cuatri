namespace WFProyectoVuelo.GUI
{
    partial class frm_Modelo
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
            this.btn_NuevoModelo = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_BuscarModelo = new System.Windows.Forms.Button();
            this.txt_NombreModelo = new System.Windows.Forms.TextBox();
            this.txt_ClaveModelo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgv_Modelos = new System.Windows.Forms.DataGridView();
            this.COD_CURSO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ETAPA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numfila = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numcolum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detalle = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Modelos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_NuevoModelo);
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
            this.label1.Location = new System.Drawing.Point(455, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Modelos";
            // 
            // btn_NuevoModelo
            // 
            this.btn_NuevoModelo.BackColor = System.Drawing.Color.Blue;
            this.btn_NuevoModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NuevoModelo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_NuevoModelo.Location = new System.Drawing.Point(13, 13);
            this.btn_NuevoModelo.Margin = new System.Windows.Forms.Padding(4);
            this.btn_NuevoModelo.Name = "btn_NuevoModelo";
            this.btn_NuevoModelo.Size = new System.Drawing.Size(159, 53);
            this.btn_NuevoModelo.TabIndex = 0;
            this.btn_NuevoModelo.Text = "Nuevo modelo";
            this.btn_NuevoModelo.UseVisualStyleBackColor = false;
            this.btn_NuevoModelo.Click += new System.EventHandler(this.btn_NuevoModelo_Click);
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
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.btn_BuscarModelo);
            this.tabPage1.Controls.Add(this.txt_NombreModelo);
            this.tabPage1.Controls.Add(this.txt_ClaveModelo);
            this.tabPage1.Controls.Add(this.label4);
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
            this.label2.Visible = false;
            // 
            // btn_BuscarModelo
            // 
            this.btn_BuscarModelo.BackColor = System.Drawing.Color.Blue;
            this.btn_BuscarModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BuscarModelo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_BuscarModelo.Location = new System.Drawing.Point(616, 44);
            this.btn_BuscarModelo.Margin = new System.Windows.Forms.Padding(4);
            this.btn_BuscarModelo.Name = "btn_BuscarModelo";
            this.btn_BuscarModelo.Size = new System.Drawing.Size(159, 37);
            this.btn_BuscarModelo.TabIndex = 2;
            this.btn_BuscarModelo.Text = "Buscar";
            this.btn_BuscarModelo.UseVisualStyleBackColor = false;
            this.btn_BuscarModelo.Click += new System.EventHandler(this.btn_BuscarModelo_Click);
            // 
            // txt_NombreModelo
            // 
            this.txt_NombreModelo.Location = new System.Drawing.Point(187, 52);
            this.txt_NombreModelo.Margin = new System.Windows.Forms.Padding(4);
            this.txt_NombreModelo.Name = "txt_NombreModelo";
            this.txt_NombreModelo.Size = new System.Drawing.Size(406, 22);
            this.txt_NombreModelo.TabIndex = 5;
            // 
            // txt_ClaveModelo
            // 
            this.txt_ClaveModelo.Location = new System.Drawing.Point(35, 52);
            this.txt_ClaveModelo.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ClaveModelo.Name = "txt_ClaveModelo";
            this.txt_ClaveModelo.Size = new System.Drawing.Size(88, 22);
            this.txt_ClaveModelo.TabIndex = 4;
            this.txt_ClaveModelo.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(183, 32);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Modelo:";
            // 
            // dgv_Modelos
            // 
            this.dgv_Modelos.AllowUserToAddRows = false;
            this.dgv_Modelos.AllowUserToDeleteRows = false;
            this.dgv_Modelos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Modelos.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Modelos.ColumnHeadersHeight = 30;
            this.dgv_Modelos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.COD_CURSO,
            this.ETAPA,
            this.numfila,
            this.numcolum,
            this.Detalle});
            this.dgv_Modelos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Modelos.Location = new System.Drawing.Point(0, 231);
            this.dgv_Modelos.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_Modelos.Name = "dgv_Modelos";
            this.dgv_Modelos.ReadOnly = true;
            this.dgv_Modelos.Size = new System.Drawing.Size(1099, 336);
            this.dgv_Modelos.TabIndex = 4;
            this.dgv_Modelos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Aerolinea_CellContentClick);
            // 
            // COD_CURSO
            // 
            this.COD_CURSO.DataPropertyName = "IdModelo";
            this.COD_CURSO.HeaderText = "Código";
            this.COD_CURSO.Name = "COD_CURSO";
            this.COD_CURSO.ReadOnly = true;
            // 
            // ETAPA
            // 
            this.ETAPA.DataPropertyName = "NombreModelo";
            this.ETAPA.HeaderText = "Modelo";
            this.ETAPA.Name = "ETAPA";
            this.ETAPA.ReadOnly = true;
            // 
            // numfila
            // 
            this.numfila.DataPropertyName = "NumeroFilas";
            this.numfila.HeaderText = "Numero de filas";
            this.numfila.Name = "numfila";
            this.numfila.ReadOnly = true;
            // 
            // numcolum
            // 
            this.numcolum.DataPropertyName = "NumeroColumnas";
            this.numcolum.HeaderText = "Numero de columnas";
            this.numcolum.Name = "numcolum";
            this.numcolum.ReadOnly = true;
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
            // frm_Modelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 567);
            this.Controls.Add(this.dgv_Modelos);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Name = "frm_Modelo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Modelo";
            this.Load += new System.EventHandler(this.frm_Modelo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Modelos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_NuevoModelo;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_BuscarModelo;
        private System.Windows.Forms.TextBox txt_NombreModelo;
        private System.Windows.Forms.TextBox txt_ClaveModelo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgv_Modelos;
        private System.Windows.Forms.DataGridViewTextBoxColumn COD_CURSO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ETAPA;
        private System.Windows.Forms.DataGridViewTextBoxColumn numfila;
        private System.Windows.Forms.DataGridViewTextBoxColumn numcolum;
        private System.Windows.Forms.DataGridViewButtonColumn Detalle;
    }
}