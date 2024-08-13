namespace AgenciaViajes_GUI
{
    partial class HotelMan01
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            label1 = new Label();
            txtFiltro = new TextBox();
            btnAgregar = new Button();
            btnCerrar = new Button();
            btnActualizar = new Button();
            dtgDatos = new DataGridView();
            Cod_hot = new DataGridViewTextBoxColumn();
            Nom_hot = new DataGridViewTextBoxColumn();
            Dir_hot = new DataGridViewTextBoxColumn();
            Pai_hot = new DataGridViewTextBoxColumn();
            Cat_hot = new DataGridViewTextBoxColumn();
            Pre_hab = new DataGridViewTextBoxColumn();
            Ciu_hot = new DataGridViewTextBoxColumn();
            Fec_reg = new DataGridViewTextBoxColumn();
            Usu_reg = new DataGridViewTextBoxColumn();
            Fec_Ult_mod = new DataGridViewTextBoxColumn();
            Usu_Ult_mod = new DataGridViewTextBoxColumn();
            Est_hot = new DataGridViewTextBoxColumn();
            label2 = new Label();
            lblRegistros = new Label();
            ((System.ComponentModel.ISupportInitialize)dtgDatos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 29);
            label1.Name = "label1";
            label1.Size = new Size(139, 15);
            label1.TabIndex = 0;
            label1.Text = "Ingrese filtro por nombre";
            // 
            // txtFiltro
            // 
            txtFiltro.Location = new Point(208, 25);
            txtFiltro.Margin = new Padding(3, 4, 3, 4);
            txtFiltro.Name = "txtFiltro";
            txtFiltro.Size = new Size(277, 23);
            txtFiltro.TabIndex = 1;
            txtFiltro.TextChanged += txtFiltro_TextChanged;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(664, 19);
            btnAgregar.Margin = new Padding(3, 4, 3, 4);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(102, 40);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(899, 19);
            btnCerrar.Margin = new Padding(3, 4, 3, 4);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(105, 40);
            btnCerrar.TabIndex = 4;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(783, 19);
            btnActualizar.Margin = new Padding(3, 4, 3, 4);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(97, 40);
            btnActualizar.TabIndex = 3;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // dtgDatos
            // 
            dtgDatos.AllowUserToAddRows = false;
            dtgDatos.AllowUserToDeleteRows = false;
            dtgDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgDatos.Columns.AddRange(new DataGridViewColumn[] { Cod_hot, Nom_hot, Dir_hot, Pai_hot, Cat_hot, Pre_hab, Ciu_hot, Fec_reg, Usu_reg, Fec_Ult_mod, Usu_Ult_mod, Est_hot });
            dtgDatos.Location = new Point(14, 79);
            dtgDatos.Name = "dtgDatos";
            dtgDatos.ReadOnly = true;
            dtgDatos.RowHeadersVisible = false;
            dtgDatos.RowHeadersWidth = 51;
            dtgDatos.RowTemplate.Height = 25;
            dtgDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgDatos.Size = new Size(1006, 384);
            dtgDatos.TabIndex = 5;
            // 
            // Cod_hot
            // 
            Cod_hot.DataPropertyName = "Cod_hot";
            Cod_hot.HeaderText = "Código";
            Cod_hot.Name = "Cod_hot";
            Cod_hot.ReadOnly = true;
            // 
            // Nom_hot
            // 
            Nom_hot.DataPropertyName = "Nom_hot";
            Nom_hot.HeaderText = "Nombre";
            Nom_hot.Name = "Nom_hot";
            Nom_hot.ReadOnly = true;
            // 
            // Dir_hot
            // 
            Dir_hot.DataPropertyName = "Dir_hot";
            Dir_hot.HeaderText = "Dirección";
            Dir_hot.Name = "Dir_hot";
            Dir_hot.ReadOnly = true;
            // 
            // Pai_hot
            // 
            Pai_hot.DataPropertyName = "Pai_hot";
            Pai_hot.HeaderText = "Pais";
            Pai_hot.Name = "Pai_hot";
            Pai_hot.ReadOnly = true;
            // 
            // Cat_hot
            // 
            Cat_hot.DataPropertyName = "Cat_hot";
            Cat_hot.HeaderText = "Estrellas";
            Cat_hot.Name = "Cat_hot";
            Cat_hot.ReadOnly = true;
            // 
            // Pre_hab
            // 
            Pre_hab.DataPropertyName = "Pre_hab";
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleRight;
            Pre_hab.DefaultCellStyle = dataGridViewCellStyle1;
            Pre_hab.HeaderText = "Precio";
            Pre_hab.Name = "Pre_hab";
            Pre_hab.ReadOnly = true;
            // 
            // Ciu_hot
            // 
            Ciu_hot.DataPropertyName = "Ciu_hot";
            Ciu_hot.HeaderText = "Ciudad";
            Ciu_hot.Name = "Ciu_hot";
            Ciu_hot.ReadOnly = true;
            // 
            // Fec_reg
            // 
            Fec_reg.DataPropertyName = "Fec_reg";
            Fec_reg.HeaderText = "Fecha Registro";
            Fec_reg.Name = "Fec_reg";
            Fec_reg.ReadOnly = true;
            // 
            // Usu_reg
            // 
            Usu_reg.DataPropertyName = "Usu_reg";
            Usu_reg.HeaderText = "Usuario Registrado";
            Usu_reg.Name = "Usu_reg";
            Usu_reg.ReadOnly = true;
            // 
            // Fec_Ult_mod
            // 
            Fec_Ult_mod.DataPropertyName = "Fec_Ult_mod";
            Fec_Ult_mod.HeaderText = "Fecha de Ultima Modificacion";
            Fec_Ult_mod.Name = "Fec_Ult_mod";
            Fec_Ult_mod.ReadOnly = true;
            // 
            // Usu_Ult_mod
            // 
            Usu_Ult_mod.DataPropertyName = "Usu_Ult_mod";
            Usu_Ult_mod.HeaderText = "Usuario Ultima Modificacion";
            Usu_Ult_mod.Name = "Usu_Ult_mod";
            Usu_Ult_mod.ReadOnly = true;
            // 
            // Est_hot
            // 
            Est_hot.DataPropertyName = "Est_hot";
            Est_hot.HeaderText = "Estado";
            Est_hot.Name = "Est_hot";
            Est_hot.ReadOnly = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(866, 487);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 4;
            label2.Text = "Registros:";
            // 
            // lblRegistros
            // 
            lblRegistros.BorderStyle = BorderStyle.FixedSingle;
            lblRegistros.Location = new Point(930, 481);
            lblRegistros.Name = "lblRegistros";
            lblRegistros.Size = new Size(90, 27);
            lblRegistros.TabIndex = 5;
            lblRegistros.TextAlign = ContentAlignment.MiddleRight;
            // 
            // HotelMan01
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1036, 526);
            Controls.Add(lblRegistros);
            Controls.Add(label2);
            Controls.Add(dtgDatos);
            Controls.Add(btnActualizar);
            Controls.Add(btnCerrar);
            Controls.Add(btnAgregar);
            Controls.Add(txtFiltro);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "HotelMan01";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mantenimiento de Hoteles";
            Load += HotelMan01_Load;
            ((System.ComponentModel.ISupportInitialize)dtgDatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private Label label1;
        private TextBox txtFiltro;
        private Button btnAgregar;
        private Button btnCerrar;
        private Button btnActualizar;
        private DataGridView dtgDatos;
        private Label label2;
        private Label lblRegistros;
        private DataGridViewTextBoxColumn Cod_hot;
        private DataGridViewTextBoxColumn Nom_hot;
        private DataGridViewTextBoxColumn Dir_hot;
        private DataGridViewTextBoxColumn Pai_hot;
        private DataGridViewTextBoxColumn Cat_hot;
        private DataGridViewTextBoxColumn Pre_hab;
        private DataGridViewTextBoxColumn Ciu_hot;
        private DataGridViewTextBoxColumn Fec_reg;
        private DataGridViewTextBoxColumn Usu_reg;
        private DataGridViewTextBoxColumn Fec_Ult_mod;
        private DataGridViewTextBoxColumn Usu_Ult_mod;
        private DataGridViewTextBoxColumn Est_hot;
    }
}