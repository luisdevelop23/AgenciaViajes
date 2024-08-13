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
    public partial class EmpleadoMan03 : Form
    {
        EmpleadoBL objempleadoBL = new EmpleadoBL();
        EmpleadoBE objempleadoBE = new EmpleadoBE();

        public EmpleadoMan03()
        {
            InitializeComponent();
        }
        public String Codigo { get; set; }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si la tecla presionada no es un dígito o la tecla de retroceso
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

        private void EmpleadoMan03_Load(object sender, EventArgs e)
        {
            try
            {
                //RELLENAR LOS DATOS
                objempleadoBE = objempleadoBL.ConsultarEmpleado(this.Codigo);
                lblCod.Text = objempleadoBE.Cod_emp;
                txtNombre.Text = objempleadoBE.Nom_emp;
                txtApellido.Text = objempleadoBE.Ape_emp;
                mskDNI.Text = objempleadoBE.Dni_emp;
                txtTelefono.Text = objempleadoBE.Tef_emp;
                txtDireccion.Text = objempleadoBE.Dir_emp;
                txtEmail.Text = objempleadoBE.Cor_emp;
                txtSueldo.Text = objempleadoBE.Sue_emp;
                chkEstado.Checked = Convert.ToBoolean(objempleadoBE.Est_emp);

                //COMBO BOX RELLENAR
                SupervisorBL objsupervisorBL = new SupervisorBL();
                cboSupervisor.DataSource = objsupervisorBL.ListarSupervisor();
                cboSupervisor.ValueMember = "Cod_emp";
                cboSupervisor.DisplayMember = "NombreEmpleado";

                string codSupervisor = objempleadoBE.Cod_sup;
                int index = cboSupervisor.FindStringExact(codSupervisor);
                if (index != -1)
                {
                    cboSupervisor.SelectedIndex = index;
                }

                Int16 cargo = objempleadoBE.Car_emp;
                if (cargo == 3)
                {
                    cboCargo.SelectedIndex = 1;
                }
                else if (cargo == 1)
                {
                    cboCargo.SelectedIndex = 0;
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
                objempleadoBE.Cod_emp = lblCod.Text;
                objempleadoBE.Nom_emp = txtNombre.Text.Trim();
                objempleadoBE.Ape_emp = txtApellido.Text.Trim();
                objempleadoBE.Dni_emp = mskDNI.Text.Trim();
                objempleadoBE.Tef_emp = txtTelefono.Text.Trim();
                objempleadoBE.Dir_emp = txtDireccion.Text.Trim();
                objempleadoBE.Cor_emp = txtEmail.Text.Trim();
                objempleadoBE.Sue_emp = txtSueldo.Text.Trim();
                objempleadoBE.Usu_ult_mod = clsCredenciales.Usuario;
                if (cboCargo.SelectedIndex == 0)
                {
                    objempleadoBE.Car_emp = 1;
                }
                else if (cboCargo.SelectedIndex == 1)
                {
                    objempleadoBE.Car_emp = 3;
                }
                objempleadoBE.Cod_sup = cboSupervisor.SelectedValue.ToString();

                if (chkEstado.Checked == true)
                {
                    objempleadoBE.Est_emp = 1;
                }
                else
                {
                    objempleadoBE.Est_emp = 0;

                }
                if (objempleadoBL.ActualizarEmpleado(objempleadoBE) == true)
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
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
