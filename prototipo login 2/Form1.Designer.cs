namespace prototipo_login_2
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Chk_gestionPass = new System.Windows.Forms.CheckBox();
            this.Btn_Aceptar = new System.Windows.Forms.Button();
            this.Btn_loginAyuda = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Lbl_loginPass = new System.Windows.Forms.Label();
            this.Lbl_loginUser = new System.Windows.Forms.Label();
            this.Txt_loginPass = new System.Windows.Forms.TextBox();
            this.Txt_loginUser = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Chk_gestionPass
            // 
            this.Chk_gestionPass.AutoSize = true;
            this.Chk_gestionPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chk_gestionPass.Location = new System.Drawing.Point(442, 175);
            this.Chk_gestionPass.Name = "Chk_gestionPass";
            this.Chk_gestionPass.Size = new System.Drawing.Size(210, 20);
            this.Chk_gestionPass.TabIndex = 51;
            this.Chk_gestionPass.Text = "MOSTRAR CONTRASEÑA";
            this.Chk_gestionPass.UseVisualStyleBackColor = true;
            // 
            // Btn_Aceptar
            // 
            this.Btn_Aceptar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn_Aceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Aceptar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Aceptar.Image")));
            this.Btn_Aceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Aceptar.Location = new System.Drawing.Point(560, 210);
            this.Btn_Aceptar.Name = "Btn_Aceptar";
            this.Btn_Aceptar.Size = new System.Drawing.Size(92, 44);
            this.Btn_Aceptar.TabIndex = 49;
            this.Btn_Aceptar.Text = "LOGIN";
            this.Btn_Aceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Aceptar.UseVisualStyleBackColor = false;
            this.Btn_Aceptar.Click += new System.EventHandler(this.Btn_Aceptar_Click);
            // 
            // Btn_loginAyuda
            // 
            this.Btn_loginAyuda.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn_loginAyuda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_loginAyuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_loginAyuda.Image = ((System.Drawing.Image)(resources.GetObject("Btn_loginAyuda.Image")));
            this.Btn_loginAyuda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_loginAyuda.Location = new System.Drawing.Point(532, 37);
            this.Btn_loginAyuda.Name = "Btn_loginAyuda";
            this.Btn_loginAyuda.Size = new System.Drawing.Size(101, 43);
            this.Btn_loginAyuda.TabIndex = 48;
            this.Btn_loginAyuda.Text = "AYUDA";
            this.Btn_loginAyuda.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_loginAyuda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_loginAyuda.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(24, 98);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(277, 109);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 47;
            this.pictureBox1.TabStop = false;
            // 
            // Lbl_loginPass
            // 
            this.Lbl_loginPass.AutoSize = true;
            this.Lbl_loginPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_loginPass.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Lbl_loginPass.Location = new System.Drawing.Point(310, 141);
            this.Lbl_loginPass.Name = "Lbl_loginPass";
            this.Lbl_loginPass.Size = new System.Drawing.Size(87, 16);
            this.Lbl_loginPass.TabIndex = 46;
            this.Lbl_loginPass.Text = "Contraseña";
            // 
            // Lbl_loginUser
            // 
            this.Lbl_loginUser.AutoSize = true;
            this.Lbl_loginUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_loginUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Lbl_loginUser.Location = new System.Drawing.Point(310, 99);
            this.Lbl_loginUser.Name = "Lbl_loginUser";
            this.Lbl_loginUser.Size = new System.Drawing.Size(62, 16);
            this.Lbl_loginUser.TabIndex = 45;
            this.Lbl_loginUser.Text = "Usuario";
            // 
            // Txt_loginPass
            // 
            this.Txt_loginPass.Location = new System.Drawing.Point(407, 137);
            this.Txt_loginPass.MaxLength = 30;
            this.Txt_loginPass.Name = "Txt_loginPass";
            this.Txt_loginPass.Size = new System.Drawing.Size(245, 20);
            this.Txt_loginPass.TabIndex = 44;
            this.Txt_loginPass.UseSystemPasswordChar = true;
            // 
            // Txt_loginUser
            // 
            this.Txt_loginUser.Location = new System.Drawing.Point(407, 98);
            this.Txt_loginUser.MaxLength = 30;
            this.Txt_loginUser.Name = "Txt_loginUser";
            this.Txt_loginUser.Size = new System.Drawing.Size(246, 20);
            this.Txt_loginUser.TabIndex = 43;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(665, 276);
            this.Controls.Add(this.Chk_gestionPass);
            this.Controls.Add(this.Btn_Aceptar);
            this.Controls.Add(this.Btn_loginAyuda);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Lbl_loginPass);
            this.Controls.Add(this.Lbl_loginUser);
            this.Controls.Add(this.Txt_loginPass);
            this.Controls.Add(this.Txt_loginUser);
            this.Name = "Form1";
            this.Text = "LOGIN";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox Chk_gestionPass;
        private System.Windows.Forms.Button Btn_Aceptar;
        private System.Windows.Forms.Button Btn_loginAyuda;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Lbl_loginPass;
        private System.Windows.Forms.Label Lbl_loginUser;
        private System.Windows.Forms.TextBox Txt_loginPass;
        private System.Windows.Forms.TextBox Txt_loginUser;
    }
}

