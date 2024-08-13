namespace AgenciaViajes_GUI
{
    partial class ActividadMan02
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
            txtDescripcion = new TextBox();
            label1 = new Label();
            btnCancelar = new Button();
            btnGrabar = new Button();
            label2 = new Label();
            txtNombre = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtPrecio = new TextBox();
            chkEstado = new CheckBox();
            txtLugar = new TextBox();
            txtPais = new TextBox();
            SuspendLayout();
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(143, 51);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(369, 23);
            txtDescripcion.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 54);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 2;
            label1.Text = "Descripcion:";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(458, 300);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(103, 30);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGrabar
            // 
            btnGrabar.Location = new Point(458, 264);
            btnGrabar.Name = "btnGrabar";
            btnGrabar.Size = new Size(103, 30);
            btnGrabar.TabIndex = 7;
            btnGrabar.Text = "Grabar";
            btnGrabar.UseVisualStyleBackColor = true;
            btnGrabar.Click += btnGrabar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 110);
            label2.Name = "label2";
            label2.Size = new Size(107, 15);
            label2.TabIndex = 2;
            label2.Text = "Nombre Actividad:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(143, 107);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(245, 23);
            txtNombre.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(79, 167);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 2;
            label3.Text = "Lugar:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(88, 221);
            label4.Name = "label4";
            label4.Size = new Size(31, 15);
            label4.TabIndex = 2;
            label4.Text = "Pais:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(458, 110);
            label5.Name = "label5";
            label5.Size = new Size(43, 15);
            label5.TabIndex = 2;
            label5.Text = "Precio:";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(507, 107);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(93, 23);
            txtPrecio.TabIndex = 3;
            txtPrecio.TextAlign = HorizontalAlignment.Right;
            txtPrecio.KeyPress += txtPrecio_KeyPress;
            // 
            // chkEstado
            // 
            chkEstado.AutoSize = true;
            chkEstado.Checked = true;
            chkEstado.CheckState = CheckState.Checked;
            chkEstado.Location = new Point(225, 298);
            chkEstado.Name = "chkEstado";
            chkEstado.Size = new Size(65, 19);
            chkEstado.TabIndex = 6;
            chkEstado.Text = "Activo?";
            chkEstado.UseVisualStyleBackColor = true;
            // 
            // txtLugar
            // 
            txtLugar.Location = new Point(143, 167);
            txtLugar.Name = "txtLugar";
            txtLugar.Size = new Size(161, 23);
            txtLugar.TabIndex = 4;
            // 
            // txtPais
            // 
            txtPais.Location = new Point(143, 218);
            txtPais.Name = "txtPais";
            txtPais.Size = new Size(161, 23);
            txtPais.TabIndex = 5;
            // 
            // ActividadMan02
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(636, 400);
            Controls.Add(chkEstado);
            Controls.Add(txtPrecio);
            Controls.Add(txtPais);
            Controls.Add(txtLugar);
            Controls.Add(txtNombre);
            Controls.Add(btnCancelar);
            Controls.Add(btnGrabar);
            Controls.Add(txtDescripcion);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ActividadMan02";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Insertar Nueva Actividad";
            Load += ActividadMan02_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDescripcion;
        private Label label1;
        private Button btnCancelar;
        private Button btnGrabar;
        private Label label2;
        private TextBox txtNombre;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtPrecio;
        private CheckBox chkEstado;
        private TextBox txtLugar;
        private TextBox txtPais;
    }
}