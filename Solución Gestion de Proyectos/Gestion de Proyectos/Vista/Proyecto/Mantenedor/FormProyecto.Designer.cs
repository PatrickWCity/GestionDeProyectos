namespace Gestion_de_Proyectos.Vista
{
    partial class FormProyecto
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
            this.tb_Id_Proyecto = new System.Windows.Forms.TextBox();
            this.l_Cliente = new System.Windows.Forms.Label();
            this.l_Id_Cliente = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.l_ZonaMensaje = new System.Windows.Forms.Label();
            this.cb_Cliente = new System.Windows.Forms.ComboBox();
            this.tb_Nombre = new System.Windows.Forms.TextBox();
            this.l_Nombre = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.b_Actualizar = new System.Windows.Forms.Button();
            this.b_Guardar = new System.Windows.Forms.Button();
            this.b_Salir = new System.Windows.Forms.Button();
            this.b_Restablecer = new System.Windows.Forms.Button();
            this.b_Eliminar = new System.Windows.Forms.Button();
            this.b_Consultar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_Id_Proyecto
            // 
            this.tb_Id_Proyecto.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Id_Proyecto.Location = new System.Drawing.Point(148, 14);
            this.tb_Id_Proyecto.Name = "tb_Id_Proyecto";
            this.tb_Id_Proyecto.Size = new System.Drawing.Size(100, 27);
            this.tb_Id_Proyecto.TabIndex = 110;
            // 
            // l_Cliente
            // 
            this.l_Cliente.AutoSize = true;
            this.l_Cliente.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_Cliente.Location = new System.Drawing.Point(9, 83);
            this.l_Cliente.Name = "l_Cliente";
            this.l_Cliente.Size = new System.Drawing.Size(67, 19);
            this.l_Cliente.TabIndex = 108;
            this.l_Cliente.Text = "Cliente";
            // 
            // l_Id_Cliente
            // 
            this.l_Id_Cliente.AutoSize = true;
            this.l_Id_Cliente.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_Id_Cliente.Location = new System.Drawing.Point(8, 17);
            this.l_Id_Cliente.Name = "l_Id_Cliente";
            this.l_Id_Cliente.Size = new System.Drawing.Size(28, 19);
            this.l_Id_Cliente.TabIndex = 106;
            this.l_Id_Cliente.Text = "ID";
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 214);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(660, 218);
            this.dataGridView1.TabIndex = 105;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // l_ZonaMensaje
            // 
            this.l_ZonaMensaje.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.l_ZonaMensaje.AutoSize = true;
            this.l_ZonaMensaje.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_ZonaMensaje.ForeColor = System.Drawing.Color.Red;
            this.l_ZonaMensaje.Location = new System.Drawing.Point(12, 435);
            this.l_ZonaMensaje.Name = "l_ZonaMensaje";
            this.l_ZonaMensaje.Size = new System.Drawing.Size(147, 19);
            this.l_ZonaMensaje.TabIndex = 99;
            this.l_ZonaMensaje.Text = "Zona de Mensaje";
            // 
            // cb_Cliente
            // 
            this.cb_Cliente.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Cliente.FormattingEnabled = true;
            this.cb_Cliente.Location = new System.Drawing.Point(148, 80);
            this.cb_Cliente.Name = "cb_Cliente";
            this.cb_Cliente.Size = new System.Drawing.Size(377, 27);
            this.cb_Cliente.TabIndex = 113;
            // 
            // tb_Nombre
            // 
            this.tb_Nombre.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Nombre.Location = new System.Drawing.Point(148, 47);
            this.tb_Nombre.Name = "tb_Nombre";
            this.tb_Nombre.Size = new System.Drawing.Size(377, 27);
            this.tb_Nombre.TabIndex = 116;
            // 
            // l_Nombre
            // 
            this.l_Nombre.AutoSize = true;
            this.l_Nombre.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_Nombre.Location = new System.Drawing.Point(8, 50);
            this.l_Nombre.Name = "l_Nombre";
            this.l_Nombre.Size = new System.Drawing.Size(73, 19);
            this.l_Nombre.TabIndex = 115;
            this.l_Nombre.Text = "Nombre";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(148, 115);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 117;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CalendarFont = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Location = new System.Drawing.Point(148, 148);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 118;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 19);
            this.label1.TabIndex = 120;
            this.label1.Text = "Fecha Inicio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 19);
            this.label2.TabIndex = 119;
            this.label2.Text = "Fecha Termino";
            // 
            // b_Actualizar
            // 
            this.b_Actualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.b_Actualizar.AutoSize = true;
            this.b_Actualizar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_Actualizar.Image = global::Gestion_de_Proyectos.Properties.Resources.pencil;
            this.b_Actualizar.Location = new System.Drawing.Point(531, 45);
            this.b_Actualizar.Name = "b_Actualizar";
            this.b_Actualizar.Size = new System.Drawing.Size(141, 29);
            this.b_Actualizar.TabIndex = 154;
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
            this.b_Guardar.Location = new System.Drawing.Point(531, 12);
            this.b_Guardar.Name = "b_Guardar";
            this.b_Guardar.Size = new System.Drawing.Size(141, 29);
            this.b_Guardar.TabIndex = 153;
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
            this.b_Salir.Location = new System.Drawing.Point(531, 144);
            this.b_Salir.Name = "b_Salir";
            this.b_Salir.Size = new System.Drawing.Size(141, 29);
            this.b_Salir.TabIndex = 152;
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
            this.b_Restablecer.Location = new System.Drawing.Point(531, 111);
            this.b_Restablecer.Name = "b_Restablecer";
            this.b_Restablecer.Size = new System.Drawing.Size(141, 29);
            this.b_Restablecer.TabIndex = 151;
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
            this.b_Eliminar.Location = new System.Drawing.Point(531, 78);
            this.b_Eliminar.Name = "b_Eliminar";
            this.b_Eliminar.Size = new System.Drawing.Size(141, 29);
            this.b_Eliminar.TabIndex = 150;
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
            this.b_Consultar.Location = new System.Drawing.Point(531, 179);
            this.b_Consultar.Name = "b_Consultar";
            this.b_Consultar.Size = new System.Drawing.Size(141, 29);
            this.b_Consultar.TabIndex = 149;
            this.b_Consultar.Text = "Consultar";
            this.b_Consultar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.b_Consultar.UseVisualStyleBackColor = true;
            this.b_Consultar.Click += new System.EventHandler(this.b_Consultar_Click);
            // 
            // FormProyecto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.b_Actualizar);
            this.Controls.Add(this.b_Guardar);
            this.Controls.Add(this.b_Salir);
            this.Controls.Add(this.b_Restablecer);
            this.Controls.Add(this.b_Eliminar);
            this.Controls.Add(this.b_Consultar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.tb_Nombre);
            this.Controls.Add(this.l_Nombre);
            this.Controls.Add(this.cb_Cliente);
            this.Controls.Add(this.tb_Id_Proyecto);
            this.Controls.Add(this.l_Cliente);
            this.Controls.Add(this.l_Id_Cliente);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.l_ZonaMensaje);
            this.MinimumSize = new System.Drawing.Size(700, 500);
            this.Name = "FormProyecto";
            this.Text = "Proyecto";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tb_Id_Proyecto;
        private System.Windows.Forms.Label l_Cliente;
        private System.Windows.Forms.Label l_Id_Cliente;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label l_ZonaMensaje;
        private System.Windows.Forms.ComboBox cb_Cliente;
        private System.Windows.Forms.TextBox tb_Nombre;
        private System.Windows.Forms.Label l_Nombre;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button b_Actualizar;
        private System.Windows.Forms.Button b_Guardar;
        private System.Windows.Forms.Button b_Salir;
        private System.Windows.Forms.Button b_Restablecer;
        private System.Windows.Forms.Button b_Eliminar;
        private System.Windows.Forms.Button b_Consultar;
    }
}