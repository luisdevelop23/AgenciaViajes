using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AgenciaViajes_ADO;
using AgenciaViajes_BL;

namespace AgenciaViajes_GUI
{
    public partial class ClienteMan01 : Form
    {
        ClienteBL objClienteBL = new ClienteBL();
        DataView dtv;

        public ClienteMan01()
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
            dtv = new DataView(objClienteBL.ListarCliente());
            dtv.RowFilter = "Ape_cli like '%" + strFiltro + "%'";
            dtgDatos.DataSource = dtv;
            lblRegistros.Text = dtgDatos.Rows.Count.ToString();

        }

        private void ClienteMan01_Load(object sender, EventArgs e)
        {
            dtgDatos.AutoGenerateColumns = false;
            CargarDatos("");
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                ClienteMan03 objCliMan03 = new ClienteMan03();
                objCliMan03.Codigo = dtgDatos.CurrentRow.Cells[0].Value.ToString();
                objCliMan03.ShowDialog();

                dtv = new DataView(objClienteBL.ListarCliente());
                CargarDatos(txtFiltro.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                ClienteMan02 objCliMan02 = new ClienteMan02();
                objCliMan02.ShowDialog();

                CargarDatos(txtFiltro.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }

        }

    }
}
