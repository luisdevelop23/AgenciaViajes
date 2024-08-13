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
    public partial class HotelMan03 : Form
    {
        HotelBL objHotelBL = new HotelBL();
        HotelBE objHotelBE = new HotelBE();
        public HotelMan03()
        {
            InitializeComponent();
        }

        public String Codigo { get; set; }

        private void HotelMan03_Load(object sender, EventArgs e)
        {
            try
            {
                objHotelBE = objHotelBL.ConsultarHotel(this.Codigo);
                //Mostramos sus datos...
                lblCodigo.Text = objHotelBE.Cod_hot;
                txtNombre.Text = objHotelBE.Nom_hot;
                txtDireccion.Text = objHotelBE.Dir_hot;
                txtPais.Text = objHotelBE.Pai_hot;
                txtCiudad.Text = objHotelBE.Ciu_hot;
                txtPrecio.Text = objHotelBE.Pre_hab.ToString();
                chkEstado.Checked = Convert.ToBoolean(objHotelBE.Est_hot);

                Int16 cat = objHotelBE.Cat_hot;
                if (cat == 1)
                {
                    cboCat.SelectedIndex = 0;
                }
                else if (cat == 2)
                {
                    cboCat.SelectedIndex = 1;
                }
                else if (cat == 3)
                {
                    cboCat.SelectedIndex = 2;
                }
                else if (cat == 4)
                {
                    cboCat.SelectedIndex = 3;
                }
                else if (cat == 5)
                {
                    cboCat.SelectedIndex = 4;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }

        }



        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtNombre.Text.Trim() == String.Empty)
                {
                    throw new Exception("El nombre es obligatorio");
                }
                if (txtDireccion.Text.Trim() == String.Empty)
                {
                    throw new Exception("La dirección es obligatoria");
                }
                if (txtPais.Text.Trim() == String.Empty)
                {
                    throw new Exception("El pais es obligatorio");
                }

                objHotelBE.Cod_hot = lblCodigo.Text;
                objHotelBE.Nom_hot = txtNombre.Text;
                objHotelBE.Dir_hot = txtDireccion.Text;
                objHotelBE.Pai_hot = txtPais.Text;
                objHotelBE.Ciu_hot = txtCiudad.Text;
                objHotelBE.Pre_hab = Convert.ToSingle(txtPrecio.Text.Trim());
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

                objHotelBE.Usu_Ult_mod = clsCredenciales.Usuario;
                if (chkEstado.Checked == true)
                {
                    objHotelBE.Est_hot = 1;
                }
                else
                {
                    objHotelBE.Est_hot = 0;
                }

                //Insertamos el registro...
                if (objHotelBL.ActualizarHotel(objHotelBE) == true)
                {
                    //Si se actualizo el registro cerramos el formulario...
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