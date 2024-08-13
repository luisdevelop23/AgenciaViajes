namespace AgenciaViajes_GUI
{
    partial class ClienteMan02
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
            btnCancelar = new Button();
            btnGrabar = new Button();
            chkEstado = new CheckBox();
            label10 = new Label();
            cboDistrito = new ComboBox();
            cboProvincia = new ComboBox();
            cboDepartamento = new ComboBox();
            label9 = new Label();
            label8 = new Label();
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
            grpDatos.Controls.Add(btnCancelar);
            grpDatos.Controls.Add(btnGrabar);
            grpDatos.Controls.Add(chkEstado);
            grpDatos.Controls.Add(label10);
            grpDatos.Controls.Add(cboDistrito);
            grpDatos.Controls.Add(cboProvincia);
            grpDatos.Controls.Add(cboDepartamento);
            grpDatos.Controls.Add(label9);
            grpDatos.Controls.Add(label8);
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
            grpDatos.Size = new Size(526, 406);
            grpDatos.TabIndex = 0;
            grpDatos.TabStop = false;
            grpDatos.Text = "Datos";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(427, 364);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 12;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGrabar
            // 
            btnGrabar.Location = new Point(427, 325);
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
            chkEstado.Checked = true;
            chkEstado.CheckState = CheckState.Checked;
            chkEstado.Location = new Point(126, 328);
            chkEstado.Name = "chkEstado";
            chkEstado.Size = new Size(65, 19);
            chkEstado.TabIndex = 10;
            chkEstado.Text = "Activo?";
            chkEstado.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(17, 329);
            label10.Name = "label10";
            label10.Size = new Size(45, 15);
            label10.TabIndex = 18;
            label10.Text = "Estado:";
            // 
            // cboDistrito
            // 
            cboDistrito.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDistrito.FormattingEnabled = true;
            cboDistrito.Location = new Point(126, 282);
            cboDistrito.Name = "cboDistrito";
            cboDistrito.Size = new Size(376, 23);
            cboDistrito.TabIndex = 9;
            // 
            // cboProvincia
            // 
            cboProvincia.DropDownStyle = ComboBoxStyle.DropDownList;
            cboProvincia.FormattingEnabled = true;
            cboProvincia.Location = new Point(126, 240);
            cboProvincia.Name = "cboProvincia";
            cboProvincia.Size = new Size(376, 23);
            cboProvincia.TabIndex = 8;
            cboProvincia.SelectionChangeCommitted += cboProvincia_SelectionChangeCommitted;
            // 
            // cboDepartamento
            // 
            cboDepartamento.BackColor = SystemColors.Window;
            cboDepartamento.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDepartamento.FormattingEnabled = true;
            cboDepartamento.Location = new Point(126, 200);
            cboDepartamento.Name = "cboDepartamento";
            cboDepartamento.Size = new Size(376, 23);
            cboDepartamento.TabIndex = 7;
            cboDepartamento.SelectionChangeCommitted += cboDepartamento_SelectionChangeCommitted;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(17, 243);
            label9.Name = "label9";
            label9.Size = new Size(59, 15);
            label9.TabIndex = 14;
            label9.Text = "Provincia:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(17, 285);
            label8.Name = "label8";
            label8.Size = new Size(48, 15);
            label8.TabIndex = 13;
            label8.Text = "Distrito:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(17, 203);
            label7.Name = "label7";
            label7.Size = new Size(86, 15);
            label7.TabIndex = 12;
            label7.Text = "Departamento:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(126, 155);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(245, 23);
            txtEmail.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(17, 158);
            label6.Name = "label6";
            label6.Size = new Size(39, 15);
            label6.TabIndex = 10;
            label6.Text = "Email:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 117);
            label5.Name = "label5";
            label5.Size = new Size(60, 15);
            label5.TabIndex = 9;
            label5.Text = "Dirección:";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(126, 114);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(245, 23);
            txtDireccion.TabIndex = 5;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(337, 73);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(114, 23);
            txtTelefono.TabIndex = 4;
            txtTelefono.KeyPress += txtTelefono_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(272, 76);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 6;
            label4.Text = "Teléfono:";
            // 
            // mskDNI
            // 
            mskDNI.Location = new Point(82, 73);
            mskDNI.Mask = "99999999";
            mskDNI.Name = "mskDNI";
            mskDNI.Size = new Size(114, 23);
            mskDNI.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 76);
            label3.Name = "label3";
            label3.Size = new Size(30, 15);
            label3.TabIndex = 4;
            label3.Text = "DNI:";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(337, 33);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(165, 23);
            txtApellido.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(272, 36);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 2;
            label2.Text = "Apellidos:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(82, 33);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(165, 23);
            txtNombre.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 36);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombres:";
            // 
            // ClienteMan02
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(550, 430);
            Controls.Add(grpDatos);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ClienteMan02";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Insertar Clientes";
            Load += ClienteMan02_Load;
            grpDatos.ResumeLayout(false);
            grpDatos.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpDatos;
        private TextBox txtApellido;
        private Label label2;
        private TextBox txtNombre;
        private Label label1;
        private TextBox txtTelefono;
        private Label label4;
        private MaskedTextBox mskDNI;
        private Label label3;
        private TextBox txtEmail;
        private Label label6;
        private Label label5;
        private TextBox txtDireccion;
        private Button btnCancelar;
        private Button btnGrabar;
        private CheckBox chkEstado;
        private Label label10;
        private ComboBox cboDistrito;
        private ComboBox cboProvincia;
        private ComboBox cboDepartamento;
        private Label label9;
        private Label label8;
        private Label label7;
    }
}