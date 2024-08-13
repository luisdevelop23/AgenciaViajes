namespace AgenciaViajes_GUI
{
    partial class ClienteMan01
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
            dtgDatos = new DataGridView();
            cod_cli = new DataGridViewTextBoxColumn();
            Nom_cli = new DataGridViewTextBoxColumn();
            Ape_cli = new DataGridViewTextBoxColumn();
            Dni_cli = new DataGridViewTextBoxColumn();
            Tef_cli = new DataGridViewTextBoxColumn();
            Id_ubi = new DataGridViewTextBoxColumn();
            Dir_cli = new DataGridViewTextBoxColumn();
            Cor_cli = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            Reservas_Realizadas = new DataGridViewTextBoxColumn();
            label1 = new Label();
            txtFiltro = new TextBox();
            btnCerrar = new Button();
            btnActualizar = new Button();
            btnAgregar = new Button();
            label2 = new Label();
            lblRegistros = new Label();
            ((System.ComponentModel.ISupportInitialize)dtgDatos).BeginInit();
            SuspendLayout();
            // 
            // dtgDatos
            // 
            dtgDatos.AllowUserToAddRows = false;
            dtgDatos.AllowUserToDeleteRows = false;
            dtgDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgDatos.Columns.AddRange(new DataGridViewColumn[] { cod_cli, Nom_cli, Ape_cli, Dni_cli, Tef_cli, Id_ubi, Dir_cli, Cor_cli, Estado, Reservas_Realizadas });
            dtgDatos.Location = new Point(12, 59);
            dtgDatos.Name = "dtgDatos";
            dtgDatos.ReadOnly = true;
            dtgDatos.RowHeadersVisible = false;
            dtgDatos.RowTemplate.Height = 25;
            dtgDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgDatos.Size = new Size(993, 354);
            dtgDatos.TabIndex = 5;
            // 
            // cod_cli
            // 
            cod_cli.DataPropertyName = "cod_cli";
            cod_cli.FillWeight = 70F;
            cod_cli.HeaderText = "Código";
            cod_cli.Name = "cod_cli";
            cod_cli.ReadOnly = true;
            // 
            // Nom_cli
            // 
            Nom_cli.DataPropertyName = "Nom_cli";
            Nom_cli.FillWeight = 120F;
            Nom_cli.HeaderText = "Nombres";
            Nom_cli.Name = "Nom_cli";
            Nom_cli.ReadOnly = true;
            // 
            // Ape_cli
            // 
            Ape_cli.DataPropertyName = "Ape_cli";
            Ape_cli.FillWeight = 120F;
            Ape_cli.HeaderText = "Apellidos";
            Ape_cli.Name = "Ape_cli";
            Ape_cli.ReadOnly = true;
            // 
            // Dni_cli
            // 
            Dni_cli.DataPropertyName = "Dni_cli";
            Dni_cli.FillWeight = 80F;
            Dni_cli.HeaderText = "DNI";
            Dni_cli.Name = "Dni_cli";
            Dni_cli.ReadOnly = true;
            // 
            // Tef_cli
            // 
            Tef_cli.DataPropertyName = "Tef_cli";
            Tef_cli.HeaderText = "Teléfono";
            Tef_cli.Name = "Tef_cli";
            Tef_cli.ReadOnly = true;
            // 
            // Id_ubi
            // 
            Id_ubi.DataPropertyName = "Id_ubi";
            Id_ubi.FillWeight = 70F;
            Id_ubi.HeaderText = "Ubigeo";
            Id_ubi.Name = "Id_ubi";
            Id_ubi.ReadOnly = true;
            // 
            // Dir_cli
            // 
            Dir_cli.DataPropertyName = "Dir_cli";
            Dir_cli.HeaderText = "Dirección";
            Dir_cli.Name = "Dir_cli";
            Dir_cli.ReadOnly = true;
            // 
            // Cor_cli
            // 
            Cor_cli.DataPropertyName = "Cor_cli";
            Cor_cli.HeaderText = "Email";
            Cor_cli.Name = "Cor_cli";
            Cor_cli.ReadOnly = true;
            // 
            // Estado
            // 
            Estado.DataPropertyName = "Estado";
            Estado.FillWeight = 70F;
            Estado.HeaderText = "Estado";
            Estado.Name = "Estado";
            Estado.ReadOnly = true;
            // 
            // Reservas_Realizadas
            // 
            Reservas_Realizadas.DataPropertyName = "Reservas_Realizadas";
            Reservas_Realizadas.FillWeight = 80F;
            Reservas_Realizadas.HeaderText = "Reservas Realizadas";
            Reservas_Realizadas.Name = "Reservas_Realizadas";
            Reservas_Realizadas.ReadOnly = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 22);
            label1.Name = "label1";
            label1.Size = new Size(142, 15);
            label1.TabIndex = 1;
            label1.Text = "Ingrese filtro por apellido:";
            // 
            // txtFiltro
            // 
            txtFiltro.Location = new Point(182, 19);
            txtFiltro.Name = "txtFiltro";
            txtFiltro.Size = new Size(243, 23);
            txtFiltro.TabIndex = 1;
            txtFiltro.TextChanged += txtFiltro_TextChanged;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(906, 14);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(85, 30);
            btnCerrar.TabIndex = 4;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(804, 14);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(85, 30);
            btnActualizar.TabIndex = 3;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(702, 14);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(85, 30);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(856, 425);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 6;
            label2.Text = "Registros:";
            // 
            // lblRegistros
            // 
            lblRegistros.BorderStyle = BorderStyle.FixedSingle;
            lblRegistros.Location = new Point(921, 421);
            lblRegistros.Name = "lblRegistros";
            lblRegistros.Size = new Size(84, 22);
            lblRegistros.TabIndex = 7;
            lblRegistros.TextAlign = ContentAlignment.MiddleRight;
            // 
            // ClienteMan01
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1017, 452);
            Controls.Add(lblRegistros);
            Controls.Add(label2);
            Controls.Add(btnAgregar);
            Controls.Add(btnActualizar);
            Controls.Add(btnCerrar);
            Controls.Add(txtFiltro);
            Controls.Add(label1);
            Controls.Add(dtgDatos);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ClienteMan01";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mantenimiento de Clientes";
            Load += ClienteMan01_Load;
            ((System.ComponentModel.ISupportInitialize)dtgDatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgDatos;
        private Label label1;
        private TextBox txtFiltro;
        private Button btnCerrar;
        private Button btnActualizar;
        private Button btnAgregar;
        private Label label2;
        private Label lblRegistros;
        private DataGridViewTextBoxColumn cod_cli;
        private DataGridViewTextBoxColumn Nom_cli;
        private DataGridViewTextBoxColumn Ape_cli;
        private DataGridViewTextBoxColumn Dni_cli;
        private DataGridViewTextBoxColumn Tef_cli;
        private DataGridViewTextBoxColumn Id_ubi;
        private DataGridViewTextBoxColumn Dir_cli;
        private DataGridViewTextBoxColumn Cor_cli;
        private DataGridViewTextBoxColumn Estado;
        private DataGridViewTextBoxColumn Reservas_Realizadas;
    }
}