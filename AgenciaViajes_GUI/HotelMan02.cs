using AgenciaViajes_BE;
using AgenciaViajes_BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgenciaViajes_GUI
{

    public partial class HotelMan02 : Form
    {
        HotelBL objHotelBL = new HotelBL();
        HotelBE objHotelBE = new HotelBE();
        public HotelMan02()
        {
            InitializeComponent();
        }

        private void HotelMan02_Load(object sender, EventArgs e)
        {
            cboCat.SelectedIndex = 0;
        }
        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtNombre.Text.Trim() == String.Empty)
                {
                    throw new Exception("El nombre es obligatoria");
                }
                if (txtDirección.Text.Trim() == String.Empty)
                {
                    throw new Exception("La dirección es obligatorio");
                }
                if (txtPrecio.Text.Trim() == String.Empty)
                {
                    throw new Exception("El usuario es obligatorio");
                }
                if (txtCiudad.Text.Trim() == String.Empty)
                {
                    throw new Exception("La Ciudad es obligatorio");
                }

                objHotelBE.Nom_hot = txtNombre.Text;
                objHotelBE.Dir_hot = txtDirección.Text;
                objHotelBE.Pai_hot = txtPais.Text;
                objHotelBE.Ciu_hot = txtCiudad.Text;
                objHotelBE.Pre_hab = Convert.ToSingle(txtPrecio.Text.Trim());
                /*objHotelBE.Cat_hot = Convert.ToInt16(cboCat.SelectedValue);*/
                if (cboCat.SelectedIndex == 0)
                {
                    objHotelBE.Cat_hot = 1;
                }
                else if (cboCat.SelectedIndex == 1)
                {
                    objHotelBE.Cat_hot = 2;
                }
                else if (cboCat.SelectedIndex == 2)
                {
                    objHotelBE.Cat_hot = 3;
                }
                else if (cboCat.SelectedIndex == 3)
                {
                    objHotelBE.Cat_hot = 4;
                }
                else if (cboCat.SelectedIndex == 4)
                {
                    objHotelBE.Cat_hot = 5;
                }
                objHotelBE.Usu_reg = clsCredenciales.Usuario;
                if (chkEstado.Checked == true)
                {
                    objHotelBE.Est_hot = 1;
                }
                else
                {
                    objHotelBE.Est_hot = 0;
                }
                if (objHotelBL.InsertarHotel(objHotelBE) == true)
                {
                    this.Close();
                }
                else
                {
                    throw new Exception("Registro no se inserto, contacte con el area de TI");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}