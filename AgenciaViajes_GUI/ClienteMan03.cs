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
using AgenciaViajes_BE;

namespace AgenciaViajes_GUI
{
    public partial class ClienteMan03 : Form
    {
        ClienteBL objClienteBL = new ClienteBL();
        ClienteBE objClienteBE = new ClienteBE();

        public ClienteMan03()
        {
            InitializeComponent();
        }

        public String Codigo { get; set; }

        private void ClienteMan03_Load(object sender, EventArgs e)
        {
            try
            {
                objClienteBE = objClienteBL.ConsultarCliente(this.Codigo);

                lblCod.Text = objClienteBE.Cod_cli;
                txtNombre.Text = objClienteBE.Nom_cli;
                txtApellido.Text = objClienteBE.Ape_cli;
                mskDNI.Text = objClienteBE.Dni_cli;
                txtTelefono.Text = objClienteBE.Tef_cli;
                txtDireccion.Text = objClienteBE.Dir_cli;
                txtEmail.Text = objClienteBE.Cor_cli;
                chkEstado.Checked = Convert.ToBoolean(objClienteBE.Est_cli);
                String Id_Ubigeo = objClienteBE.Id_ubi;

                CargarUbigeo(Id_Ubigeo.Substring(0, 2), Id_Ubigeo.Substring(2, 2), Id_Ubigeo.Substring(4, 2));

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

        private void CargarUbigeo(String Id_dep, String Id_pro, String Id_dis)
        {
            UbigeoBL objUbigeoBL = new UbigeoBL();
            cboDepartamento.DataSource = objUbigeoBL.Ubigeo_Departamentos();
            cboDepartamento.ValueMember = "Id_dep";
            cboDepartamento.DisplayMember = "Departamento";
            cboDepartamento.SelectedValue = Id_dep;

            cboProvincia.DataSource = objUbigeoBL.Ubigeo_ProvinciasDepartamento(Id_dep);
            cboProvincia.ValueMember = "Id_pro";
            cboProvincia.DisplayMember = "Provincia";
            cboProvincia.SelectedValue = Id_pro;

            cboDistrito.DataSource = objUbigeoBL.Ubigeo_DistritosProvinciaDepartamento(Id_dep, Id_pro);
            cboDistrito.ValueMember = "Id_dis";
            cboDistrito.DisplayMember = "Distrito";
            cboDistrito.SelectedValue = Id_dis;
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNombre.Text.Trim() == String.Empty)
                {
                    throw new Exception("Por favor, ingrese sus nombres.");
                }
                if (txtApellido.Text.Trim() == String.Empty)
                {
                    throw new Exception("Por favor, ingrese sus apellidos.");
                }
                if (mskDNI.MaskFull == false)
                {
                    throw new Exception("El DNI debe tener 8 caracteres.");
                }
                objClienteBE.Cod_cli = lblCod.Text;
                objClienteBE.Nom_cli = txtNombre.Text;
                objClienteBE.Ape_cli = txtApellido.Text;
                objClienteBE.Dni_cli = mskDNI.Text;
                objClienteBE.Tef_cli = txtTelefono.Text;
                objClienteBE.Dir_cli = txtDireccion.Text;
                objClienteBE.Cor_cli = txtEmail.Text;

                objClienteBE.Id_ubi = cboDepartamento.SelectedValue.ToString() + cboProvincia.SelectedValue.ToString() + cboDistrito.SelectedValue.ToString();
                if (chkEstado.Checked == true)
                {
                    objClienteBE.Est_cli = 1;
                }
                else
                {
                    objClienteBE.Est_cli = 0;

                }
                objClienteBE.Usu_ult_mod = clsCredenciales.Usuario;

                if (objClienteBL.ActualizarCliente(objClienteBE) == true)
                {
                    this.Close();
                }
                else
                {
                    throw new Exception("El registro no se inserto.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ha producido un error: " + ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboDepartamento_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CargarUbigeo(cboDepartamento.SelectedValue.ToString(), "01", "01");

        }

        private void cboProvincia_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CargarUbigeo(cboDepartamento.SelectedValue.ToString(), cboProvincia.SelectedValue.ToString(), "01");

        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Ignorar el carácter ingresado
            }

            // Verificar la longitud actual del texto en el TextBox
            if (txtTelefono.Text.Length >= 9 && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Ignorar el carácter ingresado si se alcanzó el límite de 9 dígitos
            }
        }
    }
}
