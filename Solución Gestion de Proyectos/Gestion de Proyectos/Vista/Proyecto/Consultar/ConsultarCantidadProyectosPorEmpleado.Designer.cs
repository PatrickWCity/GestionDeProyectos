namespace Gestion_de_Proyectos.Vista
{
    partial class ConsultarCantidadProyectosPorEmpleado
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
            this.l_Empleado = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.l_ZonaMensaje = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_Empleado
            // 
            this.cb_Empleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Empleado.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Empleado.FormattingEnabled = true;
            this.cb_Empleado.Location = new System.Drawing.Point(128, 12);
            this.cb_Empleado.Name = "cb_Empleado";
            this.cb_Empleado.Size = new System.Drawing.Size(494, 27);
            this.cb_Empleado.TabIndex = 132;
            this.cb_Empleado.SelectedIndexChanged += new System.EventHandler(this.cb_Empleado_SelectedIndexChanged);
            // 
            // l_Empleado
            // 
            this.l_Empleado.AutoSize = true;
            this.l_Empleado.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_Empleado.Location = new System.Drawing.Point(12, 15);
            this.l_Empleado.Name = "l_Empleado";
            this.l_Empleado.Size = new System.Drawing.Size(89, 19);
            this.l_Empleado.TabIndex = 131;
            this.l_Empleado.Text = "Empleado";
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(610, 435);
            this.dataGridView1.TabIndex = 134;
            // 
            // l_ZonaMensaje
            // 
            this.l_ZonaMensaje.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.l_ZonaMensaje.AutoSize = true;
            this.l_ZonaMensaje.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_ZonaMensaje.ForeColor = System.Drawing.Color.Red;
            this.l_ZonaMensaje.Location = new System.Drawing.Point(12, 483);
            this.l_ZonaMensaje.Name = "l_ZonaMensaje";
            this.l_ZonaMensaje.Size = new System.Drawing.Size(147, 19);
            this.l_ZonaMensaje.TabIndex = 133;
            this.l_ZonaMensaje.Text = "Zona de Mensaje";
            // 
            // ConsultarCantidadProyectosPorEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 511);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.l_ZonaMensaje);
            this.Controls.Add(this.cb_Empleado);
            this.Controls.Add(this.l_Empleado);
            this.MinimumSize = new System.Drawing.Size(650, 550);
            this.Name = "ConsultarCantidadProyectosPorEmpleado";
            this.Text = "ConsultarCantidadProyectosPorEmpleado";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_Empleado;
        private System.Windows.Forms.Label l_Empleado;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label l_ZonaMensaje;
    }
}