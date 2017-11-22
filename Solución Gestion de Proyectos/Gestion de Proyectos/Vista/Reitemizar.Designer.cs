namespace Gestion_de_Proyectos.Vista
{
    partial class Reitemizar
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
            this.tb_Monto1 = new System.Windows.Forms.TextBox();
            this.l_Monto1 = new System.Windows.Forms.Label();
            this.tb_Nombre1 = new System.Windows.Forms.TextBox();
            this.l_Nombre1 = new System.Windows.Forms.Label();
            this.l_Id_Item = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id_item1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.b_Actualizar = new System.Windows.Forms.Button();
            this.b_Salir = new System.Windows.Forms.Button();
            this.l_ZonaMensaje = new System.Windows.Forms.Label();
            this.b_Restablecer = new System.Windows.Forms.Button();
            this.b_Consultar = new System.Windows.Forms.Button();
            this.tb_Monto2 = new System.Windows.Forms.TextBox();
            this.l_Monto2 = new System.Windows.Forms.Label();
            this.tb_Nombre2 = new System.Windows.Forms.TextBox();
            this.l_Nombre2 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.id_item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monto2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.l_Total = new System.Windows.Forms.Label();
            this.tb_Id_Item1 = new System.Windows.Forms.TextBox();
            this.l_Id1 = new System.Windows.Forms.Label();
            this.tb_Id_Item2 = new System.Windows.Forms.TextBox();
            this.l_Id2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_Descripcion1 = new System.Windows.Forms.TextBox();
            this.tb_Descripcion2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_Monto1
            // 
            this.tb_Monto1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Monto1.Location = new System.Drawing.Point(93, 77);
            this.tb_Monto1.Name = "tb_Monto1";
            this.tb_Monto1.Size = new System.Drawing.Size(100, 27);
            this.tb_Monto1.TabIndex = 113;
            this.tb_Monto1.TextChanged += new System.EventHandler(this.tb_Monto1_TextChanged);
            // 
            // l_Monto1
            // 
            this.l_Monto1.AutoSize = true;
            this.l_Monto1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_Monto1.Location = new System.Drawing.Point(12, 80);
            this.l_Monto1.Name = "l_Monto1";
            this.l_Monto1.Size = new System.Drawing.Size(60, 19);
            this.l_Monto1.TabIndex = 112;
            this.l_Monto1.Text = "Monto";
            // 
            // tb_Nombre1
            // 
            this.tb_Nombre1.Enabled = false;
            this.tb_Nombre1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Nombre1.Location = new System.Drawing.Point(93, 44);
            this.tb_Nombre1.Name = "tb_Nombre1";
            this.tb_Nombre1.Size = new System.Drawing.Size(186, 27);
            this.tb_Nombre1.TabIndex = 110;
            // 
            // l_Nombre1
            // 
            this.l_Nombre1.AutoSize = true;
            this.l_Nombre1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_Nombre1.Location = new System.Drawing.Point(12, 47);
            this.l_Nombre1.Name = "l_Nombre1";
            this.l_Nombre1.Size = new System.Drawing.Size(73, 19);
            this.l_Nombre1.TabIndex = 107;
            this.l_Nombre1.Text = "Nombre";
            // 
            // l_Id_Item
            // 
            this.l_Id_Item.AutoSize = true;
            this.l_Id_Item.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_Id_Item.Location = new System.Drawing.Point(185, 148);
            this.l_Id_Item.Name = "l_Id_Item";
            this.l_Id_Item.Size = new System.Drawing.Size(166, 19);
            this.l_Id_Item.TabIndex = 106;
            this.l_Id_Item.Text = "Monto sin Asignar :";
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
            this.id_item1,
            this.nombre,
            this.descripcion,
            this.monto});
            this.dataGridView1.Location = new System.Drawing.Point(12, 212);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(295, 218);
            this.dataGridView1.TabIndex = 105;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // id_item1
            // 
            this.id_item1.DataPropertyName = "id_item";
            this.id_item1.HeaderText = "ID de Item";
            this.id_item1.Name = "id_item1";
            this.id_item1.ReadOnly = true;
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
            // monto
            // 
            this.monto.DataPropertyName = "monto";
            this.monto.HeaderText = "Monto";
            this.monto.Name = "monto";
            this.monto.ReadOnly = true;
            // 
            // b_Actualizar
            // 
            this.b_Actualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.b_Actualizar.AutoSize = true;
            this.b_Actualizar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_Actualizar.Location = new System.Drawing.Point(556, 9);
            this.b_Actualizar.Name = "b_Actualizar";
            this.b_Actualizar.Size = new System.Drawing.Size(116, 29);
            this.b_Actualizar.TabIndex = 104;
            this.b_Actualizar.Text = "Acualizar";
            this.b_Actualizar.UseVisualStyleBackColor = true;
            this.b_Actualizar.Click += new System.EventHandler(this.b_Actualizar_Click);
            // 
            // b_Salir
            // 
            this.b_Salir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.b_Salir.AutoSize = true;
            this.b_Salir.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_Salir.Location = new System.Drawing.Point(556, 77);
            this.b_Salir.Name = "b_Salir";
            this.b_Salir.Size = new System.Drawing.Size(116, 29);
            this.b_Salir.TabIndex = 100;
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
            this.l_ZonaMensaje.TabIndex = 99;
            this.l_ZonaMensaje.Text = "Zona de Mensaje";
            // 
            // b_Restablecer
            // 
            this.b_Restablecer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.b_Restablecer.AutoSize = true;
            this.b_Restablecer.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_Restablecer.Location = new System.Drawing.Point(556, 44);
            this.b_Restablecer.Name = "b_Restablecer";
            this.b_Restablecer.Size = new System.Drawing.Size(116, 29);
            this.b_Restablecer.TabIndex = 98;
            this.b_Restablecer.Text = "Restablecer";
            this.b_Restablecer.UseVisualStyleBackColor = true;
            this.b_Restablecer.Click += new System.EventHandler(this.b_Restablecer_Click);
            // 
            // b_Consultar
            // 
            this.b_Consultar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.b_Consultar.AutoSize = true;
            this.b_Consultar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_Consultar.Location = new System.Drawing.Point(556, 112);
            this.b_Consultar.Name = "b_Consultar";
            this.b_Consultar.Size = new System.Drawing.Size(116, 29);
            this.b_Consultar.TabIndex = 96;
            this.b_Consultar.Text = "Consultar";
            this.b_Consultar.UseVisualStyleBackColor = true;
            this.b_Consultar.Click += new System.EventHandler(this.b_Consultar_Click);
            // 
            // tb_Monto2
            // 
            this.tb_Monto2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Monto2.Location = new System.Drawing.Point(364, 77);
            this.tb_Monto2.Name = "tb_Monto2";
            this.tb_Monto2.Size = new System.Drawing.Size(100, 27);
            this.tb_Monto2.TabIndex = 117;
            this.tb_Monto2.TextChanged += new System.EventHandler(this.tb_Monto2_TextChanged);
            // 
            // l_Monto2
            // 
            this.l_Monto2.AutoSize = true;
            this.l_Monto2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_Monto2.Location = new System.Drawing.Point(285, 80);
            this.l_Monto2.Name = "l_Monto2";
            this.l_Monto2.Size = new System.Drawing.Size(60, 19);
            this.l_Monto2.TabIndex = 116;
            this.l_Monto2.Text = "Monto";
            // 
            // tb_Nombre2
            // 
            this.tb_Nombre2.Enabled = false;
            this.tb_Nombre2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Nombre2.Location = new System.Drawing.Point(364, 44);
            this.tb_Nombre2.Name = "tb_Nombre2";
            this.tb_Nombre2.Size = new System.Drawing.Size(186, 27);
            this.tb_Nombre2.TabIndex = 115;
            // 
            // l_Nombre2
            // 
            this.l_Nombre2.AutoSize = true;
            this.l_Nombre2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_Nombre2.Location = new System.Drawing.Point(285, 47);
            this.l_Nombre2.Name = "l_Nombre2";
            this.l_Nombre2.Size = new System.Drawing.Size(73, 19);
            this.l_Nombre2.TabIndex = 114;
            this.l_Nombre2.Text = "Nombre";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_item,
            this.nombre2,
            this.descripcion2,
            this.monto2});
            this.dataGridView2.Location = new System.Drawing.Point(373, 212);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.Size = new System.Drawing.Size(295, 218);
            this.dataGridView2.TabIndex = 118;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // id_item
            // 
            this.id_item.DataPropertyName = "id_item";
            this.id_item.HeaderText = "ID de Item";
            this.id_item.Name = "id_item";
            this.id_item.ReadOnly = true;
            // 
            // nombre2
            // 
            this.nombre2.DataPropertyName = "nombre";
            this.nombre2.HeaderText = "Nombre";
            this.nombre2.Name = "nombre2";
            this.nombre2.ReadOnly = true;
            // 
            // descripcion2
            // 
            this.descripcion2.DataPropertyName = "descripcion";
            this.descripcion2.HeaderText = "Descripcion";
            this.descripcion2.Name = "descripcion2";
            this.descripcion2.ReadOnly = true;
            // 
            // monto2
            // 
            this.monto2.DataPropertyName = "monto";
            this.monto2.HeaderText = "Monto";
            this.monto2.Name = "monto2";
            this.monto2.ReadOnly = true;
            // 
            // l_Total
            // 
            this.l_Total.AutoSize = true;
            this.l_Total.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_Total.Location = new System.Drawing.Point(351, 148);
            this.l_Total.Name = "l_Total";
            this.l_Total.Size = new System.Drawing.Size(19, 19);
            this.l_Total.TabIndex = 119;
            this.l_Total.Text = "0";
            // 
            // tb_Id_Item1
            // 
            this.tb_Id_Item1.Enabled = false;
            this.tb_Id_Item1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Id_Item1.Location = new System.Drawing.Point(93, 11);
            this.tb_Id_Item1.Name = "tb_Id_Item1";
            this.tb_Id_Item1.Size = new System.Drawing.Size(100, 27);
            this.tb_Id_Item1.TabIndex = 121;
            // 
            // l_Id1
            // 
            this.l_Id1.AutoSize = true;
            this.l_Id1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_Id1.Location = new System.Drawing.Point(12, 14);
            this.l_Id1.Name = "l_Id1";
            this.l_Id1.Size = new System.Drawing.Size(28, 19);
            this.l_Id1.TabIndex = 120;
            this.l_Id1.Text = "ID";
            // 
            // tb_Id_Item2
            // 
            this.tb_Id_Item2.Enabled = false;
            this.tb_Id_Item2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Id_Item2.Location = new System.Drawing.Point(364, 11);
            this.tb_Id_Item2.Name = "tb_Id_Item2";
            this.tb_Id_Item2.Size = new System.Drawing.Size(100, 27);
            this.tb_Id_Item2.TabIndex = 123;
            // 
            // l_Id2
            // 
            this.l_Id2.AutoSize = true;
            this.l_Id2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_Id2.Location = new System.Drawing.Point(285, 14);
            this.l_Id2.Name = "l_Id2";
            this.l_Id2.Size = new System.Drawing.Size(28, 19);
            this.l_Id2.TabIndex = 122;
            this.l_Id2.Text = "ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(119, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 19);
            this.label5.TabIndex = 124;
            this.label5.Text = "Items";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(494, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 19);
            this.label6.TabIndex = 125;
            this.label6.Text = "Items";
            // 
            // tb_Descripcion1
            // 
            this.tb_Descripcion1.Location = new System.Drawing.Point(93, 110);
            this.tb_Descripcion1.Name = "tb_Descripcion1";
            this.tb_Descripcion1.Size = new System.Drawing.Size(100, 20);
            this.tb_Descripcion1.TabIndex = 126;
            this.tb_Descripcion1.Visible = false;
            // 
            // tb_Descripcion2
            // 
            this.tb_Descripcion2.Location = new System.Drawing.Point(364, 112);
            this.tb_Descripcion2.Name = "tb_Descripcion2";
            this.tb_Descripcion2.Size = new System.Drawing.Size(100, 20);
            this.tb_Descripcion2.TabIndex = 127;
            this.tb_Descripcion2.Visible = false;
            // 
            // Reitemizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.tb_Descripcion2);
            this.Controls.Add(this.tb_Descripcion1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_Id_Item2);
            this.Controls.Add(this.l_Id2);
            this.Controls.Add(this.tb_Id_Item1);
            this.Controls.Add(this.l_Id1);
            this.Controls.Add(this.l_Total);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.tb_Monto2);
            this.Controls.Add(this.l_Monto2);
            this.Controls.Add(this.tb_Nombre2);
            this.Controls.Add(this.l_Nombre2);
            this.Controls.Add(this.tb_Monto1);
            this.Controls.Add(this.l_Monto1);
            this.Controls.Add(this.tb_Nombre1);
            this.Controls.Add(this.l_Nombre1);
            this.Controls.Add(this.l_Id_Item);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.b_Actualizar);
            this.Controls.Add(this.b_Salir);
            this.Controls.Add(this.l_ZonaMensaje);
            this.Controls.Add(this.b_Restablecer);
            this.Controls.Add(this.b_Consultar);
            this.MinimumSize = new System.Drawing.Size(700, 500);
            this.Name = "Reitemizar";
            this.Text = "Reitemizar";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Monto1;
        private System.Windows.Forms.Label l_Monto1;
        private System.Windows.Forms.TextBox tb_Nombre1;
        private System.Windows.Forms.Label l_Nombre1;
        private System.Windows.Forms.Label l_Id_Item;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_item1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn monto;
        private System.Windows.Forms.Button b_Actualizar;
        private System.Windows.Forms.Button b_Salir;
        private System.Windows.Forms.Label l_ZonaMensaje;
        private System.Windows.Forms.Button b_Restablecer;
        private System.Windows.Forms.Button b_Consultar;
        private System.Windows.Forms.TextBox tb_Monto2;
        private System.Windows.Forms.Label l_Monto2;
        private System.Windows.Forms.TextBox tb_Nombre2;
        private System.Windows.Forms.Label l_Nombre2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label l_Total;
        private System.Windows.Forms.TextBox tb_Id_Item1;
        private System.Windows.Forms.Label l_Id1;
        private System.Windows.Forms.TextBox tb_Id_Item2;
        private System.Windows.Forms.Label l_Id2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_Descripcion1;
        private System.Windows.Forms.TextBox tb_Descripcion2;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_item;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre2;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion2;
        private System.Windows.Forms.DataGridViewTextBoxColumn monto2;
    }
}