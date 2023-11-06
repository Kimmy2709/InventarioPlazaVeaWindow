namespace ProyInventario_GUI
{
    partial class ProductoMant01
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
            txtFiltro = new TextBox();
            label1 = new Label();
            dtgDatos = new DataGridView();
            Cod_pro = new DataGridViewTextBoxColumn();
            Dscp_pro = new DataGridViewTextBoxColumn();
            Pre_pro = new DataGridViewTextBoxColumn();
            Stk_act = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            Dscp_area = new DataGridViewTextBoxColumn();
            Dscp_sec = new DataGridViewTextBoxColumn();
            Dscp_lin = new DataGridViewTextBoxColumn();
            Dscp_fam = new DataGridViewTextBoxColumn();
            Dscp_sub = new DataGridViewTextBoxColumn();
            Dscp_uni = new DataGridViewTextBoxColumn();
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
            label1.Size = new Size(161, 15);
            label1.TabIndex = 0;
            label1.Text = "Ingrese filtro por descripcion:";
            // 
            // dtgDatos
            // 
            dtgDatos.AllowUserToAddRows = false;
            dtgDatos.AllowUserToDeleteRows = false;
            dtgDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgDatos.Columns.AddRange(new DataGridViewColumn[] { Cod_pro, Dscp_pro, Pre_pro, Stk_act, Estado, Dscp_area, Dscp_sec, Dscp_lin, Dscp_fam, Dscp_sub, Dscp_uni });
            dtgDatos.Location = new Point(12, 90);
            dtgDatos.Name = "dtgDatos";
            dtgDatos.ReadOnly = true;
            dtgDatos.RowHeadersVisible = false;
            dtgDatos.RowTemplate.Height = 25;
            dtgDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgDatos.Size = new Size(1040, 340);
            dtgDatos.TabIndex = 2;
            // 
            // Cod_pro
            // 
            Cod_pro.DataPropertyName = "Cod_pro";
            Cod_pro.FillWeight = 98.83249F;
            Cod_pro.HeaderText = "Codigo";
            Cod_pro.Name = "Cod_pro";
            Cod_pro.ReadOnly = true;
            // 
            // Dscp_pro
            // 
            Dscp_pro.DataPropertyName = "Dscp_pro";
            Dscp_pro.FillWeight = 98.83249F;
            Dscp_pro.HeaderText = "Descripcion";
            Dscp_pro.Name = "Dscp_pro";
            Dscp_pro.ReadOnly = true;
            // 
            // Pre_pro
            // 
            Pre_pro.DataPropertyName = "Pre_pro";
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "N2";
            Pre_pro.DefaultCellStyle = dataGridViewCellStyle1;
            Pre_pro.FillWeight = 98.83249F;
            Pre_pro.HeaderText = "Precio";
            Pre_pro.Name = "Pre_pro";
            Pre_pro.ReadOnly = true;
            // 
            // Stk_act
            // 
            Stk_act.DataPropertyName = "Stk_act";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleRight;
            Stk_act.DefaultCellStyle = dataGridViewCellStyle2;
            Stk_act.FillWeight = 111.675125F;
            Stk_act.HeaderText = "Stock Actual";
            Stk_act.Name = "Stk_act";
            Stk_act.ReadOnly = true;
            // 
            // Estado
            // 
            Estado.DataPropertyName = "Estado";
            Estado.FillWeight = 98.83249F;
            Estado.HeaderText = "Estado";
            Estado.Name = "Estado";
            Estado.ReadOnly = true;
            // 
            // Dscp_area
            // 
            Dscp_area.DataPropertyName = "Dscp_area";
            Dscp_area.FillWeight = 98.83249F;
            Dscp_area.HeaderText = "Area";
            Dscp_area.Name = "Dscp_area";
            Dscp_area.ReadOnly = true;
            // 
            // Dscp_sec
            // 
            Dscp_sec.DataPropertyName = "Dscp_sec";
            Dscp_sec.FillWeight = 98.83249F;
            Dscp_sec.HeaderText = "Seccion";
            Dscp_sec.Name = "Dscp_sec";
            Dscp_sec.ReadOnly = true;
            // 
            // Dscp_lin
            // 
            Dscp_lin.DataPropertyName = "Dscp_lin";
            Dscp_lin.FillWeight = 98.83249F;
            Dscp_lin.HeaderText = "Linea";
            Dscp_lin.Name = "Dscp_lin";
            Dscp_lin.ReadOnly = true;
            // 
            // Dscp_fam
            // 
            Dscp_fam.DataPropertyName = "Dscp_fam";
            Dscp_fam.FillWeight = 98.83249F;
            Dscp_fam.HeaderText = "Familia";
            Dscp_fam.Name = "Dscp_fam";
            Dscp_fam.ReadOnly = true;
            // 
            // Dscp_sub
            // 
            Dscp_sub.DataPropertyName = "Dscp_sub";
            Dscp_sub.FillWeight = 98.83249F;
            Dscp_sub.HeaderText = "Subfamilia";
            Dscp_sub.Name = "Dscp_sub";
            Dscp_sub.ReadOnly = true;
            // 
            // Dscp_uni
            // 
            Dscp_uni.DataPropertyName = "Dscp_uni";
            Dscp_uni.FillWeight = 98.83249F;
            Dscp_uni.HeaderText = "U. Medida";
            Dscp_uni.Name = "Dscp_uni";
            Dscp_uni.ReadOnly = true;
            // 
            // lblRegistros
            // 
            lblRegistros.BorderStyle = BorderStyle.FixedSingle;
            lblRegistros.Location = new Point(962, 447);
            lblRegistros.Name = "lblRegistros";
            lblRegistros.Size = new Size(84, 22);
            lblRegistros.TabIndex = 4;
            lblRegistros.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(883, 447);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 3;
            label2.Text = "Registros:";
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(949, 492);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(97, 32);
            btnCerrar.TabIndex = 7;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(815, 492);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(97, 32);
            btnActualizar.TabIndex = 6;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(699, 492);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(97, 32);
            btnInsertar.TabIndex = 5;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // ProductoMant01
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
            Name = "ProductoMant01";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mantenimiento de productos";
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
        private DataGridViewTextBoxColumn Cod_pro;
        private DataGridViewTextBoxColumn Dscp_pro;
        private DataGridViewTextBoxColumn Pre_pro;
        private DataGridViewTextBoxColumn Stk_act;
        private DataGridViewTextBoxColumn Estado;
        private DataGridViewTextBoxColumn Dscp_area;
        private DataGridViewTextBoxColumn Dscp_sec;
        private DataGridViewTextBoxColumn Dscp_lin;
        private DataGridViewTextBoxColumn Dscp_fam;
        private DataGridViewTextBoxColumn Dscp_sub;
        private DataGridViewTextBoxColumn Dscp_uni;
    }
}