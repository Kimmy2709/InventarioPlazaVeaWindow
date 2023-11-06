namespace ProyInventario_GUI
{
    partial class EmpleadoMant02
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
            pcbFoto = new PictureBox();
            btnCargar = new Button();
            label13 = new Label();
            cboTipUsuario = new ComboBox();
            txtSue = new TextBox();
            label12 = new Label();
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
            mskDni = new MaskedTextBox();
            txtApe = new TextBox();
            Label2 = new Label();
            label7 = new Label();
            Label3 = new Label();
            Label1 = new Label();
            openFileDialog1 = new OpenFileDialog();
            grpDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcbFoto).BeginInit();
            SuspendLayout();
            // 
            // grpDatos
            // 
            grpDatos.Controls.Add(pcbFoto);
            grpDatos.Controls.Add(btnCargar);
            grpDatos.Controls.Add(label13);
            grpDatos.Controls.Add(cboTipUsuario);
            grpDatos.Controls.Add(txtSue);
            grpDatos.Controls.Add(label12);
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
            grpDatos.Controls.Add(mskDni);
            grpDatos.Controls.Add(txtApe);
            grpDatos.Controls.Add(Label2);
            grpDatos.Controls.Add(label7);
            grpDatos.Controls.Add(Label3);
            grpDatos.Controls.Add(Label1);
            grpDatos.Location = new Point(12, 8);
            grpDatos.Margin = new Padding(3, 2, 3, 2);
            grpDatos.Name = "grpDatos";
            grpDatos.Padding = new Padding(3, 2, 3, 2);
            grpDatos.Size = new Size(809, 452);
            grpDatos.TabIndex = 0;
            grpDatos.TabStop = false;
            grpDatos.Text = "Datos del Empleado:";
            // 
            // pcbFoto
            // 
            pcbFoto.BorderStyle = BorderStyle.FixedSingle;
            pcbFoto.Location = new Point(478, 26);
            pcbFoto.Name = "pcbFoto";
            pcbFoto.Size = new Size(306, 337);
            pcbFoto.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbFoto.TabIndex = 25;
            pcbFoto.TabStop = false;
            // 
            // btnCargar
            // 
            btnCargar.Location = new Point(478, 405);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(97, 26);
            btnCargar.TabIndex = 24;
            btnCargar.Text = "Cargar Foto";
            btnCargar.UseVisualStyleBackColor = true;
            btnCargar.Click += btnCargar_Click;
            // 
            // label13
            // 
            label13.Location = new Point(6, 223);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(94, 21);
            label13.TabIndex = 14;
            label13.Text = "Tipo Usuario:";
            // 
            // cboTipUsuario
            // 
            cboTipUsuario.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTipUsuario.FormattingEnabled = true;
            cboTipUsuario.Location = new Point(106, 220);
            cboTipUsuario.Margin = new Padding(4);
            cboTipUsuario.Name = "cboTipUsuario";
            cboTipUsuario.Size = new Size(184, 23);
            cboTipUsuario.TabIndex = 15;
            // 
            // txtSue
            // 
            txtSue.Location = new Point(107, 163);
            txtSue.Margin = new Padding(4);
            txtSue.Name = "txtSue";
            txtSue.Size = new Size(115, 23);
            txtSue.TabIndex = 11;
            // 
            // label12
            // 
            label12.Location = new Point(7, 165);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(74, 19);
            label12.TabIndex = 10;
            label12.Text = "Sueldo:";
            // 
            // txtDir
            // 
            txtDir.Location = new Point(107, 110);
            txtDir.Margin = new Padding(4);
            txtDir.Name = "txtDir";
            txtDir.Size = new Size(326, 23);
            txtDir.TabIndex = 7;
            // 
            // label11
            // 
            label11.Location = new Point(7, 112);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(74, 19);
            label11.TabIndex = 6;
            label11.Text = "Direccion:";
            // 
            // mskTelf
            // 
            mskTelf.Location = new Point(106, 135);
            mskTelf.Margin = new Padding(4);
            mskTelf.Mask = "999999999";
            mskTelf.Name = "mskTelf";
            mskTelf.Size = new Size(116, 23);
            mskTelf.TabIndex = 9;
            // 
            // cboDepartamento
            // 
            cboDepartamento.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDepartamento.FormattingEnabled = true;
            cboDepartamento.Location = new Point(106, 266);
            cboDepartamento.Margin = new Padding(4);
            cboDepartamento.Name = "cboDepartamento";
            cboDepartamento.Size = new Size(326, 23);
            cboDepartamento.TabIndex = 17;
            cboDepartamento.SelectionChangeCommitted += cboDepartamento_SelectionChangeCommitted;
            // 
            // cboProvincia
            // 
            cboProvincia.DropDownStyle = ComboBoxStyle.DropDownList;
            cboProvincia.FormattingEnabled = true;
            cboProvincia.Location = new Point(106, 302);
            cboProvincia.Margin = new Padding(4);
            cboProvincia.Name = "cboProvincia";
            cboProvincia.Size = new Size(326, 23);
            cboProvincia.TabIndex = 19;
            cboProvincia.SelectionChangeCommitted += cboProvincia_SelectionChangeCommitted;
            // 
            // cboDistrito
            // 
            cboDistrito.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDistrito.FormattingEnabled = true;
            cboDistrito.Location = new Point(106, 340);
            cboDistrito.Margin = new Padding(4);
            cboDistrito.Name = "cboDistrito";
            cboDistrito.Size = new Size(326, 23);
            cboDistrito.TabIndex = 21;
            // 
            // label6
            // 
            label6.Location = new Point(6, 266);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(94, 21);
            label6.TabIndex = 16;
            label6.Text = "Departamento:";
            // 
            // label5
            // 
            label5.Location = new Point(6, 302);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(74, 19);
            label5.TabIndex = 18;
            label5.Text = "Provincia:";
            // 
            // label9
            // 
            label9.Location = new Point(6, 340);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(74, 19);
            label9.TabIndex = 20;
            label9.Text = "Distrito:";
            // 
            // chkEstado
            // 
            chkEstado.AutoSize = true;
            chkEstado.Location = new Point(108, 194);
            chkEstado.Margin = new Padding(4);
            chkEstado.Name = "chkEstado";
            chkEstado.Size = new Size(60, 19);
            chkEstado.TabIndex = 13;
            chkEstado.Text = "Activo";
            chkEstado.UseVisualStyleBackColor = true;
            // 
            // btnGrabar
            // 
            btnGrabar.BackColor = Color.FromArgb(0, 192, 0);
            btnGrabar.ForeColor = SystemColors.ControlLightLight;
            btnGrabar.Location = new Point(609, 405);
            btnGrabar.Margin = new Padding(4);
            btnGrabar.Name = "btnGrabar";
            btnGrabar.Size = new Size(84, 28);
            btnGrabar.TabIndex = 22;
            btnGrabar.Text = "Grabar";
            btnGrabar.UseVisualStyleBackColor = false;
            btnGrabar.Click += btnGrabar_Click;
            // 
            // label10
            // 
            label10.Location = new Point(7, 192);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(94, 21);
            label10.TabIndex = 12;
            label10.Text = "Estado:";
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Red;
            btnCancelar.ForeColor = SystemColors.ControlLightLight;
            btnCancelar.Location = new Point(700, 405);
            btnCancelar.Margin = new Padding(4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(84, 28);
            btnCancelar.TabIndex = 23;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtNom
            // 
            txtNom.Location = new Point(106, 24);
            txtNom.Margin = new Padding(4);
            txtNom.Name = "txtNom";
            txtNom.Size = new Size(326, 23);
            txtNom.TabIndex = 1;
            // 
            // mskDni
            // 
            mskDni.Location = new Point(106, 82);
            mskDni.Margin = new Padding(4);
            mskDni.Mask = "99999999";
            mskDni.Name = "mskDni";
            mskDni.Size = new Size(116, 23);
            mskDni.TabIndex = 5;
            // 
            // txtApe
            // 
            txtApe.Location = new Point(106, 53);
            txtApe.Margin = new Padding(4);
            txtApe.Name = "txtApe";
            txtApe.Size = new Size(326, 23);
            txtApe.TabIndex = 3;
            // 
            // Label2
            // 
            Label2.Location = new Point(6, 56);
            Label2.Margin = new Padding(4, 0, 4, 0);
            Label2.Name = "Label2";
            Label2.Size = new Size(74, 19);
            Label2.TabIndex = 2;
            Label2.Text = "Apellidos:";
            // 
            // label7
            // 
            label7.Location = new Point(6, 88);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(74, 19);
            label7.TabIndex = 4;
            label7.Text = "DNI:";
            // 
            // Label3
            // 
            Label3.Location = new Point(6, 138);
            Label3.Margin = new Padding(4, 0, 4, 0);
            Label3.Name = "Label3";
            Label3.Size = new Size(74, 19);
            Label3.TabIndex = 8;
            Label3.Text = "Telefono:";
            // 
            // Label1
            // 
            Label1.Location = new Point(6, 26);
            Label1.Margin = new Padding(4, 0, 4, 0);
            Label1.Name = "Label1";
            Label1.Size = new Size(74, 19);
            Label1.TabIndex = 0;
            Label1.Text = "Nombres:";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // EmpleadoMant02
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(833, 471);
            Controls.Add(grpDatos);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EmpleadoMant02";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Insertar Empleado";
            Load += EmpleadoMant02_Load;
            grpDatos.ResumeLayout(false);
            grpDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pcbFoto).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpDatos;
        internal Label label13;
        private ComboBox cboTipUsuario;
        internal TextBox txtSue;
        internal Label label12;
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
        private MaskedTextBox mskDni;
        internal TextBox txtApe;
        internal Label Label2;
        internal Label label7;
        internal Label Label3;
        internal Label Label1;
        private PictureBox pcbFoto;
        private Button btnCargar;
        private OpenFileDialog openFileDialog1;
    }
}