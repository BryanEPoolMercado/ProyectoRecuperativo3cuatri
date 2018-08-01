namespace WFProyectoVuelo.GUI
{
    partial class frm_BuscarVuelos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.dgv_Vuelos = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.clave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.origen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aerolinea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.avion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fila = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.boton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.bunifuCards2 = new Bunifu.Framework.UI.BunifuCards();
            this.cmb_Destino = new System.Windows.Forms.ComboBox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btn_BuscarVuelo = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.dt_FechaVuelo = new System.Windows.Forms.DateTimePicker();
            this.cmb_Origen = new System.Windows.Forms.ComboBox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuCards1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Vuelos)).BeginInit();
            this.bunifuCards2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(130)))), ((int)(((byte)(232)))));
            this.bunifuCards1.Controls.Add(this.label2);
            this.bunifuCards1.Controls.Add(this.dgv_Vuelos);
            this.bunifuCards1.Controls.Add(this.bunifuCards2);
            this.bunifuCards1.Controls.Add(this.label1);
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(40, -15);
            this.bunifuCards1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(1307, 641);
            this.bunifuCards1.TabIndex = 3;
            // 
            // dgv_Vuelos
            // 
            this.dgv_Vuelos.AllowUserToAddRows = false;
            this.dgv_Vuelos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgv_Vuelos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Vuelos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Vuelos.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgv_Vuelos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Vuelos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(130)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Vuelos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Vuelos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Vuelos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clave,
            this.origen,
            this.destino,
            this.hora,
            this.HoraFin,
            this.fecha,
            this.aerolinea,
            this.avion,
            this.fila,
            this.columna,
            this.boton});
            this.dgv_Vuelos.DoubleBuffered = true;
            this.dgv_Vuelos.EnableHeadersVisualStyles = false;
            this.dgv_Vuelos.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(130)))), ((int)(((byte)(232)))));
            this.dgv_Vuelos.HeaderForeColor = System.Drawing.Color.White;
            this.dgv_Vuelos.Location = new System.Drawing.Point(0, 251);
            this.dgv_Vuelos.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_Vuelos.Name = "dgv_Vuelos";
            this.dgv_Vuelos.ReadOnly = true;
            this.dgv_Vuelos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_Vuelos.Size = new System.Drawing.Size(1307, 386);
            this.dgv_Vuelos.TabIndex = 3;
            this.dgv_Vuelos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Vuelos_CellContentClick);
            // 
            // clave
            // 
            this.clave.DataPropertyName = "Id_Vuelo";
            this.clave.HeaderText = "Clave";
            this.clave.Name = "clave";
            this.clave.ReadOnly = true;
            // 
            // origen
            // 
            this.origen.DataPropertyName = "Origen";
            this.origen.HeaderText = "Origen";
            this.origen.Name = "origen";
            this.origen.ReadOnly = true;
            // 
            // destino
            // 
            this.destino.DataPropertyName = "Destino";
            this.destino.HeaderText = "Destino";
            this.destino.Name = "destino";
            this.destino.ReadOnly = true;
            // 
            // hora
            // 
            this.hora.DataPropertyName = "Hora_Inicio";
            this.hora.HeaderText = "Hora Inicio";
            this.hora.Name = "hora";
            this.hora.ReadOnly = true;
            // 
            // HoraFin
            // 
            this.HoraFin.DataPropertyName = "Hora_Fin";
            this.HoraFin.HeaderText = "Hora Fin";
            this.HoraFin.Name = "HoraFin";
            this.HoraFin.ReadOnly = true;
            // 
            // fecha
            // 
            this.fecha.DataPropertyName = "Fecha";
            this.fecha.HeaderText = "Fecha";
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
            // 
            // aerolinea
            // 
            this.aerolinea.DataPropertyName = "Nombre";
            this.aerolinea.HeaderText = "Aerolinea";
            this.aerolinea.Name = "aerolinea";
            this.aerolinea.ReadOnly = true;
            // 
            // avion
            // 
            this.avion.DataPropertyName = "NombreModelo";
            this.avion.HeaderText = "Avion";
            this.avion.Name = "avion";
            this.avion.ReadOnly = true;
            // 
            // fila
            // 
            this.fila.DataPropertyName = "NumeroFilas";
            this.fila.HeaderText = "Fila";
            this.fila.Name = "fila";
            this.fila.ReadOnly = true;
            // 
            // columna
            // 
            this.columna.DataPropertyName = "NumeroColumnas";
            this.columna.HeaderText = "Columna";
            this.columna.Name = "columna";
            this.columna.ReadOnly = true;
            // 
            // boton
            // 
            this.boton.HeaderText = "";
            this.boton.Name = "boton";
            this.boton.ReadOnly = true;
            this.boton.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.boton.Text = "Seleccionar";
            this.boton.UseColumnTextForButtonValue = true;
            // 
            // bunifuCards2
            // 
            this.bunifuCards2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(130)))), ((int)(((byte)(232)))));
            this.bunifuCards2.BorderRadius = 5;
            this.bunifuCards2.BottomSahddow = true;
            this.bunifuCards2.color = System.Drawing.Color.Transparent;
            this.bunifuCards2.Controls.Add(this.cmb_Destino);
            this.bunifuCards2.Controls.Add(this.bunifuCustomLabel2);
            this.bunifuCards2.Controls.Add(this.btn_BuscarVuelo);
            this.bunifuCards2.Controls.Add(this.bunifuCustomLabel3);
            this.bunifuCards2.Controls.Add(this.dt_FechaVuelo);
            this.bunifuCards2.Controls.Add(this.cmb_Origen);
            this.bunifuCards2.Controls.Add(this.bunifuCustomLabel1);
            this.bunifuCards2.LeftSahddow = false;
            this.bunifuCards2.Location = new System.Drawing.Point(0, 63);
            this.bunifuCards2.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuCards2.Name = "bunifuCards2";
            this.bunifuCards2.RightSahddow = true;
            this.bunifuCards2.ShadowDepth = 20;
            this.bunifuCards2.Size = new System.Drawing.Size(1303, 180);
            this.bunifuCards2.TabIndex = 2;
            // 
            // cmb_Destino
            // 
            this.cmb_Destino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Destino.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Destino.FormattingEnabled = true;
            this.cmb_Destino.Location = new System.Drawing.Point(497, 50);
            this.cmb_Destino.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_Destino.Name = "cmb_Destino";
            this.cmb_Destino.Size = new System.Drawing.Size(376, 30);
            this.cmb_Destino.TabIndex = 12;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(492, 18);
            this.bunifuCustomLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(92, 25);
            this.bunifuCustomLabel2.TabIndex = 11;
            this.bunifuCustomLabel2.Text = "Destino:";
            // 
            // btn_BuscarVuelo
            // 
            this.btn_BuscarVuelo.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(115)))), ((int)(((byte)(166)))));
            this.btn_BuscarVuelo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(115)))), ((int)(((byte)(166)))));
            this.btn_BuscarVuelo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_BuscarVuelo.BorderRadius = 0;
            this.btn_BuscarVuelo.ButtonText = "Buscar";
            this.btn_BuscarVuelo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_BuscarVuelo.DisabledColor = System.Drawing.Color.Gray;
            this.btn_BuscarVuelo.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_BuscarVuelo.Iconimage = null;
            this.btn_BuscarVuelo.Iconimage_right = null;
            this.btn_BuscarVuelo.Iconimage_right_Selected = null;
            this.btn_BuscarVuelo.Iconimage_Selected = null;
            this.btn_BuscarVuelo.IconMarginLeft = 0;
            this.btn_BuscarVuelo.IconMarginRight = 0;
            this.btn_BuscarVuelo.IconRightVisible = true;
            this.btn_BuscarVuelo.IconRightZoom = 0D;
            this.btn_BuscarVuelo.IconVisible = true;
            this.btn_BuscarVuelo.IconZoom = 90D;
            this.btn_BuscarVuelo.IsTab = false;
            this.btn_BuscarVuelo.Location = new System.Drawing.Point(917, 41);
            this.btn_BuscarVuelo.Margin = new System.Windows.Forms.Padding(5);
            this.btn_BuscarVuelo.Name = "btn_BuscarVuelo";
            this.btn_BuscarVuelo.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(115)))), ((int)(((byte)(166)))));
            this.btn_BuscarVuelo.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(141)))), ((int)(((byte)(255)))));
            this.btn_BuscarVuelo.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_BuscarVuelo.selected = false;
            this.btn_BuscarVuelo.Size = new System.Drawing.Size(205, 39);
            this.btn_BuscarVuelo.TabIndex = 10;
            this.btn_BuscarVuelo.Text = "Buscar";
            this.btn_BuscarVuelo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_BuscarVuelo.Textcolor = System.Drawing.Color.White;
            this.btn_BuscarVuelo.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BuscarVuelo.Click += new System.EventHandler(this.btn_BuscarVuelo_Click);
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(28, 98);
            this.bunifuCustomLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(79, 25);
            this.bunifuCustomLabel3.TabIndex = 7;
            this.bunifuCustomLabel3.Text = "Fecha:";
            // 
            // dt_FechaVuelo
            // 
            this.dt_FechaVuelo.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_FechaVuelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_FechaVuelo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_FechaVuelo.Location = new System.Drawing.Point(33, 127);
            this.dt_FechaVuelo.Margin = new System.Windows.Forms.Padding(4);
            this.dt_FechaVuelo.Name = "dt_FechaVuelo";
            this.dt_FechaVuelo.Size = new System.Drawing.Size(147, 27);
            this.dt_FechaVuelo.TabIndex = 6;
            // 
            // cmb_Origen
            // 
            this.cmb_Origen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Origen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Origen.FormattingEnabled = true;
            this.cmb_Origen.Items.AddRange(new object[] {
            ""});
            this.cmb_Origen.Location = new System.Drawing.Point(33, 50);
            this.cmb_Origen.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_Origen.Name = "cmb_Origen";
            this.cmb_Origen.Size = new System.Drawing.Size(393, 30);
            this.cmb_Origen.TabIndex = 3;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(28, 16);
            this.bunifuCustomLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(84, 25);
            this.bunifuCustomLabel1.TabIndex = 2;
            this.bunifuCustomLabel1.Text = "Origen:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(451, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "Haga una reservacion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(811, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "label2";
            // 
            // frm_BuscarVuelos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1387, 660);
            this.Controls.Add(this.bunifuCards1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_BuscarVuelos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_BuscarVuelos";
            this.Load += new System.EventHandler(this.frm_BuscarVuelos_Load);
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Vuelos)).EndInit();
            this.bunifuCards2.ResumeLayout(false);
            this.bunifuCards2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgv_Vuelos;
        private Bunifu.Framework.UI.BunifuCards bunifuCards2;
        private System.Windows.Forms.ComboBox cmb_Destino;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuFlatButton btn_BuscarVuelo;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private System.Windows.Forms.DateTimePicker dt_FechaVuelo;
        private System.Windows.Forms.ComboBox cmb_Origen;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clave;
        private System.Windows.Forms.DataGridViewTextBoxColumn origen;
        private System.Windows.Forms.DataGridViewTextBoxColumn destino;
        private System.Windows.Forms.DataGridViewTextBoxColumn hora;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraFin;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn aerolinea;
        private System.Windows.Forms.DataGridViewTextBoxColumn avion;
        private System.Windows.Forms.DataGridViewTextBoxColumn fila;
        private System.Windows.Forms.DataGridViewTextBoxColumn columna;
        private System.Windows.Forms.DataGridViewButtonColumn boton;
        private System.Windows.Forms.Label label2;
    }
}