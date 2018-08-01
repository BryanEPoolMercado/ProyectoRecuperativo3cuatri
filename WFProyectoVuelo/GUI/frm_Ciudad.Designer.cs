namespace WFProyectoVuelo.GUI
{
    partial class frm_Ciudad
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
            this.dgv_Ciudad = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_BuscarCiudad = new System.Windows.Forms.Button();
            this.txt_NombreCiudad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_ClaveCiudad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_NuevaCiudad = new System.Windows.Forms.Button();
            this.Id_Seccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombrePais = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ver = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Ciudad)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_Ciudad
            // 
            this.dgv_Ciudad.AllowUserToAddRows = false;
            this.dgv_Ciudad.AllowUserToDeleteRows = false;
            this.dgv_Ciudad.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Ciudad.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Ciudad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Ciudad.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Seccion,
            this.NombrePais,
            this.Nombre,
            this.Ver});
            this.dgv_Ciudad.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_Ciudad.Location = new System.Drawing.Point(0, 221);
            this.dgv_Ciudad.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_Ciudad.Name = "dgv_Ciudad";
            this.dgv_Ciudad.ReadOnly = true;
            this.dgv_Ciudad.Size = new System.Drawing.Size(1104, 334);
            this.dgv_Ciudad.TabIndex = 118;
            this.dgv_Ciudad.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Ciudad_CellContentClick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 73);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1104, 151);
            this.tabControl1.TabIndex = 117;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel3);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1096, 122);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Clase";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gray;
            this.panel3.Controls.Add(this.btn_BuscarCiudad);
            this.panel3.Controls.Add(this.txt_NombreCiudad);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txt_ClaveCiudad);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(4, 4);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1088, 118);
            this.panel3.TabIndex = 112;
            // 
            // btn_BuscarCiudad
            // 
            this.btn_BuscarCiudad.BackColor = System.Drawing.Color.Blue;
            this.btn_BuscarCiudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BuscarCiudad.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_BuscarCiudad.Location = new System.Drawing.Point(882, 44);
            this.btn_BuscarCiudad.Margin = new System.Windows.Forms.Padding(4);
            this.btn_BuscarCiudad.Name = "btn_BuscarCiudad";
            this.btn_BuscarCiudad.Size = new System.Drawing.Size(159, 37);
            this.btn_BuscarCiudad.TabIndex = 2;
            this.btn_BuscarCiudad.Text = "Buscar";
            this.btn_BuscarCiudad.UseVisualStyleBackColor = false;
            this.btn_BuscarCiudad.Click += new System.EventHandler(this.btn_BuscarCiudad_Click);
            // 
            // txt_NombreCiudad
            // 
            this.txt_NombreCiudad.Location = new System.Drawing.Point(211, 50);
            this.txt_NombreCiudad.Margin = new System.Windows.Forms.Padding(4);
            this.txt_NombreCiudad.Name = "txt_NombreCiudad";
            this.txt_NombreCiudad.Size = new System.Drawing.Size(256, 22);
            this.txt_NombreCiudad.TabIndex = 106;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(25, 27);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 21);
            this.label3.TabIndex = 107;
            this.label3.Text = "Clave:";
            // 
            // txt_ClaveCiudad
            // 
            this.txt_ClaveCiudad.Location = new System.Drawing.Point(29, 50);
            this.txt_ClaveCiudad.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ClaveCiudad.Name = "txt_ClaveCiudad";
            this.txt_ClaveCiudad.Size = new System.Drawing.Size(132, 22);
            this.txt_ClaveCiudad.TabIndex = 108;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(207, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 21);
            this.label2.TabIndex = 105;
            this.label2.Text = "Ciudad:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_NuevaCiudad);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1104, 73);
            this.panel1.TabIndex = 116;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(949, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ciudad";
            // 
            // btn_NuevaCiudad
            // 
            this.btn_NuevaCiudad.BackColor = System.Drawing.Color.Blue;
            this.btn_NuevaCiudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NuevaCiudad.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_NuevaCiudad.Location = new System.Drawing.Point(4, 12);
            this.btn_NuevaCiudad.Margin = new System.Windows.Forms.Padding(4);
            this.btn_NuevaCiudad.Name = "btn_NuevaCiudad";
            this.btn_NuevaCiudad.Size = new System.Drawing.Size(159, 53);
            this.btn_NuevaCiudad.TabIndex = 0;
            this.btn_NuevaCiudad.Text = "Nueva Ciudad";
            this.btn_NuevaCiudad.UseVisualStyleBackColor = false;
            this.btn_NuevaCiudad.Click += new System.EventHandler(this.btn_NuevaCiudad_Click);
            // 
            // Id_Seccion
            // 
            this.Id_Seccion.DataPropertyName = "Id_Ciudad";
            this.Id_Seccion.HeaderText = "Clave";
            this.Id_Seccion.Name = "Id_Seccion";
            this.Id_Seccion.ReadOnly = true;
            // 
            // NombrePais
            // 
            this.NombrePais.DataPropertyName = "NombrePais";
            this.NombrePais.HeaderText = "Pais";
            this.NombrePais.Name = "NombrePais";
            this.NombrePais.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Ciudad";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
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
            // frm_Ciudad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 555);
            this.Controls.Add(this.dgv_Ciudad);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Name = "frm_Ciudad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Ciudad";
            this.Load += new System.EventHandler(this.frm_Ciudad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Ciudad)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Ciudad;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_BuscarCiudad;
        private System.Windows.Forms.TextBox txt_NombreCiudad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_ClaveCiudad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_NuevaCiudad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Seccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombrePais;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewButtonColumn Ver;
    }
}