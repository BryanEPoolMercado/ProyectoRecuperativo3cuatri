namespace WFProyectoVuelo.GUI
{
    partial class frm_InformacionVuelo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_InformacionVuelo));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_HoraFinal = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cmb_CantPasajeros = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_Avion = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_cerrar_main = new Bunifu.Framework.UI.BunifuImageButton();
            this.lbl_Aerolinea = new System.Windows.Forms.Label();
            this.lbl_HoraInicio = new System.Windows.Forms.Label();
            this.lbl_Fecha = new System.Windows.Forms.Label();
            this.lbl_Destino = new System.Windows.Forms.Label();
            this.lbl_Origen = new System.Windows.Forms.Label();
            this.btn_RealizarPago = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_Asientos = new System.Windows.Forms.Panel();
            this.dgv_Asientos = new System.Windows.Forms.DataGridView();
            this.asiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cerrar_main)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Asientos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(130)))), ((int)(((byte)(232)))));
            this.panel1.Controls.Add(this.lbl_HoraFinal);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.cmb_CantPasajeros);
            this.panel1.Controls.Add(this.btn_RealizarPago);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.lbl_Avion);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_cerrar_main);
            this.panel1.Controls.Add(this.lbl_Aerolinea);
            this.panel1.Controls.Add(this.lbl_HoraInicio);
            this.panel1.Controls.Add(this.lbl_Fecha);
            this.panel1.Controls.Add(this.lbl_Destino);
            this.panel1.Controls.Add(this.lbl_Origen);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1387, 165);
            this.panel1.TabIndex = 2;
            // 
            // lbl_HoraFinal
            // 
            this.lbl_HoraFinal.AutoSize = true;
            this.lbl_HoraFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_HoraFinal.ForeColor = System.Drawing.Color.White;
            this.lbl_HoraFinal.Location = new System.Drawing.Point(453, 105);
            this.lbl_HoraFinal.Name = "lbl_HoraFinal";
            this.lbl_HoraFinal.Size = new System.Drawing.Size(78, 24);
            this.lbl_HoraFinal.TabIndex = 23;
            this.lbl_HoraFinal.Text = "HoraFin";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(353, 105);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 24);
            this.label11.TabIndex = 22;
            this.label11.Text = "Hora final:";
            // 
            // cmb_CantPasajeros
            // 
            this.cmb_CantPasajeros.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_CantPasajeros.FormattingEnabled = true;
            this.cmb_CantPasajeros.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cmb_CantPasajeros.Location = new System.Drawing.Point(213, 122);
            this.cmb_CantPasajeros.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_CantPasajeros.Name = "cmb_CantPasajeros";
            this.cmb_CantPasajeros.Size = new System.Drawing.Size(76, 24);
            this.cmb_CantPasajeros.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(36, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(171, 24);
            this.label7.TabIndex = 19;
            this.label7.Text = "Cant. de pasajeros:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(828, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 24);
            this.label6.TabIndex = 18;
            this.label6.Text = "Avion:";
            // 
            // lbl_Avion
            // 
            this.lbl_Avion.AutoSize = true;
            this.lbl_Avion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Avion.ForeColor = System.Drawing.Color.White;
            this.lbl_Avion.Location = new System.Drawing.Point(903, 63);
            this.lbl_Avion.Name = "lbl_Avion";
            this.lbl_Avion.Size = new System.Drawing.Size(58, 24);
            this.lbl_Avion.TabIndex = 17;
            this.lbl_Avion.Text = "Avion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(801, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 24);
            this.label5.TabIndex = 16;
            this.label5.Text = "Aerolinea:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(341, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 24);
            this.label4.TabIndex = 15;
            this.label4.Text = "Hora inicio:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(379, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 24);
            this.label3.TabIndex = 14;
            this.label3.Text = "Fecha:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(35, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 24);
            this.label2.TabIndex = 13;
            this.label2.Text = "Destino:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(39, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "Origen:";
            // 
            // btn_cerrar_main
            // 
            this.btn_cerrar_main.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cerrar_main.BackColor = System.Drawing.Color.Transparent;
            this.btn_cerrar_main.Image = ((System.Drawing.Image)(resources.GetObject("btn_cerrar_main.Image")));
            this.btn_cerrar_main.ImageActive = null;
            this.btn_cerrar_main.Location = new System.Drawing.Point(1353, 4);
            this.btn_cerrar_main.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cerrar_main.Name = "btn_cerrar_main";
            this.btn_cerrar_main.Size = new System.Drawing.Size(29, 27);
            this.btn_cerrar_main.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_cerrar_main.TabIndex = 11;
            this.btn_cerrar_main.TabStop = false;
            this.btn_cerrar_main.Zoom = 8;
            this.btn_cerrar_main.Click += new System.EventHandler(this.btn_cerrar_main_Click);
            // 
            // lbl_Aerolinea
            // 
            this.lbl_Aerolinea.AutoSize = true;
            this.lbl_Aerolinea.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Aerolinea.ForeColor = System.Drawing.Color.White;
            this.lbl_Aerolinea.Location = new System.Drawing.Point(903, 30);
            this.lbl_Aerolinea.Name = "lbl_Aerolinea";
            this.lbl_Aerolinea.Size = new System.Drawing.Size(91, 24);
            this.lbl_Aerolinea.TabIndex = 4;
            this.lbl_Aerolinea.Text = "Aerolinea";
            // 
            // lbl_HoraInicio
            // 
            this.lbl_HoraInicio.AutoSize = true;
            this.lbl_HoraInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_HoraInicio.ForeColor = System.Drawing.Color.White;
            this.lbl_HoraInicio.Location = new System.Drawing.Point(453, 63);
            this.lbl_HoraInicio.Name = "lbl_HoraInicio";
            this.lbl_HoraInicio.Size = new System.Drawing.Size(95, 24);
            this.lbl_HoraInicio.TabIndex = 3;
            this.lbl_HoraInicio.Text = "HoraInicio";
            // 
            // lbl_Fecha
            // 
            this.lbl_Fecha.AutoSize = true;
            this.lbl_Fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Fecha.ForeColor = System.Drawing.Color.White;
            this.lbl_Fecha.Location = new System.Drawing.Point(453, 30);
            this.lbl_Fecha.Name = "lbl_Fecha";
            this.lbl_Fecha.Size = new System.Drawing.Size(64, 24);
            this.lbl_Fecha.TabIndex = 2;
            this.lbl_Fecha.Text = "Fecha";
            // 
            // lbl_Destino
            // 
            this.lbl_Destino.AutoSize = true;
            this.lbl_Destino.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Destino.ForeColor = System.Drawing.Color.White;
            this.lbl_Destino.Location = new System.Drawing.Point(117, 63);
            this.lbl_Destino.Name = "lbl_Destino";
            this.lbl_Destino.Size = new System.Drawing.Size(73, 24);
            this.lbl_Destino.TabIndex = 1;
            this.lbl_Destino.Text = "Destino";
            // 
            // lbl_Origen
            // 
            this.lbl_Origen.AutoSize = true;
            this.lbl_Origen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Origen.ForeColor = System.Drawing.Color.White;
            this.lbl_Origen.Location = new System.Drawing.Point(117, 30);
            this.lbl_Origen.Name = "lbl_Origen";
            this.lbl_Origen.Size = new System.Drawing.Size(68, 24);
            this.lbl_Origen.TabIndex = 0;
            this.lbl_Origen.Text = "Origen";
            // 
            // btn_RealizarPago
            // 
            this.btn_RealizarPago.Location = new System.Drawing.Point(1216, 105);
            this.btn_RealizarPago.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_RealizarPago.Name = "btn_RealizarPago";
            this.btn_RealizarPago.Size = new System.Drawing.Size(127, 38);
            this.btn_RealizarPago.TabIndex = 21;
            this.btn_RealizarPago.Text = "Realizar pago";
            this.btn_RealizarPago.UseVisualStyleBackColor = true;
            this.btn_RealizarPago.Click += new System.EventHandler(this.btn_RealizarPago_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 165);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1387, 495);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // panel_Asientos
            // 
            this.panel_Asientos.BackColor = System.Drawing.Color.White;
            this.panel_Asientos.Location = new System.Drawing.Point(210, 270);
            this.panel_Asientos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_Asientos.Name = "panel_Asientos";
            this.panel_Asientos.Size = new System.Drawing.Size(821, 283);
            this.panel_Asientos.TabIndex = 25;
            // 
            // dgv_Asientos
            // 
            this.dgv_Asientos.AllowUserToAddRows = false;
            this.dgv_Asientos.AllowUserToDeleteRows = false;
            this.dgv_Asientos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Asientos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Asientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Asientos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.asiento});
            this.dgv_Asientos.Location = new System.Drawing.Point(238, 582);
            this.dgv_Asientos.Name = "dgv_Asientos";
            this.dgv_Asientos.ReadOnly = true;
            this.dgv_Asientos.RowTemplate.Height = 24;
            this.dgv_Asientos.Size = new System.Drawing.Size(208, 187);
            this.dgv_Asientos.TabIndex = 26;
            // 
            // asiento
            // 
            this.asiento.HeaderText = "Asiento seleccionado";
            this.asiento.Name = "asiento";
            this.asiento.ReadOnly = true;
            // 
            // frm_InformacionVuelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1387, 781);
            this.Controls.Add(this.dgv_Asientos);
            this.Controls.Add(this.panel_Asientos);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_InformacionVuelo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_InformacionVuelo";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cerrar_main)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Asientos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_HoraFinal;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_RealizarPago;
        private System.Windows.Forms.ComboBox cmb_CantPasajeros;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_Avion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuImageButton btn_cerrar_main;
        private System.Windows.Forms.Label lbl_Aerolinea;
        private System.Windows.Forms.Label lbl_HoraInicio;
        private System.Windows.Forms.Label lbl_Fecha;
        private System.Windows.Forms.Label lbl_Destino;
        private System.Windows.Forms.Label lbl_Origen;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel_Asientos;
        private System.Windows.Forms.DataGridView dgv_Asientos;
        private System.Windows.Forms.DataGridViewTextBoxColumn asiento;
    }
}