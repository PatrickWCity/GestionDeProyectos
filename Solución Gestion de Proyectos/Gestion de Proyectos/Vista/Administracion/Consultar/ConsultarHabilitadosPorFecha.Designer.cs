namespace Gestion_de_Proyectos.Vista
{
    partial class ConsultarHabilitadosPorFecha
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
            this.b_salir = new System.Windows.Forms.Button();
            this.b_Consultar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nroInterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.run = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apmat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tb_FechaInicio = new System.Windows.Forms.TextBox();
            this.tb_FechaFinal = new System.Windows.Forms.TextBox();
            this.l_FechaInicio = new System.Windows.Forms.Label();
            this.l_FechaFinal = new System.Windows.Forms.Label();
            this.l_ZonaMensaje = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // b_salir
            // 
            this.b_salir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.b_salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_salir.Location = new System.Drawing.Point(541, 430);
            this.b_salir.Name = "b_salir";
            this.b_salir.Size = new System.Drawing.Size(75, 23);
            this.b_salir.TabIndex = 8;
            this.b_salir.Text = "Salir";
            this.b_salir.UseVisualStyleBackColor = true;
            this.b_salir.Click += new System.EventHandler(this.b_salir_Click);
            // 
            // b_Consultar
            // 
            this.b_Consultar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.b_Consultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_Consultar.Location = new System.Drawing.Point(460, 430);
            this.b_Consultar.Name = "b_Consultar";
            this.b_Consultar.Size = new System.Drawing.Size(75, 23);
            this.b_Consultar.TabIndex = 7;
            this.b_Consultar.Text = "Consultar";
            this.b_Consultar.UseVisualStyleBackColor = true;
            this.b_Consultar.Click += new System.EventHandler(this.b_Consultar_Click);
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
            this.nroInterno,
            this.run,
            this.nombre,
            this.appat,
            this.apmat,
            this.direccion,
            this.fecha});
            this.dataGridView1.Location = new System.Drawing.Point(13, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(603, 412);
            this.dataGridView1.TabIndex = 6;
            // 
            // nroInterno
            // 
            this.nroInterno.DataPropertyName = "nroInterno";
            this.nroInterno.HeaderText = "Numero Interno";
            this.nroInterno.Name = "nroInterno";
            this.nroInterno.ReadOnly = true;
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
            // fecha
            // 
            this.fecha.DataPropertyName = "fecha";
            this.fecha.HeaderText = "Fecha Habilitada";
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
            // 
            // tb_FechaInicio
            // 
            this.tb_FechaInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_FechaInicio.Location = new System.Drawing.Point(96, 438);
            this.tb_FechaInicio.Name = "tb_FechaInicio";
            this.tb_FechaInicio.Size = new System.Drawing.Size(100, 20);
            this.tb_FechaInicio.TabIndex = 9;
            // 
            // tb_FechaFinal
            // 
            this.tb_FechaFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_FechaFinal.Location = new System.Drawing.Point(281, 440);
            this.tb_FechaFinal.Name = "tb_FechaFinal";
            this.tb_FechaFinal.Size = new System.Drawing.Size(100, 20);
            this.tb_FechaFinal.TabIndex = 10;
            // 
            // l_FechaInicio
            // 
            this.l_FechaInicio.AutoSize = true;
            this.l_FechaInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_FechaInicio.Location = new System.Drawing.Point(10, 443);
            this.l_FechaInicio.Name = "l_FechaInicio";
            this.l_FechaInicio.Size = new System.Drawing.Size(80, 13);
            this.l_FechaInicio.TabIndex = 11;
            this.l_FechaInicio.Text = "Fecha Inicial";
            // 
            // l_FechaFinal
            // 
            this.l_FechaFinal.AutoSize = true;
            this.l_FechaFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_FechaFinal.Location = new System.Drawing.Point(202, 443);
            this.l_FechaFinal.Name = "l_FechaFinal";
            this.l_FechaFinal.Size = new System.Drawing.Size(73, 13);
            this.l_FechaFinal.TabIndex = 12;
            this.l_FechaFinal.Text = "Fecha Final";
            // 
            // l_ZonaMensaje
            // 
            this.l_ZonaMensaje.AutoSize = true;
            this.l_ZonaMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_ZonaMensaje.Location = new System.Drawing.Point(434, 435);
            this.l_ZonaMensaje.Name = "l_ZonaMensaje";
            this.l_ZonaMensaje.Size = new System.Drawing.Size(0, 13);
            this.l_ZonaMensaje.TabIndex = 13;
            // 
            // ConsultarHabilitadosPorFecha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 465);
            this.Controls.Add(this.l_ZonaMensaje);
            this.Controls.Add(this.l_FechaFinal);
            this.Controls.Add(this.l_FechaInicio);
            this.Controls.Add(this.tb_FechaFinal);
            this.Controls.Add(this.tb_FechaInicio);
            this.Controls.Add(this.b_salir);
            this.Controls.Add(this.b_Consultar);
            this.Controls.Add(this.dataGridView1);
            this.MinimumSize = new System.Drawing.Size(644, 504);
            this.Name = "ConsultarHabilitadosPorFecha";
            this.Text = "ConsultarHabilitadosPorFecha";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b_salir;
        private System.Windows.Forms.Button b_Consultar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tb_FechaInicio;
        private System.Windows.Forms.TextBox tb_FechaFinal;
        private System.Windows.Forms.Label l_FechaInicio;
        private System.Windows.Forms.Label l_FechaFinal;
        private System.Windows.Forms.Label l_ZonaMensaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn nroInterno;
        private System.Windows.Forms.DataGridViewTextBoxColumn run;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn appat;
        private System.Windows.Forms.DataGridViewTextBoxColumn apmat;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
    }
}