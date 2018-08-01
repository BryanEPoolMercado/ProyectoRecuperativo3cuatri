namespace WFProyectoVuelo.GUI
{
    partial class frmPrecio
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNuevoPrecio = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Ruta = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Seccion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Avion = new System.Windows.Forms.TextBox();
            this.txt_Precio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_IdPrecio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_Precio = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdAero_Colum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ruta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ciudad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomaerolinea_colum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ver = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Precio)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnNuevoPrecio);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 59);
            this.panel1.TabIndex = 2;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.ForestGreen;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscar.Location = new System.Drawing.Point(20, 13);
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
            this.label1.Location = new System.Drawing.Point(684, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Precio";
            // 
            // btnNuevoPrecio
            // 
            this.btnNuevoPrecio.BackColor = System.Drawing.Color.ForestGreen;
            this.btnNuevoPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoPrecio.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNuevoPrecio.Location = new System.Drawing.Point(145, 13);
            this.btnNuevoPrecio.Name = "btnNuevoPrecio";
            this.btnNuevoPrecio.Size = new System.Drawing.Size(119, 43);
            this.btnNuevoPrecio.TabIndex = 0;
            this.btnNuevoPrecio.Text = "Nueva Precio";
            this.btnNuevoPrecio.UseVisualStyleBackColor = false;
            this.btnNuevoPrecio.Click += new System.EventHandler(this.btnNuevoPrecio_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 59);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 125);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 99);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Precio";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.txt_Ruta);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.txt_Seccion);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.txt_Avion);
            this.panel3.Controls.Add(this.txt_Precio);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txt_IdPrecio);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(786, 94);
            this.panel3.TabIndex = 112;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(185, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 17);
            this.label4.TabIndex = 115;
            this.label4.Text = "Ruta:";
            // 
            // txt_Ruta
            // 
            this.txt_Ruta.Location = new System.Drawing.Point(240, 53);
            this.txt_Ruta.Name = "txt_Ruta";
            this.txt_Ruta.Size = new System.Drawing.Size(100, 20);
            this.txt_Ruta.TabIndex = 116;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(172, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 17);
            this.label6.TabIndex = 113;
            this.label6.Text = "Seccion:";
            // 
            // txt_Seccion
            // 
            this.txt_Seccion.Location = new System.Drawing.Point(240, 11);
            this.txt_Seccion.Name = "txt_Seccion";
            this.txt_Seccion.Size = new System.Drawing.Size(100, 20);
            this.txt_Seccion.TabIndex = 114;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(5, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 17);
            this.label5.TabIndex = 111;
            this.label5.Text = "Avion:";
            // 
            // txt_Avion
            // 
            this.txt_Avion.Location = new System.Drawing.Point(60, 53);
            this.txt_Avion.Name = "txt_Avion";
            this.txt_Avion.Size = new System.Drawing.Size(100, 20);
            this.txt_Avion.TabIndex = 112;
            // 
            // txt_Precio
            // 
            this.txt_Precio.Location = new System.Drawing.Point(446, 29);
            this.txt_Precio.Name = "txt_Precio";
            this.txt_Precio.Size = new System.Drawing.Size(163, 20);
            this.txt_Precio.TabIndex = 106;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(5, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 17);
            this.label3.TabIndex = 107;
            this.label3.Text = "ID:";
            // 
            // txt_IdPrecio
            // 
            this.txt_IdPrecio.Location = new System.Drawing.Point(36, 11);
            this.txt_IdPrecio.Name = "txt_IdPrecio";
            this.txt_IdPrecio.Size = new System.Drawing.Size(100, 20);
            this.txt_IdPrecio.TabIndex = 108;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(397, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 105;
            this.label2.Text = "Precio:";
            // 
            // dgv_Precio
            // 
            this.dgv_Precio.AllowUserToDeleteRows = false;
            this.dgv_Precio.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Precio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Precio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.IdAero_Colum,
            this.Ruta,
            this.Ciudad,
            this.nomaerolinea_colum,
            this.Ver});
            this.dgv_Precio.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_Precio.Location = new System.Drawing.Point(0, 179);
            this.dgv_Precio.Name = "dgv_Precio";
            this.dgv_Precio.ReadOnly = true;
            this.dgv_Precio.Size = new System.Drawing.Size(800, 271);
            this.dgv_Precio.TabIndex = 112;
            this.dgv_Precio.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Precio_CellContentClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "Id_Precio";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // IdAero_Colum
            // 
            this.IdAero_Colum.DataPropertyName = "Id_Avion";
            this.IdAero_Colum.HeaderText = "Avion";
            this.IdAero_Colum.Name = "IdAero_Colum";
            this.IdAero_Colum.ReadOnly = true;
            // 
            // Ruta
            // 
            this.Ruta.DataPropertyName = "Id_Ruta";
            this.Ruta.HeaderText = "Ruta";
            this.Ruta.Name = "Ruta";
            this.Ruta.ReadOnly = true;
            // 
            // Ciudad
            // 
            this.Ciudad.DataPropertyName = "Id_Seccion";
            this.Ciudad.HeaderText = "Seccion";
            this.Ciudad.Name = "Ciudad";
            this.Ciudad.ReadOnly = true;
            // 
            // nomaerolinea_colum
            // 
            this.nomaerolinea_colum.DataPropertyName = "Precio1";
            this.nomaerolinea_colum.HeaderText = "Precio";
            this.nomaerolinea_colum.Name = "nomaerolinea_colum";
            this.nomaerolinea_colum.ReadOnly = true;
            // 
            // Ver
            // 
            this.Ver.HeaderText = "Ver";
            this.Ver.Name = "Ver";
            this.Ver.ReadOnly = true;
            // 
            // frmPrecio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgv_Precio);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Name = "frmPrecio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPrecio";
            this.Load += new System.EventHandler(this.frmPrecio_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Precio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNuevoPrecio;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txt_Precio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_IdPrecio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_Precio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Seccion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Avion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Ruta;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdAero_Colum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ruta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ciudad;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomaerolinea_colum;
        private System.Windows.Forms.DataGridViewButtonColumn Ver;
    }
}