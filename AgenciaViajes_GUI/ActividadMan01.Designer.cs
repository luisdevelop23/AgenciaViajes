namespace AgenciaViajes_GUI
{
    partial class ActividadMan01
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
            dtgData = new DataGridView();
            Cod_act = new DataGridViewTextBoxColumn();
            Nom_Act = new DataGridViewTextBoxColumn();
            Lug_act = new DataGridViewTextBoxColumn();
            Pai_act = new DataGridViewTextBoxColumn();
            Pre_per_act = new DataGridViewTextBoxColumn();
            Des_Act = new DataGridViewTextBoxColumn();
            Usu_reg = new DataGridViewTextBoxColumn();
            Fec_reg = new DataGridViewTextBoxColumn();
            Fec_Ult_mod = new DataGridViewTextBoxColumn();
            Usu_Ult_mod = new DataGridViewTextBoxColumn();
            Est_act = new DataGridViewTextBoxColumn();
            btnAgregar = new Button();
            btnActualizar = new Button();
            btnCerrar = new Button();
            txtFiltro = new TextBox();
            lblRegistros = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dtgData).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(80, 25);
            label1.Name = "label1";
            label1.Size = new Size(142, 15);
            label1.TabIndex = 2;
            label1.Text = "Ingrese filtro por nombre:";
            // 
            // dtgData
            // 
            dtgData.AllowUserToAddRows = false;
            dtgData.AllowUserToDeleteRows = false;
            dtgData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgData.Columns.AddRange(new DataGridViewColumn[] { Cod_act, Nom_Act, Lug_act, Pai_act, Pre_per_act, Des_Act, Usu_reg, Fec_reg, Fec_Ult_mod, Usu_Ult_mod, Est_act });
            dtgData.Location = new Point(12, 72);
            dtgData.Name = "dtgData";
            dtgData.ReadOnly = true;
            dtgData.RowHeadersVisible = false;
            dtgData.RowTemplate.Height = 25;
            dtgData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgData.Size = new Size(962, 342);
            dtgData.TabIndex = 5;
            // 
            // Cod_act
            // 
            Cod_act.DataPropertyName = "Cod_act";
            Cod_act.HeaderText = "Codigo";
            Cod_act.Name = "Cod_act";
            Cod_act.ReadOnly = true;
            // 
            // Nom_Act
            // 
            Nom_Act.DataPropertyName = "Nom_act";
            Nom_Act.HeaderText = "Nombre Actividad";
            Nom_Act.Name = "Nom_Act";
            Nom_Act.ReadOnly = true;
            // 
            // Lug_act
            // 
            Lug_act.DataPropertyName = "Lug_act";
            Lug_act.HeaderText = "Lugar";
            Lug_act.Name = "Lug_act";
            Lug_act.ReadOnly = true;
            // 
            // Pai_act
            // 
            Pai_act.DataPropertyName = "Pai_act";
            Pai_act.HeaderText = "Pais";
            Pai_act.Name = "Pai_act";
            Pai_act.ReadOnly = true;
            // 
            // Pre_per_act
            // 
            Pre_per_act.DataPropertyName = "Pre_per_act";
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "N2";
            Pre_per_act.DefaultCellStyle = dataGridViewCellStyle1;
            Pre_per_act.HeaderText = "Precio Actividad";
            Pre_per_act.Name = "Pre_per_act";
            Pre_per_act.ReadOnly = true;
            // 
            // Des_Act
            // 
            Des_Act.DataPropertyName = "Des_act";
            Des_Act.HeaderText = "Descripción";
            Des_Act.Name = "Des_Act";
            Des_Act.ReadOnly = true;
            // 
            // Usu_reg
            // 
            Usu_reg.DataPropertyName = "Usu_reg";
            Usu_reg.HeaderText = "Usuario";
            Usu_reg.Name = "Usu_reg";
            Usu_reg.ReadOnly = true;
            // 
            // Fec_reg
            // 
            Fec_reg.DataPropertyName = "Fec_reg";
            Fec_reg.HeaderText = "Fecha Registro";
            Fec_reg.Name = "Fec_reg";
            Fec_reg.ReadOnly = true;
            // 
            // Fec_Ult_mod
            // 
            Fec_Ult_mod.DataPropertyName = "Fec_Ult_mod";
            Fec_Ult_mod.HeaderText = "Fecha de Ultima Modificación";
            Fec_Ult_mod.Name = "Fec_Ult_mod";
            Fec_Ult_mod.ReadOnly = true;
            // 
            // Usu_Ult_mod
            // 
            Usu_Ult_mod.DataPropertyName = "Usu_Ult_mod";
            Usu_Ult_mod.HeaderText = "Usuario Ultima Modificación";
            Usu_Ult_mod.Name = "Usu_Ult_mod";
            Usu_Ult_mod.ReadOnly = true;
            // 
            // Est_act
            // 
            Est_act.DataPropertyName = "Est_act";
            Est_act.HeaderText = "Estado";
            Est_act.Name = "Est_act";
            Est_act.ReadOnly = true;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(678, 17);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(85, 30);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(769, 17);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(85, 30);
            btnActualizar.TabIndex = 3;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(860, 17);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(85, 30);
            btnCerrar.TabIndex = 4;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // txtFiltro
            // 
            txtFiltro.Location = new Point(228, 22);
            txtFiltro.Name = "txtFiltro";
            txtFiltro.Size = new Size(243, 23);
            txtFiltro.TabIndex = 1;
            txtFiltro.TextChanged += txtFiltro_TextChanged;
            // 
            // lblRegistros
            // 
            lblRegistros.BorderStyle = BorderStyle.FixedSingle;
            lblRegistros.Location = new Point(890, 429);
            lblRegistros.Name = "lblRegistros";
            lblRegistros.Size = new Size(84, 22);
            lblRegistros.TabIndex = 11;
            lblRegistros.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(826, 433);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 10;
            label2.Text = "Registros:";
            // 
            // ActividadMan01
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(986, 465);
            Controls.Add(lblRegistros);
            Controls.Add(label2);
            Controls.Add(txtFiltro);
            Controls.Add(btnAgregar);
            Controls.Add(btnActualizar);
            Controls.Add(btnCerrar);
            Controls.Add(dtgData);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ActividadMan01";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mantenimiento de Actividades";
            Load += ActividadMan01_Load;
            ((System.ComponentModel.ISupportInitialize)dtgData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dtgData;
        private Button btnAgregar;
        private Button btnActualizar;
        private Button btnCerrar;
        private TextBox txtFiltro;
        private Label lblRegistros;
        private Label label2;
        private DataGridViewTextBoxColumn Cod_act;
        private DataGridViewTextBoxColumn Nom_Act;
        private DataGridViewTextBoxColumn Lug_act;
        private DataGridViewTextBoxColumn Pai_act;
        private DataGridViewTextBoxColumn Pre_per_act;
        private DataGridViewTextBoxColumn Des_Act;
        private DataGridViewTextBoxColumn Usu_reg;
        private DataGridViewTextBoxColumn Fec_reg;
        private DataGridViewTextBoxColumn Fec_Ult_mod;
        private DataGridViewTextBoxColumn Usu_Ult_mod;
        private DataGridViewTextBoxColumn Est_act;
    }
}