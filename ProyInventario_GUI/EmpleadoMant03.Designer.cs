namespace ProyInventario_GUI
{
    partial class EmpleadoMant03
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
            btnCargar = new Button();
            pcbFoto = new PictureBox();
            lblCod = new Label();
            label4 = new Label();
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
            grpDatos.Controls.Add(btnCargar);
            grpDatos.Controls.Add(pcbFoto);
            grpDatos.Controls.Add(lblCod);
            grpDatos.Controls.Add(label4);
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
            grpDatos.Location = new Point(10, 11);
            grpDatos.Margin = new Padding(3, 2, 3, 2);
            grpDatos.Name = "grpDatos";
            grpDatos.Padding = new Padding(3, 2, 3, 2);
            grpDatos.Size = new Size(816, 482);
            grpDatos.TabIndex = 0;
            grpDatos.TabStop = false;
            grpDatos.Text = "Datos del Empleado:";
            // 
            // btnCargar
            // 
            btnCargar.Location = new Point(496, 433);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(97, 26);
            btnCargar.TabIndex = 27;
            btnCargar.Text = "Cargar Foto";
            btnCargar.UseVisualStyleBackColor = true;
            btnCargar.Click += btnCargar_Click;
            // 
            // pcbFoto
            // 
            pcbFoto.BorderStyle = BorderStyle.FixedSingle;
            pcbFoto.Location = new Point(496, 62);
            pcbFoto.Name = "pcbFoto";
            pcbFoto.Size = new Size(306, 337);
            pcbFoto.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbFoto.TabIndex = 26;
            pcbFoto.TabStop = false;
            // 
            // lblCod
            // 
            lblCod.BorderStyle = BorderStyle.FixedSingle;
            lblCod.Location = new Point(103, 28);
            lblCod.Margin = new Padding(4, 0, 4, 0);
            lblCod.Name = "lblCod";
            lblCod.Size = new Size(75, 23);
            lblCod.TabIndex = 1;
            // 
            // label4
            // 
            label4.Location = new Point(7, 29);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(74, 19);
            label4.TabIndex = 0;
            label4.Text = "Codigo:";
            // 
            // label13
            // 
            label13.Location = new Point(6, 256);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(94, 21);
            label13.TabIndex = 16;
            label13.Text = "Tipo Usuario:";
            // 
            // cboTipUsuario
            // 
            cboTipUsuario.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTipUsuario.FormattingEnabled = true;
            cboTipUsuario.Location = new Point(106, 254);
            cboTipUsuario.Margin = new Padding(4);
            cboTipUsuario.Name = "cboTipUsuario";
            cboTipUsuario.Size = new Size(184, 23);
            cboTipUsuario.TabIndex = 17;
            // 
            // txtSue
            // 
            txtSue.Location = new Point(107, 199);
            txtSue.Margin = new Padding(4);
            txtSue.Name = "txtSue";
            txtSue.Size = new Size(115, 23);
            txtSue.TabIndex = 13;
            // 
            // label12
            // 
            label12.Location = new Point(7, 201);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(74, 19);
            label12.TabIndex = 12;
            label12.Text = "Sueldo:";
            // 
            // txtDir
            // 
            txtDir.Location = new Point(107, 146);
            txtDir.Margin = new Padding(4);
            txtDir.Name = "txtDir";
            txtDir.Size = new Size(326, 23);
            txtDir.TabIndex = 9;
            // 
            // label11
            // 
            label11.Location = new Point(7, 148);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(74, 19);
            label11.TabIndex = 8;
            label11.Text = "Direccion:";
            // 
            // mskTelf
            // 
            mskTelf.Location = new Point(106, 171);
            mskTelf.Margin = new Padding(4);
            mskTelf.Mask = "999999999";
            mskTelf.Name = "mskTelf";
            mskTelf.Size = new Size(116, 23);
            mskTelf.TabIndex = 11;
            // 
            // cboDepartamento
            // 
            cboDepartamento.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDepartamento.FormattingEnabled = true;
            cboDepartamento.Location = new Point(106, 299);
            cboDepartamento.Margin = new Padding(4);
            cboDepartamento.Name = "cboDepartamento";
            cboDepartamento.Size = new Size(326, 23);
            cboDepartamento.TabIndex = 19;
            cboDepartamento.SelectionChangeCommitted += cboDepartamento_SelectionChangeCommitted;
            // 
            // cboProvincia
            // 
            cboProvincia.DropDownStyle = ComboBoxStyle.DropDownList;
            cboProvincia.FormattingEnabled = true;
            cboProvincia.Location = new Point(106, 336);
            cboProvincia.Margin = new Padding(4);
            cboProvincia.Name = "cboProvincia";
            cboProvincia.Size = new Size(326, 23);
            cboProvincia.TabIndex = 21;
            cboProvincia.SelectionChangeCommitted += cboProvincia_SelectionChangeCommitted;
            // 
            // cboDistrito
            // 
            cboDistrito.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDistrito.FormattingEnabled = true;
            cboDistrito.Location = new Point(106, 374);
            cboDistrito.Margin = new Padding(4);
            cboDistrito.Name = "cboDistrito";
            cboDistrito.Size = new Size(326, 23);
            cboDistrito.TabIndex = 23;
            // 
            // label6
            // 
            label6.Location = new Point(6, 299);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(94, 21);
            label6.TabIndex = 18;
            label6.Text = "Departamento:";
            // 
            // label5
            // 
            label5.Location = new Point(6, 336);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(74, 19);
            label5.TabIndex = 20;
            label5.Text = "Provincia:";
            // 
            // label9
            // 
            label9.Location = new Point(6, 374);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(74, 19);
            label9.TabIndex = 22;
            label9.Text = "Distrito:";
            // 
            // chkEstado
            // 
            chkEstado.AutoSize = true;
            chkEstado.Location = new Point(108, 230);
            chkEstado.Margin = new Padding(4);
            chkEstado.Name = "chkEstado";
            chkEstado.Size = new Size(60, 19);
            chkEstado.TabIndex = 15;
            chkEstado.Text = "Activo";
            chkEstado.UseVisualStyleBackColor = true;
            // 
            // btnGrabar
            // 
            btnGrabar.BackColor = Color.FromArgb(0, 192, 0);
            btnGrabar.ForeColor = SystemColors.ControlLightLight;
            btnGrabar.Location = new Point(627, 433);
            btnGrabar.Margin = new Padding(4);
            btnGrabar.Name = "btnGrabar";
            btnGrabar.Size = new Size(84, 28);
            btnGrabar.TabIndex = 24;
            btnGrabar.Text = "Grabar";
            btnGrabar.UseVisualStyleBackColor = false;
            btnGrabar.Click += btnGrabar_Click;
            // 
            // label10
            // 
            label10.Location = new Point(7, 228);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(94, 21);
            label10.TabIndex = 14;
            label10.Text = "Estado:";
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Red;
            btnCancelar.ForeColor = SystemColors.ControlLightLight;
            btnCancelar.Location = new Point(718, 433);
            btnCancelar.Margin = new Padding(4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(84, 28);
            btnCancelar.TabIndex = 25;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtNom
            // 
            txtNom.Location = new Point(106, 60);
            txtNom.Margin = new Padding(4);
            txtNom.Name = "txtNom";
            txtNom.Size = new Size(326, 23);
            txtNom.TabIndex = 3;
            // 
            // mskDni
            // 
            mskDni.Location = new Point(106, 118);
            mskDni.Margin = new Padding(4);
            mskDni.Mask = "99999999";
            mskDni.Name = "mskDni";
            mskDni.Size = new Size(116, 23);
            mskDni.TabIndex = 7;
            // 
            // txtApe
            // 
            txtApe.Location = new Point(106, 89);
            txtApe.Margin = new Padding(4);
            txtApe.Name = "txtApe";
            txtApe.Size = new Size(326, 23);
            txtApe.TabIndex = 5;
            // 
            // Label2
            // 
            Label2.Location = new Point(6, 92);
            Label2.Margin = new Padding(4, 0, 4, 0);
            Label2.Name = "Label2";
            Label2.Size = new Size(74, 19);
            Label2.TabIndex = 4;
            Label2.Text = "Apellidos:";
            // 
            // label7
            // 
            label7.Location = new Point(6, 124);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(74, 19);
            label7.TabIndex = 6;
            label7.Text = "DNI:";
            // 
            // Label3
            // 
            Label3.Location = new Point(6, 174);
            Label3.Margin = new Padding(4, 0, 4, 0);
            Label3.Name = "Label3";
            Label3.Size = new Size(74, 19);
            Label3.TabIndex = 10;
            Label3.Text = "Telefono:";
            // 
            // Label1
            // 
            Label1.Location = new Point(6, 62);
            Label1.Margin = new Padding(4, 0, 4, 0);
            Label1.Name = "Label1";
            Label1.Size = new Size(74, 19);
            Label1.TabIndex = 2;
            Label1.Text = "Nombres:";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // EmpleadoMant03
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(836, 505);
            Controls.Add(grpDatos);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EmpleadoMant03";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Actualizar Empleado";
            Load += EmpleadoMant03_Load;
            grpDatos.ResumeLayout(false);
            grpDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pcbFoto).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpDatos;
        internal Label lblCod;
        internal Label label4;
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