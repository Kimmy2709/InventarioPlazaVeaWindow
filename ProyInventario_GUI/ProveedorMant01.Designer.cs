namespace ProyInventario_GUI
{
    partial class ProveedorMant01
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            txtFiltro = new TextBox();
            label1 = new Label();
            dtgDatos = new DataGridView();
            cod_prov = new DataGridViewTextBoxColumn();
            raz_soc_prov = new DataGridViewTextBoxColumn();
            dir_prov = new DataGridViewTextBoxColumn();
            telf_prov = new DataGridViewTextBoxColumn();
            Email_prov = new DataGridViewTextBoxColumn();
            ruc_prov = new DataGridViewTextBoxColumn();
            departamento = new DataGridViewTextBoxColumn();
            provincia = new DataGridViewTextBoxColumn();
            distrito = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            lblRegistros = new Label();
            label2 = new Label();
            btnCerrar = new Button();
            btnActualizar = new Button();
            btnInsertar = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgDatos).BeginInit();
            SuspendLayout();
            // 
            // txtFiltro
            // 
            txtFiltro.Location = new Point(223, 32);
            txtFiltro.Name = "txtFiltro";
            txtFiltro.Size = new Size(314, 23);
            txtFiltro.TabIndex = 1;
            txtFiltro.TextChanged += txtFiltro_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 35);
            label1.Name = "label1";
            label1.Size = new Size(162, 15);
            label1.TabIndex = 0;
            label1.Text = "Ingrese filtro por razon social:";
            // 
            // dtgDatos
            // 
            dtgDatos.AllowUserToAddRows = false;
            dtgDatos.AllowUserToDeleteRows = false;
            dtgDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgDatos.Columns.AddRange(new DataGridViewColumn[] { cod_prov, raz_soc_prov, dir_prov, telf_prov, Email_prov, ruc_prov, departamento, provincia, distrito, Estado });
            dtgDatos.Location = new Point(12, 90);
            dtgDatos.Name = "dtgDatos";
            dtgDatos.ReadOnly = true;
            dtgDatos.RowHeadersVisible = false;
            dtgDatos.RowTemplate.Height = 25;
            dtgDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgDatos.Size = new Size(1040, 340);
            dtgDatos.TabIndex = 2;
            // 
            // cod_prov
            // 
            cod_prov.DataPropertyName = "cod_prov";
            cod_prov.HeaderText = "Codigo";
            cod_prov.Name = "cod_prov";
            cod_prov.ReadOnly = true;
            // 
            // raz_soc_prov
            // 
            raz_soc_prov.DataPropertyName = "raz_soc_prov";
            raz_soc_prov.HeaderText = "Razon Social";
            raz_soc_prov.Name = "raz_soc_prov";
            raz_soc_prov.ReadOnly = true;
            // 
            // dir_prov
            // 
            dir_prov.DataPropertyName = "dir_prov";
            dir_prov.HeaderText = "Direccion";
            dir_prov.Name = "dir_prov";
            dir_prov.ReadOnly = true;
            // 
            // telf_prov
            // 
            telf_prov.DataPropertyName = "telf_prov";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleRight;
            telf_prov.DefaultCellStyle = dataGridViewCellStyle3;
            telf_prov.HeaderText = "Telefono";
            telf_prov.Name = "telf_prov";
            telf_prov.ReadOnly = true;
            // 
            // Email_prov
            // 
            Email_prov.DataPropertyName = "Email_prov";
            Email_prov.HeaderText = "Email";
            Email_prov.Name = "Email_prov";
            Email_prov.ReadOnly = true;
            // 
            // ruc_prov
            // 
            ruc_prov.DataPropertyName = "ruc_prov";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleRight;
            ruc_prov.DefaultCellStyle = dataGridViewCellStyle4;
            ruc_prov.HeaderText = "RUC";
            ruc_prov.Name = "ruc_prov";
            ruc_prov.ReadOnly = true;
            // 
            // departamento
            // 
            departamento.DataPropertyName = "departamento";
            departamento.HeaderText = "Departamento";
            departamento.Name = "departamento";
            departamento.ReadOnly = true;
            // 
            // provincia
            // 
            provincia.DataPropertyName = "provincia";
            provincia.HeaderText = "Provincia";
            provincia.Name = "provincia";
            provincia.ReadOnly = true;
            // 
            // distrito
            // 
            distrito.DataPropertyName = "distrito";
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
            // lblRegistros
            // 
            lblRegistros.BorderStyle = BorderStyle.FixedSingle;
            lblRegistros.Location = new Point(963, 449);
            lblRegistros.Name = "lblRegistros";
            lblRegistros.Size = new Size(84, 22);
            lblRegistros.TabIndex = 4;
            lblRegistros.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(884, 449);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 3;
            label2.Text = "Registros:";
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(950, 494);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(97, 32);
            btnCerrar.TabIndex = 7;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(816, 494);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(97, 32);
            btnActualizar.TabIndex = 6;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(700, 494);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(97, 32);
            btnInsertar.TabIndex = 5;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // ProveedorMant01
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
            Name = "ProveedorMant01";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mantenimiento de proveedores";
            Load += MDIPrincipal_Load;
            ((System.ComponentModel.ISupportInitialize)dtgDatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFiltro;
        private Label label1;
        private DataGridView dtgDatos;
        private Label lblRegistros;
        private Label label2;
        private Button btnCerrar;
        private Button btnActualizar;
        private Button btnInsertar;
        private DataGridViewTextBoxColumn cod_prov;
        private DataGridViewTextBoxColumn raz_soc_prov;
        private DataGridViewTextBoxColumn dir_prov;
        private DataGridViewTextBoxColumn telf_prov;
        private DataGridViewTextBoxColumn Email_prov;
        private DataGridViewTextBoxColumn ruc_prov;
        private DataGridViewTextBoxColumn departamento;
        private DataGridViewTextBoxColumn provincia;
        private DataGridViewTextBoxColumn distrito;
        private DataGridViewTextBoxColumn Estado;
    }
}