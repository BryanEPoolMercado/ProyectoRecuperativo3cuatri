namespace WFProyectoVuelo.GUI
{
    partial class frm_MensajeRegistro
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
            this.btn_Ok = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.SuspendLayout();
            // 
            // btn_Ok
            // 
            this.btn_Ok.Activecolor = System.Drawing.Color.Gray;
            this.btn_Ok.BackColor = System.Drawing.Color.Gray;
            this.btn_Ok.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Ok.BorderRadius = 0;
            this.btn_Ok.ButtonText = "OK";
            this.btn_Ok.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Ok.DisabledColor = System.Drawing.Color.Silver;
            this.btn_Ok.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Ok.Iconimage = null;
            this.btn_Ok.Iconimage_right = null;
            this.btn_Ok.Iconimage_right_Selected = null;
            this.btn_Ok.Iconimage_Selected = null;
            this.btn_Ok.IconMarginLeft = 0;
            this.btn_Ok.IconMarginRight = 0;
            this.btn_Ok.IconRightVisible = true;
            this.btn_Ok.IconRightZoom = 0D;
            this.btn_Ok.IconVisible = true;
            this.btn_Ok.IconZoom = 90D;
            this.btn_Ok.IsTab = false;
            this.btn_Ok.Location = new System.Drawing.Point(157, 124);
            this.btn_Ok.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Ok.Name = "btn_Ok";
            this.btn_Ok.Normalcolor = System.Drawing.Color.Gray;
            this.btn_Ok.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(141)))), ((int)(((byte)(255)))));
            this.btn_Ok.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Ok.selected = false;
            this.btn_Ok.Size = new System.Drawing.Size(175, 38);
            this.btn_Ok.TabIndex = 16;
            this.btn_Ok.Text = "OK";
            this.btn_Ok.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Ok.Textcolor = System.Drawing.Color.White;
            this.btn_Ok.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Ok.Click += new System.EventHandler(this.btn_Ok_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(40, 40);
            this.bunifuCustomLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(393, 30);
            this.bunifuCustomLabel1.TabIndex = 15;
            this.bunifuCustomLabel1.Text = "Registro realizado exitosamente";
            // 
            // frm_MensajeRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(473, 202);
            this.Controls.Add(this.btn_Ok);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_MensajeRegistro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_MensajeRegistro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFlatButton btn_Ok;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
    }
}