namespace Gestion_de_Proyectos.Vista
{
    partial class AsignarEspecialidadEmpleado
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
            this.b_Desasignar = new System.Windows.Forms.Button();
            this.b_Asignar = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.l_Usuarios = new System.Windows.Forms.Label();
            this.l_Perfil = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.l_ZonaMensaje.TabIndex = 28;
            this.l_ZonaMensaje.Text = "Zona de Mensaje";
            // 
            // l_UsuariosDePerfil
            // 
            this.l_UsuariosDePerfil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.l_UsuariosDePerfil.AutoSize = true;
            this.l_UsuariosDePerfil.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_UsuariosDePerfil.ForeColor = System.Drawing.Color.Green;
            this.l_UsuariosDePerfil.Location = new System.Drawing.Point(396, 84);
            this.l_UsuariosDePerfil.Name = "l_UsuariosDePerfil";
            this.l_UsuariosDePerfil.Size = new System.Drawing.Size(256, 19);
            this.l_UsuariosDePerfil.TabIndex = 27;
            this.l_UsuariosDePerfil.Text = "Empleados con la Especialidad";
            // 
            // b_BN
            // 
            this.b_BN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.b_BN.AutoSize = true;
            this.b_BN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.b_BN.BackColor = System.Drawing.Color.Black;
            this.b_BN.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_BN.ForeColor = System.Drawing.Color.White;
            this.b_BN.Location = new System.Drawing.Point(632, 425);
            this.b_BN.Name = "b_BN";
            this.b_BN.Size = new System.Drawing.Size(40, 24);
            this.b_BN.TabIndex = 26;
            this.b_BN.Text = "B/N";
            this.b_BN.UseVisualStyleBackColor = false;
            this.b_BN.Click += new System.EventHandler(this.b_BN_Click);
            // 
            // cb_Perfil
            // 
            this.cb_Perfil.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Perfil.FormattingEnabled = true;
            this.cb_Perfil.Location = new System.Drawing.Point(128, 12);
            this.cb_Perfil.Name = "cb_Perfil";
            this.cb_Perfil.Size = new System.Drawing.Size(261, 27);
            this.cb_Perfil.TabIndex = 25;
            this.cb_Perfil.Text = "Selecionar Especialidad";
            this.cb_Perfil.SelectedIndexChanged += new System.EventHandler(this.cb_Perfil_SelectedIndexChanged);
            // 
            // b_Desasignar
            // 
            this.b_Desasignar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.b_Desasignar.AutoSize = true;
            this.b_Desasignar.BackColor = System.Drawing.Color.Red;
            this.b_Desasignar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_Desasignar.ForeColor = System.Drawing.Color.Yellow;
            this.b_Desasignar.Location = new System.Drawing.Point(305, 210);
            this.b_Desasignar.Name = "b_Desasignar";
            this.b_Desasignar.Size = new System.Drawing.Size(75, 29);
            this.b_Desasignar.TabIndex = 24;
            this.b_Desasignar.Text = "<<";
            this.b_Desasignar.UseVisualStyleBackColor = false;
            this.b_Desasignar.Click += new System.EventHandler(this.b_Desasignar_Click);
            // 
            // b_Asignar
            // 
            this.b_Asignar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.b_Asignar.AutoSize = true;
            this.b_Asignar.BackColor = System.Drawing.Color.Green;
            this.b_Asignar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_Asignar.ForeColor = System.Drawing.Color.White;
            this.b_Asignar.Location = new System.Drawing.Point(305, 270);
            this.b_Asignar.Name = "b_Asignar";
            this.b_Asignar.Size = new System.Drawing.Size(75, 29);
            this.b_Asignar.TabIndex = 23;
            this.b_Asignar.Text = ">>";
            this.b_Asignar.UseVisualStyleBackColor = false;
            this.b_Asignar.Click += new System.EventHandler(this.b_Asignar_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(385, 106);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.Size = new System.Drawing.Size(287, 313);
            this.dataGridView2.TabIndex = 22;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 106);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(287, 313);
            this.dataGridView1.TabIndex = 21;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // l_Usuarios
            // 
            this.l_Usuarios.AutoSize = true;
            this.l_Usuarios.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_Usuarios.ForeColor = System.Drawing.Color.Red;
            this.l_Usuarios.Location = new System.Drawing.Point(32, 84);
            this.l_Usuarios.Name = "l_Usuarios";
            this.l_Usuarios.Size = new System.Drawing.Size(251, 19);
            this.l_Usuarios.TabIndex = 20;
            this.l_Usuarios.Text = "Empleados sin la Especialidad";
            // 
            // l_Perfil
            // 
            this.l_Perfil.AutoSize = true;
            this.l_Perfil.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_Perfil.Location = new System.Drawing.Point(12, 15);
            this.l_Perfil.Name = "l_Perfil";
            this.l_Perfil.Size = new System.Drawing.Size(110, 19);
            this.l_Perfil.TabIndex = 19;
            this.l_Perfil.Text = "Especialidad";
            // 
            // AsignarEspecialidadEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.l_ZonaMensaje);
            this.Controls.Add(this.l_UsuariosDePerfil);
            this.Controls.Add(this.b_BN);
            this.Controls.Add(this.cb_Perfil);
            this.Controls.Add(this.b_Desasignar);
            this.Controls.Add(this.b_Asignar);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.l_Usuarios);
            this.Controls.Add(this.l_Perfil);
            this.MinimumSize = new System.Drawing.Size(700, 500);
            this.Name = "AsignarEspecialidadEmpleado";
            this.Text = "AsignarEspecialidadEmpleado";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l_ZonaMensaje;
        private System.Windows.Forms.Label l_UsuariosDePerfil;
        private System.Windows.Forms.Button b_BN;
        private System.Windows.Forms.ComboBox cb_Perfil;
        private System.Windows.Forms.Button b_Desasignar;
        private System.Windows.Forms.Button b_Asignar;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label l_Usuarios;
        private System.Windows.Forms.Label l_Perfil;
    }
}