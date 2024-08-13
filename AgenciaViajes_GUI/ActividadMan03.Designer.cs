namespace AgenciaViajes_GUI
{
    partial class ActividadMan03
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
            label7 = new Label();
            txtDescripcion = new TextBox();
            label1 = new Label();
            txtPrecio = new TextBox();
            label5 = new Label();
            label3 = new Label();
            label4 = new Label();
            chkEstado = new CheckBox();
            btnCancelar = new Button();
            btnGrabar = new Button();
            txtNombre = new TextBox();
            label2 = new Label();
            txtLugar = new TextBox();
            txtPais = new TextBox();
            lblCodigo = new Label();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(78, 59);
            label7.Name = "label7";
            label7.Size = new Size(49, 15);
            label7.TabIndex = 2;
            label7.Text = "Código:";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(156, 112);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(376, 23);
            txtDescripcion.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(70, 115);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 4;
            label1.Text = "Descripcion:";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(517, 175);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(93, 23);
            txtPrecio.TabIndex = 3;
            txtPrecio.TextAlign = HorizontalAlignment.Right;
            txtPrecio.KeyPress += txtPrecio_KeyPress_1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(468, 178);
            label5.Name = "label5";
            label5.Size = new Size(43, 15);
            label5.TabIndex = 21;
            label5.Text = "Precio:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(111, 232);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 23;
            label3.Text = "Lugar:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(119, 289);
            label4.Name = "label4";
            label4.Size = new Size(31, 15);
            label4.TabIndex = 25;
            label4.Text = "Pais:";
            // 
            // chkEstado
            // 
            chkEstado.AutoSize = true;
            chkEstado.Location = new Point(302, 347);
            chkEstado.Name = "chkEstado";
            chkEstado.Size = new Size(65, 19);
            chkEstado.TabIndex = 6;
            chkEstado.Text = "Activo?";
            chkEstado.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(517, 347);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(103, 30);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGrabar
            // 
            btnGrabar.Location = new Point(517, 311);
            btnGrabar.Name = "btnGrabar";
            btnGrabar.Size = new Size(103, 30);
            btnGrabar.TabIndex = 7;
            btnGrabar.Text = "Grabar";
            btnGrabar.UseVisualStyleBackColor = true;
            btnGrabar.Click += btnGrabar_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(157, 175);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(245, 23);
            txtNombre.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 178);
            label2.Name = "label2";
            label2.Size = new Size(107, 15);
            label2.TabIndex = 30;
            label2.Text = "Nombre Actividad:";
            // 
            // txtLugar
            // 
            txtLugar.Location = new Point(157, 229);
            txtLugar.Name = "txtLugar";
            txtLugar.Size = new Size(161, 23);
            txtLugar.TabIndex = 4;
            // 
            // txtPais
            // 
            txtPais.Location = new Point(157, 281);
            txtPais.Name = "txtPais";
            txtPais.Size = new Size(161, 23);
            txtPais.TabIndex = 5;
            // 
            // lblCodigo
            // 
            lblCodigo.BorderStyle = BorderStyle.FixedSingle;
            lblCodigo.Location = new Point(156, 58);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(70, 23);
            lblCodigo.TabIndex = 34;
            // 
            // ActividadMan03
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(708, 450);
            Controls.Add(lblCodigo);
            Controls.Add(txtPais);
            Controls.Add(txtLugar);
            Controls.Add(txtNombre);
            Controls.Add(label2);
            Controls.Add(btnCancelar);
            Controls.Add(btnGrabar);
            Controls.Add(chkEstado);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtPrecio);
            Controls.Add(label5);
            Controls.Add(txtDescripcion);
            Controls.Add(label1);
            Controls.Add(label7);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ActividadMan03";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Actualizar Actividad";
            Load += ActividadMan03_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label7;
        private TextBox txtDescripcion;
        private Label label1;
        private TextBox txtPrecio;
        private Label label5;
        private Label label3;
        private Label label4;
        private CheckBox chkEstado;
        private Button btnCancelar;
        private Button btnGrabar;
        private TextBox txtNombre;
        private Label label2;
        private TextBox txtLugar;
        private TextBox txtPais;
        private Label lblCodigo;
    }
}