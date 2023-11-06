namespace ProyInventario_GUI
{
    partial class TiendaMant01
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            lblRegistros = new Label();
            label2 = new Label();
            btnCerrar = new Button();
            btnActualizar = new Button();
            btnInsertar = new Button();
            txtFiltro = new TextBox();
            label1 = new Label();
            dtgDatos = new DataGridView();
            Cod_tiend = new DataGridViewTextBoxColumn();
            Nom_tiend = new DataGridViewTextBoxColumn();
            Dir_tiend = new DataGridViewTextBoxColumn();
            Telf_tiend = new DataGridViewTextBoxColumn();
            departamento = new DataGridViewTextBoxColumn();
            provincia = new DataGridViewTextBoxColumn();
            distrito = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dtgDatos).BeginInit();
            SuspendLayout();
            // 
            // lblRegistros
            // 
            lblRegistros.BorderStyle = BorderStyle.FixedSingle;
            lblRegistros.Location = new Point(963, 443);
            lblRegistros.Name = "lblRegistros";
            lblRegistros.Size = new Size(84, 22);
            lblRegistros.TabIndex = 12;
            lblRegistros.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(884, 443);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 11;
            label2.Text = "Registros:";
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(950, 488);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(97, 32);
            btnCerrar.TabIndex = 15;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(816, 488);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(97, 32);
            btnActualizar.TabIndex = 14;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(700, 488);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(97, 32);
            btnInsertar.TabIndex = 13;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // txtFiltro
            // 
            txtFiltro.Location = new Point(244, 26);
            txtFiltro.Name = "txtFiltro";
            txtFiltro.Size = new Size(314, 23);
            txtFiltro.TabIndex = 9;
            txtFiltro.TextChanged += txtFiltro_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 29);
            label1.Name = "label1";
            label1.Size = new Size(194, 15);
            label1.TabIndex = 8;
            label1.Text = "Ingrese filtro por nombre de tienda:";
            // 
            // dtgDatos
            // 
            dtgDatos.AllowUserToAddRows = false;
            dtgDatos.AllowUserToDeleteRows = false;
            dtgDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgDatos.Columns.AddRange(new DataGridViewColumn[] { Cod_tiend, Nom_tiend, Dir_tiend, Telf_tiend, departamento, provincia, distrito, Estado });
            dtgDatos.Location = new Point(12, 84);
            dtgDatos.Name = "dtgDatos";
            dtgDatos.ReadOnly = true;
            dtgDatos.RowHeadersVisible = false;
            dtgDatos.RowTemplate.Height = 25;
            dtgDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgDatos.Size = new Size(1040, 340);
            dtgDatos.TabIndex = 10;
            // 
            // Cod_tiend
            // 
            Cod_tiend.DataPropertyName = "Cod_tiend";
            Cod_tiend.HeaderText = "Codigo";
            Cod_tiend.Name = "Cod_tiend";
            Cod_tiend.ReadOnly = true;
            // 
            // Nom_tiend
            // 
            Nom_tiend.DataPropertyName = "Nom_tiend";
            Nom_tiend.HeaderText = "Tienda";
            Nom_tiend.Name = "Nom_tiend";
            Nom_tiend.ReadOnly = true;
            // 
            // Dir_tiend
            // 
            Dir_tiend.DataPropertyName = "Dir_tiend";
            Dir_tiend.HeaderText = "Direccion";
            Dir_tiend.Name = "Dir_tiend";
            Dir_tiend.ReadOnly = true;
            // 
            // Telf_tiend
            // 
            Telf_tiend.DataPropertyName = "Telf_tiend";
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleRight;
            Telf_tiend.DefaultCellStyle = dataGridViewCellStyle1;
            Telf_tiend.HeaderText = "Telefono";
            Telf_tiend.Name = "Telf_tiend";
            Telf_tiend.ReadOnly = true;
            // 
            // departamento
            // 
            departamento.DataPropertyName = "Departamento";
            departamento.HeaderText = "Departamento";
            departamento.Name = "departamento";
            departamento.ReadOnly = true;
            // 
            // provincia
            // 
            provincia.DataPropertyName = "Provincia";
            provincia.HeaderText = "Provincia";
            provincia.Name = "provincia";
            provincia.ReadOnly = true;
            // 
            // distrito
            // 
            distrito.DataPropertyName = "Distrito";
            distrito.HeaderText = "Distrito";
            distrito.Name = "distrito";
            distrito.ReadOnly = true;
            // 
            // Estado
            // 
            Estado.DataPropertyName = "Estado";
            Estado.HeaderText = "Estado";
            Estado.Name = "Estado";
            Estado.ReadOnly = true;
            // 
            // TiendaMant01
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1064, 547);
            Controls.Add(lblRegistros);
            Controls.Add(label2);
            Controls.Add(btnCerrar);
            Controls.Add(btnActualizar);
            Controls.Add(btnInsertar);
            Controls.Add(txtFiltro);
            Controls.Add(label1);
            Controls.Add(dtgDatos);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TiendaMant01";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mantenimiento de tiendas";
            Load += TiendaMant01_Load;
            ((System.ComponentModel.ISupportInitialize)dtgDatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRegistros;
        private Label label2;
        private Button btnCerrar;
        private Button btnActualizar;
        private Button btnInsertar;
        private TextBox txtFiltro;
        private Label label1;
        private DataGridView dtgDatos;
        private DataGridViewTextBoxColumn Cod_tiend;
        private DataGridViewTextBoxColumn Nom_tiend;
        private DataGridViewTextBoxColumn Dir_tiend;
        private DataGridViewTextBoxColumn Telf_tiend;
        private DataGridViewTextBoxColumn departamento;
        private DataGridViewTextBoxColumn provincia;
        private DataGridViewTextBoxColumn distrito;
        private DataGridViewTextBoxColumn Estado;
    }
}