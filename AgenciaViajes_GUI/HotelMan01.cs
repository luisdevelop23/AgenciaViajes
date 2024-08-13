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
    public partial class HotelMan01 : Form
    {
        HotelBL objHotelBL = new HotelBL();
        DataView dtv;
        public HotelMan01()
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
            dtv = new DataView(objHotelBL.ListarHotel());
            dtv.RowFilter = "Nom_hot like '%" + strFiltro + "%'";
            dtgDatos.DataSource = dtv;
            lblRegistros.Text = dtgDatos.Rows.Count.ToString();

        }

        private void HotelMan01_Load(object sender, EventArgs e)
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
                HotelMan02 objHotMan02 = new HotelMan02();
                objHotMan02.ShowDialog();

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
                HotelMan03 objHotMan03 = new HotelMan03();
                objHotMan03.Codigo = dtgDatos.CurrentRow.Cells[0].Value.ToString();
                objHotMan03.ShowDialog();

                dtv = new DataView(objHotelBL.ListarHotel());
                CargarDatos(txtFiltro.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

    }
}




