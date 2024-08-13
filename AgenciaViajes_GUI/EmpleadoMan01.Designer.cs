namespace AgenciaViajes_GUI
{
    partial class EmpleadoMan01
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
            cod_emp = new DataGridViewTextBoxColumn();
            NombreEmpleado = new DataGridViewTextBoxColumn();
            DNI = new DataGridViewTextBoxColumn();
            Telefono = new DataGridViewTextBoxColumn();
            Domicilio = new DataGridViewTextBoxColumn();
            Correo = new DataGridViewTextBoxColumn();
            Sueldo = new DataGridViewTextBoxColumn();
            Cargo = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            ReservasRealizadas = new DataGridViewTextBoxColumn();
            btnAgregar = new Button();
            btnActualizar = new Button();
            btnCerrar = new Button();
            txtFiltro = new TextBox();
            label1 = new Label();
            lblRegistros = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dtgDatos).BeginInit();
            SuspendLayout();
            // 
            // dtgDatos
            // 
            dtgDatos.AllowUserToAddRows = false;
            dtgDatos.AllowUserToDeleteRows = false;
            dtgDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgDatos.Columns.AddRange(new DataGridViewColumn[] { cod_emp, NombreEmpleado, DNI, Telefono, Domicilio, Correo, Sueldo, Cargo, Estado, ReservasRealizadas });
            dtgDatos.Location = new Point(13, 60);
            dtgDatos.Name = "dtgDatos";
            dtgDatos.ReadOnly = true;
            dtgDatos.RowHeadersVisible = false;
            dtgDatos.RowTemplate.Height = 25;
            dtgDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgDatos.Size = new Size(880, 354);
            dtgDatos.TabIndex = 5;
            // 
            // cod_emp
            // 
            cod_emp.DataPropertyName = "cod_emp";
            cod_emp.HeaderText = "Código";
            cod_emp.Name = "cod_emp";
            cod_emp.ReadOnly = true;
            // 
            // NombreEmpleado
            // 
            NombreEmpleado.DataPropertyName = "NombreEmpleado";
            NombreEmpleado.HeaderText = "Apellidos y Nombres";
            NombreEmpleado.Name = "NombreEmpleado";
            NombreEmpleado.ReadOnly = true;
            NombreEmpleado.Width = 150;
            // 
            // DNI
            // 
            DNI.DataPropertyName = "DNI";
            DNI.HeaderText = "DNI";
            DNI.Name = "DNI";
            DNI.ReadOnly = true;
            // 
            // Telefono
            // 
            Telefono.DataPropertyName = "Telefono";
            Telefono.HeaderText = "Teléfono";
            Telefono.Name = "Telefono";
            Telefono.ReadOnly = true;
            // 
            // Domicilio
            // 
            Domicilio.DataPropertyName = "Domicilio";
            Domicilio.HeaderText = "Domicilio";
            Domicilio.Name = "Domicilio";
            Domicilio.ReadOnly = true;
            // 
            // Correo
            // 
            Correo.DataPropertyName = "Correo";
            Correo.HeaderText = "Correo";
            Correo.Name = "Correo";
            Correo.ReadOnly = true;
            Correo.Width = 130;
            // 
            // Sueldo
            // 
            Sueldo.DataPropertyName = "Sueldo";
            Sueldo.HeaderText = "Sueldo";
            Sueldo.Name = "Sueldo";
            Sueldo.ReadOnly = true;
            // 
            // Cargo
            // 
            Cargo.DataPropertyName = "Cargo";
            Cargo.HeaderText = "Cargo";
            Cargo.Name = "Cargo";
            Cargo.ReadOnly = true;
            // 
            // Estado
            // 
            Estado.DataPropertyName = "Estado";
            Estado.HeaderText = "Estado";
            Estado.Name = "Estado";
            Estado.ReadOnly = true;
            // 
            // ReservasRealizadas
            // 
            ReservasRealizadas.DataPropertyName = "ReservasRealizadas";
            ReservasRealizadas.HeaderText = "Reservas Realizadas";
            ReservasRealizadas.Name = "ReservasRealizadas";
            ReservasRealizadas.ReadOnly = true;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(594, 12);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(85, 30);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(698, 12);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(85, 30);
            btnActualizar.TabIndex = 3;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(800, 12);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(85, 30);
            btnCerrar.TabIndex = 4;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // txtFiltro
            // 
            txtFiltro.Location = new Point(195, 17);
            txtFiltro.Name = "txtFiltro";
            txtFiltro.Size = new Size(243, 23);
            txtFiltro.TabIndex = 1;
            txtFiltro.TextChanged += txtFiltro_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 20);
            label1.Name = "label1";
            label1.Size = new Size(142, 15);
            label1.TabIndex = 6;
            label1.Text = "Ingrese filtro por nombre:";
            // 
            // lblRegistros
            // 
            lblRegistros.BorderStyle = BorderStyle.FixedSingle;
            lblRegistros.Location = new Point(800, 421);
            lblRegistros.Name = "lblRegistros";
            lblRegistros.Size = new Size(84, 22);
            lblRegistros.TabIndex = 12;
            lblRegistros.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(736, 425);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 11;
            label2.Text = "Registros:";
            // 
            // EmpleadoMan01
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(905, 452);
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
            Name = "EmpleadoMan01";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mantenimiento de Empleados";
            Load += EmpleadosMan01_Load;
            ((System.ComponentModel.ISupportInitialize)dtgDatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgDatos;
        private Button btnAgregar;
        private Button btnActualizar;
        private Button btnCerrar;
        private TextBox txtFiltro;
        private Label label1;
        private Label lblRegistros;
        private Label label2;
        private DataGridViewTextBoxColumn cod_emp;
        private DataGridViewTextBoxColumn NombreEmpleado;
        private DataGridViewTextBoxColumn DNI;
        private DataGridViewTextBoxColumn Telefono;
        private DataGridViewTextBoxColumn Domicilio;
        private DataGridViewTextBoxColumn Correo;
        private DataGridViewTextBoxColumn Sueldo;
        private DataGridViewTextBoxColumn Cargo;
        private DataGridViewTextBoxColumn Estado;
        private DataGridViewTextBoxColumn ReservasRealizadas;
    }
}