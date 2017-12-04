namespace Gestion_de_Proyectos.Vista
{
    partial class ConsultarRangoMontosFuenteFinanciamiento
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tb_monto1 = new System.Windows.Forms.TextBox();
            this.tb_monto2 = new System.Windows.Forms.TextBox();
            this.b_BN = new System.Windows.Forms.Button();
            this.l_ZonaMensaje = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(212, 14);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(317, 27);
            this.comboBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fuente Financiamiento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Monto Minimo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Monto Maximo";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.AutoSize = true;
            this.button1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(533, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 29);
            this.button1.TabIndex = 4;
            this.button1.Text = "Consultar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.AutoSize = true;
            this.button2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(533, 47);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 29);
            this.button2.TabIndex = 5;
            this.button2.Text = "Restablecer";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 117);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(660, 452);
            this.dataGridView1.TabIndex = 6;
            // 
            // tb_monto1
            // 
            this.tb_monto1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_monto1.Location = new System.Drawing.Point(212, 49);
            this.tb_monto1.Name = "tb_monto1";
            this.tb_monto1.Size = new System.Drawing.Size(317, 27);
            this.tb_monto1.TabIndex = 9;
            // 
            // tb_monto2
            // 
            this.tb_monto2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_monto2.Location = new System.Drawing.Point(212, 84);
            this.tb_monto2.Name = "tb_monto2";
            this.tb_monto2.Size = new System.Drawing.Size(317, 27);
            this.tb_monto2.TabIndex = 10;
            // 
            // b_BN
            // 
            this.b_BN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.b_BN.AutoSize = true;
            this.b_BN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.b_BN.BackColor = System.Drawing.Color.Black;
            this.b_BN.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_BN.ForeColor = System.Drawing.Color.White;
            this.b_BN.Location = new System.Drawing.Point(632, 575);
            this.b_BN.Name = "b_BN";
            this.b_BN.Size = new System.Drawing.Size(40, 24);
            this.b_BN.TabIndex = 27;
            this.b_BN.Text = "B/N";
            this.b_BN.UseVisualStyleBackColor = false;
            this.b_BN.Click += new System.EventHandler(this.b_BN_Click);
            // 
            // l_ZonaMensaje
            // 
            this.l_ZonaMensaje.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.l_ZonaMensaje.AutoSize = true;
            this.l_ZonaMensaje.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_ZonaMensaje.Location = new System.Drawing.Point(12, 576);
            this.l_ZonaMensaje.Name = "l_ZonaMensaje";
            this.l_ZonaMensaje.Size = new System.Drawing.Size(147, 19);
            this.l_ZonaMensaje.TabIndex = 29;
            this.l_ZonaMensaje.Text = "Zona de Mensaje";
            // 
            // ConsultarRangoMontosFuenteFinanciamiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 611);
            this.Controls.Add(this.l_ZonaMensaje);
            this.Controls.Add(this.b_BN);
            this.Controls.Add(this.tb_monto2);
            this.Controls.Add(this.tb_monto1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.MinimumSize = new System.Drawing.Size(700, 650);
            this.Name = "ConsultarRangoMontosFuenteFinanciamiento";
            this.Text = "ConsultarRangoMontosFuenteFinanciamiento";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tb_monto1;
        private System.Windows.Forms.TextBox tb_monto2;
        private System.Windows.Forms.Button b_BN;
        private System.Windows.Forms.Label l_ZonaMensaje;
    }
}