namespace WFProyectoVuelo.GUI
{
    partial class frm_Usuario
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
            this.btn_NuevoUsuario = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txt_ApellidoMat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_BuscarUsuario = new System.Windows.Forms.Button();
            this.txt_ApellidoPat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Usuario = new System.Windows.Forms.TextBox();
            this.txt_ClaveUsuario = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgv_Usuario = new System.Windows.Forms.DataGridView();
            this.IdUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApellidoPat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApellidoMat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono_us = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo_p = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Perfil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contrasenia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detalle = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Usuario)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_NuevoUsuario);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1067, 80);
            this.panel1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(431, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usuarios";
            // 
            // btn_NuevoUsuario
            // 
            this.btn_NuevoUsuario.BackColor = System.Drawing.Color.Blue;
            this.btn_NuevoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NuevoUsuario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_NuevoUsuario.Location = new System.Drawing.Point(13, 14);
            this.btn_NuevoUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.btn_NuevoUsuario.Name = "btn_NuevoUsuario";
            this.btn_NuevoUsuario.Size = new System.Drawing.Size(159, 53);
            this.btn_NuevoUsuario.TabIndex = 0;
            this.btn_NuevoUsuario.Text = "Nuevo Usuario";
            this.btn_NuevoUsuario.UseVisualStyleBackColor = false;
            this.btn_NuevoUsuario.Click += new System.EventHandler(this.btn_NuevoUsuario_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 80);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1067, 183);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txt_ApellidoMat);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.btn_BuscarUsuario);
            this.tabPage1.Controls.Add(this.txt_ApellidoPat);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txt_Usuario);
            this.tabPage1.Controls.Add(this.txt_ClaveUsuario);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1059, 154);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "     Administrar     ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txt_ApellidoMat
            // 
            this.txt_ApellidoMat.Location = new System.Drawing.Point(453, 32);
            this.txt_ApellidoMat.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ApellidoMat.Name = "txt_ApellidoMat";
            this.txt_ApellidoMat.Size = new System.Drawing.Size(255, 22);
            this.txt_ApellidoMat.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(449, 16);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Apellido materno:";
            // 
            // btn_BuscarUsuario
            // 
            this.btn_BuscarUsuario.BackColor = System.Drawing.Color.Blue;
            this.btn_BuscarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BuscarUsuario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_BuscarUsuario.Location = new System.Drawing.Point(817, 32);
            this.btn_BuscarUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.btn_BuscarUsuario.Name = "btn_BuscarUsuario";
            this.btn_BuscarUsuario.Size = new System.Drawing.Size(159, 42);
            this.btn_BuscarUsuario.TabIndex = 2;
            this.btn_BuscarUsuario.Text = "Buscar";
            this.btn_BuscarUsuario.UseVisualStyleBackColor = false;
            this.btn_BuscarUsuario.Click += new System.EventHandler(this.btn_BuscarUsuario_Click);
            // 
            // txt_ApellidoPat
            // 
            this.txt_ApellidoPat.Location = new System.Drawing.Point(144, 87);
            this.txt_ApellidoPat.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ApellidoPat.Name = "txt_ApellidoPat";
            this.txt_ApellidoPat.Size = new System.Drawing.Size(255, 22);
            this.txt_ApellidoPat.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(147, 68);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Apellido paterno:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Clave:";
            // 
            // txt_Usuario
            // 
            this.txt_Usuario.Location = new System.Drawing.Point(144, 32);
            this.txt_Usuario.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Usuario.Name = "txt_Usuario";
            this.txt_Usuario.Size = new System.Drawing.Size(255, 22);
            this.txt_Usuario.TabIndex = 5;
            // 
            // txt_ClaveUsuario
            // 
            this.txt_ClaveUsuario.Location = new System.Drawing.Point(25, 32);
            this.txt_ClaveUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ClaveUsuario.Name = "txt_ClaveUsuario";
            this.txt_ClaveUsuario.Size = new System.Drawing.Size(88, 22);
            this.txt_ClaveUsuario.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(140, 12);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Nombre:";
            // 
            // dgv_Usuario
            // 
            this.dgv_Usuario.AllowUserToAddRows = false;
            this.dgv_Usuario.AllowUserToDeleteRows = false;
            this.dgv_Usuario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Usuario.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Usuario.ColumnHeadersHeight = 30;
            this.dgv_Usuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdUsuario,
            this.NombreUsuario,
            this.ApellidoPat,
            this.ApellidoMat,
            this.fecha,
            this.Direccion,
            this.Telefono_us,
            this.Codigo_p,
            this.Perfil,
            this.correo,
            this.contrasenia,
            this.Detalle});
            this.dgv_Usuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Usuario.Location = new System.Drawing.Point(0, 263);
            this.dgv_Usuario.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_Usuario.Name = "dgv_Usuario";
            this.dgv_Usuario.ReadOnly = true;
            this.dgv_Usuario.Size = new System.Drawing.Size(1067, 291);
            this.dgv_Usuario.TabIndex = 9;
            this.dgv_Usuario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Usuario_CellContentClick);
            // 
            // IdUsuario
            // 
            this.IdUsuario.DataPropertyName = "Id_Usuario";
            this.IdUsuario.HeaderText = "Código";
            this.IdUsuario.Name = "IdUsuario";
            this.IdUsuario.ReadOnly = true;
            // 
            // NombreUsuario
            // 
            this.NombreUsuario.DataPropertyName = "Nombre";
            this.NombreUsuario.HeaderText = "Nombre";
            this.NombreUsuario.Name = "NombreUsuario";
            this.NombreUsuario.ReadOnly = true;
            // 
            // ApellidoPat
            // 
            this.ApellidoPat.DataPropertyName = "Apellido_pat";
            this.ApellidoPat.HeaderText = "Apellido Paterno";
            this.ApellidoPat.Name = "ApellidoPat";
            this.ApellidoPat.ReadOnly = true;
            // 
            // ApellidoMat
            // 
            this.ApellidoMat.DataPropertyName = "Apellido_mat";
            this.ApellidoMat.HeaderText = "Apellido Materno";
            this.ApellidoMat.Name = "ApellidoMat";
            this.ApellidoMat.ReadOnly = true;
            // 
            // fecha
            // 
            this.fecha.DataPropertyName = "Fecha";
            this.fecha.HeaderText = "Fecha de nacimiento";
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
            // 
            // Direccion
            // 
            this.Direccion.DataPropertyName = "Direccion";
            this.Direccion.HeaderText = "Dirección";
            this.Direccion.Name = "Direccion";
            this.Direccion.ReadOnly = true;
            // 
            // Telefono_us
            // 
            this.Telefono_us.DataPropertyName = "Telefono_us";
            this.Telefono_us.HeaderText = "Teléfono";
            this.Telefono_us.Name = "Telefono_us";
            this.Telefono_us.ReadOnly = true;
            // 
            // Codigo_p
            // 
            this.Codigo_p.DataPropertyName = "CodigoPos_Usuario";
            this.Codigo_p.HeaderText = "Código Postal";
            this.Codigo_p.Name = "Codigo_p";
            this.Codigo_p.ReadOnly = true;
            // 
            // Perfil
            // 
            this.Perfil.DataPropertyName = "Nombre_perfil";
            this.Perfil.HeaderText = "Perfil";
            this.Perfil.Name = "Perfil";
            this.Perfil.ReadOnly = true;
            // 
            // correo
            // 
            this.correo.DataPropertyName = "Correo";
            this.correo.HeaderText = "Correo";
            this.correo.Name = "correo";
            this.correo.ReadOnly = true;
            // 
            // contrasenia
            // 
            this.contrasenia.DataPropertyName = "Contrasenia";
            this.contrasenia.HeaderText = "Contraseña";
            this.contrasenia.Name = "contrasenia";
            this.contrasenia.ReadOnly = true;
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
            // frm_Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.dgv_Usuario);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Name = "frm_Usuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Usuario";
            this.Load += new System.EventHandler(this.frm_Usuario_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Usuario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_NuevoUsuario;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txt_ApellidoMat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_BuscarUsuario;
        private System.Windows.Forms.TextBox txt_ApellidoPat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Usuario;
        private System.Windows.Forms.TextBox txt_ClaveUsuario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgv_Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApellidoPat;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApellidoMat;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono_us;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo_p;
        private System.Windows.Forms.DataGridViewTextBoxColumn Perfil;
        private System.Windows.Forms.DataGridViewTextBoxColumn correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn contrasenia;
        private System.Windows.Forms.DataGridViewButtonColumn Detalle;
    }
}