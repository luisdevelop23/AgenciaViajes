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

    public partial class ActividadMan02 : Form
    {
        ActividadBL objActividadBL = new ActividadBL();
        ActividadBE objActividadBE = new ActividadBE();
        public ActividadMan02()
        {
            InitializeComponent();
        }

        private void ActividadMan02_Load(object sender, EventArgs e)
        {

        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtDescripcion.Text.Trim() == String.Empty)
                {
                    throw new Exception("La descripcion es obligatoria");
                }
                if (txtNombre.Text.Trim() == String.Empty)
                {
                    throw new Exception("El nombre es obligatorio");
                }
                if (txtLugar.Text.Trim() == String.Empty)
                {
                    throw new Exception("El lugar es obligatorio");
                }
                if (txtPais.Text.Trim() == String.Empty)
                {
                    throw new Exception("El pais es obligatorio");
                }
                //Cargamos la Entidad de negocio
                objActividadBE.Des_act = txtDescripcion.Text;
                objActividadBE.Nom_act = txtNombre.Text;
                objActividadBE.Pre_per_act = Convert.ToSingle(txtPrecio.Text.Trim());
                objActividadBE.Lug_act = txtLugar.Text;
                objActividadBE.Pai_act = txtPais.Text;

                if (chkEstado.Checked == true)
                {
                    objActividadBE.Est_act = 1;
                }
                else
                {
                    objActividadBE.Est_act = 0;
                }
                objActividadBE.Usu_Reg = clsCredenciales.Usuario;

                //Insertamos el registro...
                if (objActividadBL.InsertarActividad(objActividadBE) == true)
                {
                    //Si se inserto el registro cerramos el formulario...
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

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            CultureInfo cc = System.Threading.Thread.CurrentThread.CurrentCulture;

            e.Handled = !(char.IsDigit(e.KeyChar)
                    || e.KeyChar == (char)Keys.Back
                    || e.KeyChar.ToString() == cc.NumberFormat.NumberDecimalSeparator);
        }
    }
}

