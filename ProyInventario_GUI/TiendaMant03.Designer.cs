namespace ProyInventario_GUI
{
    partial class TiendaMant03
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
            grpDatos = new GroupBox();
            lblCod = new Label();
            label4 = new Label();
            txtDir = new TextBox();
            label11 = new Label();
            mskTelf = new MaskedTextBox();
            cboDepartamento = new ComboBox();
            cboProvincia = new ComboBox();
            cboDistrito = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            label9 = new Label();
            chkEstado = new CheckBox();
            btnGrabar = new Button();
            label10 = new Label();
            btnCancelar = new Button();
            txtNom = new TextBox();
            Label3 = new Label();
            Label1 = new Label();
            grpDatos.SuspendLayout();
            SuspendLayout();
            // 
            // grpDatos
            // 
            grpDatos.Controls.Add(lblCod);
            grpDatos.Controls.Add(label4);
            grpDatos.Controls.Add(txtDir);
            grpDatos.Controls.Add(label11);
            grpDatos.Controls.Add(mskTelf);
            grpDatos.Controls.Add(cboDepartamento);
            grpDatos.Controls.Add(cboProvincia);
            grpDatos.Controls.Add(cboDistrito);
            grpDatos.Controls.Add(label6);
            grpDatos.Controls.Add(label5);
            grpDatos.Controls.Add(label9);
            grpDatos.Controls.Add(chkEstado);
            grpDatos.Controls.Add(btnGrabar);
            grpDatos.Controls.Add(label10);
            grpDatos.Controls.Add(btnCancelar);
            grpDatos.Controls.Add(txtNom);
            grpDatos.Controls.Add(Label3);
            grpDatos.Controls.Add(Label1);
            grpDatos.Location = new Point(9, 5);
            grpDatos.Margin = new Padding(3, 2, 3, 2);
            grpDatos.Name = "grpDatos";
            grpDatos.Padding = new Padding(3, 2, 3, 2);
            grpDatos.Size = new Size(448, 364);
            grpDatos.TabIndex = 2;
            grpDatos.TabStop = false;
            grpDatos.Text = "Datos de la Tienda:";
            // 
            // lblCod
            // 
            lblCod.BorderStyle = BorderStyle.FixedSingle;
            lblCod.Location = new Point(103, 29);
            lblCod.Margin = new Padding(4, 0, 4, 0);
            lblCod.Name = "lblCod";
            lblCod.Size = new Size(75, 23);
            lblCod.TabIndex = 21;
            // 
            // label4
            // 
            label4.Location = new Point(7, 30);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(74, 19);
            label4.TabIndex = 20;
            label4.Text = "Codigo:";
            // 
            // txtDir
            // 
            txtDir.Location = new Point(104, 97);
            txtDir.Margin = new Padding(4);
            txtDir.Name = "txtDir";
            txtDir.Size = new Size(326, 23);
            txtDir.TabIndex = 5;
            // 
            // label11
            // 
            label11.Location = new Point(4, 100);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(74, 19);
            label11.TabIndex = 4;
            label11.Text = "Direccion:";
            // 
            // mskTelf
            // 
            mskTelf.Location = new Point(103, 131);
            mskTelf.Margin = new Padding(4);
            mskTelf.Mask = "999999999";
            mskTelf.Name = "mskTelf";
            mskTelf.Size = new Size(116, 23);
            mskTelf.TabIndex = 7;
            // 
            // cboDepartamento
            // 
            cboDepartamento.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDepartamento.FormattingEnabled = true;
            cboDepartamento.Location = new Point(104, 199);
            cboDepartamento.Margin = new Padding(4);
            cboDepartamento.Name = "cboDepartamento";
            cboDepartamento.Size = new Size(326, 23);
            cboDepartamento.TabIndex = 13;
            cboDepartamento.SelectionChangeCommitted += cboDepartamento_SelectionChangeCommitted;
            // 
            // cboProvincia
            // 
            cboProvincia.DropDownStyle = ComboBoxStyle.DropDownList;
            cboProvincia.FormattingEnabled = true;
            cboProvincia.Location = new Point(104, 235);
            cboProvincia.Margin = new Padding(4);
            cboProvincia.Name = "cboProvincia";
            cboProvincia.Size = new Size(326, 23);
            cboProvincia.TabIndex = 15;
            cboProvincia.SelectionChangeCommitted += cboProvincia_SelectionChangeCommitted;
            // 
            // cboDistrito
            // 
            cboDistrito.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDistrito.FormattingEnabled = true;
            cboDistrito.Location = new Point(104, 273);
            cboDistrito.Margin = new Padding(4);
            cboDistrito.Name = "cboDistrito";
            cboDistrito.Size = new Size(326, 23);
            cboDistrito.TabIndex = 17;
            // 
            // label6
            // 
            label6.Location = new Point(4, 199);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(94, 21);
            label6.TabIndex = 12;
            label6.Text = "Departamento:";
            // 
            // label5
            // 
            label5.Location = new Point(4, 235);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(74, 19);
            label5.TabIndex = 14;
            label5.Text = "Provincia:";
            // 
            // label9
            // 
            label9.Location = new Point(4, 273);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(74, 19);
            label9.TabIndex = 16;
            label9.Text = "Distrito:";
            // 
            // chkEstado
            // 
            chkEstado.AutoSize = true;
            chkEstado.Location = new Point(105, 171);
            chkEstado.Margin = new Padding(4);
            chkEstado.Name = "chkEstado";
            chkEstado.Size = new Size(60, 19);
            chkEstado.TabIndex = 11;
            chkEstado.Text = "Activo";
            chkEstado.UseVisualStyleBackColor = true;
            // 
            // btnGrabar
            // 
            btnGrabar.BackColor = Color.FromArgb(0, 192, 0);
            btnGrabar.ForeColor = SystemColors.ControlLightLight;
            btnGrabar.Location = new Point(259, 322);
            btnGrabar.Margin = new Padding(4);
            btnGrabar.Name = "btnGrabar";
            btnGrabar.Size = new Size(84, 28);
            btnGrabar.TabIndex = 18;
            btnGrabar.Text = "Grabar";
            btnGrabar.UseVisualStyleBackColor = false;
            btnGrabar.Click += btnGrabar_Click;
            // 
            // label10
            // 
            label10.Location = new Point(4, 171);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(94, 21);
            label10.TabIndex = 10;
            label10.Text = "Estado:";
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Red;
            btnCancelar.ForeColor = SystemColors.ControlLightLight;
            btnCancelar.Location = new Point(350, 322);
            btnCancelar.Margin = new Padding(4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(84, 28);
            btnCancelar.TabIndex = 19;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtNom
            // 
            txtNom.Location = new Point(103, 64);
            txtNom.Margin = new Padding(4);
            txtNom.Name = "txtNom";
            txtNom.Size = new Size(326, 23);
            txtNom.TabIndex = 1;
            // 
            // Label3
            // 
            Label3.Location = new Point(3, 134);
            Label3.Margin = new Padding(4, 0, 4, 0);
            Label3.Name = "Label3";
            Label3.Size = new Size(74, 19);
            Label3.TabIndex = 6;
            Label3.Text = "Telefono:";
            // 
            // Label1
            // 
            Label1.Location = new Point(3, 66);
            Label1.Margin = new Padding(4, 0, 4, 0);
            Label1.Name = "Label1";
            Label1.Size = new Size(92, 19);
            Label1.TabIndex = 0;
            Label1.Text = "Nombre:";
            // 
            // TiendaMant03
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(466, 388);
            Controls.Add(grpDatos);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TiendaMant03";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Actualizar Tienda";
            Load += TiendaMant03_Load;
            grpDatos.ResumeLayout(false);
            grpDatos.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpDatos;
        internal TextBox txtDir;
        internal Label label11;
        private MaskedTextBox mskTelf;
        private ComboBox cboDepartamento;
        private ComboBox cboProvincia;
        private ComboBox cboDistrito;
        internal Label label6;
        internal Label label5;
        internal Label label9;
        private CheckBox chkEstado;
        internal Button btnGrabar;
        internal Label label10;
        internal Button btnCancelar;
        internal TextBox txtNom;
        internal Label Label3;
        internal Label Label1;
        internal Label lblCod;
        internal Label label4;
    }
}