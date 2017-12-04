namespace Gestion_de_Proyectos.Vista
{
    partial class FormLocalidad
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
            this.id_localidad1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.region = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.providencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comuna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.b_Actualizar = new System.Windows.Forms.Button();
            this.b_Guardar = new System.Windows.Forms.Button();
            this.l_PalabraClave = new System.Windows.Forms.Label();
            this.tb_PalabraClave = new System.Windows.Forms.TextBox();
            this.b_Salir = new System.Windows.Forms.Button();
            this.l_ZonaMensaje = new System.Windows.Forms.Label();
            this.b_Restablecer = new System.Windows.Forms.Button();
            this.b_Eliminar = new System.Windows.Forms.Button();
            this.b_Consultar = new System.Windows.Forms.Button();
            this.tb_Region = new System.Windows.Forms.TextBox();
            this.l_Region = new System.Windows.Forms.Label();
            this.tb_Comuna = new System.Windows.Forms.TextBox();
            this.tb_Providencia = new System.Windows.Forms.TextBox();
            this.l_Comuna = new System.Windows.Forms.Label();
            this.l_Providencia = new System.Windows.Forms.Label();
            this.tb_Id_Localidad = new System.Windows.Forms.TextBox();
            this.l_Id_Localidad = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
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
            this.id_localidad1,
            this.region,
            this.providencia,
            this.comuna});
            this.dataGridView1.Location = new System.Drawing.Point(12, 250);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(760, 180);
            this.dataGridView1.TabIndex = 87;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // id_localidad1
            // 
            this.id_localidad1.DataPropertyName = "id_localidad";
            this.id_localidad1.HeaderText = "ID de Localidad";
            this.id_localidad1.Name = "id_localidad1";
            this.id_localidad1.ReadOnly = true;
            // 
            // region
            // 
            this.region.DataPropertyName = "region";
            this.region.HeaderText = "Region";
            this.region.Name = "region";
            this.region.ReadOnly = true;
            // 
            // providencia
            // 
            this.providencia.DataPropertyName = "providencia";
            this.providencia.HeaderText = "Providencia";
            this.providencia.Name = "providencia";
            this.providencia.ReadOnly = true;
            // 
            // comuna
            // 
            this.comuna.DataPropertyName = "comuna";
            this.comuna.HeaderText = "Comuna";
            this.comuna.Name = "comuna";
            this.comuna.ReadOnly = true;
            // 
            // b_Actualizar
            // 
            this.b_Actualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.b_Actualizar.AutoSize = true;
            this.b_Actualizar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_Actualizar.Location = new System.Drawing.Point(656, 71);
            this.b_Actualizar.Name = "b_Actualizar";
            this.b_Actualizar.Size = new System.Drawing.Size(116, 29);
            this.b_Actualizar.TabIndex = 86;
            this.b_Actualizar.Text = "Acualizar";
            this.b_Actualizar.UseVisualStyleBackColor = true;
            this.b_Actualizar.Click += new System.EventHandler(this.b_Actualizar_Click);
            // 
            // b_Guardar
            // 
            this.b_Guardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.b_Guardar.AutoSize = true;
            this.b_Guardar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_Guardar.Location = new System.Drawing.Point(656, 38);
            this.b_Guardar.Name = "b_Guardar";
            this.b_Guardar.Size = new System.Drawing.Size(116, 29);
            this.b_Guardar.TabIndex = 85;
            this.b_Guardar.Text = "Guardar";
            this.b_Guardar.UseVisualStyleBackColor = true;
            this.b_Guardar.Click += new System.EventHandler(this.b_Guardar_Click);
            // 
            // l_PalabraClave
            // 
            this.l_PalabraClave.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.l_PalabraClave.AutoSize = true;
            this.l_PalabraClave.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_PalabraClave.Location = new System.Drawing.Point(12, 210);
            this.l_PalabraClave.Name = "l_PalabraClave";
            this.l_PalabraClave.Size = new System.Drawing.Size(213, 19);
            this.l_PalabraClave.TabIndex = 84;
            this.l_PalabraClave.Text = "Buscar por Palabra Clave";
            // 
            // tb_PalabraClave
            // 
            this.tb_PalabraClave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_PalabraClave.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_PalabraClave.Location = new System.Drawing.Point(231, 207);
            this.tb_PalabraClave.Name = "tb_PalabraClave";
            this.tb_PalabraClave.Size = new System.Drawing.Size(100, 27);
            this.tb_PalabraClave.TabIndex = 83;
            // 
            // b_Salir
            // 
            this.b_Salir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.b_Salir.AutoSize = true;
            this.b_Salir.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_Salir.Location = new System.Drawing.Point(656, 170);
            this.b_Salir.Name = "b_Salir";
            this.b_Salir.Size = new System.Drawing.Size(116, 29);
            this.b_Salir.TabIndex = 82;
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
            this.l_ZonaMensaje.Location = new System.Drawing.Point(12, 433);
            this.l_ZonaMensaje.Name = "l_ZonaMensaje";
            this.l_ZonaMensaje.Size = new System.Drawing.Size(147, 19);
            this.l_ZonaMensaje.TabIndex = 81;
            this.l_ZonaMensaje.Text = "Zona de Mensaje";
            // 
            // b_Restablecer
            // 
            this.b_Restablecer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.b_Restablecer.AutoSize = true;
            this.b_Restablecer.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_Restablecer.Location = new System.Drawing.Point(656, 137);
            this.b_Restablecer.Name = "b_Restablecer";
            this.b_Restablecer.Size = new System.Drawing.Size(116, 29);
            this.b_Restablecer.TabIndex = 80;
            this.b_Restablecer.Text = "Restablecer";
            this.b_Restablecer.UseVisualStyleBackColor = true;
            this.b_Restablecer.Click += new System.EventHandler(this.b_Restablecer_Click);
            // 
            // b_Eliminar
            // 
            this.b_Eliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.b_Eliminar.AutoSize = true;
            this.b_Eliminar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_Eliminar.Location = new System.Drawing.Point(656, 104);
            this.b_Eliminar.Name = "b_Eliminar";
            this.b_Eliminar.Size = new System.Drawing.Size(116, 29);
            this.b_Eliminar.TabIndex = 79;
            this.b_Eliminar.Text = "Eliminar";
            this.b_Eliminar.UseVisualStyleBackColor = true;
            this.b_Eliminar.Click += new System.EventHandler(this.b_Eliminar_Click);
            // 
            // b_Consultar
            // 
            this.b_Consultar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.b_Consultar.AutoSize = true;
            this.b_Consultar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_Consultar.Location = new System.Drawing.Point(656, 205);
            this.b_Consultar.Name = "b_Consultar";
            this.b_Consultar.Size = new System.Drawing.Size(116, 29);
            this.b_Consultar.TabIndex = 78;
            this.b_Consultar.Text = "Consultar";
            this.b_Consultar.UseVisualStyleBackColor = true;
            this.b_Consultar.Click += new System.EventHandler(this.b_Consultar_Click);
            // 
            // tb_Region
            // 
            this.tb_Region.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Region.Location = new System.Drawing.Point(122, 40);
            this.tb_Region.Name = "tb_Region";
            this.tb_Region.Size = new System.Drawing.Size(528, 27);
            this.tb_Region.TabIndex = 95;
            // 
            // l_Region
            // 
            this.l_Region.AutoSize = true;
            this.l_Region.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_Region.Location = new System.Drawing.Point(12, 43);
            this.l_Region.Name = "l_Region";
            this.l_Region.Size = new System.Drawing.Size(66, 19);
            this.l_Region.TabIndex = 94;
            this.l_Region.Text = "Region";
            // 
            // tb_Comuna
            // 
            this.tb_Comuna.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Comuna.Location = new System.Drawing.Point(122, 106);
            this.tb_Comuna.Name = "tb_Comuna";
            this.tb_Comuna.Size = new System.Drawing.Size(528, 27);
            this.tb_Comuna.TabIndex = 92;
            // 
            // tb_Providencia
            // 
            this.tb_Providencia.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Providencia.Location = new System.Drawing.Point(122, 73);
            this.tb_Providencia.Name = "tb_Providencia";
            this.tb_Providencia.Size = new System.Drawing.Size(528, 27);
            this.tb_Providencia.TabIndex = 91;
            // 
            // l_Comuna
            // 
            this.l_Comuna.AutoSize = true;
            this.l_Comuna.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_Comuna.Location = new System.Drawing.Point(12, 109);
            this.l_Comuna.Name = "l_Comuna";
            this.l_Comuna.Size = new System.Drawing.Size(75, 19);
            this.l_Comuna.TabIndex = 89;
            this.l_Comuna.Text = "Comuna";
            // 
            // l_Providencia
            // 
            this.l_Providencia.AutoSize = true;
            this.l_Providencia.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_Providencia.Location = new System.Drawing.Point(12, 76);
            this.l_Providencia.Name = "l_Providencia";
            this.l_Providencia.Size = new System.Drawing.Size(104, 19);
            this.l_Providencia.TabIndex = 88;
            this.l_Providencia.Text = "Providencia";
            // 
            // tb_Id_Localidad
            // 
            this.tb_Id_Localidad.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Id_Localidad.Location = new System.Drawing.Point(122, 7);
            this.tb_Id_Localidad.Name = "tb_Id_Localidad";
            this.tb_Id_Localidad.Size = new System.Drawing.Size(100, 27);
            this.tb_Id_Localidad.TabIndex = 97;
            // 
            // l_Id_Localidad
            // 
            this.l_Id_Localidad.AutoSize = true;
            this.l_Id_Localidad.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_Id_Localidad.Location = new System.Drawing.Point(12, 10);
            this.l_Id_Localidad.Name = "l_Id_Localidad";
            this.l_Id_Localidad.Size = new System.Drawing.Size(28, 19);
            this.l_Id_Localidad.TabIndex = 96;
            this.l_Id_Localidad.Text = "ID";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(122, 40);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(528, 27);
            this.comboBox1.TabIndex = 98;
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(122, 73);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(528, 27);
            this.comboBox2.TabIndex = 99;
            // 
            // comboBox3
            // 
            this.comboBox3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(122, 106);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(528, 27);
            this.comboBox3.TabIndex = 100;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.AutoSize = true;
            this.button1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(656, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 29);
            this.button1.TabIndex = 101;
            this.button1.Text = "Nuevo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormLocalidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.tb_Id_Localidad);
            this.Controls.Add(this.l_Id_Localidad);
            this.Controls.Add(this.tb_Region);
            this.Controls.Add(this.l_Region);
            this.Controls.Add(this.tb_Comuna);
            this.Controls.Add(this.tb_Providencia);
            this.Controls.Add(this.l_Comuna);
            this.Controls.Add(this.l_Providencia);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.b_Actualizar);
            this.Controls.Add(this.b_Guardar);
            this.Controls.Add(this.l_PalabraClave);
            this.Controls.Add(this.tb_PalabraClave);
            this.Controls.Add(this.b_Salir);
            this.Controls.Add(this.l_ZonaMensaje);
            this.Controls.Add(this.b_Restablecer);
            this.Controls.Add(this.b_Eliminar);
            this.Controls.Add(this.b_Consultar);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "FormLocalidad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Localidad";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button b_Actualizar;
        private System.Windows.Forms.Button b_Guardar;
        private System.Windows.Forms.Label l_PalabraClave;
        private System.Windows.Forms.TextBox tb_PalabraClave;
        private System.Windows.Forms.Button b_Salir;
        private System.Windows.Forms.Label l_ZonaMensaje;
        private System.Windows.Forms.Button b_Restablecer;
        private System.Windows.Forms.Button b_Eliminar;
        private System.Windows.Forms.Button b_Consultar;
        private System.Windows.Forms.TextBox tb_Region;
        private System.Windows.Forms.Label l_Region;
        private System.Windows.Forms.TextBox tb_Comuna;
        private System.Windows.Forms.TextBox tb_Providencia;
        private System.Windows.Forms.Label l_Comuna;
        private System.Windows.Forms.Label l_Providencia;
        private System.Windows.Forms.TextBox tb_Id_Localidad;
        private System.Windows.Forms.Label l_Id_Localidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_localidad1;
        private System.Windows.Forms.DataGridViewTextBoxColumn region;
        private System.Windows.Forms.DataGridViewTextBoxColumn providencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn comuna;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Button button1;
    }
}