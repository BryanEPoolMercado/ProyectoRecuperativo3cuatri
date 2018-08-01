namespace WFProyectoVuelo.GUI
{
    partial class frm_VuelosEdit
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
            this.label7 = new System.Windows.Forms.Label();
            this.cmb_Ruta = new System.Windows.Forms.ComboBox();
            this.dt_Fecha = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_HoraFin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_HoraInicio = new System.Windows.Forms.TextBox();
            this.txt_ClaveVuelo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_Avion = new System.Windows.Forms.ComboBox();
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
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(840, 233);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.cmb_Ruta);
            this.tabPage1.Controls.Add(this.dt_Fecha);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.txt_HoraFin);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txt_HoraInicio);
            this.tabPage1.Controls.Add(this.txt_ClaveVuelo);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.cmb_Avion);
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(457, 20);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 17);
            this.label7.TabIndex = 126;
            this.label7.Text = "Ruta:";
            // 
            // cmb_Ruta
            // 
            this.cmb_Ruta.FormattingEnabled = true;
            this.cmb_Ruta.Location = new System.Drawing.Point(461, 40);
            this.cmb_Ruta.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_Ruta.Name = "cmb_Ruta";
            this.cmb_Ruta.Size = new System.Drawing.Size(280, 24);
            this.cmb_Ruta.TabIndex = 125;
            // 
            // dt_Fecha
            // 
            this.dt_Fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_Fecha.Location = new System.Drawing.Point(148, 100);
            this.dt_Fecha.Name = "dt_Fecha";
            this.dt_Fecha.Size = new System.Drawing.Size(280, 22);
            this.dt_Fecha.TabIndex = 124;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(145, 80);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 17);
            this.label6.TabIndex = 123;
            this.label6.Text = "Fecha:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 139);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 17);
            this.label5.TabIndex = 122;
            this.label5.Text = "Hora llegada:";
            // 
            // txt_HoraFin
            // 
            this.txt_HoraFin.Location = new System.Drawing.Point(16, 160);
            this.txt_HoraFin.Margin = new System.Windows.Forms.Padding(4);
            this.txt_HoraFin.Name = "txt_HoraFin";
            this.txt_HoraFin.Size = new System.Drawing.Size(116, 22);
            this.txt_HoraFin.TabIndex = 121;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 81);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 120;
            this.label2.Text = "Hora salida:";
            // 
            // txt_HoraInicio
            // 
            this.txt_HoraInicio.Location = new System.Drawing.Point(16, 102);
            this.txt_HoraInicio.Margin = new System.Windows.Forms.Padding(4);
            this.txt_HoraInicio.Name = "txt_HoraInicio";
            this.txt_HoraInicio.Size = new System.Drawing.Size(116, 22);
            this.txt_HoraInicio.TabIndex = 119;
            // 
            // txt_ClaveVuelo
            // 
            this.txt_ClaveVuelo.Location = new System.Drawing.Point(15, 39);
            this.txt_ClaveVuelo.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ClaveVuelo.Name = "txt_ClaveVuelo";
            this.txt_ClaveVuelo.Size = new System.Drawing.Size(116, 22);
            this.txt_ClaveVuelo.TabIndex = 118;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(144, 20);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 116;
            this.label3.Text = "Avion:";
            // 
            // cmb_Avion
            // 
            this.cmb_Avion.FormattingEnabled = true;
            this.cmb_Avion.Location = new System.Drawing.Point(148, 40);
            this.cmb_Avion.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_Avion.Name = "cmb_Avion";
            this.cmb_Avion.Size = new System.Drawing.Size(280, 24);
            this.cmb_Avion.TabIndex = 115;
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
            this.panel1.TabIndex = 5;
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
            // frm_VuelosEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 313);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.Name = "frm_VuelosEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_VuelosEdit";
            this.Load += new System.EventHandler(this.frm_VuelosEdit_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txt_ClaveVuelo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_Avion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmb_Ruta;
        private System.Windows.Forms.DateTimePicker dt_Fecha;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_HoraFin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_HoraInicio;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.Button btn_GuardarNext;
    }
}