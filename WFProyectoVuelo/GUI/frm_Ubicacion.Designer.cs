namespace WFProyectoVuelo.GUI
{
    partial class frm_Ubicacion
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
            this.btnNuevaUbicacion = new System.Windows.Forms.Button();
            this.btnBuscarUbicacion = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Ubicacion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_Ubicacion = new System.Windows.Forms.DataGridView();
            this.Id_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_ubicacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.avion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ver = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Ubicacion)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnNuevaUbicacion);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1056, 73);
            this.panel1.TabIndex = 116;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(901, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ubicacion";
            // 
            // btnNuevaUbicacion
            // 
            this.btnNuevaUbicacion.BackColor = System.Drawing.Color.Blue;
            this.btnNuevaUbicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevaUbicacion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNuevaUbicacion.Location = new System.Drawing.Point(17, 12);
            this.btnNuevaUbicacion.Margin = new System.Windows.Forms.Padding(4);
            this.btnNuevaUbicacion.Name = "btnNuevaUbicacion";
            this.btnNuevaUbicacion.Size = new System.Drawing.Size(159, 53);
            this.btnNuevaUbicacion.TabIndex = 0;
            this.btnNuevaUbicacion.Text = "Nueva Ubicacion";
            this.btnNuevaUbicacion.UseVisualStyleBackColor = false;
            this.btnNuevaUbicacion.Click += new System.EventHandler(this.btnNuevaUbicacion_Click);
            // 
            // btnBuscarUbicacion
            // 
            this.btnBuscarUbicacion.BackColor = System.Drawing.Color.Blue;
            this.btnBuscarUbicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarUbicacion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscarUbicacion.Location = new System.Drawing.Point(694, 32);
            this.btnBuscarUbicacion.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarUbicacion.Name = "btnBuscarUbicacion";
            this.btnBuscarUbicacion.Size = new System.Drawing.Size(159, 36);
            this.btnBuscarUbicacion.TabIndex = 2;
            this.btnBuscarUbicacion.Text = "Buscar";
            this.btnBuscarUbicacion.UseVisualStyleBackColor = false;
            this.btnBuscarUbicacion.Click += new System.EventHandler(this.btnBuscarUbicacion_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 73);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1056, 151);
            this.tabControl1.TabIndex = 117;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel3);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1048, 122);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ubicacion";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.btnBuscarUbicacion);
            this.panel3.Controls.Add(this.txt_Nombre);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txt_Ubicacion);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(4, 4);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1040, 118);
            this.panel3.TabIndex = 112;
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(363, 33);
            this.txt_Nombre.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(256, 22);
            this.txt_Nombre.TabIndex = 106;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(5, 33);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 21);
            this.label3.TabIndex = 107;
            this.label3.Text = "Clave:";
            // 
            // txt_Ubicacion
            // 
            this.txt_Ubicacion.Location = new System.Drawing.Point(81, 32);
            this.txt_Ubicacion.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Ubicacion.Name = "txt_Ubicacion";
            this.txt_Ubicacion.Size = new System.Drawing.Size(132, 22);
            this.txt_Ubicacion.TabIndex = 108;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(268, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 21);
            this.label2.TabIndex = 105;
            this.label2.Text = "Nombre:";
            // 
            // dgv_Ubicacion
            // 
            this.dgv_Ubicacion.AllowUserToAddRows = false;
            this.dgv_Ubicacion.AllowUserToDeleteRows = false;
            this.dgv_Ubicacion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Ubicacion.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Ubicacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Ubicacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_,
            this.nombre_ubicacion,
            this.avion,
            this.Ver});
            this.dgv_Ubicacion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_Ubicacion.Location = new System.Drawing.Point(0, 220);
            this.dgv_Ubicacion.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_Ubicacion.Name = "dgv_Ubicacion";
            this.dgv_Ubicacion.ReadOnly = true;
            this.dgv_Ubicacion.Size = new System.Drawing.Size(1056, 294);
            this.dgv_Ubicacion.TabIndex = 118;
            this.dgv_Ubicacion.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Ubicacion_CellContentClick);
            // 
            // Id_
            // 
            this.Id_.DataPropertyName = "Id_Ubicacion";
            this.Id_.HeaderText = "Clave";
            this.Id_.Name = "Id_";
            this.Id_.ReadOnly = true;
            // 
            // nombre_ubicacion
            // 
            this.nombre_ubicacion.DataPropertyName = "nombre_ubicacion";
            this.nombre_ubicacion.HeaderText = "Nombre";
            this.nombre_ubicacion.Name = "nombre_ubicacion";
            this.nombre_ubicacion.ReadOnly = true;
            // 
            // avion
            // 
            this.avion.DataPropertyName = "NombreModelo";
            this.avion.HeaderText = "Avion";
            this.avion.Name = "avion";
            this.avion.ReadOnly = true;
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
            // frm_Ubicacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 514);
            this.Controls.Add(this.dgv_Ubicacion);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Name = "frm_Ubicacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Ubicacion";
            this.Load += new System.EventHandler(this.frm_Ubicacion_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Ubicacion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBuscarUbicacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNuevaUbicacion;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Ubicacion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_Ubicacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_ubicacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn avion;
        private System.Windows.Forms.DataGridViewButtonColumn Ver;
    }
}