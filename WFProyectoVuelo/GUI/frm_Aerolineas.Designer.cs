namespace WFProyectoVuelo.GUI
{
    partial class frm_Aerolineas
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
            this.btn_NuevaAerolinea = new System.Windows.Forms.Button();
            this.btn_BuscarAerolinea = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_NombreAerolinea = new System.Windows.Forms.TextBox();
            this.txt_ClaveAerolinea = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgv_Aerolinea = new System.Windows.Forms.DataGridView();
            this.COD_CURSO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ETAPA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detalle = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Aerolinea)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_NuevaAerolinea);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1099, 80);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(455, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Aerolineas";
            // 
            // btn_NuevaAerolinea
            // 
            this.btn_NuevaAerolinea.BackColor = System.Drawing.Color.Blue;
            this.btn_NuevaAerolinea.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NuevaAerolinea.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_NuevaAerolinea.Location = new System.Drawing.Point(13, 13);
            this.btn_NuevaAerolinea.Margin = new System.Windows.Forms.Padding(4);
            this.btn_NuevaAerolinea.Name = "btn_NuevaAerolinea";
            this.btn_NuevaAerolinea.Size = new System.Drawing.Size(159, 53);
            this.btn_NuevaAerolinea.TabIndex = 0;
            this.btn_NuevaAerolinea.Text = "Nueva aerolinea";
            this.btn_NuevaAerolinea.UseVisualStyleBackColor = false;
            this.btn_NuevaAerolinea.Click += new System.EventHandler(this.btn_NuevaAerolinea_Click);
            // 
            // btn_BuscarAerolinea
            // 
            this.btn_BuscarAerolinea.BackColor = System.Drawing.Color.Blue;
            this.btn_BuscarAerolinea.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BuscarAerolinea.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_BuscarAerolinea.Location = new System.Drawing.Point(616, 44);
            this.btn_BuscarAerolinea.Margin = new System.Windows.Forms.Padding(4);
            this.btn_BuscarAerolinea.Name = "btn_BuscarAerolinea";
            this.btn_BuscarAerolinea.Size = new System.Drawing.Size(159, 37);
            this.btn_BuscarAerolinea.TabIndex = 2;
            this.btn_BuscarAerolinea.Text = "Buscar";
            this.btn_BuscarAerolinea.UseVisualStyleBackColor = false;
            this.btn_BuscarAerolinea.Click += new System.EventHandler(this.btn_BuscarAerolinea_Click);
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
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.btn_BuscarAerolinea);
            this.tabPage1.Controls.Add(this.txt_NombreAerolinea);
            this.tabPage1.Controls.Add(this.txt_ClaveAerolinea);
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
            this.label2.Visible = false;
            // 
            // txt_NombreAerolinea
            // 
            this.txt_NombreAerolinea.Location = new System.Drawing.Point(187, 52);
            this.txt_NombreAerolinea.Margin = new System.Windows.Forms.Padding(4);
            this.txt_NombreAerolinea.Name = "txt_NombreAerolinea";
            this.txt_NombreAerolinea.Size = new System.Drawing.Size(406, 22);
            this.txt_NombreAerolinea.TabIndex = 5;
            // 
            // txt_ClaveAerolinea
            // 
            this.txt_ClaveAerolinea.Location = new System.Drawing.Point(35, 52);
            this.txt_ClaveAerolinea.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ClaveAerolinea.Name = "txt_ClaveAerolinea";
            this.txt_ClaveAerolinea.Size = new System.Drawing.Size(88, 22);
            this.txt_ClaveAerolinea.TabIndex = 4;
            this.txt_ClaveAerolinea.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(183, 32);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Aerolinea:";
            // 
            // dgv_Aerolinea
            // 
            this.dgv_Aerolinea.AllowUserToAddRows = false;
            this.dgv_Aerolinea.AllowUserToDeleteRows = false;
            this.dgv_Aerolinea.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Aerolinea.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Aerolinea.ColumnHeadersHeight = 30;
            this.dgv_Aerolinea.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.COD_CURSO,
            this.ETAPA,
            this.Detalle});
            this.dgv_Aerolinea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Aerolinea.Location = new System.Drawing.Point(0, 231);
            this.dgv_Aerolinea.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_Aerolinea.Name = "dgv_Aerolinea";
            this.dgv_Aerolinea.ReadOnly = true;
            this.dgv_Aerolinea.Size = new System.Drawing.Size(1099, 336);
            this.dgv_Aerolinea.TabIndex = 3;
            this.dgv_Aerolinea.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Aerolinea_CellContentClick);
            // 
            // COD_CURSO
            // 
            this.COD_CURSO.DataPropertyName = "Id_Aerolinea";
            this.COD_CURSO.HeaderText = "Código";
            this.COD_CURSO.Name = "COD_CURSO";
            this.COD_CURSO.ReadOnly = true;
            // 
            // ETAPA
            // 
            this.ETAPA.DataPropertyName = "Nombre";
            this.ETAPA.HeaderText = "Aerolinea";
            this.ETAPA.Name = "ETAPA";
            this.ETAPA.ReadOnly = true;
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
            // frm_Aerolineas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 567);
            this.Controls.Add(this.dgv_Aerolinea);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Name = "frm_Aerolineas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Aerolineas";
            this.Load += new System.EventHandler(this.frm_Aerolineas_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Aerolinea)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_BuscarAerolinea;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_NuevaAerolinea;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txt_NombreAerolinea;
        private System.Windows.Forms.TextBox txt_ClaveAerolinea;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgv_Aerolinea;
        private System.Windows.Forms.DataGridViewTextBoxColumn COD_CURSO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ETAPA;
        private System.Windows.Forms.DataGridViewButtonColumn Detalle;
        private System.Windows.Forms.Label label2;
    }
}