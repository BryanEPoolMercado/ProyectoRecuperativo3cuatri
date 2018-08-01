namespace WFProyectoVuelo.GUI
{
    partial class frmAsiento
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
            this.dgv_Clase = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cmb_Clase = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Letra = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Clave = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNuevaClase = new System.Windows.Forms.Button();
            this.txtFila = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_Ubicacion = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Id_Asiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Letra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fila = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_Seccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ver = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Clase)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_Clase
            // 
            this.dgv_Clase.AllowUserToDeleteRows = false;
            this.dgv_Clase.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Clase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Clase.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Asiento,
            this.Letra,
            this.Fila,
            this.Id_Seccion,
            this.Id_,
            this.Ver});
            this.dgv_Clase.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_Clase.Location = new System.Drawing.Point(0, 168);
            this.dgv_Clase.Name = "dgv_Clase";
            this.dgv_Clase.ReadOnly = true;
            this.dgv_Clase.Size = new System.Drawing.Size(905, 271);
            this.dgv_Clase.TabIndex = 117;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 59);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(905, 123);
            this.tabControl1.TabIndex = 116;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(897, 97);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Aeropuerto";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gray;
            this.panel3.Controls.Add(this.cmb_Ubicacion);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.txtFila);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.cmb_Clase);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.txt_Letra);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txt_Clave);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(891, 94);
            this.panel3.TabIndex = 112;
            // 
            // cmb_Clase
            // 
            this.cmb_Clase.FormattingEnabled = true;
            this.cmb_Clase.Location = new System.Drawing.Point(545, 28);
            this.cmb_Clase.Name = "cmb_Clase";
            this.cmb_Clase.Size = new System.Drawing.Size(129, 21);
            this.cmb_Clase.TabIndex = 110;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(490, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 109;
            this.label4.Text = "Clase:";
            // 
            // txt_Letra
            // 
            this.txt_Letra.Location = new System.Drawing.Point(246, 28);
            this.txt_Letra.Name = "txt_Letra";
            this.txt_Letra.Size = new System.Drawing.Size(88, 20);
            this.txt_Letra.TabIndex = 106;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(4, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 107;
            this.label3.Text = "Clave:";
            // 
            // txt_Clave
            // 
            this.txt_Clave.Location = new System.Drawing.Point(61, 28);
            this.txt_Clave.Name = "txt_Clave";
            this.txt_Clave.Size = new System.Drawing.Size(100, 20);
            this.txt_Clave.TabIndex = 108;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(201, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 105;
            this.label2.Text = "Letra:";
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
            this.panel1.Size = new System.Drawing.Size(905, 59);
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
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(789, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Asiento";
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
            this.btnNuevaClase.Text = "Nuevo Asiento";
            this.btnNuevaClase.UseVisualStyleBackColor = false;
            // 
            // txtFila
            // 
            this.txtFila.Location = new System.Drawing.Point(390, 28);
            this.txtFila.Name = "txtFila";
            this.txtFila.Size = new System.Drawing.Size(71, 20);
            this.txtFila.TabIndex = 112;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(345, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 17);
            this.label5.TabIndex = 111;
            this.label5.Text = "Fila:";
            // 
            // cmb_Ubicacion
            // 
            this.cmb_Ubicacion.FormattingEnabled = true;
            this.cmb_Ubicacion.Location = new System.Drawing.Point(759, 28);
            this.cmb_Ubicacion.Name = "cmb_Ubicacion";
            this.cmb_Ubicacion.Size = new System.Drawing.Size(129, 21);
            this.cmb_Ubicacion.TabIndex = 114;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(682, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 17);
            this.label6.TabIndex = 113;
            this.label6.Text = "Ubicacion:";
            // 
            // Id_Asiento
            // 
            this.Id_Asiento.DataPropertyName = "Id_Asiento";
            this.Id_Asiento.HeaderText = "Clave";
            this.Id_Asiento.Name = "Id_Asiento";
            this.Id_Asiento.ReadOnly = true;
            // 
            // Letra
            // 
            this.Letra.DataPropertyName = "Letra";
            this.Letra.HeaderText = "Letra";
            this.Letra.Name = "Letra";
            this.Letra.ReadOnly = true;
            // 
            // Fila
            // 
            this.Fila.DataPropertyName = "Fila";
            this.Fila.HeaderText = "Fila";
            this.Fila.Name = "Fila";
            this.Fila.ReadOnly = true;
            // 
            // Id_Seccion
            // 
            this.Id_Seccion.DataPropertyName = "Id_Seccion";
            this.Id_Seccion.HeaderText = "Clase";
            this.Id_Seccion.Name = "Id_Seccion";
            this.Id_Seccion.ReadOnly = true;
            // 
            // Id_
            // 
            this.Id_.DataPropertyName = "Id_";
            this.Id_.HeaderText = "Ubicacion";
            this.Id_.Name = "Id_";
            this.Id_.ReadOnly = true;
            // 
            // Ver
            // 
            this.Ver.HeaderText = "Ver";
            this.Ver.Name = "Ver";
            this.Ver.ReadOnly = true;
            // 
            // frmAsiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 439);
            this.Controls.Add(this.dgv_Clase);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Name = "frmAsiento";
            this.Text = "frmAsiento";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Clase)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Clase;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cmb_Clase;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Letra;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Clave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNuevaClase;
        private System.Windows.Forms.TextBox txtFila;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmb_Ubicacion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Asiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Letra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fila;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Seccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_;
        private System.Windows.Forms.DataGridViewButtonColumn Ver;
    }
}