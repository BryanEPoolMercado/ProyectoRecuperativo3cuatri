namespace WFProyectoVuelo.GUI
{
    partial class frm_UsuarioEdit
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dtm_FechaNacUsu = new System.Windows.Forms.DateTimePicker();
            this.cmb_Perfil = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_Cp = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_Telefono = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Direccion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_ApetMat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_ApePat = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_ClaveUsuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.btn_GuardarNext = new System.Windows.Forms.Button();
            this.txt_CorreoUsuario = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_ContraseniaUsuario = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(840, 233);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txt_ContraseniaUsuario);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.txt_CorreoUsuario);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.dtm_FechaNacUsu);
            this.tabPage1.Controls.Add(this.cmb_Perfil);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.txt_Cp);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.txt_Telefono);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.txt_Direccion);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txt_ApetMat);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txt_ApePat);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txt_Nombre);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.txt_ClaveUsuario);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(832, 204);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "     Edicion     ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dtm_FechaNacUsu
            // 
            this.dtm_FechaNacUsu.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtm_FechaNacUsu.Location = new System.Drawing.Point(401, 162);
            this.dtm_FechaNacUsu.Margin = new System.Windows.Forms.Padding(4);
            this.dtm_FechaNacUsu.Name = "dtm_FechaNacUsu";
            this.dtm_FechaNacUsu.Size = new System.Drawing.Size(198, 22);
            this.dtm_FechaNacUsu.TabIndex = 99;
            // 
            // cmb_Perfil
            // 
            this.cmb_Perfil.FormattingEnabled = true;
            this.cmb_Perfil.Location = new System.Drawing.Point(12, 102);
            this.cmb_Perfil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_Perfil.Name = "cmb_Perfil";
            this.cmb_Perfil.Size = new System.Drawing.Size(143, 24);
            this.cmb_Perfil.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 83);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 17);
            this.label9.TabIndex = 22;
            this.label9.Text = "Perfil:";
            // 
            // txt_Cp
            // 
            this.txt_Cp.Location = new System.Drawing.Point(392, 104);
            this.txt_Cp.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Cp.Name = "txt_Cp";
            this.txt_Cp.Size = new System.Drawing.Size(207, 22);
            this.txt_Cp.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(389, 83);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 17);
            this.label8.TabIndex = 20;
            this.label8.Text = "Código postal:";
            // 
            // txt_Telefono
            // 
            this.txt_Telefono.Location = new System.Drawing.Point(175, 104);
            this.txt_Telefono.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Telefono.Name = "txt_Telefono";
            this.txt_Telefono.Size = new System.Drawing.Size(209, 22);
            this.txt_Telefono.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(173, 83);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 17);
            this.label7.TabIndex = 18;
            this.label7.Text = "Teléfono:";
            // 
            // txt_Direccion
            // 
            this.txt_Direccion.Location = new System.Drawing.Point(15, 162);
            this.txt_Direccion.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Direccion.Name = "txt_Direccion";
            this.txt_Direccion.Size = new System.Drawing.Size(369, 22);
            this.txt_Direccion.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 141);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Dirección:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(397, 141);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Fecha de nacimiento:";
            // 
            // txt_ApetMat
            // 
            this.txt_ApetMat.Location = new System.Drawing.Point(609, 41);
            this.txt_ApetMat.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ApetMat.Name = "txt_ApetMat";
            this.txt_ApetMat.Size = new System.Drawing.Size(209, 22);
            this.txt_ApetMat.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(607, 20);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Apellido materno:";
            // 
            // txt_ApePat
            // 
            this.txt_ApePat.Location = new System.Drawing.Point(392, 41);
            this.txt_ApePat.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ApePat.Name = "txt_ApePat";
            this.txt_ApePat.Size = new System.Drawing.Size(209, 22);
            this.txt_ApePat.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(389, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Apellido paterno:";
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(175, 41);
            this.txt_Nombre.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(209, 22);
            this.txt_Nombre.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(172, 20);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Nombre:";
            // 
            // txt_ClaveUsuario
            // 
            this.txt_ClaveUsuario.Location = new System.Drawing.Point(15, 41);
            this.txt_ClaveUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ClaveUsuario.Name = "txt_ClaveUsuario";
            this.txt_ClaveUsuario.Size = new System.Drawing.Size(140, 22);
            this.txt_ClaveUsuario.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Clave:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.btn_Cancelar);
            this.panel1.Controls.Add(this.btn_Eliminar);
            this.panel1.Controls.Add(this.btn_Guardar);
            this.panel1.Controls.Add(this.btn_GuardarNext);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 233);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(840, 80);
            this.panel1.TabIndex = 7;
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.BackColor = System.Drawing.Color.Blue;
            this.btn_Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancelar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Cancelar.Location = new System.Drawing.Point(707, 25);
            this.btn_Cancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(120, 37);
            this.btn_Cancelar.TabIndex = 4;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = false;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.BackColor = System.Drawing.Color.DarkRed;
            this.btn_Eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Eliminar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Eliminar.Location = new System.Drawing.Point(444, 25);
            this.btn_Eliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(159, 37);
            this.btn_Eliminar.TabIndex = 3;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = false;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.BackColor = System.Drawing.Color.Blue;
            this.btn_Guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Guardar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Guardar.Location = new System.Drawing.Point(16, 25);
            this.btn_Guardar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(120, 37);
            this.btn_Guardar.TabIndex = 2;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.UseVisualStyleBackColor = false;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // btn_GuardarNext
            // 
            this.btn_GuardarNext.BackColor = System.Drawing.Color.Blue;
            this.btn_GuardarNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GuardarNext.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_GuardarNext.Location = new System.Drawing.Point(164, 25);
            this.btn_GuardarNext.Margin = new System.Windows.Forms.Padding(4);
            this.btn_GuardarNext.Name = "btn_GuardarNext";
            this.btn_GuardarNext.Size = new System.Drawing.Size(259, 37);
            this.btn_GuardarNext.TabIndex = 0;
            this.btn_GuardarNext.Text = "Guardar y Seguir Capturando";
            this.btn_GuardarNext.UseVisualStyleBackColor = false;
            this.btn_GuardarNext.Click += new System.EventHandler(this.btn_GuardarNext_Click);
            // 
            // txt_CorreoUsuario
            // 
            this.txt_CorreoUsuario.Location = new System.Drawing.Point(615, 104);
            this.txt_CorreoUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txt_CorreoUsuario.Name = "txt_CorreoUsuario";
            this.txt_CorreoUsuario.Size = new System.Drawing.Size(209, 22);
            this.txt_CorreoUsuario.TabIndex = 101;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(613, 83);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 17);
            this.label10.TabIndex = 100;
            this.label10.Text = "Correo:";
            // 
            // txt_ContraseniaUsuario
            // 
            this.txt_ContraseniaUsuario.Location = new System.Drawing.Point(615, 164);
            this.txt_ContraseniaUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ContraseniaUsuario.Name = "txt_ContraseniaUsuario";
            this.txt_ContraseniaUsuario.Size = new System.Drawing.Size(209, 22);
            this.txt_ContraseniaUsuario.TabIndex = 103;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(613, 143);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 17);
            this.label11.TabIndex = 102;
            this.label11.Text = "Contraseña:";
            // 
            // frm_UsuarioEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 312);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.Name = "frm_UsuarioEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_UsuarioEdit";
            this.Load += new System.EventHandler(this.frm_UsuarioEdit_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DateTimePicker dtm_FechaNacUsu;
        private System.Windows.Forms.ComboBox cmb_Perfil;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_Cp;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_Telefono;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_Direccion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_ApetMat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_ApePat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_ClaveUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.Button btn_GuardarNext;
        private System.Windows.Forms.TextBox txt_ContraseniaUsuario;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_CorreoUsuario;
        private System.Windows.Forms.Label label10;
    }
}