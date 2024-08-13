using AgenciaViajes_BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgenciaViajes_GUI
{
    public partial class EmpleadoMan01 : Form
    {
        EmpleadoBL objEmpleadoBL = new EmpleadoBL();
        DataView dtv;
        public EmpleadoMan01()
        {
            InitializeComponent();
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CargarDatos(txtFiltro.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void CargarDatos(String strFiltro)
        {
            dtv = new DataView(objEmpleadoBL.ListarEmpleado());
            dtv.RowFilter = "NombreEmpleado like '%" + strFiltro + "%'";
            dtgDatos.DataSource = dtv;
            lblRegistros.Text = dtgDatos.Rows.Count.ToString();

        }

        private void EmpleadosMan01_Load(object sender, EventArgs e)
        {
            dtgDatos.AutoGenerateColumns = false;
            CargarDatos("");
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                EmpleadoMan02 objempleadoMan02 = new EmpleadoMan02();
                objempleadoMan02.ShowDialog();
                CargarDatos(txtFiltro.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);

            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                EmpleadoMan03 objEmpMan03 = new EmpleadoMan03();
                objEmpMan03.Codigo = dtgDatos.CurrentRow.Cells[0].Value.ToString();
                objEmpMan03.ShowDialog();

                dtv = new DataView(objEmpleadoBL.ListarEmpleado());
                CargarDatos(txtFiltro.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }
    }
}
