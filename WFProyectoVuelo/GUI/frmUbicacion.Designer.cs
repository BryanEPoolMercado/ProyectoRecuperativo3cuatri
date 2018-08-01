namespace WFProyectoVuelo.GUI
{
    partial class frmUbicacion
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
            this.dgv_Ubicacion = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cmb_Asiento = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Ubicacion = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNuevaClase = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.Id_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_ubicacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_Asiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ver = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Ubicacion)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_Ubicacion
            // 
            this.dgv_Ubicacion.AllowUserToDeleteRows = false;
            this.dgv_Ubicacion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Ubicacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Ubicacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_,
            this.nombre_ubicacion,
            this.Id_Asiento,
            this.Ver});
            this.dgv_Ubicacion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_Ubicacion.Location = new System.Drawing.Point(0, 147);
            this.dgv_Ubicacion.Name = "dgv_Ubicacion";
            this.dgv_Ubicacion.ReadOnly = true;
            this.dgv_Ubicacion.Size = new System.Drawing.Size(792, 271);
            this.dgv_Ubicacion.TabIndex = 117;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 59);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(792, 123);
            this.tabControl1.TabIndex = 116;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(784, 97);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Aeropuerto";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gray;
            this.panel3.Controls.Add(this.cmb_Asiento);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.txt_Nombre);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txt_Ubicacion);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(778, 94);
            this.panel3.TabIndex = 112;
            // 
            // cmb_Asiento
            // 
            this.cmb_Asiento.FormattingEnabled = true;
            this.cmb_Asiento.Location = new System.Drawing.Point(550, 26);
            this.cmb_Asiento.Name = "cmb_Asiento";
            this.cmb_Asiento.Size = new System.Drawing.Size(193, 21);
            this.cmb_Asiento.TabIndex = 110;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(467, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 17);
            this.label4.TabIndex = 109;
            this.label4.Text = "Ubicacion:";
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
            // txt_Ubicacion
            // 
            this.txt_Ubicacion.Location = new System.Drawing.Point(61, 26);
            this.txt_Ubicacion.Name = "txt_Ubicacion";
            this.txt_Ubicacion.Size = new System.Drawing.Size(100, 20);
            this.txt_Ubicacion.TabIndex = 108;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnNuevaClase);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(792, 59);
            this.panel1.TabIndex = 115;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscar.Location = new System.Drawing.Point(20, 9);
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
            this.label1.Location = new System.Drawing.Point(676, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ubicacion";
            // 
            // btnNuevaClase
            // 
            this.btnNuevaClase.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnNuevaClase.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevaClase.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNuevaClase.Location = new System.Drawing.Point(145, 9);
            this.btnNuevaClase.Name = "btnNuevaClase";
            this.btnNuevaClase.Size = new System.Drawing.Size(119, 43);
            this.btnNuevaClase.TabIndex = 0;
            this.btnNuevaClase.Text = "Nueva Ubicacion";
            this.btnNuevaClase.UseVisualStyleBackColor = false;
            this.btnNuevaClase.Click += new System.EventHandler(this.btnNuevaClase_Click);
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
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(272, 27);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(163, 20);
            this.txt_Nombre.TabIndex = 106;
            // 
            // Id_
            // 
            this.Id_.DataPropertyName = "Id_";
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
            // Id_Asiento
            // 
            this.Id_Asiento.DataPropertyName = "Id_Asiento";
            this.Id_Asiento.HeaderText = "Asiento";
            this.Id_Asiento.Name = "Id_Asiento";
            this.Id_Asiento.ReadOnly = true;
            // 
            // Ver
            // 
            this.Ver.HeaderText = "Ver";
            this.Ver.Name = "Ver";
            this.Ver.ReadOnly = true;
            // 
            // frmUbicacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 418);
            this.Controls.Add(this.dgv_Ubicacion);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Name = "frmUbicacion";
            this.Text = "frmUbicacion";
            this.Load += new System.EventHandler(this.frmUbicacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Ubicacion)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Ubicacion;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cmb_Asiento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Ubicacion;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNuevaClase;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_ubicacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Asiento;
        private System.Windows.Forms.DataGridViewButtonColumn Ver;
    }
}