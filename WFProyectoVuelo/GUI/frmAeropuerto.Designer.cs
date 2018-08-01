namespace WFProyectoVuelo
{
    partial class frmAeropuerto
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNuevoCurso = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_NomAeropuerto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_ClaveAeropuerto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_Aeropuerto = new System.Windows.Forms.DataGridView();
            this.IdAero_Colum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ciudad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomaerolinea_colum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ver = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cbo_IdCiudad = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Aeropuerto)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnNuevoCurso);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 59);
            this.panel1.TabIndex = 1;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.ForestGreen;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscar.Location = new System.Drawing.Point(20, 13);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(119, 43);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(684, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Aeropuerto";
            // 
            // btnNuevoCurso
            // 
            this.btnNuevoCurso.BackColor = System.Drawing.Color.ForestGreen;
            this.btnNuevoCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoCurso.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNuevoCurso.Location = new System.Drawing.Point(145, 13);
            this.btnNuevoCurso.Name = "btnNuevoCurso";
            this.btnNuevoCurso.Size = new System.Drawing.Size(119, 43);
            this.btnNuevoCurso.TabIndex = 0;
            this.btnNuevoCurso.Text = "Nueva Aeropuerto";
            this.btnNuevoCurso.UseVisualStyleBackColor = false;
            this.btnNuevoCurso.Click += new System.EventHandler(this.btnNuevoCurso_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 59);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 123);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 97);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Aeropuerto";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel3.Controls.Add(this.cbo_IdCiudad);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.txt_NomAeropuerto);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txt_ClaveAeropuerto);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(786, 94);
            this.panel3.TabIndex = 112;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(467, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 17);
            this.label4.TabIndex = 109;
            this.label4.Text = "Clave Ciudad:";
            // 
            // txt_NomAeropuerto
            // 
            this.txt_NomAeropuerto.Location = new System.Drawing.Point(272, 27);
            this.txt_NomAeropuerto.Name = "txt_NomAeropuerto";
            this.txt_NomAeropuerto.Size = new System.Drawing.Size(163, 20);
            this.txt_NomAeropuerto.TabIndex = 106;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(4, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 107;
            this.label3.Text = "Clave:";
            // 
            // txt_ClaveAeropuerto
            // 
            this.txt_ClaveAeropuerto.Location = new System.Drawing.Point(61, 26);
            this.txt_ClaveAeropuerto.Name = "txt_ClaveAeropuerto";
            this.txt_ClaveAeropuerto.Size = new System.Drawing.Size(100, 20);
            this.txt_ClaveAeropuerto.TabIndex = 108;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(201, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 105;
            this.label2.Text = "Nombre:";
            // 
            // dgv_Aeropuerto
            // 
            this.dgv_Aeropuerto.AllowUserToDeleteRows = false;
            this.dgv_Aeropuerto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Aeropuerto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Aeropuerto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdAero_Colum,
            this.Ciudad,
            this.nomaerolinea_colum,
            this.Ver});
            this.dgv_Aeropuerto.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_Aeropuerto.Location = new System.Drawing.Point(0, 179);
            this.dgv_Aeropuerto.Name = "dgv_Aeropuerto";
            this.dgv_Aeropuerto.ReadOnly = true;
            this.dgv_Aeropuerto.Size = new System.Drawing.Size(800, 271);
            this.dgv_Aeropuerto.TabIndex = 111;
            this.dgv_Aeropuerto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Aerolinea_CellContentClick);
            // 
            // IdAero_Colum
            // 
            this.IdAero_Colum.DataPropertyName = "Id_Aeropuerto";
            this.IdAero_Colum.HeaderText = "Clave";
            this.IdAero_Colum.Name = "IdAero_Colum";
            this.IdAero_Colum.ReadOnly = true;
            // 
            // Ciudad
            // 
            this.Ciudad.DataPropertyName = "Ciudad";
            this.Ciudad.HeaderText = "Ciudad";
            this.Ciudad.Name = "Ciudad";
            this.Ciudad.ReadOnly = true;
            // 
            // nomaerolinea_colum
            // 
            this.nomaerolinea_colum.DataPropertyName = "Nombre";
            this.nomaerolinea_colum.HeaderText = "Nombre";
            this.nomaerolinea_colum.Name = "nomaerolinea_colum";
            this.nomaerolinea_colum.ReadOnly = true;
            // 
            // Ver
            // 
            this.Ver.HeaderText = "Ver";
            this.Ver.Name = "Ver";
            this.Ver.ReadOnly = true;
            // 
            // cbo_IdCiudad
            // 
            this.cbo_IdCiudad.FormattingEnabled = true;
            this.cbo_IdCiudad.Location = new System.Drawing.Point(577, 26);
            this.cbo_IdCiudad.Name = "cbo_IdCiudad";
            this.cbo_IdCiudad.Size = new System.Drawing.Size(193, 21);
            this.cbo_IdCiudad.TabIndex = 110;
            // 
            // frmAeropuerto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgv_Aeropuerto);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Name = "frmAeropuerto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmAerolinea_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Aeropuerto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNuevoCurso;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txt_NomAeropuerto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_ClaveAeropuerto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_Aeropuerto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdAero_Colum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ciudad;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomaerolinea_colum;
        private System.Windows.Forms.DataGridViewButtonColumn Ver;
        private System.Windows.Forms.ComboBox cbo_IdCiudad;
    }
}

