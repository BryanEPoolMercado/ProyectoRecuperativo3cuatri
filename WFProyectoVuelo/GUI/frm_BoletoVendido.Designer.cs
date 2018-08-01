namespace WFProyectoVuelo.GUI
{
    partial class frm_BoletoVendido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_BoletoVendido));
            this.label1 = new System.Windows.Forms.Label();
            this.btn_ImprimirTicket = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_cerrar_main = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cerrar_main)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(165, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(460, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "La venta se realizo con exito";
            // 
            // btn_ImprimirTicket
            // 
            this.btn_ImprimirTicket.Location = new System.Drawing.Point(303, 345);
            this.btn_ImprimirTicket.Name = "btn_ImprimirTicket";
            this.btn_ImprimirTicket.Size = new System.Drawing.Size(159, 38);
            this.btn_ImprimirTicket.TabIndex = 24;
            this.btn_ImprimirTicket.Text = "Imprimir Ticket";
            this.btn_ImprimirTicket.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(130)))), ((int)(((byte)(232)))));
            this.panel1.Controls.Add(this.btn_cerrar_main);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 39);
            this.panel1.TabIndex = 25;
            // 
            // btn_cerrar_main
            // 
            this.btn_cerrar_main.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cerrar_main.BackColor = System.Drawing.Color.Transparent;
            this.btn_cerrar_main.Image = ((System.Drawing.Image)(resources.GetObject("btn_cerrar_main.Image")));
            this.btn_cerrar_main.ImageActive = null;
            this.btn_cerrar_main.Location = new System.Drawing.Point(767, 4);
            this.btn_cerrar_main.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cerrar_main.Name = "btn_cerrar_main";
            this.btn_cerrar_main.Size = new System.Drawing.Size(29, 27);
            this.btn_cerrar_main.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_cerrar_main.TabIndex = 12;
            this.btn_cerrar_main.TabStop = false;
            this.btn_cerrar_main.Zoom = 8;
            this.btn_cerrar_main.Click += new System.EventHandler(this.btn_cerrar_main_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(130)))), ((int)(((byte)(232)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 411);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 39);
            this.panel2.TabIndex = 26;
            // 
            // frm_BoletoVendido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_ImprimirTicket);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_BoletoVendido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_BoletoVendido";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_cerrar_main)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_ImprimirTicket;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton btn_cerrar_main;
        private System.Windows.Forms.Panel panel2;
    }
}