namespace ProyInventario_GUI
{
    partial class EmpleadoMant01
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            txtFiltro = new TextBox();
            label1 = new Label();
            dtgDatos = new DataGridView();
            lblRegistros = new Label();
            label2 = new Label();
            btnCerrar = new Button();
            btnActualizar = new Button();
            btnInsertar = new Button();
            Cod_emple = new DataGridViewTextBoxColumn();
            Ape_emple = new DataGridViewTextBoxColumn();
            Nom_emple = new DataGridViewTextBoxColumn();
            Dni_emple = new DataGridViewTextBoxColumn();
            Dir_emple = new DataGridViewTextBoxColumn();
            Telf_emple = new DataGridViewTextBoxColumn();
            Sue_emple = new DataGridViewTextBoxColumn();
            Departamento = new DataGridViewTextBoxColumn();
            Provincia = new DataGridViewTextBoxColumn();
            Distrito = new DataGridViewTextBoxColumn();
            TipoUsuario = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            Foto_emple = new DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)dtgDatos).BeginInit();
            SuspendLayout();
            // 
            // txtFiltro
            // 
            txtFiltro.Location = new Point(196, 32);
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
            label1.Size = new Size(142, 15);
            label1.TabIndex = 0;
            label1.Text = "Ingrese filtro por apellido:";
            // 
            // dtgDatos
            // 
            dtgDatos.AllowUserToAddRows = false;
            dtgDatos.AllowUserToDeleteRows = false;
            dtgDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgDatos.Columns.AddRange(new DataGridViewColumn[] { Cod_emple, Ape_emple, Nom_emple, Dni_emple, Dir_emple, Telf_emple, Sue_emple, Departamento, Provincia, Distrito, TipoUsuario, Estado, Foto_emple });
            dtgDatos.Location = new Point(12, 90);
            dtgDatos.Name = "dtgDatos";
            dtgDatos.ReadOnly = true;
            dtgDatos.RowHeadersVisible = false;
            dtgDatos.RowTemplate.Height = 25;
            dtgDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgDatos.Size = new Size(1040, 340);
            dtgDatos.TabIndex = 2;
            // 
            // lblRegistros
            // 
            lblRegistros.BorderStyle = BorderStyle.FixedSingle;
            lblRegistros.Location = new Point(962, 451);
            lblRegistros.Name = "lblRegistros";
            lblRegistros.Size = new Size(84, 22);
            lblRegistros.TabIndex = 4;
            lblRegistros.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(883, 451);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 3;
            label2.Text = "Registros:";
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(949, 496);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(97, 32);
            btnCerrar.TabIndex = 7;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(815, 496);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(97, 32);
            btnActualizar.TabIndex = 6;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(699, 496);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(97, 32);
            btnInsertar.TabIndex = 5;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // Cod_emple
            // 
            Cod_emple.DataPropertyName = "Cod_emple";
            Cod_emple.HeaderText = "Codigo";
            Cod_emple.Name = "Cod_emple";
            Cod_emple.ReadOnly = true;
            // 
            // Ape_emple
            // 
            Ape_emple.DataPropertyName = "Ape_emple";
            Ape_emple.HeaderText = "Apellido";
            Ape_emple.Name = "Ape_emple";
            Ape_emple.ReadOnly = true;
            // 
            // Nom_emple
            // 
            Nom_emple.DataPropertyName = "Nom_emple";
            Nom_emple.HeaderText = "Nombre";
            Nom_emple.Name = "Nom_emple";
            Nom_emple.ReadOnly = true;
            // 
            // Dni_emple
            // 
            Dni_emple.DataPropertyName = "Dni_emple";
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleRight;
            Dni_emple.DefaultCellStyle = dataGridViewCellStyle1;
            Dni_emple.FillWeight = 70F;
            Dni_emple.HeaderText = "DNI";
            Dni_emple.Name = "Dni_emple";
            Dni_emple.ReadOnly = true;
            // 
            // Dir_emple
            // 
            Dir_emple.DataPropertyName = "Dir_emple";
            Dir_emple.HeaderText = "Direccion";
            Dir_emple.Name = "Dir_emple";
            Dir_emple.ReadOnly = true;
            // 
            // Telf_emple
            // 
            Telf_emple.DataPropertyName = "Telf_emple";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleRight;
            Telf_emple.DefaultCellStyle = dataGridViewCellStyle2;
            Telf_emple.HeaderText = "Telefono";
            Telf_emple.Name = "Telf_emple";
            Telf_emple.ReadOnly = true;
            // 
            // Sue_emple
            // 
            Sue_emple.DataPropertyName = "Sue_emple";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N2";
            Sue_emple.DefaultCellStyle = dataGridViewCellStyle3;
            Sue_emple.FillWeight = 80F;
            Sue_emple.HeaderText = "Sueldo";
            Sue_emple.Name = "Sue_emple";
            Sue_emple.ReadOnly = true;
            // 
            // Departamento
            // 
            Departamento.DataPropertyName = "Departamento";
            Departamento.FillWeight = 120F;
            Departamento.HeaderText = "Departamento";
            Departamento.Name = "Departamento";
            Departamento.ReadOnly = true;
            // 
            // Provincia
            // 
            Provincia.DataPropertyName = "Provincia";
            Provincia.HeaderText = "Provincia";
            Provincia.Name = "Provincia";
            Provincia.ReadOnly = true;
            // 
            // Distrito
            // 
            Distrito.DataPropertyName = "Distrito";
            Distrito.HeaderText = "Distrito";
            Distrito.Name = "Distrito";
            Distrito.ReadOnly = true;
            // 
            // TipoUsuario
            // 
            TipoUsuario.DataPropertyName = "TipoUsuario";
            TipoUsuario.FillWeight = 120F;
            TipoUsuario.HeaderText = "Tipo Usuario";
            TipoUsuario.Name = "TipoUsuario";
            TipoUsuario.ReadOnly = true;
            // 
            // Estado
            // 
            Estado.DataPropertyName = "Estado";
            Estado.HeaderText = "Estado";
            Estado.Name = "Estado";
            Estado.ReadOnly = true;
            // 
            // Foto_emple
            // 
            Foto_emple.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Foto_emple.DataPropertyName = "Foto_emple";
            Foto_emple.HeaderText = "Foto";
            Foto_emple.ImageLayout = DataGridViewImageCellLayout.Zoom;
            Foto_emple.Name = "Foto_emple";
            Foto_emple.ReadOnly = true;
            Foto_emple.Resizable = DataGridViewTriState.True;
            // 
            // EmpleadoMant01
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
            Name = "EmpleadoMant01";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mantenimiento de empleados";
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
        private DataGridViewTextBoxColumn Cod_emple;
        private DataGridViewTextBoxColumn Ape_emple;
        private DataGridViewTextBoxColumn Nom_emple;
        private DataGridViewTextBoxColumn Dni_emple;
        private DataGridViewTextBoxColumn Dir_emple;
        private DataGridViewTextBoxColumn Telf_emple;
        private DataGridViewTextBoxColumn Sue_emple;
        private DataGridViewTextBoxColumn Departamento;
        private DataGridViewTextBoxColumn Provincia;
        private DataGridViewTextBoxColumn Distrito;
        private DataGridViewTextBoxColumn TipoUsuario;
        private DataGridViewTextBoxColumn Estado;
        private DataGridViewImageColumn Foto_emple;
    }
}