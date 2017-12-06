namespace Gestion_de_Proyectos.Vista
{
    partial class ConsultarDeshabilitados
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
            this.b_BN = new System.Windows.Forms.Button();
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
            this.b_salir.TabIndex = 5;
            this.b_salir.Text = "Salir";
            this.b_salir.UseVisualStyleBackColor = true;
            this.b_salir.Click += new System.EventHandler(this.b_salir_Click);
            // 
            // b_Consultar
            // 
            this.b_Consultar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.b_Consultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_Consultar.Location = new System.Drawing.Point(13, 430);
            this.b_Consultar.Name = "b_Consultar";
            this.b_Consultar.Size = new System.Drawing.Size(75, 23);
            this.b_Consultar.TabIndex = 4;
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
            this.direccion});
            this.dataGridView1.Location = new System.Drawing.Point(13, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(603, 412);
            this.dataGridView1.TabIndex = 3;
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
            // b_BN
            // 
            this.b_BN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.b_BN.AutoSize = true;
            this.b_BN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.b_BN.BackColor = System.Drawing.Color.Black;
            this.b_BN.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_BN.ForeColor = System.Drawing.Color.White;
            this.b_BN.Location = new System.Drawing.Point(283, 429);
            this.b_BN.Name = "b_BN";
            this.b_BN.Size = new System.Drawing.Size(40, 24);
            this.b_BN.TabIndex = 17;
            this.b_BN.Text = "B/N";
            this.b_BN.UseVisualStyleBackColor = false;
            this.b_BN.Click += new System.EventHandler(this.b_BN_Click);
            // 
            // ConsultarDeshabilitados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 465);
            this.Controls.Add(this.b_BN);
            this.Controls.Add(this.b_salir);
            this.Controls.Add(this.b_Consultar);
            this.Controls.Add(this.dataGridView1);
            this.MinimumSize = new System.Drawing.Size(644, 504);
            this.Name = "ConsultarDeshabilitados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConsultarDeshabilitados";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b_salir;
        private System.Windows.Forms.Button b_Consultar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nroInterno;
        private System.Windows.Forms.DataGridViewTextBoxColumn run;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn appat;
        private System.Windows.Forms.DataGridViewTextBoxColumn apmat;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion;
        private System.Windows.Forms.Button b_BN;
    }
}