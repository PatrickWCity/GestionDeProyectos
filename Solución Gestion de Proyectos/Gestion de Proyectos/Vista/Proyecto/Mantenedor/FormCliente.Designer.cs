namespace Gestion_de_Proyectos.Vista
{
    partial class FormCliente
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.l_PalabraClave = new System.Windows.Forms.Label();
            this.tb_PalabraClave = new System.Windows.Forms.TextBox();
            this.l_ZonaMensaje = new System.Windows.Forms.Label();
            this.tb_Domicilio = new System.Windows.Forms.TextBox();
            this.tb_Nombre = new System.Windows.Forms.TextBox();
            this.tb_Rut = new System.Windows.Forms.TextBox();
            this.tb_Id_Cliente = new System.Windows.Forms.TextBox();
            this.l_Domicilio = new System.Windows.Forms.Label();
            this.l_Nombre = new System.Windows.Forms.Label();
            this.l_Rut = new System.Windows.Forms.Label();
            this.l_Id_Cliente = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.b_Actualizar = new System.Windows.Forms.Button();
            this.b_Guardar = new System.Windows.Forms.Button();
            this.b_Salir = new System.Windows.Forms.Button();
            this.b_Restablecer = new System.Windows.Forms.Button();
            this.b_Eliminar = new System.Windows.Forms.Button();
            this.b_Consultar = new System.Windows.Forms.Button();
            this.l_email = new System.Windows.Forms.Label();
            this.tb_Email = new System.Windows.Forms.TextBox();
            this.tb_Telefono = new System.Windows.Forms.TextBox();
            this.l_telefono = new System.Windows.Forms.Label();
            this.id_cliente1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.domicilio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comuna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            this.id_cliente1,
            this.rut,
            this.nombre,
            this.domicilio,
            this.comuna,
            this.telefono1,
            this.email});
            this.dataGridView1.Location = new System.Drawing.Point(12, 278);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(760, 152);
            this.dataGridView1.TabIndex = 87;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // l_PalabraClave
            // 
            this.l_PalabraClave.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.l_PalabraClave.AutoSize = true;
            this.l_PalabraClave.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_PalabraClave.Location = new System.Drawing.Point(12, 248);
            this.l_PalabraClave.Name = "l_PalabraClave";
            this.l_PalabraClave.Size = new System.Drawing.Size(213, 19);
            this.l_PalabraClave.TabIndex = 84;
            this.l_PalabraClave.Text = "Buscar por Palabra Clave";
            // 
            // tb_PalabraClave
            // 
            this.tb_PalabraClave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_PalabraClave.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_PalabraClave.Location = new System.Drawing.Point(231, 245);
            this.tb_PalabraClave.Name = "tb_PalabraClave";
            this.tb_PalabraClave.Size = new System.Drawing.Size(147, 27);
            this.tb_PalabraClave.TabIndex = 83;
            // 
            // l_ZonaMensaje
            // 
            this.l_ZonaMensaje.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.l_ZonaMensaje.AutoSize = true;
            this.l_ZonaMensaje.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_ZonaMensaje.ForeColor = System.Drawing.Color.Red;
            this.l_ZonaMensaje.Location = new System.Drawing.Point(12, 433);
            this.l_ZonaMensaje.Name = "l_ZonaMensaje";
            this.l_ZonaMensaje.Size = new System.Drawing.Size(147, 19);
            this.l_ZonaMensaje.TabIndex = 81;
            this.l_ZonaMensaje.Text = "Zona de Mensaje";
            // 
            // tb_Domicilio
            // 
            this.tb_Domicilio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Domicilio.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Domicilio.Location = new System.Drawing.Point(102, 111);
            this.tb_Domicilio.Name = "tb_Domicilio";
            this.tb_Domicilio.Size = new System.Drawing.Size(523, 27);
            this.tb_Domicilio.TabIndex = 95;
            // 
            // tb_Nombre
            // 
            this.tb_Nombre.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Nombre.Location = new System.Drawing.Point(102, 78);
            this.tb_Nombre.Name = "tb_Nombre";
            this.tb_Nombre.Size = new System.Drawing.Size(523, 27);
            this.tb_Nombre.TabIndex = 94;
            // 
            // tb_Rut
            // 
            this.tb_Rut.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Rut.Location = new System.Drawing.Point(102, 45);
            this.tb_Rut.Name = "tb_Rut";
            this.tb_Rut.Size = new System.Drawing.Size(100, 27);
            this.tb_Rut.TabIndex = 93;
            // 
            // tb_Id_Cliente
            // 
            this.tb_Id_Cliente.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Id_Cliente.Location = new System.Drawing.Point(102, 12);
            this.tb_Id_Cliente.Name = "tb_Id_Cliente";
            this.tb_Id_Cliente.Size = new System.Drawing.Size(100, 27);
            this.tb_Id_Cliente.TabIndex = 92;
            // 
            // l_Domicilio
            // 
            this.l_Domicilio.AutoSize = true;
            this.l_Domicilio.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_Domicilio.Location = new System.Drawing.Point(12, 114);
            this.l_Domicilio.Name = "l_Domicilio";
            this.l_Domicilio.Size = new System.Drawing.Size(84, 19);
            this.l_Domicilio.TabIndex = 91;
            this.l_Domicilio.Text = "Domicilio";
            // 
            // l_Nombre
            // 
            this.l_Nombre.AutoSize = true;
            this.l_Nombre.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_Nombre.Location = new System.Drawing.Point(8, 81);
            this.l_Nombre.Name = "l_Nombre";
            this.l_Nombre.Size = new System.Drawing.Size(73, 19);
            this.l_Nombre.TabIndex = 90;
            this.l_Nombre.Text = "Nombre";
            // 
            // l_Rut
            // 
            this.l_Rut.AutoSize = true;
            this.l_Rut.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_Rut.Location = new System.Drawing.Point(12, 48);
            this.l_Rut.Name = "l_Rut";
            this.l_Rut.Size = new System.Drawing.Size(44, 19);
            this.l_Rut.TabIndex = 89;
            this.l_Rut.Text = "RUT";
            // 
            // l_Id_Cliente
            // 
            this.l_Id_Cliente.AutoSize = true;
            this.l_Id_Cliente.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_Id_Cliente.Location = new System.Drawing.Point(12, 15);
            this.l_Id_Cliente.Name = "l_Id_Cliente";
            this.l_Id_Cliente.Size = new System.Drawing.Size(28, 19);
            this.l_Id_Cliente.TabIndex = 88;
            this.l_Id_Cliente.Text = "ID";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(104, 144);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(521, 27);
            this.comboBox1.TabIndex = 97;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 19);
            this.label1.TabIndex = 96;
            this.label1.Text = "Localidad";
            // 
            // b_Actualizar
            // 
            this.b_Actualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.b_Actualizar.AutoSize = true;
            this.b_Actualizar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_Actualizar.Image = global::Gestion_de_Proyectos.Properties.Resources.pencil;
            this.b_Actualizar.Location = new System.Drawing.Point(631, 43);
            this.b_Actualizar.Name = "b_Actualizar";
            this.b_Actualizar.Size = new System.Drawing.Size(141, 29);
            this.b_Actualizar.TabIndex = 105;
            this.b_Actualizar.Text = "Acualizar";
            this.b_Actualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.b_Actualizar.UseVisualStyleBackColor = true;
            this.b_Actualizar.Click += new System.EventHandler(this.b_Actualizar_Click);
            // 
            // b_Guardar
            // 
            this.b_Guardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.b_Guardar.AutoSize = true;
            this.b_Guardar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_Guardar.Image = global::Gestion_de_Proyectos.Properties.Resources.plus;
            this.b_Guardar.Location = new System.Drawing.Point(631, 10);
            this.b_Guardar.Name = "b_Guardar";
            this.b_Guardar.Size = new System.Drawing.Size(141, 29);
            this.b_Guardar.TabIndex = 104;
            this.b_Guardar.Text = "Guardar";
            this.b_Guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.b_Guardar.UseVisualStyleBackColor = true;
            this.b_Guardar.Click += new System.EventHandler(this.b_Guardar_Click);
            // 
            // b_Salir
            // 
            this.b_Salir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.b_Salir.AutoSize = true;
            this.b_Salir.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_Salir.Image = global::Gestion_de_Proyectos.Properties.Resources.times;
            this.b_Salir.Location = new System.Drawing.Point(631, 142);
            this.b_Salir.Name = "b_Salir";
            this.b_Salir.Size = new System.Drawing.Size(141, 29);
            this.b_Salir.TabIndex = 103;
            this.b_Salir.Text = "Salir";
            this.b_Salir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.b_Salir.UseVisualStyleBackColor = true;
            this.b_Salir.Click += new System.EventHandler(this.b_Salir_Click);
            // 
            // b_Restablecer
            // 
            this.b_Restablecer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.b_Restablecer.AutoSize = true;
            this.b_Restablecer.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_Restablecer.Image = global::Gestion_de_Proyectos.Properties.Resources.eraser;
            this.b_Restablecer.Location = new System.Drawing.Point(631, 109);
            this.b_Restablecer.Name = "b_Restablecer";
            this.b_Restablecer.Size = new System.Drawing.Size(141, 29);
            this.b_Restablecer.TabIndex = 102;
            this.b_Restablecer.Text = "Restablecer";
            this.b_Restablecer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.b_Restablecer.UseVisualStyleBackColor = true;
            this.b_Restablecer.Click += new System.EventHandler(this.b_Restablecer_Click);
            // 
            // b_Eliminar
            // 
            this.b_Eliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.b_Eliminar.AutoSize = true;
            this.b_Eliminar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_Eliminar.Image = global::Gestion_de_Proyectos.Properties.Resources.trash;
            this.b_Eliminar.Location = new System.Drawing.Point(631, 76);
            this.b_Eliminar.Name = "b_Eliminar";
            this.b_Eliminar.Size = new System.Drawing.Size(141, 29);
            this.b_Eliminar.TabIndex = 101;
            this.b_Eliminar.Text = "Eliminar";
            this.b_Eliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.b_Eliminar.UseVisualStyleBackColor = true;
            this.b_Eliminar.Click += new System.EventHandler(this.b_Eliminar_Click);
            // 
            // b_Consultar
            // 
            this.b_Consultar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.b_Consultar.AutoSize = true;
            this.b_Consultar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_Consultar.Image = global::Gestion_de_Proyectos.Properties.Resources.eye;
            this.b_Consultar.Location = new System.Drawing.Point(631, 177);
            this.b_Consultar.Name = "b_Consultar";
            this.b_Consultar.Size = new System.Drawing.Size(141, 29);
            this.b_Consultar.TabIndex = 100;
            this.b_Consultar.Text = "Consultar";
            this.b_Consultar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.b_Consultar.UseVisualStyleBackColor = true;
            this.b_Consultar.Click += new System.EventHandler(this.b_Consultar_Click);
            // 
            // l_email
            // 
            this.l_email.AutoSize = true;
            this.l_email.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_email.Location = new System.Drawing.Point(12, 215);
            this.l_email.Name = "l_email";
            this.l_email.Size = new System.Drawing.Size(54, 19);
            this.l_email.TabIndex = 109;
            this.l_email.Text = "Email";
            // 
            // tb_Email
            // 
            this.tb_Email.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Email.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Email.Location = new System.Drawing.Point(104, 212);
            this.tb_Email.Name = "tb_Email";
            this.tb_Email.Size = new System.Drawing.Size(521, 27);
            this.tb_Email.TabIndex = 108;
            // 
            // tb_Telefono
            // 
            this.tb_Telefono.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Telefono.Location = new System.Drawing.Point(104, 179);
            this.tb_Telefono.Name = "tb_Telefono";
            this.tb_Telefono.Size = new System.Drawing.Size(521, 27);
            this.tb_Telefono.TabIndex = 107;
            // 
            // l_telefono
            // 
            this.l_telefono.AutoSize = true;
            this.l_telefono.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_telefono.Location = new System.Drawing.Point(12, 182);
            this.l_telefono.Name = "l_telefono";
            this.l_telefono.Size = new System.Drawing.Size(81, 19);
            this.l_telefono.TabIndex = 106;
            this.l_telefono.Text = "Telefono";
            // 
            // id_cliente1
            // 
            this.id_cliente1.DataPropertyName = "id_cliente";
            this.id_cliente1.HeaderText = "ID de Cliente";
            this.id_cliente1.Name = "id_cliente1";
            this.id_cliente1.ReadOnly = true;
            // 
            // rut
            // 
            this.rut.DataPropertyName = "rut";
            this.rut.HeaderText = "RUT";
            this.rut.Name = "rut";
            this.rut.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // domicilio
            // 
            this.domicilio.DataPropertyName = "domicilio";
            this.domicilio.HeaderText = "Domicilio";
            this.domicilio.Name = "domicilio";
            this.domicilio.ReadOnly = true;
            // 
            // comuna
            // 
            this.comuna.DataPropertyName = "comuna";
            this.comuna.HeaderText = "Comuna";
            this.comuna.Name = "comuna";
            this.comuna.ReadOnly = true;
            // 
            // telefono1
            // 
            this.telefono1.DataPropertyName = "telefono";
            this.telefono1.HeaderText = "Telefono";
            this.telefono1.Name = "telefono1";
            this.telefono1.ReadOnly = true;
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            // 
            // FormCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.l_email);
            this.Controls.Add(this.tb_Email);
            this.Controls.Add(this.tb_Telefono);
            this.Controls.Add(this.l_telefono);
            this.Controls.Add(this.b_Actualizar);
            this.Controls.Add(this.b_Guardar);
            this.Controls.Add(this.b_Salir);
            this.Controls.Add(this.b_Restablecer);
            this.Controls.Add(this.b_Eliminar);
            this.Controls.Add(this.b_Consultar);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_Domicilio);
            this.Controls.Add(this.tb_Nombre);
            this.Controls.Add(this.tb_Rut);
            this.Controls.Add(this.tb_Id_Cliente);
            this.Controls.Add(this.l_Domicilio);
            this.Controls.Add(this.l_Nombre);
            this.Controls.Add(this.l_Rut);
            this.Controls.Add(this.l_Id_Cliente);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.l_PalabraClave);
            this.Controls.Add(this.tb_PalabraClave);
            this.Controls.Add(this.l_ZonaMensaje);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "FormCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cliente";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label l_PalabraClave;
        private System.Windows.Forms.TextBox tb_PalabraClave;
        private System.Windows.Forms.Label l_ZonaMensaje;
        private System.Windows.Forms.TextBox tb_Domicilio;
        private System.Windows.Forms.TextBox tb_Nombre;
        private System.Windows.Forms.TextBox tb_Rut;
        private System.Windows.Forms.TextBox tb_Id_Cliente;
        private System.Windows.Forms.Label l_Domicilio;
        private System.Windows.Forms.Label l_Nombre;
        private System.Windows.Forms.Label l_Rut;
        private System.Windows.Forms.Label l_Id_Cliente;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button b_Actualizar;
        private System.Windows.Forms.Button b_Guardar;
        private System.Windows.Forms.Button b_Salir;
        private System.Windows.Forms.Button b_Restablecer;
        private System.Windows.Forms.Button b_Eliminar;
        private System.Windows.Forms.Button b_Consultar;
        private System.Windows.Forms.Label l_email;
        private System.Windows.Forms.TextBox tb_Email;
        private System.Windows.Forms.TextBox tb_Telefono;
        private System.Windows.Forms.Label l_telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_cliente1;
        private System.Windows.Forms.DataGridViewTextBoxColumn rut;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn domicilio;
        private System.Windows.Forms.DataGridViewTextBoxColumn comuna;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono1;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
    }
}