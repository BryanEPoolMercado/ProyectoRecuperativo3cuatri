namespace WFProyectoVuelo.GUI
{
    partial class Menu_Principal
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
            this.btn_Aeropuerto = new System.Windows.Forms.Button();
            this.btn_Precio = new System.Windows.Forms.Button();
            this.btn_Ruta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Aeropuerto
            // 
            this.btn_Aeropuerto.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_Aeropuerto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Aeropuerto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Aeropuerto.Location = new System.Drawing.Point(89, 94);
            this.btn_Aeropuerto.Name = "btn_Aeropuerto";
            this.btn_Aeropuerto.Size = new System.Drawing.Size(119, 43);
            this.btn_Aeropuerto.TabIndex = 1;
            this.btn_Aeropuerto.Text = "Aeropuerto";
            this.btn_Aeropuerto.UseVisualStyleBackColor = false;
            this.btn_Aeropuerto.Click += new System.EventHandler(this.btn_Aeropuerto_Click);
            // 
            // btn_Precio
            // 
            this.btn_Precio.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_Precio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Precio.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Precio.Location = new System.Drawing.Point(267, 94);
            this.btn_Precio.Name = "btn_Precio";
            this.btn_Precio.Size = new System.Drawing.Size(119, 43);
            this.btn_Precio.TabIndex = 2;
            this.btn_Precio.Text = "Precio";
            this.btn_Precio.UseVisualStyleBackColor = false;
            this.btn_Precio.Click += new System.EventHandler(this.btn_Precio_Click);
            // 
            // btn_Ruta
            // 
            this.btn_Ruta.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_Ruta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Ruta.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Ruta.Location = new System.Drawing.Point(450, 94);
            this.btn_Ruta.Name = "btn_Ruta";
            this.btn_Ruta.Size = new System.Drawing.Size(119, 43);
            this.btn_Ruta.TabIndex = 3;
            this.btn_Ruta.Text = "Ruta";
            this.btn_Ruta.UseVisualStyleBackColor = false;
            this.btn_Ruta.Click += new System.EventHandler(this.btn_Ruta_Click);
            // 
            // Menu_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Ruta);
            this.Controls.Add(this.btn_Precio);
            this.Controls.Add(this.btn_Aeropuerto);
            this.Name = "Menu_Principal";
            this.Text = "Menu_Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Aeropuerto;
        private System.Windows.Forms.Button btn_Precio;
        private System.Windows.Forms.Button btn_Ruta;
    }
}