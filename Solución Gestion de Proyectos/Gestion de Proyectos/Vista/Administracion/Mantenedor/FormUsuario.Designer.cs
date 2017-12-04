namespace Gestion_de_Proyectos.Vista
{
    partial class FormUsuario
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
            this.l_PalabraClave = new System.Windows.Forms.Label();
            this.tb_PalabraClave = new System.Windows.Forms.TextBox();
            this.b_Salir = new System.Windows.Forms.Button();
            this.l_ZonaMensaje = new System.Windows.Forms.Label();
            this.b_Restablecer = new System.Windows.Forms.Button();
            this.b_Eliminar = new System.Windows.Forms.Button();
            this.b_Consultar = new System.Windows.Forms.Button();
            this.tb_Direccion = new System.Windows.Forms.TextBox();
            this.tb_Apmat = new System.Windows.Forms.TextBox();
            this.tb_Appat = new System.Windows.Forms.TextBox();
            this.tb_Nombre = new System.Windows.Forms.TextBox();
            this.tb_Run = new System.Windows.Forms.TextBox();
            this.tb_NroInterno = new System.Windows.Forms.TextBox();
            this.l_Apmat = new System.Windows.Forms.Label();
            this.l_Appat = new System.Windows.Forms.Label();
            this.l_Nombre = new System.Windows.Forms.Label();
            this.l_Run = new System.Windows.Forms.Label();
            this.l_NroInterno = new System.Windows.Forms.Label();
            this.l_Direccion = new System.Windows.Forms.Label();
            this.b_Guardar = new System.Windows.Forms.Button();
            this.b_Actualizar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nroInterno1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.run = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apmat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // l_PalabraClave
            // 
            this.l_PalabraClave.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.l_PalabraClave.AutoSize = true;
            this.l_PalabraClave.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_PalabraClave.Location = new System.Drawing.Point(13, 246);
            this.l_PalabraClave.Name = "l_PalabraClave";
            this.l_PalabraClave.Size = new System.Drawing.Size(213, 19);
            this.l_PalabraClave.TabIndex = 73;
            this.l_PalabraClave.Text = "Buscar por Palabra Clave";
            // 
            // tb_PalabraClave
            // 
            this.tb_PalabraClave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_PalabraClave.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_PalabraClave.Location = new System.Drawing.Point(232, 243);
            this.tb_PalabraClave.Name = "tb_PalabraClave";
            this.tb_PalabraClave.Size = new System.Drawing.Size(100, 27);
            this.tb_PalabraClave.TabIndex = 72;
            // 
            // b_Salir
            // 
            this.b_Salir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.b_Salir.AutoSize = true;
            this.b_Salir.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_Salir.Location = new System.Drawing.Point(656, 142);
            this.b_Salir.Name = "b_Salir";
            this.b_Salir.Size = new System.Drawing.Size(116, 29);
            this.b_Salir.TabIndex = 71;
            this.b_Salir.Text = "Salir";
            this.b_Salir.UseVisualStyleBackColor = true;
            this.b_Salir.Click += new System.EventHandler(this.b_Salir_Click);
            // 
            // l_ZonaMensaje
            // 
            this.l_ZonaMensaje.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.l_ZonaMensaje.AutoSize = true;
            this.l_ZonaMensaje.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_ZonaMensaje.ForeColor = System.Drawing.Color.Red;
            this.l_ZonaMensaje.Location = new System.Drawing.Point(12, 472);
            this.l_ZonaMensaje.Name = "l_ZonaMensaje";
            this.l_ZonaMensaje.Size = new System.Drawing.Size(147, 19);
            this.l_ZonaMensaje.TabIndex = 70;
            this.l_ZonaMensaje.Text = "Zona de Mensaje";
            // 
            // b_Restablecer
            // 
            this.b_Restablecer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.b_Restablecer.AutoSize = true;
            this.b_Restablecer.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_Restablecer.Location = new System.Drawing.Point(656, 109);
            this.b_Restablecer.Name = "b_Restablecer";
            this.b_Restablecer.Size = new System.Drawing.Size(116, 29);
            this.b_Restablecer.TabIndex = 69;
            this.b_Restablecer.Text = "Restablecer";
            this.b_Restablecer.UseVisualStyleBackColor = true;
            this.b_Restablecer.Click += new System.EventHandler(this.b_Restablecer_Click);
            // 
            // b_Eliminar
            // 
            this.b_Eliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.b_Eliminar.AutoSize = true;
            this.b_Eliminar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_Eliminar.Location = new System.Drawing.Point(656, 76);
            this.b_Eliminar.Name = "b_Eliminar";
            this.b_Eliminar.Size = new System.Drawing.Size(116, 29);
            this.b_Eliminar.TabIndex = 68;
            this.b_Eliminar.Text = "Eliminar";
            this.b_Eliminar.UseVisualStyleBackColor = true;
            this.b_Eliminar.Click += new System.EventHandler(this.b_Eliminar_Click);
            // 
            // b_Consultar
            // 
            this.b_Consultar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.b_Consultar.AutoSize = true;
            this.b_Consultar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_Consultar.Location = new System.Drawing.Point(656, 177);
            this.b_Consultar.Name = "b_Consultar";
            this.b_Consultar.Size = new System.Drawing.Size(116, 29);
            this.b_Consultar.TabIndex = 67;
            this.b_Consultar.Text = "Consultar";
            this.b_Consultar.UseVisualStyleBackColor = true;
            this.b_Consultar.Click += new System.EventHandler(this.b_Consultar_Click);
            // 
            // tb_Direccion
            // 
            this.tb_Direccion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Direccion.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Direccion.Location = new System.Drawing.Point(164, 177);
            this.tb_Direccion.Name = "tb_Direccion";
            this.tb_Direccion.Size = new System.Drawing.Size(486, 27);
            this.tb_Direccion.TabIndex = 66;
            // 
            // tb_Apmat
            // 
            this.tb_Apmat.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Apmat.Location = new System.Drawing.Point(164, 144);
            this.tb_Apmat.Name = "tb_Apmat";
            this.tb_Apmat.Size = new System.Drawing.Size(486, 27);
            this.tb_Apmat.TabIndex = 65;
            // 
            // tb_Appat
            // 
            this.tb_Appat.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Appat.Location = new System.Drawing.Point(164, 111);
            this.tb_Appat.Name = "tb_Appat";
            this.tb_Appat.Size = new System.Drawing.Size(486, 27);
            this.tb_Appat.TabIndex = 64;
            // 
            // tb_Nombre
            // 
            this.tb_Nombre.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Nombre.Location = new System.Drawing.Point(164, 78);
            this.tb_Nombre.Name = "tb_Nombre";
            this.tb_Nombre.Size = new System.Drawing.Size(486, 27);
            this.tb_Nombre.TabIndex = 63;
            // 
            // tb_Run
            // 
            this.tb_Run.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Run.Location = new System.Drawing.Point(164, 45);
            this.tb_Run.Name = "tb_Run";
            this.tb_Run.Size = new System.Drawing.Size(100, 27);
            this.tb_Run.TabIndex = 62;
            // 
            // tb_NroInterno
            // 
            this.tb_NroInterno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_NroInterno.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_NroInterno.Location = new System.Drawing.Point(164, 12);
            this.tb_NroInterno.Name = "tb_NroInterno";
            this.tb_NroInterno.Size = new System.Drawing.Size(100, 27);
            this.tb_NroInterno.TabIndex = 61;
            // 
            // l_Apmat
            // 
            this.l_Apmat.AutoSize = true;
            this.l_Apmat.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_Apmat.Location = new System.Drawing.Point(12, 147);
            this.l_Apmat.Name = "l_Apmat";
            this.l_Apmat.Size = new System.Drawing.Size(149, 19);
            this.l_Apmat.TabIndex = 59;
            this.l_Apmat.Text = "Apellido Materno";
            // 
            // l_Appat
            // 
            this.l_Appat.AutoSize = true;
            this.l_Appat.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_Appat.Location = new System.Drawing.Point(12, 114);
            this.l_Appat.Name = "l_Appat";
            this.l_Appat.Size = new System.Drawing.Size(146, 19);
            this.l_Appat.TabIndex = 58;
            this.l_Appat.Text = "Apellido Paterno";
            // 
            // l_Nombre
            // 
            this.l_Nombre.AutoSize = true;
            this.l_Nombre.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_Nombre.Location = new System.Drawing.Point(12, 81);
            this.l_Nombre.Name = "l_Nombre";
            this.l_Nombre.Size = new System.Drawing.Size(73, 19);
            this.l_Nombre.TabIndex = 57;
            this.l_Nombre.Text = "Nombre";
            // 
            // l_Run
            // 
            this.l_Run.AutoSize = true;
            this.l_Run.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_Run.Location = new System.Drawing.Point(12, 48);
            this.l_Run.Name = "l_Run";
            this.l_Run.Size = new System.Drawing.Size(45, 19);
            this.l_Run.TabIndex = 56;
            this.l_Run.Text = "RUN";
            // 
            // l_NroInterno
            // 
            this.l_NroInterno.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.l_NroInterno.AutoSize = true;
            this.l_NroInterno.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_NroInterno.Location = new System.Drawing.Point(12, 15);
            this.l_NroInterno.Name = "l_NroInterno";
            this.l_NroInterno.Size = new System.Drawing.Size(139, 19);
            this.l_NroInterno.TabIndex = 55;
            this.l_NroInterno.Text = "Numero Interno";
            // 
            // l_Direccion
            // 
            this.l_Direccion.AutoSize = true;
            this.l_Direccion.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_Direccion.Location = new System.Drawing.Point(12, 180);
            this.l_Direccion.Name = "l_Direccion";
            this.l_Direccion.Size = new System.Drawing.Size(84, 19);
            this.l_Direccion.TabIndex = 74;
            this.l_Direccion.Text = "Direccion";
            // 
            // b_Guardar
            // 
            this.b_Guardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.b_Guardar.AutoSize = true;
            this.b_Guardar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_Guardar.Location = new System.Drawing.Point(656, 10);
            this.b_Guardar.Name = "b_Guardar";
            this.b_Guardar.Size = new System.Drawing.Size(116, 29);
            this.b_Guardar.TabIndex = 75;
            this.b_Guardar.Text = "Guardar";
            this.b_Guardar.UseVisualStyleBackColor = true;
            this.b_Guardar.Click += new System.EventHandler(this.b_Guardar_Click);
            // 
            // b_Actualizar
            // 
            this.b_Actualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.b_Actualizar.AutoSize = true;
            this.b_Actualizar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_Actualizar.Location = new System.Drawing.Point(656, 43);
            this.b_Actualizar.Name = "b_Actualizar";
            this.b_Actualizar.Size = new System.Drawing.Size(116, 29);
            this.b_Actualizar.TabIndex = 76;
            this.b_Actualizar.Text = "Acualizar";
            this.b_Actualizar.UseVisualStyleBackColor = true;
            this.b_Actualizar.Click += new System.EventHandler(this.b_Actualizar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nroInterno1,
            this.run,
            this.nombre,
            this.appat,
            this.apmat,
            this.direccion});
            this.dataGridView1.Location = new System.Drawing.Point(12, 276);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(760, 193);
            this.dataGridView1.TabIndex = 77;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // nroInterno1
            // 
            this.nroInterno1.DataPropertyName = "nroInterno";
            this.nroInterno1.HeaderText = "Numero Interno";
            this.nroInterno1.Name = "nroInterno1";
            this.nroInterno1.ReadOnly = true;
            // 
            // run
            // 
            this.run.DataPropertyName = "run";
            this.run.HeaderText = "RUN";
            this.run.Name = "run";
            this.run.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // appat
            // 
            this.appat.DataPropertyName = "appat";
            this.appat.HeaderText = "Apellido Paterno";
            this.appat.Name = "appat";
            this.appat.ReadOnly = true;
            // 
            // apmat
            // 
            this.apmat.DataPropertyName = "apmat";
            this.apmat.HeaderText = "Apellido Materno";
            this.apmat.Name = "apmat";
            this.apmat.ReadOnly = true;
            // 
            // direccion
            // 
            this.direccion.DataPropertyName = "direccion";
            this.direccion.HeaderText = "Direccion";
            this.direccion.Name = "direccion";
            this.direccion.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 19);
            this.label1.TabIndex = 79;
            this.label1.Text = "Localidad";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(164, 210);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(486, 27);
            this.comboBox1.TabIndex = 80;
            // 
            // FormUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(784, 500);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.b_Actualizar);
            this.Controls.Add(this.b_Guardar);
            this.Controls.Add(this.l_Direccion);
            this.Controls.Add(this.l_PalabraClave);
            this.Controls.Add(this.tb_PalabraClave);
            this.Controls.Add(this.b_Salir);
            this.Controls.Add(this.l_ZonaMensaje);
            this.Controls.Add(this.b_Restablecer);
            this.Controls.Add(this.b_Eliminar);
            this.Controls.Add(this.b_Consultar);
            this.Controls.Add(this.tb_Direccion);
            this.Controls.Add(this.tb_Apmat);
            this.Controls.Add(this.tb_Appat);
            this.Controls.Add(this.tb_Nombre);
            this.Controls.Add(this.tb_Run);
            this.Controls.Add(this.tb_NroInterno);
            this.Controls.Add(this.l_Apmat);
            this.Controls.Add(this.l_Appat);
            this.Controls.Add(this.l_Nombre);
            this.Controls.Add(this.l_Run);
            this.Controls.Add(this.l_NroInterno);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "FormUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuario";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l_PalabraClave;
        private System.Windows.Forms.TextBox tb_PalabraClave;
        private System.Windows.Forms.Button b_Salir;
        private System.Windows.Forms.Label l_ZonaMensaje;
        private System.Windows.Forms.Button b_Restablecer;
        private System.Windows.Forms.Button b_Eliminar;
        private System.Windows.Forms.Button b_Consultar;
        private System.Windows.Forms.TextBox tb_Direccion;
        private System.Windows.Forms.TextBox tb_Apmat;
        private System.Windows.Forms.TextBox tb_Appat;
        private System.Windows.Forms.TextBox tb_Nombre;
        private System.Windows.Forms.TextBox tb_Run;
        private System.Windows.Forms.TextBox tb_NroInterno;
        private System.Windows.Forms.Label l_Apmat;
        private System.Windows.Forms.Label l_Appat;
        private System.Windows.Forms.Label l_Nombre;
        private System.Windows.Forms.Label l_Run;
        private System.Windows.Forms.Label l_NroInterno;
        private System.Windows.Forms.Label l_Direccion;
        private System.Windows.Forms.Button b_Guardar;
        private System.Windows.Forms.Button b_Actualizar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nroInterno1;
        private System.Windows.Forms.DataGridViewTextBoxColumn run;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn appat;
        private System.Windows.Forms.DataGridViewTextBoxColumn apmat;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}