namespace Gestion_de_Proyectos.Vista
{
    partial class CambiarClave
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
            this.l_Username = new System.Windows.Forms.Label();
            this.l_ClaveActual = new System.Windows.Forms.Label();
            this.l_ClaveNueva = new System.Windows.Forms.Label();
            this.l_ConfirmarClaveNueva = new System.Windows.Forms.Label();
            this.tb_Username = new System.Windows.Forms.TextBox();
            this.tb_ClaveActual = new System.Windows.Forms.TextBox();
            this.tb_ClaveNueva = new System.Windows.Forms.TextBox();
            this.tb_ConfirmarClaveNueva = new System.Windows.Forms.TextBox();
            this.b_CambiarClave = new System.Windows.Forms.Button();
            this.b_Cancelar = new System.Windows.Forms.Button();
            this.l_ZonaMensaje = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // l_Username
            // 
            this.l_Username.AutoSize = true;
            this.l_Username.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_Username.Location = new System.Drawing.Point(12, 15);
            this.l_Username.Name = "l_Username";
            this.l_Username.Size = new System.Drawing.Size(91, 19);
            this.l_Username.TabIndex = 0;
            this.l_Username.Text = "Username";
            // 
            // l_ClaveActual
            // 
            this.l_ClaveActual.AutoSize = true;
            this.l_ClaveActual.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_ClaveActual.Location = new System.Drawing.Point(12, 48);
            this.l_ClaveActual.Name = "l_ClaveActual";
            this.l_ClaveActual.Size = new System.Drawing.Size(111, 19);
            this.l_ClaveActual.TabIndex = 1;
            this.l_ClaveActual.Text = "Clave Actual";
            // 
            // l_ClaveNueva
            // 
            this.l_ClaveNueva.AutoSize = true;
            this.l_ClaveNueva.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_ClaveNueva.Location = new System.Drawing.Point(12, 81);
            this.l_ClaveNueva.Name = "l_ClaveNueva";
            this.l_ClaveNueva.Size = new System.Drawing.Size(110, 19);
            this.l_ClaveNueva.TabIndex = 2;
            this.l_ClaveNueva.Text = "Clave Nueva";
            // 
            // l_ConfirmarClaveNueva
            // 
            this.l_ConfirmarClaveNueva.AutoSize = true;
            this.l_ConfirmarClaveNueva.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_ConfirmarClaveNueva.Location = new System.Drawing.Point(12, 114);
            this.l_ConfirmarClaveNueva.Name = "l_ConfirmarClaveNueva";
            this.l_ConfirmarClaveNueva.Size = new System.Drawing.Size(201, 19);
            this.l_ConfirmarClaveNueva.TabIndex = 3;
            this.l_ConfirmarClaveNueva.Text = "Comfirmar Clave Nueva";
            // 
            // tb_Username
            // 
            this.tb_Username.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Username.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Username.Location = new System.Drawing.Point(219, 12);
            this.tb_Username.Name = "tb_Username";
            this.tb_Username.Size = new System.Drawing.Size(153, 27);
            this.tb_Username.TabIndex = 4;
            // 
            // tb_ClaveActual
            // 
            this.tb_ClaveActual.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_ClaveActual.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ClaveActual.Location = new System.Drawing.Point(219, 45);
            this.tb_ClaveActual.Name = "tb_ClaveActual";
            this.tb_ClaveActual.PasswordChar = '*';
            this.tb_ClaveActual.Size = new System.Drawing.Size(153, 27);
            this.tb_ClaveActual.TabIndex = 5;
            // 
            // tb_ClaveNueva
            // 
            this.tb_ClaveNueva.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_ClaveNueva.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ClaveNueva.Location = new System.Drawing.Point(219, 78);
            this.tb_ClaveNueva.Name = "tb_ClaveNueva";
            this.tb_ClaveNueva.PasswordChar = '*';
            this.tb_ClaveNueva.Size = new System.Drawing.Size(153, 27);
            this.tb_ClaveNueva.TabIndex = 6;
            this.tb_ClaveNueva.TextChanged += new System.EventHandler(this.tb_ClaveNueva_TextChanged);
            // 
            // tb_ConfirmarClaveNueva
            // 
            this.tb_ConfirmarClaveNueva.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_ConfirmarClaveNueva.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ConfirmarClaveNueva.Location = new System.Drawing.Point(219, 111);
            this.tb_ConfirmarClaveNueva.Name = "tb_ConfirmarClaveNueva";
            this.tb_ConfirmarClaveNueva.PasswordChar = '*';
            this.tb_ConfirmarClaveNueva.Size = new System.Drawing.Size(153, 27);
            this.tb_ConfirmarClaveNueva.TabIndex = 7;
            // 
            // b_CambiarClave
            // 
            this.b_CambiarClave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.b_CambiarClave.AutoSize = true;
            this.b_CambiarClave.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_CambiarClave.Location = new System.Drawing.Point(12, 201);
            this.b_CambiarClave.Name = "b_CambiarClave";
            this.b_CambiarClave.Size = new System.Drawing.Size(137, 29);
            this.b_CambiarClave.TabIndex = 8;
            this.b_CambiarClave.Text = "Cambiar Clave";
            this.b_CambiarClave.UseVisualStyleBackColor = true;
            this.b_CambiarClave.Click += new System.EventHandler(this.b_CambiarClave_Click);
            // 
            // b_Cancelar
            // 
            this.b_Cancelar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.b_Cancelar.AutoSize = true;
            this.b_Cancelar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_Cancelar.Location = new System.Drawing.Point(282, 201);
            this.b_Cancelar.Name = "b_Cancelar";
            this.b_Cancelar.Size = new System.Drawing.Size(90, 29);
            this.b_Cancelar.TabIndex = 9;
            this.b_Cancelar.Text = "Cancelar";
            this.b_Cancelar.UseVisualStyleBackColor = true;
            this.b_Cancelar.Click += new System.EventHandler(this.b_Cancelar_Click);
            // 
            // l_ZonaMensaje
            // 
            this.l_ZonaMensaje.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.l_ZonaMensaje.AutoSize = true;
            this.l_ZonaMensaje.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_ZonaMensaje.ForeColor = System.Drawing.Color.Red;
            this.l_ZonaMensaje.Location = new System.Drawing.Point(12, 233);
            this.l_ZonaMensaje.Name = "l_ZonaMensaje";
            this.l_ZonaMensaje.Size = new System.Drawing.Size(147, 19);
            this.l_ZonaMensaje.TabIndex = 10;
            this.l_ZonaMensaje.Text = "Zona de Mensaje";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.AutoSize = true;
            this.button1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(155, 201);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 29);
            this.button1.TabIndex = 11;
            this.button1.Text = "Restablecer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CambiarClave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.l_ZonaMensaje);
            this.Controls.Add(this.b_Cancelar);
            this.Controls.Add(this.b_CambiarClave);
            this.Controls.Add(this.tb_ConfirmarClaveNueva);
            this.Controls.Add(this.tb_ClaveNueva);
            this.Controls.Add(this.tb_ClaveActual);
            this.Controls.Add(this.tb_Username);
            this.Controls.Add(this.l_ConfirmarClaveNueva);
            this.Controls.Add(this.l_ClaveNueva);
            this.Controls.Add(this.l_ClaveActual);
            this.Controls.Add(this.l_Username);
            this.Name = "CambiarClave";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CambiarClave";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l_Username;
        private System.Windows.Forms.Label l_ClaveActual;
        private System.Windows.Forms.Label l_ClaveNueva;
        private System.Windows.Forms.Label l_ConfirmarClaveNueva;
        private System.Windows.Forms.TextBox tb_Username;
        private System.Windows.Forms.TextBox tb_ClaveActual;
        private System.Windows.Forms.TextBox tb_ClaveNueva;
        private System.Windows.Forms.TextBox tb_ConfirmarClaveNueva;
        private System.Windows.Forms.Button b_CambiarClave;
        private System.Windows.Forms.Button b_Cancelar;
        private System.Windows.Forms.Label l_ZonaMensaje;
        private System.Windows.Forms.Button button1;
    }
}