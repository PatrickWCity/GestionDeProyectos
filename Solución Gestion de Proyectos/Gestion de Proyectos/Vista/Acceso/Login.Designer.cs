namespace Gestion_de_Proyectos.Vista
{
    partial class Login
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
            this.ll_CambiarClave = new System.Windows.Forms.LinkLabel();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.tb_Username = new System.Windows.Forms.TextBox();
            this.b_Cancelar = new System.Windows.Forms.Button();
            this.b_Aceptar = new System.Windows.Forms.Button();
            this.l_ZonaMensaje = new System.Windows.Forms.Label();
            this.l_Password = new System.Windows.Forms.Label();
            this.l_Username = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ll_CambiarClave
            // 
            this.ll_CambiarClave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ll_CambiarClave.AutoSize = true;
            this.ll_CambiarClave.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ll_CambiarClave.Location = new System.Drawing.Point(361, 179);
            this.ll_CambiarClave.Name = "ll_CambiarClave";
            this.ll_CambiarClave.Size = new System.Drawing.Size(111, 19);
            this.ll_CambiarClave.TabIndex = 15;
            this.ll_CambiarClave.TabStop = true;
            this.ll_CambiarClave.Text = "Cambiar Clave";
            this.ll_CambiarClave.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_CambiarClave_LinkClicked);
            // 
            // tb_Password
            // 
            this.tb_Password.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Password.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Password.Location = new System.Drawing.Point(264, 45);
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.PasswordChar = '*';
            this.tb_Password.Size = new System.Drawing.Size(208, 27);
            this.tb_Password.TabIndex = 14;
            // 
            // tb_Username
            // 
            this.tb_Username.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Username.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Username.Location = new System.Drawing.Point(264, 12);
            this.tb_Username.Name = "tb_Username";
            this.tb_Username.Size = new System.Drawing.Size(208, 27);
            this.tb_Username.TabIndex = 13;
            // 
            // b_Cancelar
            // 
            this.b_Cancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.b_Cancelar.AutoSize = true;
            this.b_Cancelar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_Cancelar.Location = new System.Drawing.Point(382, 201);
            this.b_Cancelar.Name = "b_Cancelar";
            this.b_Cancelar.Size = new System.Drawing.Size(90, 29);
            this.b_Cancelar.TabIndex = 12;
            this.b_Cancelar.Text = "Cancelar";
            this.b_Cancelar.UseVisualStyleBackColor = true;
            this.b_Cancelar.Click += new System.EventHandler(this.b_Cancelar_Click);
            // 
            // b_Aceptar
            // 
            this.b_Aceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.b_Aceptar.AutoSize = true;
            this.b_Aceptar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_Aceptar.Location = new System.Drawing.Point(12, 201);
            this.b_Aceptar.Name = "b_Aceptar";
            this.b_Aceptar.Size = new System.Drawing.Size(83, 29);
            this.b_Aceptar.TabIndex = 11;
            this.b_Aceptar.Text = "Aceptar";
            this.b_Aceptar.UseVisualStyleBackColor = true;
            this.b_Aceptar.Click += new System.EventHandler(this.b_Aceptar_Click);
            // 
            // l_ZonaMensaje
            // 
            this.l_ZonaMensaje.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.l_ZonaMensaje.AutoSize = true;
            this.l_ZonaMensaje.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_ZonaMensaje.ForeColor = System.Drawing.Color.Red;
            this.l_ZonaMensaje.Location = new System.Drawing.Point(12, 233);
            this.l_ZonaMensaje.Name = "l_ZonaMensaje";
            this.l_ZonaMensaje.Size = new System.Drawing.Size(147, 19);
            this.l_ZonaMensaje.TabIndex = 10;
            this.l_ZonaMensaje.Text = "Zona de Mensaje";
            // 
            // l_Password
            // 
            this.l_Password.AutoSize = true;
            this.l_Password.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_Password.Location = new System.Drawing.Point(12, 48);
            this.l_Password.Name = "l_Password";
            this.l_Password.Size = new System.Drawing.Size(87, 19);
            this.l_Password.TabIndex = 9;
            this.l_Password.Text = "Password";
            // 
            // l_Username
            // 
            this.l_Username.AutoSize = true;
            this.l_Username.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_Username.Location = new System.Drawing.Point(12, 15);
            this.l_Username.Name = "l_Username";
            this.l_Username.Size = new System.Drawing.Size(91, 19);
            this.l_Username.TabIndex = 8;
            this.l_Username.Text = "Username";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.AutoSize = true;
            this.button1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(185, 201);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 29);
            this.button1.TabIndex = 16;
            this.button1.Text = "Restablecer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Login
            // 
            this.AcceptButton = this.b_Aceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ll_CambiarClave);
            this.Controls.Add(this.tb_Password);
            this.Controls.Add(this.tb_Username);
            this.Controls.Add(this.b_Cancelar);
            this.Controls.Add(this.b_Aceptar);
            this.Controls.Add(this.l_ZonaMensaje);
            this.Controls.Add(this.l_Password);
            this.Controls.Add(this.l_Username);
            this.MinimumSize = new System.Drawing.Size(500, 300);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel ll_CambiarClave;
        private System.Windows.Forms.TextBox tb_Password;
        private System.Windows.Forms.TextBox tb_Username;
        private System.Windows.Forms.Button b_Cancelar;
        private System.Windows.Forms.Button b_Aceptar;
        private System.Windows.Forms.Label l_ZonaMensaje;
        private System.Windows.Forms.Label l_Password;
        private System.Windows.Forms.Label l_Username;
        private System.Windows.Forms.Button button1;
    }
}