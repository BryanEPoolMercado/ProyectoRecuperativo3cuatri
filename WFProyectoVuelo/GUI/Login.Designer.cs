namespace WFProyectoVuelo
{
    partial class frm_Login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_CorreoUsuario = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txt_ContraseniaUsuario = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Registro = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_IniciarSesion = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_cerrar_main = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cerrar_main)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(130)))), ((int)(((byte)(232)))));
            this.panel1.Controls.Add(this.txt_CorreoUsuario);
            this.panel1.Controls.Add(this.txt_ContraseniaUsuario);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btn_IniciarSesion);
            this.panel1.Controls.Add(this.btn_Registro);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 304);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(583, 396);
            this.panel1.TabIndex = 5;
            // 
            // txt_CorreoUsuario
            // 
            this.txt_CorreoUsuario.BackColor = System.Drawing.Color.White;
            this.txt_CorreoUsuario.BorderColorFocused = System.Drawing.Color.Gainsboro;
            this.txt_CorreoUsuario.BorderColorIdle = System.Drawing.Color.Transparent;
            this.txt_CorreoUsuario.BorderColorMouseHover = System.Drawing.Color.Transparent;
            this.txt_CorreoUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_CorreoUsuario.BorderThickness = 3;
            this.txt_CorreoUsuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_CorreoUsuario.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_CorreoUsuario.ForeColor = System.Drawing.Color.Black;
            this.txt_CorreoUsuario.isPassword = false;
            this.txt_CorreoUsuario.Location = new System.Drawing.Point(110, 88);
            this.txt_CorreoUsuario.Margin = new System.Windows.Forms.Padding(5);
            this.txt_CorreoUsuario.Name = "txt_CorreoUsuario";
            this.txt_CorreoUsuario.Size = new System.Drawing.Size(364, 40);
            this.txt_CorreoUsuario.TabIndex = 20;
            this.txt_CorreoUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_ContraseniaUsuario
            // 
            this.txt_ContraseniaUsuario.BackColor = System.Drawing.Color.White;
            this.txt_ContraseniaUsuario.BorderColorFocused = System.Drawing.Color.Gainsboro;
            this.txt_ContraseniaUsuario.BorderColorIdle = System.Drawing.Color.Transparent;
            this.txt_ContraseniaUsuario.BorderColorMouseHover = System.Drawing.Color.Transparent;
            this.txt_ContraseniaUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ContraseniaUsuario.BorderThickness = 3;
            this.txt_ContraseniaUsuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_ContraseniaUsuario.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_ContraseniaUsuario.ForeColor = System.Drawing.Color.Black;
            this.txt_ContraseniaUsuario.isPassword = true;
            this.txt_ContraseniaUsuario.Location = new System.Drawing.Point(110, 176);
            this.txt_ContraseniaUsuario.Margin = new System.Windows.Forms.Padding(5);
            this.txt_ContraseniaUsuario.Name = "txt_ContraseniaUsuario";
            this.txt_ContraseniaUsuario.Size = new System.Drawing.Size(364, 40);
            this.txt_ContraseniaUsuario.TabIndex = 19;
            this.txt_ContraseniaUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_ContraseniaUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_ContraseniaUsuario_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(106, 148);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 23);
            this.label3.TabIndex = 15;
            this.label3.Text = "Contraseña";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(108, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 23);
            this.label2.TabIndex = 9;
            this.label2.Text = "Correo electronico";
            // 
            // btn_Registro
            // 
            this.btn_Registro.Activecolor = System.Drawing.Color.Transparent;
            this.btn_Registro.BackColor = System.Drawing.Color.Transparent;
            this.btn_Registro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Registro.BorderRadius = 0;
            this.btn_Registro.ButtonText = "Registrarse";
            this.btn_Registro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Registro.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Registro.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Registro.Iconimage = null;
            this.btn_Registro.Iconimage_right = null;
            this.btn_Registro.Iconimage_right_Selected = null;
            this.btn_Registro.Iconimage_Selected = null;
            this.btn_Registro.IconMarginLeft = 0;
            this.btn_Registro.IconMarginRight = 0;
            this.btn_Registro.IconRightVisible = true;
            this.btn_Registro.IconRightZoom = 0D;
            this.btn_Registro.IconVisible = true;
            this.btn_Registro.IconZoom = 50D;
            this.btn_Registro.IsTab = false;
            this.btn_Registro.Location = new System.Drawing.Point(5, 344);
            this.btn_Registro.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Registro.Name = "btn_Registro";
            this.btn_Registro.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_Registro.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(115)))), ((int)(((byte)(166)))));
            this.btn_Registro.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Registro.selected = false;
            this.btn_Registro.Size = new System.Drawing.Size(179, 38);
            this.btn_Registro.TabIndex = 14;
            this.btn_Registro.Text = "Registrarse";
            this.btn_Registro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Registro.Textcolor = System.Drawing.Color.White;
            this.btn_Registro.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Registro.Click += new System.EventHandler(this.btn_Registro_Click);
            // 
            // btn_IniciarSesion
            // 
            this.btn_IniciarSesion.Activecolor = System.Drawing.Color.Blue;
            this.btn_IniciarSesion.BackColor = System.Drawing.Color.Blue;
            this.btn_IniciarSesion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_IniciarSesion.BorderRadius = 0;
            this.btn_IniciarSesion.ButtonText = "Iniciar sesion";
            this.btn_IniciarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_IniciarSesion.DisabledColor = System.Drawing.Color.Blue;
            this.btn_IniciarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_IniciarSesion.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_IniciarSesion.Iconimage = null;
            this.btn_IniciarSesion.Iconimage_right = null;
            this.btn_IniciarSesion.Iconimage_right_Selected = null;
            this.btn_IniciarSesion.Iconimage_Selected = null;
            this.btn_IniciarSesion.IconMarginLeft = 0;
            this.btn_IniciarSesion.IconMarginRight = 0;
            this.btn_IniciarSesion.IconRightVisible = true;
            this.btn_IniciarSesion.IconRightZoom = 0D;
            this.btn_IniciarSesion.IconVisible = true;
            this.btn_IniciarSesion.IconZoom = 50D;
            this.btn_IniciarSesion.IsTab = false;
            this.btn_IniciarSesion.Location = new System.Drawing.Point(110, 226);
            this.btn_IniciarSesion.Margin = new System.Windows.Forms.Padding(5);
            this.btn_IniciarSesion.Name = "btn_IniciarSesion";
            this.btn_IniciarSesion.Normalcolor = System.Drawing.Color.Transparent;
            this.btn_IniciarSesion.OnHovercolor = System.Drawing.Color.Blue;
            this.btn_IniciarSesion.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_IniciarSesion.selected = false;
            this.btn_IniciarSesion.Size = new System.Drawing.Size(363, 59);
            this.btn_IniciarSesion.TabIndex = 13;
            this.btn_IniciarSesion.Text = "Iniciar sesion";
            this.btn_IniciarSesion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_IniciarSesion.Textcolor = System.Drawing.Color.White;
            this.btn_IniciarSesion.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_IniciarSesion.Click += new System.EventHandler(this.btn_IniciarSesion_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(77, 185);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(27, 25);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(77, 96);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(27, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(210, 100);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 133);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(221, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 44);
            this.label1.TabIndex = 7;
            this.label1.Text = "AirFly";
            // 
            // btn_cerrar_main
            // 
            this.btn_cerrar_main.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cerrar_main.BackColor = System.Drawing.Color.Transparent;
            this.btn_cerrar_main.Image = ((System.Drawing.Image)(resources.GetObject("btn_cerrar_main.Image")));
            this.btn_cerrar_main.ImageActive = null;
            this.btn_cerrar_main.Location = new System.Drawing.Point(551, 3);
            this.btn_cerrar_main.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cerrar_main.Name = "btn_cerrar_main";
            this.btn_cerrar_main.Size = new System.Drawing.Size(29, 27);
            this.btn_cerrar_main.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_cerrar_main.TabIndex = 12;
            this.btn_cerrar_main.TabStop = false;
            this.btn_cerrar_main.Zoom = 8;
            this.btn_cerrar_main.Click += new System.EventHandler(this.btn_cerrar_main_Click);
            // 
            // frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(583, 700);
            this.Controls.Add(this.btn_cerrar_main);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cerrar_main)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_CorreoUsuario;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_ContraseniaUsuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Registro;
        private Bunifu.Framework.UI.BunifuFlatButton btn_IniciarSesion;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuImageButton btn_cerrar_main;
    }
}

