namespace Gestion_de_Proyectos.Vista
{
    partial class FormSubmodulo
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
            this.id_submodulo1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ubicacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.l_PalabraClave = new System.Windows.Forms.Label();
            this.tb_PalabraClave = new System.Windows.Forms.TextBox();
            this.l_ZonaMensaje = new System.Windows.Forms.Label();
            this.tb_Ubicacion = new System.Windows.Forms.TextBox();
            this.l_Ubicacion = new System.Windows.Forms.Label();
            this.l_Descripcion = new System.Windows.Forms.Label();
            this.l_Nombre = new System.Windows.Forms.Label();
            this.l_Id_Submodulo = new System.Windows.Forms.Label();
            this.tb_Descripcion = new System.Windows.Forms.TextBox();
            this.tb_Nombre = new System.Windows.Forms.TextBox();
            this.tb_Id_Submodulo = new System.Windows.Forms.TextBox();
            this.b_Actualizar = new System.Windows.Forms.Button();
            this.b_Guardar = new System.Windows.Forms.Button();
            this.b_Salir = new System.Windows.Forms.Button();
            this.b_Restablecer = new System.Windows.Forms.Button();
            this.b_Eliminar = new System.Windows.Forms.Button();
            this.b_Consultar = new System.Windows.Forms.Button();
            this.b_BN = new System.Windows.Forms.Button();
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
            this.id_submodulo1,
            this.nombre,
            this.descripcion,
            this.ubicacion});
            this.dataGridView1.Location = new System.Drawing.Point(12, 212);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(760, 218);
            this.dataGridView1.TabIndex = 87;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // id_submodulo1
            // 
            this.id_submodulo1.DataPropertyName = "id_submodulo";
            this.id_submodulo1.HeaderText = "ID de Submodulo";
            this.id_submodulo1.Name = "id_submodulo1";
            this.id_submodulo1.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // descripcion
            // 
            this.descripcion.DataPropertyName = "descripcion";
            this.descripcion.HeaderText = "Descripcion";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            // 
            // ubicacion
            // 
            this.ubicacion.DataPropertyName = "ubicacion";
            this.ubicacion.HeaderText = "Ubicacion";
            this.ubicacion.Name = "ubicacion";
            this.ubicacion.ReadOnly = true;
            // 
            // l_PalabraClave
            // 
            this.l_PalabraClave.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.l_PalabraClave.AutoSize = true;
            this.l_PalabraClave.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_PalabraClave.Location = new System.Drawing.Point(12, 182);
            this.l_PalabraClave.Name = "l_PalabraClave";
            this.l_PalabraClave.Size = new System.Drawing.Size(213, 19);
            this.l_PalabraClave.TabIndex = 84;
            this.l_PalabraClave.Text = "Buscar por Palabra Clave";
            // 
            // tb_PalabraClave
            // 
            this.tb_PalabraClave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_PalabraClave.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_PalabraClave.Location = new System.Drawing.Point(231, 179);
            this.tb_PalabraClave.Name = "tb_PalabraClave";
            this.tb_PalabraClave.Size = new System.Drawing.Size(100, 27);
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
            // tb_Ubicacion
            // 
            this.tb_Ubicacion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Ubicacion.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Ubicacion.Location = new System.Drawing.Point(120, 111);
            this.tb_Ubicacion.Name = "tb_Ubicacion";
            this.tb_Ubicacion.Size = new System.Drawing.Size(505, 27);
            this.tb_Ubicacion.TabIndex = 95;
            // 
            // l_Ubicacion
            // 
            this.l_Ubicacion.AutoSize = true;
            this.l_Ubicacion.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_Ubicacion.Location = new System.Drawing.Point(12, 114);
            this.l_Ubicacion.Name = "l_Ubicacion";
            this.l_Ubicacion.Size = new System.Drawing.Size(87, 19);
            this.l_Ubicacion.TabIndex = 94;
            this.l_Ubicacion.Text = "Ubicacion";
            // 
            // l_Descripcion
            // 
            this.l_Descripcion.AutoSize = true;
            this.l_Descripcion.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_Descripcion.Location = new System.Drawing.Point(12, 81);
            this.l_Descripcion.Name = "l_Descripcion";
            this.l_Descripcion.Size = new System.Drawing.Size(102, 19);
            this.l_Descripcion.TabIndex = 93;
            this.l_Descripcion.Text = "Descripcion";
            // 
            // l_Nombre
            // 
            this.l_Nombre.AutoSize = true;
            this.l_Nombre.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_Nombre.Location = new System.Drawing.Point(12, 48);
            this.l_Nombre.Name = "l_Nombre";
            this.l_Nombre.Size = new System.Drawing.Size(73, 19);
            this.l_Nombre.TabIndex = 92;
            this.l_Nombre.Text = "Nombre";
            // 
            // l_Id_Submodulo
            // 
            this.l_Id_Submodulo.AutoSize = true;
            this.l_Id_Submodulo.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_Id_Submodulo.Location = new System.Drawing.Point(12, 15);
            this.l_Id_Submodulo.Name = "l_Id_Submodulo";
            this.l_Id_Submodulo.Size = new System.Drawing.Size(28, 19);
            this.l_Id_Submodulo.TabIndex = 91;
            this.l_Id_Submodulo.Text = "ID";
            // 
            // tb_Descripcion
            // 
            this.tb_Descripcion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Descripcion.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Descripcion.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tb_Descripcion.Location = new System.Drawing.Point(120, 78);
            this.tb_Descripcion.Name = "tb_Descripcion";
            this.tb_Descripcion.Size = new System.Drawing.Size(505, 27);
            this.tb_Descripcion.TabIndex = 90;
            // 
            // tb_Nombre
            // 
            this.tb_Nombre.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Nombre.Location = new System.Drawing.Point(120, 45);
            this.tb_Nombre.Name = "tb_Nombre";
            this.tb_Nombre.Size = new System.Drawing.Size(505, 27);
            this.tb_Nombre.TabIndex = 89;
            // 
            // tb_Id_Submodulo
            // 
            this.tb_Id_Submodulo.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Id_Submodulo.Location = new System.Drawing.Point(120, 12);
            this.tb_Id_Submodulo.Name = "tb_Id_Submodulo";
            this.tb_Id_Submodulo.Size = new System.Drawing.Size(100, 27);
            this.tb_Id_Submodulo.TabIndex = 88;
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
            this.b_Actualizar.TabIndex = 101;
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
            this.b_Guardar.TabIndex = 100;
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
            this.b_Salir.TabIndex = 99;
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
            this.b_Restablecer.TabIndex = 98;
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
            this.b_Eliminar.TabIndex = 97;
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
            this.b_Consultar.TabIndex = 96;
            this.b_Consultar.Text = "Consultar";
            this.b_Consultar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.b_Consultar.UseVisualStyleBackColor = true;
            this.b_Consultar.Click += new System.EventHandler(this.b_Consultar_Click);
            // 
            // b_BN
            // 
            this.b_BN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.b_BN.AutoSize = true;
            this.b_BN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.b_BN.BackColor = System.Drawing.Color.Black;
            this.b_BN.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_BN.ForeColor = System.Drawing.Color.White;
            this.b_BN.Location = new System.Drawing.Point(732, 432);
            this.b_BN.Name = "b_BN";
            this.b_BN.Size = new System.Drawing.Size(40, 24);
            this.b_BN.TabIndex = 102;
            this.b_BN.Text = "B/N";
            this.b_BN.UseVisualStyleBackColor = false;
            this.b_BN.Click += new System.EventHandler(this.b_BN_Click);
            // 
            // FormSubmodulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.b_BN);
            this.Controls.Add(this.b_Actualizar);
            this.Controls.Add(this.b_Guardar);
            this.Controls.Add(this.b_Salir);
            this.Controls.Add(this.b_Restablecer);
            this.Controls.Add(this.b_Eliminar);
            this.Controls.Add(this.b_Consultar);
            this.Controls.Add(this.tb_Ubicacion);
            this.Controls.Add(this.l_Ubicacion);
            this.Controls.Add(this.l_Descripcion);
            this.Controls.Add(this.l_Nombre);
            this.Controls.Add(this.l_Id_Submodulo);
            this.Controls.Add(this.tb_Descripcion);
            this.Controls.Add(this.tb_Nombre);
            this.Controls.Add(this.tb_Id_Submodulo);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.l_PalabraClave);
            this.Controls.Add(this.tb_PalabraClave);
            this.Controls.Add(this.l_ZonaMensaje);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "FormSubmodulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Submodulo";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label l_PalabraClave;
        private System.Windows.Forms.TextBox tb_PalabraClave;
        private System.Windows.Forms.Label l_ZonaMensaje;
        private System.Windows.Forms.TextBox tb_Ubicacion;
        private System.Windows.Forms.Label l_Ubicacion;
        private System.Windows.Forms.Label l_Descripcion;
        private System.Windows.Forms.Label l_Nombre;
        private System.Windows.Forms.Label l_Id_Submodulo;
        private System.Windows.Forms.TextBox tb_Descripcion;
        private System.Windows.Forms.TextBox tb_Nombre;
        private System.Windows.Forms.TextBox tb_Id_Submodulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_submodulo1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ubicacion;
        private System.Windows.Forms.Button b_Actualizar;
        private System.Windows.Forms.Button b_Guardar;
        private System.Windows.Forms.Button b_Salir;
        private System.Windows.Forms.Button b_Restablecer;
        private System.Windows.Forms.Button b_Eliminar;
        private System.Windows.Forms.Button b_Consultar;
        private System.Windows.Forms.Button b_BN;
    }
}