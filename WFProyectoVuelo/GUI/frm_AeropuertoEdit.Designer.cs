namespace WFProyectoVuelo.GUI
{
    partial class frm_AeropuertoEdit
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
            this.txt_ClaveAeopuerto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbo_IdCiudad = new System.Windows.Forms.ComboBox();
            this.txt_NombreAeropuerto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.btn_GuardarNext = new System.Windows.Forms.Button();
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
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(840, 233);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txt_ClaveAeopuerto);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.cbo_IdCiudad);
            this.tabPage1.Controls.Add(this.txt_NombreAeropuerto);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Size = new System.Drawing.Size(832, 204);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "     Edicion     ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txt_ClaveAeopuerto
            // 
            this.txt_ClaveAeopuerto.Location = new System.Drawing.Point(15, 39);
            this.txt_ClaveAeopuerto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_ClaveAeopuerto.Name = "txt_ClaveAeopuerto";
            this.txt_ClaveAeopuerto.Size = new System.Drawing.Size(116, 22);
            this.txt_ClaveAeopuerto.TabIndex = 118;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 78);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 17);
            this.label4.TabIndex = 117;
            this.label4.Text = "Aeropuerto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 130);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 116;
            this.label3.Text = "Ciudad:";
            // 
            // cbo_IdCiudad
            // 
            this.cbo_IdCiudad.FormattingEnabled = true;
            this.cbo_IdCiudad.Location = new System.Drawing.Point(16, 150);
            this.cbo_IdCiudad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbo_IdCiudad.Name = "cbo_IdCiudad";
            this.cbo_IdCiudad.Size = new System.Drawing.Size(280, 24);
            this.cbo_IdCiudad.TabIndex = 115;
            // 
            // txt_NombreAeropuerto
            // 
            this.txt_NombreAeropuerto.Location = new System.Drawing.Point(15, 97);
            this.txt_NombreAeropuerto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_NombreAeropuerto.Name = "txt_NombreAeropuerto";
            this.txt_NombreAeropuerto.Size = new System.Drawing.Size(401, 22);
            this.txt_NombreAeropuerto.TabIndex = 9;
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
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(840, 80);
            this.panel1.TabIndex = 4;
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.BackColor = System.Drawing.Color.Blue;
            this.btn_Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancelar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Cancelar.Location = new System.Drawing.Point(707, 25);
            this.btn_Cancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.btn_Eliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.btn_Guardar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.btn_GuardarNext.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_GuardarNext.Name = "btn_GuardarNext";
            this.btn_GuardarNext.Size = new System.Drawing.Size(259, 37);
            this.btn_GuardarNext.TabIndex = 0;
            this.btn_GuardarNext.Text = "Guardar y Seguir Capturando";
            this.btn_GuardarNext.UseVisualStyleBackColor = false;
            this.btn_GuardarNext.Click += new System.EventHandler(this.btn_GuardarNext_Click);
            // 
            // frm_AeropuertoEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 313);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frm_AeropuertoEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_AeropuertoEdit";
            this.Load += new System.EventHandler(this.frm_AeropuertoEdit_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txt_NombreAeropuerto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.Button btn_GuardarNext;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbo_IdCiudad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_ClaveAeopuerto;
    }
}