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
    public partial class EmpleadoMan02 : Form
    {
        EmpleadoBL objEmpleadoBL = new EmpleadoBL();
        EmpleadoBE objEmpleadoBE = new EmpleadoBE();

        public EmpleadoMan02()
        {
            InitializeComponent();
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
        private void EmpleadoMan02_Load(object sender, EventArgs e)
        {
            //CARGAMOS LOS COMBOX
            cboCargo.SelectedIndex = 0;
            //CARGA EL COMBOX DE LOS SUPERVISORES
            SupervisorBL objsupervisorBL = new SupervisorBL();
            cboSupervisor.DataSource = objsupervisorBL.ListarSupervisor();
            cboSupervisor.ValueMember = "Cod_emp";
            cboSupervisor.DisplayMember = "NombreEmpleado";
            //cboSupervisor.SelectedValue = Id_emp;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
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
                objEmpleadoBE.Nom_emp = txtNombre.Text.Trim();
                objEmpleadoBE.Ape_emp = txtApellido.Text.Trim();
                objEmpleadoBE.Dni_emp = mskDNI.Text.Trim();
                objEmpleadoBE.Tef_emp = txtTelefono.Text.Trim();
                objEmpleadoBE.Dir_emp = txtDireccion.Text.Trim();
                objEmpleadoBE.Cor_emp = txtEmail.Text.Trim();
                objEmpleadoBE.Sue_emp = txtSueldo.Text.Trim();
                if (cboCargo.SelectedIndex == 0)
                {
                    objEmpleadoBE.Car_emp = 1;
                }
                else if (cboCargo.SelectedIndex == 1)
                {
                    objEmpleadoBE.Car_emp = 3;
                }
                objEmpleadoBE.Cod_sup = cboSupervisor.SelectedValue.ToString();

                objEmpleadoBE.Usu_reg = clsCredenciales.Usuario;
                if (chkEstado.Checked == true)
                {
                    objEmpleadoBE.Est_emp = 1;
                }
                else
                {
                    objEmpleadoBE.Est_emp = 0;

                }
                if (objEmpleadoBL.InsertarEmpleado(objEmpleadoBE) == true)
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
    }
}
