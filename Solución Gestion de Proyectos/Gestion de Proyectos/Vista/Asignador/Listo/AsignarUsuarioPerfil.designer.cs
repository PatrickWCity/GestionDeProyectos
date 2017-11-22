using Gestion_de_Proyectos.Modelo;

namespace Gestion_de_Proyectos.Vista
{
    partial class AsignarUsuarioPerfil
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
            this.cb_Perfil = new System.Windows.Forms.ComboBox();
            this.b_Desasignar = new System.Windows.Forms.Button();
            this.b_Asignar = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.l_Usuarios = new System.Windows.Forms.Label();
            this.l_Perfil = new System.Windows.Forms.Label();
            this.b_BN = new System.Windows.Forms.Button();
            this.l_UsuariosDePerfil = new System.Windows.Forms.Label();
            this.l_ZonaMensaje = new System.Windows.Forms.Label();
            this.apmat2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appat2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nroInterno2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apmat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nroInterno1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_Perfil
            // 
            this.cb_Perfil.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Perfil.FormattingEnabled = true;
            this.cb_Perfil.Location = new System.Drawing.Point(71, 12);
            this.cb_Perfil.Name = "cb_Perfil";
            this.cb_Perfil.Size = new System.Drawing.Size(261, 27);
            this.cb_Perfil.TabIndex = 15;
            this.cb_Perfil.Text = "Selecionar Perfil";
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
            this.b_Desasignar.TabIndex = 14;
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
            this.b_Asignar.TabIndex = 13;
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
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nroInterno2,
            this.nombre2,
            this.appat2,
            this.apmat2});
            this.dataGridView2.Location = new System.Drawing.Point(385, 106);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.Size = new System.Drawing.Size(287, 313);
            this.dataGridView2.TabIndex = 12;
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
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nroInterno1,
            this.nombre,
            this.appat,
            this.apmat});
            this.dataGridView1.Location = new System.Drawing.Point(12, 106);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(287, 313);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // l_Usuarios
            // 
            this.l_Usuarios.AutoSize = true;
            this.l_Usuarios.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_Usuarios.ForeColor = System.Drawing.Color.Red;
            this.l_Usuarios.Location = new System.Drawing.Point(40, 84);
            this.l_Usuarios.Name = "l_Usuarios";
            this.l_Usuarios.Size = new System.Drawing.Size(176, 19);
            this.l_Usuarios.TabIndex = 9;
            this.l_Usuarios.Text = "Usuarios sin el Perfil";
            // 
            // l_Perfil
            // 
            this.l_Perfil.AutoSize = true;
            this.l_Perfil.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_Perfil.Location = new System.Drawing.Point(12, 15);
            this.l_Perfil.Name = "l_Perfil";
            this.l_Perfil.Size = new System.Drawing.Size(53, 19);
            this.l_Perfil.TabIndex = 8;
            this.l_Perfil.Text = "Perfil";
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
            this.b_BN.TabIndex = 16;
            this.b_BN.Text = "B/N";
            this.b_BN.UseVisualStyleBackColor = false;
            this.b_BN.Click += new System.EventHandler(this.b_BN_Click);
            // 
            // l_UsuariosDePerfil
            // 
            this.l_UsuariosDePerfil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.l_UsuariosDePerfil.AutoSize = true;
            this.l_UsuariosDePerfil.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_UsuariosDePerfil.ForeColor = System.Drawing.Color.Green;
            this.l_UsuariosDePerfil.Location = new System.Drawing.Point(465, 84);
            this.l_UsuariosDePerfil.Name = "l_UsuariosDePerfil";
            this.l_UsuariosDePerfil.Size = new System.Drawing.Size(181, 19);
            this.l_UsuariosDePerfil.TabIndex = 17;
            this.l_UsuariosDePerfil.Text = "Usuarios con el Perfil";
            // 
            // l_ZonaMensaje
            // 
            this.l_ZonaMensaje.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.l_ZonaMensaje.AutoSize = true;
            this.l_ZonaMensaje.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_ZonaMensaje.Location = new System.Drawing.Point(12, 426);
            this.l_ZonaMensaje.Name = "l_ZonaMensaje";
            this.l_ZonaMensaje.Size = new System.Drawing.Size(147, 19);
            this.l_ZonaMensaje.TabIndex = 18;
            this.l_ZonaMensaje.Text = "Zona de Mensaje";
            // 
            // apmat2
            // 
            this.apmat2.DataPropertyName = "apmat";
            this.apmat2.HeaderText = "Apellido Materno";
            this.apmat2.Name = "apmat2";
            this.apmat2.ReadOnly = true;
            // 
            // appat2
            // 
            this.appat2.DataPropertyName = "appat";
            this.appat2.HeaderText = "Apellido Paterno";
            this.appat2.Name = "appat2";
            this.appat2.ReadOnly = true;
            // 
            // nombre2
            // 
            this.nombre2.DataPropertyName = "nombre";
            this.nombre2.HeaderText = "Nombre";
            this.nombre2.Name = "nombre2";
            this.nombre2.ReadOnly = true;
            // 
            // nroInterno2
            // 
            this.nroInterno2.DataPropertyName = "nroInterno";
            this.nroInterno2.HeaderText = "Numero Interno";
            this.nroInterno2.Name = "nroInterno2";
            this.nroInterno2.ReadOnly = true;
            // 
            // apmat
            // 
            this.apmat.DataPropertyName = "apmat";
            this.apmat.HeaderText = "Apellido Materno";
            this.apmat.Name = "apmat";
            this.apmat.ReadOnly = true;
            // 
            // appat
            // 
            this.appat.DataPropertyName = "appat";
            this.appat.HeaderText = "Apellido Paterno";
            this.appat.Name = "appat";
            this.appat.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // nroInterno1
            // 
            this.nroInterno1.DataPropertyName = "nroInterno";
            this.nroInterno1.HeaderText = "Numero Interno";
            this.nroInterno1.Name = "nroInterno1";
            this.nroInterno1.ReadOnly = true;
            // 
            // AsignarUsuarioPerfil
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
            this.Name = "AsignarUsuarioPerfil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AsignarPerfilUsuario";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_Perfil;
        private System.Windows.Forms.Button b_Desasignar;
        private System.Windows.Forms.Button b_Asignar;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label l_Usuarios;
        private System.Windows.Forms.Label l_Perfil;
        private System.Windows.Forms.Button b_BN;
        private System.Windows.Forms.Label l_UsuariosDePerfil;
        private System.Windows.Forms.Label l_ZonaMensaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn nroInterno2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre2;
        private System.Windows.Forms.DataGridViewTextBoxColumn appat2;
        private System.Windows.Forms.DataGridViewTextBoxColumn apmat2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nroInterno1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn appat;
        private System.Windows.Forms.DataGridViewTextBoxColumn apmat;
    }
}