namespace WFProyectoVuelo.GUI
{
    partial class frm_Moneda
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_NuevaMoneda = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_BuscarMoneda = new System.Windows.Forms.Button();
            this.txt_NombreMoneda = new System.Windows.Forms.TextBox();
            this.txt_ClaveMoneda = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgv_Moneda = new System.Windows.Forms.DataGridView();
            this.COD_CURSO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ETAPA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detalle = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Moneda)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_NuevaMoneda);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1099, 80);
            this.panel1.TabIndex = 3;
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
            this.label1.Size = new System.Drawing.Size(111, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Moneda";
            // 
            // btn_NuevaMoneda
            // 
            this.btn_NuevaMoneda.BackColor = System.Drawing.Color.Blue;
            this.btn_NuevaMoneda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NuevaMoneda.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_NuevaMoneda.Location = new System.Drawing.Point(13, 13);
            this.btn_NuevaMoneda.Margin = new System.Windows.Forms.Padding(4);
            this.btn_NuevaMoneda.Name = "btn_NuevaMoneda";
            this.btn_NuevaMoneda.Size = new System.Drawing.Size(159, 53);
            this.btn_NuevaMoneda.TabIndex = 0;
            this.btn_NuevaMoneda.Text = "Nueva moneda";
            this.btn_NuevaMoneda.UseVisualStyleBackColor = false;
            this.btn_NuevaMoneda.Click += new System.EventHandler(this.btn_NuevaMoneda_Click);
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
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.btn_BuscarMoneda);
            this.tabPage1.Controls.Add(this.txt_NombreMoneda);
            this.tabPage1.Controls.Add(this.txt_ClaveMoneda);
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
            // btn_BuscarMoneda
            // 
            this.btn_BuscarMoneda.BackColor = System.Drawing.Color.Blue;
            this.btn_BuscarMoneda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BuscarMoneda.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_BuscarMoneda.Location = new System.Drawing.Point(616, 44);
            this.btn_BuscarMoneda.Margin = new System.Windows.Forms.Padding(4);
            this.btn_BuscarMoneda.Name = "btn_BuscarMoneda";
            this.btn_BuscarMoneda.Size = new System.Drawing.Size(159, 37);
            this.btn_BuscarMoneda.TabIndex = 2;
            this.btn_BuscarMoneda.Text = "Buscar";
            this.btn_BuscarMoneda.UseVisualStyleBackColor = false;
            this.btn_BuscarMoneda.Click += new System.EventHandler(this.btn_BuscarMoneda_Click);
            // 
            // txt_NombreMoneda
            // 
            this.txt_NombreMoneda.Location = new System.Drawing.Point(187, 52);
            this.txt_NombreMoneda.Margin = new System.Windows.Forms.Padding(4);
            this.txt_NombreMoneda.Name = "txt_NombreMoneda";
            this.txt_NombreMoneda.Size = new System.Drawing.Size(406, 22);
            this.txt_NombreMoneda.TabIndex = 5;
            // 
            // txt_ClaveMoneda
            // 
            this.txt_ClaveMoneda.Location = new System.Drawing.Point(35, 52);
            this.txt_ClaveMoneda.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ClaveMoneda.Name = "txt_ClaveMoneda";
            this.txt_ClaveMoneda.Size = new System.Drawing.Size(88, 22);
            this.txt_ClaveMoneda.TabIndex = 4;
            this.txt_ClaveMoneda.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(183, 32);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Moneda:";
            // 
            // dgv_Moneda
            // 
            this.dgv_Moneda.AllowUserToAddRows = false;
            this.dgv_Moneda.AllowUserToDeleteRows = false;
            this.dgv_Moneda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Moneda.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Moneda.ColumnHeadersHeight = 30;
            this.dgv_Moneda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.COD_CURSO,
            this.ETAPA,
            this.Detalle});
            this.dgv_Moneda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Moneda.Location = new System.Drawing.Point(0, 231);
            this.dgv_Moneda.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_Moneda.Name = "dgv_Moneda";
            this.dgv_Moneda.ReadOnly = true;
            this.dgv_Moneda.Size = new System.Drawing.Size(1099, 336);
            this.dgv_Moneda.TabIndex = 5;
            this.dgv_Moneda.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Moneda_CellContentClick);
            // 
            // COD_CURSO
            // 
            this.COD_CURSO.DataPropertyName = "Id_Moneda";
            this.COD_CURSO.HeaderText = "Código";
            this.COD_CURSO.Name = "COD_CURSO";
            this.COD_CURSO.ReadOnly = true;
            // 
            // ETAPA
            // 
            this.ETAPA.DataPropertyName = "Nombre_Moneda";
            this.ETAPA.HeaderText = "Moneda";
            this.ETAPA.Name = "ETAPA";
            this.ETAPA.ReadOnly = true;
            // 
            // Detalle
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DarkGreen;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            this.Detalle.DefaultCellStyle = dataGridViewCellStyle4;
            this.Detalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Detalle.HeaderText = "";
            this.Detalle.Name = "Detalle";
            this.Detalle.ReadOnly = true;
            this.Detalle.Text = "Modificar";
            this.Detalle.UseColumnTextForButtonValue = true;
            // 
            // frm_Moneda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 567);
            this.Controls.Add(this.dgv_Moneda);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Name = "frm_Moneda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Moneda";
            this.Load += new System.EventHandler(this.frm_Moneda_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Moneda)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_NuevaMoneda;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_BuscarMoneda;
        private System.Windows.Forms.TextBox txt_NombreMoneda;
        private System.Windows.Forms.TextBox txt_ClaveMoneda;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgv_Moneda;
        private System.Windows.Forms.DataGridViewTextBoxColumn COD_CURSO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ETAPA;
        private System.Windows.Forms.DataGridViewButtonColumn Detalle;
    }
}