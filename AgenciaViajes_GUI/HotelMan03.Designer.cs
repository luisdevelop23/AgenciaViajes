namespace AgenciaViajes_GUI
{
    partial class HotelMan03
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
            label7 = new Label();
            lblCodigo = new Label();
            txtNombre = new TextBox();
            txtDireccion = new TextBox();
            txtPais = new TextBox();
            chkEstado = new CheckBox();
            btnGrabar = new Button();
            btnCancelar = new Button();
            label9 = new Label();
            label12 = new Label();
            txtCiudad = new TextBox();
            txtPrecio = new TextBox();
            label8 = new Label();
            label5 = new Label();
            cboCat = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 39);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 0;
            label1.Text = "Código:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(56, 89);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 0;
            label2.Text = "Nombre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(56, 135);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 0;
            label3.Text = "Dirección:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(56, 184);
            label4.Name = "label4";
            label4.Size = new Size(31, 15);
            label4.TabIndex = 0;
            label4.Text = "Pais:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(-171, 195);
            label7.Name = "label7";
            label7.Size = new Size(38, 15);
            label7.TabIndex = 0;
            label7.Text = "label1";
            // 
            // lblCodigo
            // 
            lblCodigo.BorderStyle = BorderStyle.FixedSingle;
            lblCodigo.Location = new Point(168, 38);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(85, 27);
            lblCodigo.TabIndex = 0;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(168, 86);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(455, 23);
            txtNombre.TabIndex = 1;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(168, 132);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(345, 23);
            txtDireccion.TabIndex = 2;
            // 
            // txtPais
            // 
            txtPais.Location = new Point(168, 179);
            txtPais.Name = "txtPais";
            txtPais.Size = new Size(195, 23);
            txtPais.TabIndex = 3;
            // 
            // chkEstado
            // 
            chkEstado.AutoSize = true;
            chkEstado.Checked = true;
            chkEstado.CheckState = CheckState.Checked;
            chkEstado.Location = new Point(168, 386);
            chkEstado.Name = "chkEstado";
            chkEstado.Size = new Size(65, 19);
            chkEstado.TabIndex = 7;
            chkEstado.Text = "Activo?";
            chkEstado.UseVisualStyleBackColor = true;
            // 
            // btnGrabar
            // 
            btnGrabar.Location = new Point(555, 344);
            btnGrabar.Name = "btnGrabar";
            btnGrabar.Size = new Size(97, 36);
            btnGrabar.TabIndex = 8;
            btnGrabar.Text = "Grabar";
            btnGrabar.UseVisualStyleBackColor = true;
            btnGrabar.Click += btnGrabar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(555, 386);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(97, 35);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(56, 231);
            label9.Name = "label9";
            label9.Size = new Size(48, 15);
            label9.TabIndex = 0;
            label9.Text = "Ciudad:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(56, 331);
            label12.Name = "label12";
            label12.Size = new Size(43, 15);
            label12.TabIndex = 0;
            label12.Text = "Precio:";
            // 
            // txtCiudad
            // 
            txtCiudad.Location = new Point(168, 228);
            txtCiudad.Name = "txtCiudad";
            txtCiudad.Size = new Size(195, 23);
            txtCiudad.TabIndex = 4;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(168, 328);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(121, 23);
            txtPrecio.TabIndex = 6;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(56, 387);
            label8.Name = "label8";
            label8.Size = new Size(45, 15);
            label8.TabIndex = 5;
            label8.Text = "Estado:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(56, 280);
            label5.Name = "label5";
            label5.Size = new Size(61, 15);
            label5.TabIndex = 14;
            label5.Text = "Categoria:";
            // 
            // cboCat
            // 
            cboCat.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCat.FormattingEnabled = true;
            cboCat.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });
            cboCat.Location = new Point(168, 277);
            cboCat.Name = "cboCat";
            cboCat.Size = new Size(121, 23);
            cboCat.TabIndex = 5;
            // 
            // HotelMan03
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(685, 449);
            Controls.Add(label5);
            Controls.Add(cboCat);
            Controls.Add(label8);
            Controls.Add(btnCancelar);
            Controls.Add(btnGrabar);
            Controls.Add(chkEstado);
            Controls.Add(txtPrecio);
            Controls.Add(txtCiudad);
            Controls.Add(txtPais);
            Controls.Add(txtDireccion);
            Controls.Add(txtNombre);
            Controls.Add(label12);
            Controls.Add(label9);
            Controls.Add(lblCodigo);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "HotelMan03";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Actualizar Hotel";
            Load += HotelMan03_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label7;
        private TextBox txtNombre;
        private TextBox txtDireccion;
        private TextBox txtPais;
        private CheckBox chkEstado;
        private Button btnGrabar;
        private Button btnCancelar;
        private Label label9;
        private Label label12;
        private TextBox txtCiudad;
        private TextBox txtPrecio;
        private Label label8;
        internal Label lblCodigo;
        private Label label5;
        private ComboBox cboCat;
    }
}