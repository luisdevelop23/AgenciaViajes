using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AgenciaViajes_BL;

namespace AgenciaViajes_GUI
{
    public partial class ActividadMan01 : Form
    {
        ActividadBL objActividadBL = new ActividadBL();
        DataView dtv;
        public ActividadMan01()
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
            dtv = new DataView(objActividadBL.ListarActividad());
            dtv.RowFilter = "Nom_act like '%" + strFiltro + "%'";
            dtgData.DataSource = dtv;
            lblRegistros.Text = dtgData.Rows.Count.ToString();

        }

        private void ActividadMan01_Load(object sender, EventArgs e)
        {
            dtgData.AutoGenerateColumns = false;
            CargarDatos("");
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                // Codifique
                ActividadMan02 objMan02 = new ActividadMan02();
                objMan02.ShowDialog();

                //Refrescamos el datagrid...
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
                // Codifique
                ActividadMan03 objMan03 = new ActividadMan03();
                objMan03.Codigo = dtgData.CurrentRow.Cells[0].Value.ToString();
                objMan03.ShowDialog();

                //Refrescamos del datagrid...
                CargarDatos(txtFiltro.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
