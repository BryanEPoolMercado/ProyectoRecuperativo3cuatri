namespace WFProyectoVuelo.GUI
{
    partial class frm_Pais
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_NuevoPais = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_BuscarPais = new System.Windows.Forms.Button();
            this.txt_Pais = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgv_Pais = new System.Windows.Forms.DataGridView();
            this.COD_Pais = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_pais = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detalle = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Pais)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_NuevoPais);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1067, 80);
            this.panel1.TabIndex = 10;
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
            this.label1.Size = new System.Drawing.Size(67, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "País";
            // 
            // btn_NuevoPais
            // 
            this.btn_NuevoPais.BackColor = System.Drawing.Color.Blue;
            this.btn_NuevoPais.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NuevoPais.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_NuevoPais.Location = new System.Drawing.Point(13, 14);
            this.btn_NuevoPais.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_NuevoPais.Name = "btn_NuevoPais";
            this.btn_NuevoPais.Size = new System.Drawing.Size(159, 53);
            this.btn_NuevoPais.TabIndex = 0;
            this.btn_NuevoPais.Text = "Nuevo país";
            this.btn_NuevoPais.UseVisualStyleBackColor = false;
            this.btn_NuevoPais.Click += new System.EventHandler(this.btn_NuevoPais_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 80);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1067, 151);
            this.tabControl1.TabIndex = 11;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_BuscarPais);
            this.tabPage1.Controls.Add(this.txt_Pais);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Size = new System.Drawing.Size(1059, 122);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "     Administrar     ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_BuscarPais
            // 
            this.btn_BuscarPais.BackColor = System.Drawing.Color.Blue;
            this.btn_BuscarPais.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BuscarPais.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_BuscarPais.Location = new System.Drawing.Point(857, 44);
            this.btn_BuscarPais.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_BuscarPais.Name = "btn_BuscarPais";
            this.btn_BuscarPais.Size = new System.Drawing.Size(159, 37);
            this.btn_BuscarPais.TabIndex = 2;
            this.btn_BuscarPais.Text = "Buscar";
            this.btn_BuscarPais.UseVisualStyleBackColor = false;
            this.btn_BuscarPais.Click += new System.EventHandler(this.btn_BuscarPais_Click);
            // 
            // txt_Pais
            // 
            this.txt_Pais.Location = new System.Drawing.Point(156, 52);
            this.txt_Pais.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Pais.Name = "txt_Pais";
            this.txt_Pais.Size = new System.Drawing.Size(551, 22);
            this.txt_Pais.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(105, 55);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "País:";
            // 
            // dgv_Pais
            // 
            this.dgv_Pais.AllowUserToAddRows = false;
            this.dgv_Pais.AllowUserToDeleteRows = false;
            this.dgv_Pais.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Pais.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Pais.ColumnHeadersHeight = 30;
            this.dgv_Pais.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.COD_Pais,
            this.Nombre_pais,
            this.Detalle});
            this.dgv_Pais.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Pais.Location = new System.Drawing.Point(0, 231);
            this.dgv_Pais.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgv_Pais.Name = "dgv_Pais";
            this.dgv_Pais.ReadOnly = true;
            this.dgv_Pais.Size = new System.Drawing.Size(1067, 323);
            this.dgv_Pais.TabIndex = 12;
            this.dgv_Pais.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Pais_CellContentClick);
            // 
            // COD_Pais
            // 
            this.COD_Pais.DataPropertyName = "Id_Pais";
            this.COD_Pais.HeaderText = "Código";
            this.COD_Pais.Name = "COD_Pais";
            this.COD_Pais.ReadOnly = true;
            // 
            // Nombre_pais
            // 
            this.Nombre_pais.DataPropertyName = "Nombre";
            this.Nombre_pais.HeaderText = "País";
            this.Nombre_pais.Name = "Nombre_pais";
            this.Nombre_pais.ReadOnly = true;
            // 
            // Detalle
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkGreen;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            this.Detalle.DefaultCellStyle = dataGridViewCellStyle2;
            this.Detalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Detalle.HeaderText = "";
            this.Detalle.Name = "Detalle";
            this.Detalle.ReadOnly = true;
            this.Detalle.Text = "Modificar";
            this.Detalle.UseColumnTextForButtonValue = true;
            // 
            // frm_Pais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.dgv_Pais);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frm_Pais";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Pais";
            this.Load += new System.EventHandler(this.frm_Pais_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Pais)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_NuevoPais;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btn_BuscarPais;
        private System.Windows.Forms.TextBox txt_Pais;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgv_Pais;
        private System.Windows.Forms.DataGridViewTextBoxColumn COD_Pais;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_pais;
        private System.Windows.Forms.DataGridViewButtonColumn Detalle;
    }
}