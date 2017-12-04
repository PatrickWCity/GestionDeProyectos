namespace Gestion_de_Proyectos.Vista
{
    partial class ConsultaProyectoGEPresupuesto
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
            this.cb_Presupuesto = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.l_Usuarios = new System.Windows.Forms.Label();
            this.l_Presupuesto = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // l_ZonaMensaje
            // 
            this.l_ZonaMensaje.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.l_ZonaMensaje.AutoSize = true;
            this.l_ZonaMensaje.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_ZonaMensaje.Location = new System.Drawing.Point(12, 480);
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
            this.b_BN.Location = new System.Drawing.Point(444, 479);
            this.b_BN.Name = "b_BN";
            this.b_BN.Size = new System.Drawing.Size(40, 24);
            this.b_BN.TabIndex = 36;
            this.b_BN.Text = "B/N";
            this.b_BN.UseVisualStyleBackColor = false;
            this.b_BN.Click += new System.EventHandler(this.b_BN_Click);
            // 
            // cb_Presupuesto
            // 
            this.cb_Presupuesto.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Presupuesto.FormattingEnabled = true;
            this.cb_Presupuesto.Items.AddRange(new object[] {
            "Selecionar",
            "Bajo",
            "Sobre"});
            this.cb_Presupuesto.Location = new System.Drawing.Point(160, 12);
            this.cb_Presupuesto.Name = "cb_Presupuesto";
            this.cb_Presupuesto.Size = new System.Drawing.Size(122, 27);
            this.cb_Presupuesto.TabIndex = 35;
            this.cb_Presupuesto.Text = "Selecionar";
            this.cb_Presupuesto.SelectedIndexChanged += new System.EventHandler(this.cb_Presupuesto_SelectedIndexChanged);
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 73);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(472, 400);
            this.dataGridView1.TabIndex = 31;
            // 
            // l_Usuarios
            // 
            this.l_Usuarios.AutoSize = true;
            this.l_Usuarios.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_Usuarios.ForeColor = System.Drawing.Color.Black;
            this.l_Usuarios.Location = new System.Drawing.Point(207, 51);
            this.l_Usuarios.Name = "l_Usuarios";
            this.l_Usuarios.Size = new System.Drawing.Size(89, 19);
            this.l_Usuarios.TabIndex = 30;
            this.l_Usuarios.Text = "Proyectos";
            // 
            // l_Presupuesto
            // 
            this.l_Presupuesto.AutoSize = true;
            this.l_Presupuesto.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_Presupuesto.Location = new System.Drawing.Point(12, 15);
            this.l_Presupuesto.Name = "l_Presupuesto";
            this.l_Presupuesto.Size = new System.Drawing.Size(142, 19);
            this.l_Presupuesto.TabIndex = 29;
            this.l_Presupuesto.Text = "Gasto Ejecutado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(288, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 19);
            this.label1.TabIndex = 39;
            this.label1.Text = "el 10% del Presupuesto";
            // 
            // ConsultaProyectoGEPresupuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 515);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.l_ZonaMensaje);
            this.Controls.Add(this.b_BN);
            this.Controls.Add(this.cb_Presupuesto);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.l_Usuarios);
            this.Controls.Add(this.l_Presupuesto);
            this.Name = "ConsultaProyectoGEPresupuesto";
            this.Text = "ConsultaProyectoGEPresupuesto";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l_ZonaMensaje;
        private System.Windows.Forms.Button b_BN;
        private System.Windows.Forms.ComboBox cb_Presupuesto;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label l_Usuarios;
        private System.Windows.Forms.Label l_Presupuesto;
        private System.Windows.Forms.Label label1;
    }
}