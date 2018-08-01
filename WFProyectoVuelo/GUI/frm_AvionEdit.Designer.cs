namespace WFProyectoVuelo.GUI
{
    partial class frm_AvionEdit
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
            this.cmb_ModeloAvion = new System.Windows.Forms.ComboBox();
            this.cmb_AerolineaAvion = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_NumeroPasajeros = new System.Windows.Forms.TextBox();
            this.txt_ClaveAvion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
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
            this.tabPage1.Controls.Add(this.cmb_ModeloAvion);
            this.tabPage1.Controls.Add(this.cmb_AerolineaAvion);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txt_NumeroPasajeros);
            this.tabPage1.Controls.Add(this.txt_ClaveAvion);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(832, 204);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "     Edicion     ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cmb_ModeloAvion
            // 
            this.cmb_ModeloAvion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_ModeloAvion.FormattingEnabled = true;
            this.cmb_ModeloAvion.Location = new System.Drawing.Point(573, 41);
            this.cmb_ModeloAvion.Name = "cmb_ModeloAvion";
            this.cmb_ModeloAvion.Size = new System.Drawing.Size(228, 24);
            this.cmb_ModeloAvion.TabIndex = 19;
            // 
            // cmb_AerolineaAvion
            // 
            this.cmb_AerolineaAvion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_AerolineaAvion.FormattingEnabled = true;
            this.cmb_AerolineaAvion.Location = new System.Drawing.Point(245, 41);
            this.cmb_AerolineaAvion.Name = "cmb_AerolineaAvion";
            this.cmb_AerolineaAvion.Size = new System.Drawing.Size(238, 24);
            this.cmb_AerolineaAvion.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(570, 21);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "Modelo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(242, 20);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Aerolinea:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Clave:";
            // 
            // txt_NumeroPasajeros
            // 
            this.txt_NumeroPasajeros.Location = new System.Drawing.Point(22, 104);
            this.txt_NumeroPasajeros.Margin = new System.Windows.Forms.Padding(4);
            this.txt_NumeroPasajeros.Name = "txt_NumeroPasajeros";
            this.txt_NumeroPasajeros.Size = new System.Drawing.Size(144, 22);
            this.txt_NumeroPasajeros.TabIndex = 14;
            // 
            // txt_ClaveAvion
            // 
            this.txt_ClaveAvion.Location = new System.Drawing.Point(22, 41);
            this.txt_ClaveAvion.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ClaveAvion.Name = "txt_ClaveAvion";
            this.txt_ClaveAvion.Size = new System.Drawing.Size(144, 22);
            this.txt_ClaveAvion.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 84);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Número de pasajeros:";
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
            this.btn_Cancelar.Location = new System.Drawing.Point(707, 24);
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
            this.btn_Eliminar.Location = new System.Drawing.Point(444, 24);
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
            this.btn_Guardar.Location = new System.Drawing.Point(16, 24);
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
            this.btn_GuardarNext.Location = new System.Drawing.Point(164, 24);
            this.btn_GuardarNext.Margin = new System.Windows.Forms.Padding(4);
            this.btn_GuardarNext.Name = "btn_GuardarNext";
            this.btn_GuardarNext.Size = new System.Drawing.Size(258, 37);
            this.btn_GuardarNext.TabIndex = 0;
            this.btn_GuardarNext.Text = "Guardar y Seguir Capturando";
            this.btn_GuardarNext.UseVisualStyleBackColor = false;
            this.btn_GuardarNext.Click += new System.EventHandler(this.btn_GuardarNext_Click);
            // 
            // frm_AvionEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 312);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.Name = "frm_AvionEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_AvionEdit";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.Button btn_GuardarNext;
        private System.Windows.Forms.ComboBox cmb_ModeloAvion;
        private System.Windows.Forms.ComboBox cmb_AerolineaAvion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_NumeroPasajeros;
        private System.Windows.Forms.TextBox txt_ClaveAvion;
        private System.Windows.Forms.Label label4;
    }
}