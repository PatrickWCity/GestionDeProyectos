namespace Gestion_de_Proyectos.Vista
{
    partial class ConsultarSubmoduloDeModulo
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
            this.l_ZonaMensaje = new System.Windows.Forms.Label();
            this.l_UsuariosDePerfil = new System.Windows.Forms.Label();
            this.b_BN = new System.Windows.Forms.Button();
            this.cb_Perfil = new System.Windows.Forms.ComboBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.l_Perfil = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // l_ZonaMensaje
            // 
            this.l_ZonaMensaje.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.l_ZonaMensaje.AutoSize = true;
            this.l_ZonaMensaje.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_ZonaMensaje.Location = new System.Drawing.Point(12, 426);
            this.l_ZonaMensaje.Name = "l_ZonaMensaje";
            this.l_ZonaMensaje.Size = new System.Drawing.Size(147, 19);
            this.l_ZonaMensaje.TabIndex = 38;
            this.l_ZonaMensaje.Text = "Zona de Mensaje";
            // 
            // l_UsuariosDePerfil
            // 
            this.l_UsuariosDePerfil.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.l_UsuariosDePerfil.AutoSize = true;
            this.l_UsuariosDePerfil.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_UsuariosDePerfil.ForeColor = System.Drawing.Color.Green;
            this.l_UsuariosDePerfil.Location = new System.Drawing.Point(109, 50);
            this.l_UsuariosDePerfil.Name = "l_UsuariosDePerfil";
            this.l_UsuariosDePerfil.Size = new System.Drawing.Size(216, 19);
            this.l_UsuariosDePerfil.TabIndex = 37;
            this.l_UsuariosDePerfil.Text = "Submodulo con el Modulo";
            // 
            // b_BN
            // 
            this.b_BN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.b_BN.AutoSize = true;
            this.b_BN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.b_BN.BackColor = System.Drawing.Color.Black;
            this.b_BN.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_BN.ForeColor = System.Drawing.Color.White;
            this.b_BN.Location = new System.Drawing.Point(382, 425);
            this.b_BN.Name = "b_BN";
            this.b_BN.Size = new System.Drawing.Size(40, 24);
            this.b_BN.TabIndex = 36;
            this.b_BN.Text = "B/N";
            this.b_BN.UseVisualStyleBackColor = false;
            this.b_BN.Click += new System.EventHandler(this.b_BN_Click);
            // 
            // cb_Perfil
            // 
            this.cb_Perfil.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Perfil.FormattingEnabled = true;
            this.cb_Perfil.Location = new System.Drawing.Point(86, 15);
            this.cb_Perfil.Name = "cb_Perfil";
            this.cb_Perfil.Size = new System.Drawing.Size(336, 27);
            this.cb_Perfil.TabIndex = 35;
            this.cb_Perfil.Text = "Selecionar Modulo";
            this.cb_Perfil.SelectedIndexChanged += new System.EventHandler(this.cb_Perfil_SelectedIndexChanged);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(12, 72);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.Size = new System.Drawing.Size(410, 347);
            this.dataGridView2.TabIndex = 32;
            // 
            // l_Perfil
            // 
            this.l_Perfil.AutoSize = true;
            this.l_Perfil.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_Perfil.Location = new System.Drawing.Point(12, 18);
            this.l_Perfil.Name = "l_Perfil";
            this.l_Perfil.Size = new System.Drawing.Size(68, 19);
            this.l_Perfil.TabIndex = 29;
            this.l_Perfil.Text = "Modulo";
            // 
            // ConsultarSubmoduloDeModulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 461);
            this.Controls.Add(this.l_ZonaMensaje);
            this.Controls.Add(this.l_UsuariosDePerfil);
            this.Controls.Add(this.b_BN);
            this.Controls.Add(this.cb_Perfil);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.l_Perfil);
            this.MinimumSize = new System.Drawing.Size(450, 500);
            this.Name = "ConsultarSubmoduloDeModulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConsultarSubmoduloDeModulo";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l_ZonaMensaje;
        private System.Windows.Forms.Label l_UsuariosDePerfil;
        private System.Windows.Forms.Button b_BN;
        private System.Windows.Forms.ComboBox cb_Perfil;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label l_Perfil;
    }
}