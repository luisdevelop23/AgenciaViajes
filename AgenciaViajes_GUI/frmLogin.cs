using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AgenciaViajes_BE;
using AgenciaViajes_BL;

namespace AgenciaViajes_GUI
{
    public partial class frmLogin : Form
    {
        Int16 intentos = 0;
        Int16 tiempo = 30;
        UsuarioBE objUsuarioBE = new UsuarioBE();
        UsuarioBL objUsuarioBL = new UsuarioBL();

        public frmLogin()
        {
            InitializeComponent();
        }

        private void ValidarAccesos()
        {
            if (intentos == 3)
            {
                MessageBox.Show("Ha sobrepasado el numero de intentos",
                    "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtUser.Text.Trim() != String.Empty & txtPassword.Text.Trim() != String.Empty)
            {
                objUsuarioBE = objUsuarioBL.ConsultarUsuario(txtUser.Text.Trim());

                if (objUsuarioBE.Login_Usuario == null)
                {
                    MessageBox.Show("Usuario no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    intentos += 1;
                    ValidarAccesos();
                }
                else if (objUsuarioBE.Est_Usuario == 0)
                {
                    MessageBox.Show("El Usuario no tiene permiso de ingreso porque esta inactivo", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    intentos += 1;
                    ValidarAccesos();
                }
                else if (objUsuarioBE.Login_Usuario == txtUser.Text.Trim() && objUsuarioBE.Pass_Usuario == txtPassword.Text.Trim())
                {
                    this.Hide();
                    timer1.Enabled = false;
                    clsCredenciales.Usuario = objUsuarioBE.Login_Usuario;
                    clsCredenciales.Password = objUsuarioBE.Pass_Usuario;
                    clsCredenciales.Nivel = objUsuarioBE.Niv_Usuario;
                    clsCredenciales.Estado = objUsuarioBE.Est_Usuario;
                    MDIPrincipal mdi = new MDIPrincipal();
                    mdi.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Usuario o Password incorrectos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    intentos += 1;
                    ValidarAccesos();

                }
            }
            else
            {
                MessageBox.Show("Usuario o Password obligatorios", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                intentos += 1;
                ValidarAccesos();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            Application.Exit();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tiempo -= 1;
            this.Text = "Ingrese su usuario y contraseña. Le quedan..." + tiempo;
            if (tiempo == 0)
            {
                MessageBox.Show("Lo sentimos, sobrepaso el tiempo de espera",
                    "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();
            }

        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer1.Enabled = false;
            Application.Exit();
        }

        private void frmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAceptar.PerformClick();
            }
        }
    }
}
