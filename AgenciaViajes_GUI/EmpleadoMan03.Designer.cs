namespace AgenciaViajes_GUI
{
    partial class EmpleadoMan03
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
            txtSueldo = new TextBox();
            label8 = new Label();
            lblCod = new Label();
            label11 = new Label();
            btnCancelar = new Button();
            btnGrabar = new Button();
            chkEstado = new CheckBox();
            label10 = new Label();
            cboSupervisor = new ComboBox();
            cboCargo = new ComboBox();
            label9 = new Label();
            label7 = new Label();
            txtEmail = new TextBox();
            label6 = new Label();
            label5 = new Label();
            txtDireccion = new TextBox();
            txtTelefono = new TextBox();
            label4 = new Label();
            mskDNI = new MaskedTextBox();
            label3 = new Label();
            txtApellido = new TextBox();
            label2 = new Label();
            txtNombre = new TextBox();
            label1 = new Label();
            grpDatos.SuspendLayout();
            SuspendLayout();
            // 
            // grpDatos
            // 
            grpDatos.Controls.Add(txtSueldo);
            grpDatos.Controls.Add(label8);
            grpDatos.Controls.Add(lblCod);
            grpDatos.Controls.Add(label11);
            grpDatos.Controls.Add(btnCancelar);
            grpDatos.Controls.Add(btnGrabar);
            grpDatos.Controls.Add(chkEstado);
            grpDatos.Controls.Add(label10);
            grpDatos.Controls.Add(cboSupervisor);
            grpDatos.Controls.Add(cboCargo);
            grpDatos.Controls.Add(label9);
            grpDatos.Controls.Add(label7);
            grpDatos.Controls.Add(txtEmail);
            grpDatos.Controls.Add(label6);
            grpDatos.Controls.Add(label5);
            grpDatos.Controls.Add(txtDireccion);
            grpDatos.Controls.Add(txtTelefono);
            grpDatos.Controls.Add(label4);
            grpDatos.Controls.Add(mskDNI);
            grpDatos.Controls.Add(label3);
            grpDatos.Controls.Add(txtApellido);
            grpDatos.Controls.Add(label2);
            grpDatos.Controls.Add(txtNombre);
            grpDatos.Controls.Add(label1);
            grpDatos.Location = new Point(12, 12);
            grpDatos.Name = "grpDatos";
            grpDatos.Size = new Size(526, 478);
            grpDatos.TabIndex = 1;
            grpDatos.TabStop = false;
            grpDatos.Text = "Datos";
            // 
            // txtSueldo
            // 
            txtSueldo.Location = new Point(130, 241);
            txtSueldo.Name = "txtSueldo";
            txtSueldo.Size = new Size(82, 23);
            txtSueldo.TabIndex = 7;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(21, 244);
            label8.Name = "label8";
            label8.Size = new Size(46, 15);
            label8.TabIndex = 46;
            label8.Text = "Sueldo:";
            // 
            // lblCod
            // 
            lblCod.BorderStyle = BorderStyle.FixedSingle;
            lblCod.Location = new Point(86, 36);
            lblCod.Margin = new Padding(4, 0, 4, 0);
            lblCod.Name = "lblCod";
            lblCod.Size = new Size(74, 23);
            lblCod.TabIndex = 44;
            // 
            // label11
            // 
            label11.Location = new Point(21, 37);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(54, 18);
            label11.TabIndex = 45;
            label11.Text = "Codigo:";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(431, 445);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 12;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGrabar
            // 
            btnGrabar.Location = new Point(431, 406);
            btnGrabar.Name = "btnGrabar";
            btnGrabar.Size = new Size(75, 23);
            btnGrabar.TabIndex = 11;
            btnGrabar.Text = "Grabar";
            btnGrabar.UseVisualStyleBackColor = true;
            btnGrabar.Click += btnGrabar_Click;
            // 
            // chkEstado
            // 
            chkEstado.AutoSize = true;
            chkEstado.Location = new Point(147, 374);
            chkEstado.Name = "chkEstado";
            chkEstado.Size = new Size(65, 19);
            chkEstado.TabIndex = 10;
            chkEstado.Text = "Activo?";
            chkEstado.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(38, 375);
            label10.Name = "label10";
            label10.Size = new Size(45, 15);
            label10.TabIndex = 40;
            label10.Text = "Estado:";
            // 
            // cboSupervisor
            // 
            cboSupervisor.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSupervisor.FormattingEnabled = true;
            cboSupervisor.Location = new Point(130, 321);
            cboSupervisor.Name = "cboSupervisor";
            cboSupervisor.Size = new Size(376, 23);
            cboSupervisor.TabIndex = 9;
            // 
            // cboCargo
            // 
            cboCargo.BackColor = SystemColors.Window;
            cboCargo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCargo.FormattingEnabled = true;
            cboCargo.Items.AddRange(new object[] { "AGENTE DE VIAJES", "SUPERVISOR" });
            cboCargo.Location = new Point(130, 281);
            cboCargo.Name = "cboCargo";
            cboCargo.Size = new Size(376, 23);
            cboCargo.TabIndex = 8;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(21, 324);
            label9.Name = "label9";
            label9.Size = new Size(62, 15);
            label9.TabIndex = 36;
            label9.Text = "Supervisor";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(21, 284);
            label7.Name = "label7";
            label7.Size = new Size(39, 15);
            label7.TabIndex = 34;
            label7.Text = "Cargo";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(130, 203);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(245, 23);
            txtEmail.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(21, 206);
            label6.Name = "label6";
            label6.Size = new Size(39, 15);
            label6.TabIndex = 32;
            label6.Text = "Email:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 165);
            label5.Name = "label5";
            label5.Size = new Size(60, 15);
            label5.TabIndex = 31;
            label5.Text = "Dirección:";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(130, 162);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(245, 23);
            txtDireccion.TabIndex = 5;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(341, 121);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(114, 23);
            txtTelefono.TabIndex = 4;
            txtTelefono.KeyPress += txtNumero_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(276, 124);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 28;
            label4.Text = "Teléfono:";
            // 
            // mskDNI
            // 
            mskDNI.Location = new Point(86, 121);
            mskDNI.Mask = "99999999";
            mskDNI.Name = "mskDNI";
            mskDNI.Size = new Size(114, 23);
            mskDNI.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 124);
            label3.Name = "label3";
            label3.Size = new Size(30, 15);
            label3.TabIndex = 26;
            label3.Text = "DNI:";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(341, 81);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(165, 23);
            txtApellido.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(276, 84);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 24;
            label2.Text = "Apellidos:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(86, 81);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(165, 23);
            txtNombre.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 84);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 22;
            label1.Text = "Nombres:";
            // 
            // EmpleadoMan03
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(550, 502);
            Controls.Add(grpDatos);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EmpleadoMan03";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EmpleadoMan03";
            Load += EmpleadoMan03_Load;
            grpDatos.ResumeLayout(false);
            grpDatos.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpDatos;
        private Button btnCancelar;
        private Button btnGrabar;
        private CheckBox chkEstado;
        private Label label10;
        private ComboBox cboSupervisor;
        private ComboBox cboCargo;
        private Label label9;
        private Label label7;
        private TextBox txtEmail;
        private Label label6;
        private Label label5;
        private TextBox txtDireccion;
        private TextBox txtTelefono;
        private Label label4;
        private MaskedTextBox mskDNI;
        private Label label3;
        private TextBox txtApellido;
        private Label label2;
        private TextBox txtNombre;
        private Label label1;
        internal Label lblCod;
        internal Label label11;
        private TextBox txtSueldo;
        private Label label8;
    }
}