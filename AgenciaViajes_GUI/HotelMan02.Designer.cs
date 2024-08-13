namespace AgenciaViajes_GUI
{
    partial class HotelMan02
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtNombre = new TextBox();
            txtDirección = new TextBox();
            txtPrecio = new TextBox();
            txtCiudad = new TextBox();
            chkEstado = new CheckBox();
            btnGrabar = new Button();
            btnCancelar = new Button();
            label6 = new Label();
            label7 = new Label();
            txtPais = new TextBox();
            cboCat = new ComboBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 67);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(52, 115);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 1;
            label2.Text = "Dirección:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(52, 312);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 2;
            label3.Text = "Precio:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(52, 211);
            label4.Name = "label4";
            label4.Size = new Size(48, 15);
            label4.TabIndex = 3;
            label4.Text = "Ciudad:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(131, 64);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(471, 23);
            txtNombre.TabIndex = 1;
            // 
            // txtDirección
            // 
            txtDirección.Location = new Point(131, 112);
            txtDirección.Name = "txtDirección";
            txtDirección.Size = new Size(339, 23);
            txtDirección.TabIndex = 2;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(131, 309);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(121, 23);
            txtPrecio.TabIndex = 6;
            // 
            // txtCiudad
            // 
            txtCiudad.Location = new Point(131, 208);
            txtCiudad.Name = "txtCiudad";
            txtCiudad.Size = new Size(207, 23);
            txtCiudad.TabIndex = 4;
            // 
            // chkEstado
            // 
            chkEstado.AutoSize = true;
            chkEstado.Checked = true;
            chkEstado.CheckState = CheckState.Checked;
            chkEstado.Location = new Point(131, 373);
            chkEstado.Name = "chkEstado";
            chkEstado.Size = new Size(65, 19);
            chkEstado.TabIndex = 7;
            chkEstado.Text = "Activo?";
            chkEstado.UseVisualStyleBackColor = true;
            // 
            // btnGrabar
            // 
            btnGrabar.Location = new Point(533, 299);
            btnGrabar.Name = "btnGrabar";
            btnGrabar.Size = new Size(102, 41);
            btnGrabar.TabIndex = 8;
            btnGrabar.Text = "Grabar";
            btnGrabar.UseVisualStyleBackColor = true;
            btnGrabar.Click += btnGrabar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(533, 361);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(102, 38);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(52, 373);
            label6.Name = "label6";
            label6.Size = new Size(45, 15);
            label6.TabIndex = 9;
            label6.Text = "Estado:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(52, 163);
            label7.Name = "label7";
            label7.Size = new Size(31, 15);
            label7.TabIndex = 10;
            label7.Text = "Pais:";
            // 
            // txtPais
            // 
            txtPais.Location = new Point(131, 160);
            txtPais.Name = "txtPais";
            txtPais.Size = new Size(207, 23);
            txtPais.TabIndex = 3;
            // 
            // cboCat
            // 
            cboCat.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCat.FormattingEnabled = true;
            cboCat.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });
            cboCat.Location = new Point(131, 255);
            cboCat.Name = "cboCat";
            cboCat.Size = new Size(121, 23);
            cboCat.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(52, 258);
            label5.Name = "label5";
            label5.Size = new Size(61, 15);
            label5.TabIndex = 12;
            label5.Text = "Categoria:";
            // 
            // HotelMan02
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(670, 450);
            Controls.Add(label5);
            Controls.Add(cboCat);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(btnCancelar);
            Controls.Add(btnGrabar);
            Controls.Add(chkEstado);
            Controls.Add(txtPais);
            Controls.Add(txtCiudad);
            Controls.Add(txtPrecio);
            Controls.Add(txtDirección);
            Controls.Add(txtNombre);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "HotelMan02";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Insertar Hotel";
            Load += HotelMan02_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtNombre;
        private TextBox txtDirección;
        private TextBox txtPrecio;
        private TextBox txtCiudad;
        private CheckBox chkEstado;
        private Button btnGrabar;
        private Button btnCancelar;
        private Label label6;
        private Label label7;
        private TextBox txtPais;
        private ComboBox cboCat;
        private Label label5;
    }
}