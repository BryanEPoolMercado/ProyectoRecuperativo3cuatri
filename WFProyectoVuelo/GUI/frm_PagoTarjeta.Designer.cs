namespace WFProyectoVuelo.GUI
{
    partial class frm_PagoTarjeta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_PagoTarjeta));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_cerrar_main = new Bunifu.Framework.UI.BunifuImageButton();
            this.Panel_Contenido = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.btn_RealizarPago = new System.Windows.Forms.Button();
            this.txt_NIP = new System.Windows.Forms.TextBox();
            this.txt_NumeroCuenta = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_Tarjeta = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_IdVuelo = new System.Windows.Forms.TextBox();
            this.dgv_Carrito = new System.Windows.Forms.DataGridView();
            this.claveasiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.letraocup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numocup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioocup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quitar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_Cantidad = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cerrar_main)).BeginInit();
            this.Panel_Contenido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Carrito)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(130)))), ((int)(((byte)(232)))));
            this.panel1.Controls.Add(this.btn_cerrar_main);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1079, 39);
            this.panel1.TabIndex = 3;
            // 
            // btn_cerrar_main
            // 
            this.btn_cerrar_main.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cerrar_main.BackColor = System.Drawing.Color.Transparent;
            this.btn_cerrar_main.Image = ((System.Drawing.Image)(resources.GetObject("btn_cerrar_main.Image")));
            this.btn_cerrar_main.ImageActive = null;
            this.btn_cerrar_main.Location = new System.Drawing.Point(1046, 4);
            this.btn_cerrar_main.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cerrar_main.Name = "btn_cerrar_main";
            this.btn_cerrar_main.Size = new System.Drawing.Size(29, 27);
            this.btn_cerrar_main.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_cerrar_main.TabIndex = 12;
            this.btn_cerrar_main.TabStop = false;
            this.btn_cerrar_main.Zoom = 8;
            this.btn_cerrar_main.Click += new System.EventHandler(this.btn_cerrar_main_Click);
            // 
            // Panel_Contenido
            // 
            this.Panel_Contenido.Controls.Add(this.label12);
            this.Panel_Contenido.Controls.Add(this.btn_RealizarPago);
            this.Panel_Contenido.Controls.Add(this.txt_NIP);
            this.Panel_Contenido.Controls.Add(this.txt_NumeroCuenta);
            this.Panel_Contenido.Controls.Add(this.label3);
            this.Panel_Contenido.Location = new System.Drawing.Point(111, 206);
            this.Panel_Contenido.Name = "Panel_Contenido";
            this.Panel_Contenido.Size = new System.Drawing.Size(862, 310);
            this.Panel_Contenido.TabIndex = 7;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(248, 133);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(33, 17);
            this.label12.TabIndex = 30;
            this.label12.Text = "Nip:";
            // 
            // btn_RealizarPago
            // 
            this.btn_RealizarPago.Location = new System.Drawing.Point(251, 219);
            this.btn_RealizarPago.Name = "btn_RealizarPago";
            this.btn_RealizarPago.Size = new System.Drawing.Size(348, 38);
            this.btn_RealizarPago.TabIndex = 23;
            this.btn_RealizarPago.Text = "Realizar pago";
            this.btn_RealizarPago.UseVisualStyleBackColor = true;
            this.btn_RealizarPago.Click += new System.EventHandler(this.btn_RealizarPago_Click);
            // 
            // txt_NIP
            // 
            this.txt_NIP.Location = new System.Drawing.Point(251, 153);
            this.txt_NIP.Name = "txt_NIP";
            this.txt_NIP.Size = new System.Drawing.Size(348, 22);
            this.txt_NIP.TabIndex = 17;
            // 
            // txt_NumeroCuenta
            // 
            this.txt_NumeroCuenta.Location = new System.Drawing.Point(251, 81);
            this.txt_NumeroCuenta.Name = "txt_NumeroCuenta";
            this.txt_NumeroCuenta.Size = new System.Drawing.Size(348, 22);
            this.txt_NumeroCuenta.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(248, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Numero de cuenta:";
            // 
            // cmb_Tarjeta
            // 
            this.cmb_Tarjeta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Tarjeta.FormattingEnabled = true;
            this.cmb_Tarjeta.Items.AddRange(new object[] {
            "",
            "Banamex",
            "Bancomer",
            "HSBC",
            "Santander",
            "Banorte",
            "Scotiabank Inverlat",
            "Banco Inbursa"});
            this.cmb_Tarjeta.Location = new System.Drawing.Point(129, 139);
            this.cmb_Tarjeta.Name = "cmb_Tarjeta";
            this.cmb_Tarjeta.Size = new System.Drawing.Size(249, 24);
            this.cmb_Tarjeta.TabIndex = 27;
            this.cmb_Tarjeta.SelectedIndexChanged += new System.EventHandler(this.cmb_Tarjeta_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(126, 119);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 17);
            this.label9.TabIndex = 26;
            this.label9.Text = "Banco:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(309, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(451, 22);
            this.label1.TabIndex = 28;
            this.label1.Text = "El pago se realizara con cargo a su tarjeta de credito\r\n";
            // 
            // txt_IdVuelo
            // 
            this.txt_IdVuelo.Location = new System.Drawing.Point(12, 45);
            this.txt_IdVuelo.Name = "txt_IdVuelo";
            this.txt_IdVuelo.Size = new System.Drawing.Size(45, 22);
            this.txt_IdVuelo.TabIndex = 29;
            // 
            // dgv_Carrito
            // 
            this.dgv_Carrito.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dgv_Carrito.AllowUserToAddRows = false;
            this.dgv_Carrito.AllowUserToDeleteRows = false;
            this.dgv_Carrito.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Carrito.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Carrito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Carrito.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.claveasiento,
            this.letraocup,
            this.numocup,
            this.precioocup,
            this.quitar});
            this.dgv_Carrito.Location = new System.Drawing.Point(235, 216);
            this.dgv_Carrito.Name = "dgv_Carrito";
            this.dgv_Carrito.ReadOnly = true;
            this.dgv_Carrito.RowTemplate.Height = 24;
            this.dgv_Carrito.Size = new System.Drawing.Size(328, 274);
            this.dgv_Carrito.TabIndex = 30;
            // 
            // claveasiento
            // 
            this.claveasiento.DataPropertyName = "Id_Asiento";
            this.claveasiento.HeaderText = "Clave";
            this.claveasiento.Name = "claveasiento";
            this.claveasiento.ReadOnly = true;
            // 
            // letraocup
            // 
            this.letraocup.DataPropertyName = "letra";
            this.letraocup.HeaderText = "Letra";
            this.letraocup.Name = "letraocup";
            this.letraocup.ReadOnly = true;
            // 
            // numocup
            // 
            this.numocup.DataPropertyName = "numero";
            this.numocup.HeaderText = "Número";
            this.numocup.Name = "numocup";
            this.numocup.ReadOnly = true;
            // 
            // precioocup
            // 
            this.precioocup.DataPropertyName = "precio";
            this.precioocup.HeaderText = "Precio";
            this.precioocup.Name = "precioocup";
            this.precioocup.ReadOnly = true;
            // 
            // quitar
            // 
            this.quitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.quitar.HeaderText = "";
            this.quitar.Name = "quitar";
            this.quitar.ReadOnly = true;
            this.quitar.Text = "Quitar";
            this.quitar.UseColumnTextForButtonValue = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(555, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 20);
            this.label2.TabIndex = 31;
            this.label2.Text = "Su pago sera de:";
            // 
            // lbl_Cantidad
            // 
            this.lbl_Cantidad.AutoSize = true;
            this.lbl_Cantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Cantidad.Location = new System.Drawing.Point(719, 149);
            this.lbl_Cantidad.Name = "lbl_Cantidad";
            this.lbl_Cantidad.Size = new System.Drawing.Size(83, 20);
            this.lbl_Cantidad.TabIndex = 32;
            this.lbl_Cantidad.Text = "Cantidad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(694, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 20);
            this.label4.TabIndex = 33;
            this.label4.Text = "$";
            // 
            // frm_PagoTarjeta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1079, 528);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_Cantidad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Panel_Contenido);
            this.Controls.Add(this.dgv_Carrito);
            this.Controls.Add(this.txt_IdVuelo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cmb_Tarjeta);
            this.Controls.Add(this.label9);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_PagoTarjeta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_PagoTarjeta";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_cerrar_main)).EndInit();
            this.Panel_Contenido.ResumeLayout(false);
            this.Panel_Contenido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Carrito)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton btn_cerrar_main;
        private System.Windows.Forms.Panel Panel_Contenido;
        private System.Windows.Forms.Button btn_RealizarPago;
        private System.Windows.Forms.TextBox txt_NIP;
        private System.Windows.Forms.TextBox txt_NumeroCuenta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmb_Tarjeta;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_IdVuelo;
        private System.Windows.Forms.DataGridView dgv_Carrito;
        private System.Windows.Forms.DataGridViewTextBoxColumn claveasiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn letraocup;
        private System.Windows.Forms.DataGridViewTextBoxColumn numocup;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioocup;
        private System.Windows.Forms.DataGridViewButtonColumn quitar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_Cantidad;
        private System.Windows.Forms.Label label4;
    }
}