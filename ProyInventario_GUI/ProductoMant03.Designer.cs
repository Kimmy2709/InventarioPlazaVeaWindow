namespace ProyInventario_GUI
{
    partial class ProductoMant03
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
            lblCod = new Label();
            label11 = new Label();
            btnGrabar = new Button();
            btnCancelar = new Button();
            cboUM = new ComboBox();
            cboSubFamilia = new ComboBox();
            label9 = new Label();
            label10 = new Label();
            cboFamilia = new ComboBox();
            cboLinea = new ComboBox();
            label7 = new Label();
            label8 = new Label();
            txtStkMin = new TextBox();
            txtStkAct = new TextBox();
            txtPrecio = new TextBox();
            chkActivo = new CheckBox();
            cboSeccion = new ComboBox();
            cboArea = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            label6 = new Label();
            txtDescripcion = new TextBox();
            label5 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblCod
            // 
            lblCod.BorderStyle = BorderStyle.FixedSingle;
            lblCod.Location = new Point(137, 42);
            lblCod.Margin = new Padding(4, 0, 4, 0);
            lblCod.Name = "lblCod";
            lblCod.Size = new Size(75, 23);
            lblCod.TabIndex = 1;
            // 
            // label11
            // 
            label11.Location = new Point(40, 43);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(74, 19);
            label11.TabIndex = 0;
            label11.Text = "Codigo:";
            // 
            // btnGrabar
            // 
            btnGrabar.BackColor = Color.FromArgb(0, 192, 0);
            btnGrabar.ForeColor = SystemColors.ControlLightLight;
            btnGrabar.Location = new Point(341, 470);
            btnGrabar.Margin = new Padding(4);
            btnGrabar.Name = "btnGrabar";
            btnGrabar.Size = new Size(84, 28);
            btnGrabar.TabIndex = 23;
            btnGrabar.Text = "Grabar";
            btnGrabar.UseVisualStyleBackColor = false;
            btnGrabar.Click += btnGrabar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Red;
            btnCancelar.ForeColor = SystemColors.ControlLightLight;
            btnCancelar.Location = new Point(431, 470);
            btnCancelar.Margin = new Padding(4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(84, 28);
            btnCancelar.TabIndex = 24;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // cboUM
            // 
            cboUM.DropDownStyle = ComboBoxStyle.DropDownList;
            cboUM.FormattingEnabled = true;
            cboUM.Location = new Point(123, 418);
            cboUM.Name = "cboUM";
            cboUM.Size = new Size(256, 23);
            cboUM.TabIndex = 22;
            // 
            // cboSubFamilia
            // 
            cboSubFamilia.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSubFamilia.FormattingEnabled = true;
            cboSubFamilia.Location = new Point(123, 378);
            cboSubFamilia.Name = "cboSubFamilia";
            cboSubFamilia.Size = new Size(256, 23);
            cboSubFamilia.TabIndex = 20;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(36, 422);
            label9.Name = "label9";
            label9.Size = new Size(64, 15);
            label9.TabIndex = 21;
            label9.Text = "U. Medida:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(36, 378);
            label10.Name = "label10";
            label10.Size = new Size(63, 15);
            label10.TabIndex = 19;
            label10.Text = "Subfamilia";
            // 
            // cboFamilia
            // 
            cboFamilia.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFamilia.FormattingEnabled = true;
            cboFamilia.Location = new Point(123, 342);
            cboFamilia.Name = "cboFamilia";
            cboFamilia.Size = new Size(256, 23);
            cboFamilia.TabIndex = 18;
            cboFamilia.SelectionChangeCommitted += cboFamilia_SelectionChangeCommitted;
            // 
            // cboLinea
            // 
            cboLinea.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLinea.FormattingEnabled = true;
            cboLinea.Location = new Point(123, 302);
            cboLinea.Name = "cboLinea";
            cboLinea.Size = new Size(256, 23);
            cboLinea.TabIndex = 16;
            cboLinea.SelectionChangeCommitted += cboLinea_SelectionChangeCommitted;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(36, 345);
            label7.Name = "label7";
            label7.Size = new Size(48, 15);
            label7.TabIndex = 17;
            label7.Text = "Familia:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(36, 302);
            label8.Name = "label8";
            label8.Size = new Size(38, 15);
            label8.TabIndex = 15;
            label8.Text = "Linea:";
            // 
            // txtStkMin
            // 
            txtStkMin.Location = new Point(439, 170);
            txtStkMin.Name = "txtStkMin";
            txtStkMin.Size = new Size(62, 23);
            txtStkMin.TabIndex = 10;
            txtStkMin.TextAlign = HorizontalAlignment.Right;
            txtStkMin.KeyPress += txtStkAct_KeyPress;
            // 
            // txtStkAct
            // 
            txtStkAct.Location = new Point(440, 126);
            txtStkAct.Name = "txtStkAct";
            txtStkAct.Size = new Size(62, 23);
            txtStkAct.TabIndex = 8;
            txtStkAct.TextAlign = HorizontalAlignment.Right;
            txtStkAct.KeyPress += txtStkAct_KeyPress;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(123, 123);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(93, 23);
            txtPrecio.TabIndex = 5;
            txtPrecio.TextAlign = HorizontalAlignment.Right;
            txtPrecio.KeyPress += txtPrecio_KeyPress;
            // 
            // chkActivo
            // 
            chkActivo.AutoSize = true;
            chkActivo.Checked = true;
            chkActivo.CheckState = CheckState.Checked;
            chkActivo.Location = new Point(123, 172);
            chkActivo.Name = "chkActivo";
            chkActivo.Size = new Size(60, 19);
            chkActivo.TabIndex = 6;
            chkActivo.Text = "Activo";
            chkActivo.UseVisualStyleBackColor = true;
            // 
            // cboSeccion
            // 
            cboSeccion.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSeccion.FormattingEnabled = true;
            cboSeccion.Location = new Point(123, 259);
            cboSeccion.Name = "cboSeccion";
            cboSeccion.Size = new Size(256, 23);
            cboSeccion.TabIndex = 14;
            cboSeccion.SelectionChangeCommitted += cboSeccion_SelectionChangeCommitted;
            // 
            // cboArea
            // 
            cboArea.DropDownStyle = ComboBoxStyle.DropDownList;
            cboArea.FormattingEnabled = true;
            cboArea.Location = new Point(123, 218);
            cboArea.Name = "cboArea";
            cboArea.Size = new Size(256, 23);
            cboArea.TabIndex = 12;
            cboArea.SelectionChangeCommitted += cboArea_SelectionChangeCommitted;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(348, 173);
            label4.Name = "label4";
            label4.Size = new Size(84, 15);
            label4.TabIndex = 9;
            label4.Text = "Stock mínimo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(348, 129);
            label3.Name = "label3";
            label3.Size = new Size(74, 15);
            label3.TabIndex = 7;
            label3.Text = "Stock actual:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(36, 262);
            label6.Name = "label6";
            label6.Size = new Size(51, 15);
            label6.TabIndex = 13;
            label6.Text = "Seccion:";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(123, 86);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(389, 23);
            txtDescripcion.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(36, 218);
            label5.Name = "label5";
            label5.Size = new Size(34, 15);
            label5.TabIndex = 11;
            label5.Text = "Area:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 126);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 4;
            label2.Text = "Precio:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 86);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 2;
            label1.Text = "Descripcion:";
            // 
            // ProductoMant03
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(551, 540);
            Controls.Add(lblCod);
            Controls.Add(label11);
            Controls.Add(btnGrabar);
            Controls.Add(btnCancelar);
            Controls.Add(cboUM);
            Controls.Add(cboSubFamilia);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(cboFamilia);
            Controls.Add(cboLinea);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(txtStkMin);
            Controls.Add(txtStkAct);
            Controls.Add(txtPrecio);
            Controls.Add(chkActivo);
            Controls.Add(cboSeccion);
            Controls.Add(cboArea);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label6);
            Controls.Add(txtDescripcion);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ProductoMant03";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Actualizar Producto";
            Load += ProductoMant03_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        internal Label lblCod;
        internal Label label11;
        internal Button btnGrabar;
        internal Button btnCancelar;
        private ComboBox cboUM;
        private ComboBox cboSubFamilia;
        private Label label9;
        private Label label10;
        private ComboBox cboFamilia;
        private ComboBox cboLinea;
        private Label label7;
        private Label label8;
        private TextBox txtStkMin;
        private TextBox txtStkAct;
        private TextBox txtPrecio;
        private CheckBox chkActivo;
        private ComboBox cboSeccion;
        private ComboBox cboArea;
        private Label label4;
        private Label label3;
        private Label label6;
        private TextBox txtDescripcion;
        private Label label5;
        private Label label2;
        private Label label1;
    }
}