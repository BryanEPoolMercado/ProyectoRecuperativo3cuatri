namespace WFProyectoVuelo.GUI
{
    partial class frm_Perfiles
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_NuevoPerfil = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_BuscarPerfil = new System.Windows.Forms.Button();
            this.txt_Perfil = new System.Windows.Forms.TextBox();
            this.txt_ClavePerfil = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgv_Perfiles = new System.Windows.Forms.DataGridView();
            this.COD_CURSO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numpasajeros = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detalle = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Perfiles)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_NuevoPerfil);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1099, 80);
            this.panel1.TabIndex = 3;
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
            this.label1.Size = new System.Drawing.Size(105, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Perfiles";
            // 
            // btn_NuevoPerfil
            // 
            this.btn_NuevoPerfil.BackColor = System.Drawing.Color.Blue;
            this.btn_NuevoPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NuevoPerfil.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_NuevoPerfil.Location = new System.Drawing.Point(13, 13);
            this.btn_NuevoPerfil.Margin = new System.Windows.Forms.Padding(4);
            this.btn_NuevoPerfil.Name = "btn_NuevoPerfil";
            this.btn_NuevoPerfil.Size = new System.Drawing.Size(159, 53);
            this.btn_NuevoPerfil.TabIndex = 0;
            this.btn_NuevoPerfil.Text = "Nuevo avion";
            this.btn_NuevoPerfil.UseVisualStyleBackColor = false;
            this.btn_NuevoPerfil.Click += new System.EventHandler(this.btn_NuevoPerfil_Click);
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
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.btn_BuscarPerfil);
            this.tabPage1.Controls.Add(this.txt_Perfil);
            this.tabPage1.Controls.Add(this.txt_ClavePerfil);
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
            // 
            // btn_BuscarPerfil
            // 
            this.btn_BuscarPerfil.BackColor = System.Drawing.Color.Blue;
            this.btn_BuscarPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BuscarPerfil.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_BuscarPerfil.Location = new System.Drawing.Point(857, 44);
            this.btn_BuscarPerfil.Margin = new System.Windows.Forms.Padding(4);
            this.btn_BuscarPerfil.Name = "btn_BuscarPerfil";
            this.btn_BuscarPerfil.Size = new System.Drawing.Size(159, 37);
            this.btn_BuscarPerfil.TabIndex = 2;
            this.btn_BuscarPerfil.Text = "Buscar";
            this.btn_BuscarPerfil.UseVisualStyleBackColor = false;
            this.btn_BuscarPerfil.Click += new System.EventHandler(this.btn_BuscarPerfil_Click);
            // 
            // txt_Perfil
            // 
            this.txt_Perfil.Location = new System.Drawing.Point(156, 52);
            this.txt_Perfil.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Perfil.Name = "txt_Perfil";
            this.txt_Perfil.Size = new System.Drawing.Size(551, 22);
            this.txt_Perfil.TabIndex = 5;
            // 
            // txt_ClavePerfil
            // 
            this.txt_ClavePerfil.Location = new System.Drawing.Point(35, 52);
            this.txt_ClavePerfil.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ClavePerfil.Name = "txt_ClavePerfil";
            this.txt_ClavePerfil.Size = new System.Drawing.Size(88, 22);
            this.txt_ClavePerfil.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(152, 32);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Perfil:";
            // 
            // dgv_Perfiles
            // 
            this.dgv_Perfiles.AllowUserToAddRows = false;
            this.dgv_Perfiles.AllowUserToDeleteRows = false;
            this.dgv_Perfiles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Perfiles.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Perfiles.ColumnHeadersHeight = 30;
            this.dgv_Perfiles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.COD_CURSO,
            this.numpasajeros,
            this.Detalle});
            this.dgv_Perfiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Perfiles.Location = new System.Drawing.Point(0, 231);
            this.dgv_Perfiles.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_Perfiles.Name = "dgv_Perfiles";
            this.dgv_Perfiles.ReadOnly = true;
            this.dgv_Perfiles.Size = new System.Drawing.Size(1099, 336);
            this.dgv_Perfiles.TabIndex = 5;
            this.dgv_Perfiles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Perfiles_CellContentClick);
            // 
            // COD_CURSO
            // 
            this.COD_CURSO.DataPropertyName = "Id_Perfil";
            this.COD_CURSO.HeaderText = "Código";
            this.COD_CURSO.Name = "COD_CURSO";
            this.COD_CURSO.ReadOnly = true;
            // 
            // numpasajeros
            // 
            this.numpasajeros.DataPropertyName = "Nombre_Perfil";
            this.numpasajeros.HeaderText = "Perfil";
            this.numpasajeros.Name = "numpasajeros";
            this.numpasajeros.ReadOnly = true;
            // 
            // Detalle
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.DarkGreen;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            this.Detalle.DefaultCellStyle = dataGridViewCellStyle6;
            this.Detalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Detalle.HeaderText = "";
            this.Detalle.Name = "Detalle";
            this.Detalle.ReadOnly = true;
            this.Detalle.Text = "Modificar";
            this.Detalle.UseColumnTextForButtonValue = true;
            // 
            // frm_Perfiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 567);
            this.Controls.Add(this.dgv_Perfiles);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Name = "frm_Perfiles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Perfiles";
            this.Load += new System.EventHandler(this.frm_Perfiles_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Perfiles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_NuevoPerfil;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_BuscarPerfil;
        private System.Windows.Forms.TextBox txt_Perfil;
        private System.Windows.Forms.TextBox txt_ClavePerfil;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgv_Perfiles;
        private System.Windows.Forms.DataGridViewTextBoxColumn COD_CURSO;
        private System.Windows.Forms.DataGridViewTextBoxColumn numpasajeros;
        private System.Windows.Forms.DataGridViewButtonColumn Detalle;
    }
}