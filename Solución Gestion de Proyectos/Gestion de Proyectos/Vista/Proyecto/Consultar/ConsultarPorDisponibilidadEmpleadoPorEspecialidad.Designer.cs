namespace Gestion_de_Proyectos.Vista
{
    partial class ConsultarPorDisponibilidadEmpleadoPorEspecialidad
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
            this.b_BN = new System.Windows.Forms.Button();
            this.cb_Perfil = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.l_Usuarios = new System.Windows.Forms.Label();
            this.l_Perfil = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // l_ZonaMensaje
            // 
            this.l_ZonaMensaje.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.l_ZonaMensaje.AutoSize = true;
            this.l_ZonaMensaje.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_ZonaMensaje.Location = new System.Drawing.Point(12, 483);
            this.l_ZonaMensaje.Name = "l_ZonaMensaje";
            this.l_ZonaMensaje.Size = new System.Drawing.Size(147, 19);
            this.l_ZonaMensaje.TabIndex = 38;
            this.l_ZonaMensaje.Text = "Zona de Mensaje";
            // 
            // b_BN
            // 
            this.b_BN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.b_BN.AutoSize = true;
            this.b_BN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.b_BN.BackColor = System.Drawing.Color.Black;
            this.b_BN.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_BN.ForeColor = System.Drawing.Color.White;
            this.b_BN.Location = new System.Drawing.Point(582, 475);
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
            this.cb_Perfil.Location = new System.Drawing.Point(128, 12);
            this.cb_Perfil.Name = "cb_Perfil";
            this.cb_Perfil.Size = new System.Drawing.Size(494, 27);
            this.cb_Perfil.TabIndex = 35;
            this.cb_Perfil.Text = "Selecionar Especialidad";
            this.cb_Perfil.SelectedIndexChanged += new System.EventHandler(this.cb_Perfil_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 72);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(610, 397);
            this.dataGridView1.TabIndex = 31;
            // 
            // l_Usuarios
            // 
            this.l_Usuarios.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.l_Usuarios.AutoSize = true;
            this.l_Usuarios.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_Usuarios.ForeColor = System.Drawing.Color.Green;
            this.l_Usuarios.Location = new System.Drawing.Point(135, 50);
            this.l_Usuarios.Name = "l_Usuarios";
            this.l_Usuarios.Size = new System.Drawing.Size(372, 19);
            this.l_Usuarios.TabIndex = 30;
            this.l_Usuarios.Text = "Disponibilidad de Empleado por Especialidad";
            // 
            // l_Perfil
            // 
            this.l_Perfil.AutoSize = true;
            this.l_Perfil.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_Perfil.Location = new System.Drawing.Point(12, 15);
            this.l_Perfil.Name = "l_Perfil";
            this.l_Perfil.Size = new System.Drawing.Size(110, 19);
            this.l_Perfil.TabIndex = 29;
            this.l_Perfil.Text = "Especialidad";
            // 
            // ConsultarPorDisponibilidadEmpleadoPorEspecialidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 511);
            this.Controls.Add(this.l_ZonaMensaje);
            this.Controls.Add(this.b_BN);
            this.Controls.Add(this.cb_Perfil);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.l_Usuarios);
            this.Controls.Add(this.l_Perfil);
            this.MinimumSize = new System.Drawing.Size(650, 550);
            this.Name = "ConsultarPorDisponibilidadEmpleadoPorEspecialidad";
            this.Text = "ConsultarPorDisponibilidadEmpleadoPorEspecialidad";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l_ZonaMensaje;
        private System.Windows.Forms.Button b_BN;
        private System.Windows.Forms.ComboBox cb_Perfil;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label l_Usuarios;
        private System.Windows.Forms.Label l_Perfil;
    }
}