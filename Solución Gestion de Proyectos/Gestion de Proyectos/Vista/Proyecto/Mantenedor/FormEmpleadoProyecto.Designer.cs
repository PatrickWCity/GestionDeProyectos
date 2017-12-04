namespace Gestion_de_Proyectos.Vista
{
    partial class FormEmpleadoProyecto
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
            this.cb_Empleado = new System.Windows.Forms.ComboBox();
            this.cb_Proyecto = new System.Windows.Forms.ComboBox();
            this.tb_Id_Proyecto = new System.Windows.Forms.TextBox();
            this.l_Proyecto = new System.Windows.Forms.Label();
            this.l_Empleado = new System.Windows.Forms.Label();
            this.l_Id_Cliente = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.b_Actualizar = new System.Windows.Forms.Button();
            this.b_Guardar = new System.Windows.Forms.Button();
            this.b_Salir = new System.Windows.Forms.Button();
            this.l_ZonaMensaje = new System.Windows.Forms.Label();
            this.b_Restablecer = new System.Windows.Forms.Button();
            this.b_Eliminar = new System.Windows.Forms.Button();
            this.b_Consultar = new System.Windows.Forms.Button();
            this.cb_Cargo = new System.Windows.Forms.ComboBox();
            this.L_Cargo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_Empleado
            // 
            this.cb_Empleado.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Empleado.FormattingEnabled = true;
            this.cb_Empleado.Location = new System.Drawing.Point(125, 44);
            this.cb_Empleado.Name = "cb_Empleado";
            this.cb_Empleado.Size = new System.Drawing.Size(422, 27);
            this.cb_Empleado.TabIndex = 130;
            // 
            // cb_Proyecto
            // 
            this.cb_Proyecto.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Proyecto.FormattingEnabled = true;
            this.cb_Proyecto.Location = new System.Drawing.Point(125, 77);
            this.cb_Proyecto.Name = "cb_Proyecto";
            this.cb_Proyecto.Size = new System.Drawing.Size(422, 27);
            this.cb_Proyecto.TabIndex = 129;
            // 
            // tb_Id_Proyecto
            // 
            this.tb_Id_Proyecto.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Id_Proyecto.Location = new System.Drawing.Point(125, 11);
            this.tb_Id_Proyecto.Name = "tb_Id_Proyecto";
            this.tb_Id_Proyecto.Size = new System.Drawing.Size(100, 27);
            this.tb_Id_Proyecto.TabIndex = 128;
            // 
            // l_Proyecto
            // 
            this.l_Proyecto.AutoSize = true;
            this.l_Proyecto.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_Proyecto.Location = new System.Drawing.Point(10, 80);
            this.l_Proyecto.Name = "l_Proyecto";
            this.l_Proyecto.Size = new System.Drawing.Size(81, 19);
            this.l_Proyecto.TabIndex = 127;
            this.l_Proyecto.Text = "Proyecto";
            // 
            // l_Empleado
            // 
            this.l_Empleado.AutoSize = true;
            this.l_Empleado.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_Empleado.Location = new System.Drawing.Point(9, 47);
            this.l_Empleado.Name = "l_Empleado";
            this.l_Empleado.Size = new System.Drawing.Size(89, 19);
            this.l_Empleado.TabIndex = 126;
            this.l_Empleado.Text = "Empleado";
            // 
            // l_Id_Cliente
            // 
            this.l_Id_Cliente.AutoSize = true;
            this.l_Id_Cliente.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_Id_Cliente.Location = new System.Drawing.Point(10, 14);
            this.l_Id_Cliente.Name = "l_Id_Cliente";
            this.l_Id_Cliente.Size = new System.Drawing.Size(28, 19);
            this.l_Id_Cliente.TabIndex = 125;
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
            this.dataGridView1.Location = new System.Drawing.Point(14, 211);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(660, 218);
            this.dataGridView1.TabIndex = 124;
            // 
            // b_Actualizar
            // 
            this.b_Actualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.b_Actualizar.AutoSize = true;
            this.b_Actualizar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_Actualizar.Location = new System.Drawing.Point(558, 42);
            this.b_Actualizar.Name = "b_Actualizar";
            this.b_Actualizar.Size = new System.Drawing.Size(116, 29);
            this.b_Actualizar.TabIndex = 123;
            this.b_Actualizar.Text = "Acualizar";
            this.b_Actualizar.UseVisualStyleBackColor = true;
            this.b_Actualizar.Click += new System.EventHandler(this.b_Actualizar_Click);
            // 
            // b_Guardar
            // 
            this.b_Guardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.b_Guardar.AutoSize = true;
            this.b_Guardar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_Guardar.Location = new System.Drawing.Point(558, 9);
            this.b_Guardar.Name = "b_Guardar";
            this.b_Guardar.Size = new System.Drawing.Size(116, 29);
            this.b_Guardar.TabIndex = 122;
            this.b_Guardar.Text = "Guardar";
            this.b_Guardar.UseVisualStyleBackColor = true;
            this.b_Guardar.Click += new System.EventHandler(this.b_Guardar_Click);
            // 
            // b_Salir
            // 
            this.b_Salir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.b_Salir.AutoSize = true;
            this.b_Salir.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_Salir.Location = new System.Drawing.Point(558, 141);
            this.b_Salir.Name = "b_Salir";
            this.b_Salir.Size = new System.Drawing.Size(116, 29);
            this.b_Salir.TabIndex = 121;
            this.b_Salir.Text = "Salir";
            this.b_Salir.UseVisualStyleBackColor = true;
            // 
            // l_ZonaMensaje
            // 
            this.l_ZonaMensaje.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.l_ZonaMensaje.AutoSize = true;
            this.l_ZonaMensaje.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_ZonaMensaje.ForeColor = System.Drawing.Color.Red;
            this.l_ZonaMensaje.Location = new System.Drawing.Point(14, 432);
            this.l_ZonaMensaje.Name = "l_ZonaMensaje";
            this.l_ZonaMensaje.Size = new System.Drawing.Size(147, 19);
            this.l_ZonaMensaje.TabIndex = 120;
            this.l_ZonaMensaje.Text = "Zona de Mensaje";
            // 
            // b_Restablecer
            // 
            this.b_Restablecer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.b_Restablecer.AutoSize = true;
            this.b_Restablecer.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_Restablecer.Location = new System.Drawing.Point(558, 108);
            this.b_Restablecer.Name = "b_Restablecer";
            this.b_Restablecer.Size = new System.Drawing.Size(116, 29);
            this.b_Restablecer.TabIndex = 119;
            this.b_Restablecer.Text = "Restablecer";
            this.b_Restablecer.UseVisualStyleBackColor = true;
            // 
            // b_Eliminar
            // 
            this.b_Eliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.b_Eliminar.AutoSize = true;
            this.b_Eliminar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_Eliminar.Location = new System.Drawing.Point(558, 75);
            this.b_Eliminar.Name = "b_Eliminar";
            this.b_Eliminar.Size = new System.Drawing.Size(116, 29);
            this.b_Eliminar.TabIndex = 118;
            this.b_Eliminar.Text = "Eliminar";
            this.b_Eliminar.UseVisualStyleBackColor = true;
            // 
            // b_Consultar
            // 
            this.b_Consultar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.b_Consultar.AutoSize = true;
            this.b_Consultar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_Consultar.Location = new System.Drawing.Point(558, 176);
            this.b_Consultar.Name = "b_Consultar";
            this.b_Consultar.Size = new System.Drawing.Size(116, 29);
            this.b_Consultar.TabIndex = 117;
            this.b_Consultar.Text = "Consultar";
            this.b_Consultar.UseVisualStyleBackColor = true;
            // 
            // cb_Cargo
            // 
            this.cb_Cargo.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Cargo.FormattingEnabled = true;
            this.cb_Cargo.Location = new System.Drawing.Point(124, 110);
            this.cb_Cargo.Name = "cb_Cargo";
            this.cb_Cargo.Size = new System.Drawing.Size(422, 27);
            this.cb_Cargo.TabIndex = 134;
            // 
            // L_Cargo
            // 
            this.L_Cargo.AutoSize = true;
            this.L_Cargo.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Cargo.Location = new System.Drawing.Point(8, 113);
            this.L_Cargo.Name = "L_Cargo";
            this.L_Cargo.Size = new System.Drawing.Size(57, 19);
            this.L_Cargo.TabIndex = 131;
            this.L_Cargo.Text = "Cargo";
            // 
            // FormEmpleadoProyecto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.cb_Cargo);
            this.Controls.Add(this.L_Cargo);
            this.Controls.Add(this.cb_Empleado);
            this.Controls.Add(this.cb_Proyecto);
            this.Controls.Add(this.tb_Id_Proyecto);
            this.Controls.Add(this.l_Proyecto);
            this.Controls.Add(this.l_Empleado);
            this.Controls.Add(this.l_Id_Cliente);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.b_Actualizar);
            this.Controls.Add(this.b_Guardar);
            this.Controls.Add(this.b_Salir);
            this.Controls.Add(this.l_ZonaMensaje);
            this.Controls.Add(this.b_Restablecer);
            this.Controls.Add(this.b_Eliminar);
            this.Controls.Add(this.b_Consultar);
            this.MinimumSize = new System.Drawing.Size(700, 500);
            this.Name = "FormEmpleadoProyecto";
            this.Text = "FormEmpleadoProyecto";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_Empleado;
        private System.Windows.Forms.ComboBox cb_Proyecto;
        private System.Windows.Forms.TextBox tb_Id_Proyecto;
        private System.Windows.Forms.Label l_Proyecto;
        private System.Windows.Forms.Label l_Empleado;
        private System.Windows.Forms.Label l_Id_Cliente;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button b_Actualizar;
        private System.Windows.Forms.Button b_Guardar;
        private System.Windows.Forms.Button b_Salir;
        private System.Windows.Forms.Label l_ZonaMensaje;
        private System.Windows.Forms.Button b_Restablecer;
        private System.Windows.Forms.Button b_Eliminar;
        private System.Windows.Forms.Button b_Consultar;
        private System.Windows.Forms.ComboBox cb_Cargo;
        private System.Windows.Forms.Label L_Cargo;
    }
}