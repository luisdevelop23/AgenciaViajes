using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgenciaViajes_GUI
{
    public partial class MDIPrincipal : Form
    {
        public MDIPrincipal()
        {
            InitializeComponent();
        }

        private void MDIPrincipal_Load(object sender, EventArgs e)
        {
            this.lblUser.Text = clsCredenciales.Usuario;
            if (clsCredenciales.Nivel == 1)
            {
                mantenimientosToolStripMenuItem.Visible = true;
            }
            else if (clsCredenciales.Nivel == 2)
            {
                mantenimientosToolStripMenuItem.Visible = false;
            }
        }

        private void MDIPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult vrpta;
            vrpta = MessageBox.Show("Seguro de salir del aplicativo?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (vrpta == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void MDIPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClienteMan01 objClie01 = new ClienteMan01();
            objClie01.MdiParent = this;
            objClie01.Show();
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmpleadoMan01 objEmpl01 = new EmpleadoMan01();
            objEmpl01.MdiParent = this;
            objEmpl01.Show();
        }

        private void hotelesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HotelMan01 objHotel01 = new HotelMan01();
            objHotel01.MdiParent = this;
            objHotel01.Show();
        }

        private void actividadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActividadMan01 objAct01 = new ActividadMan01();
            objAct01.MdiParent = this;
            objAct01.Show();
        }

        private void salirDelSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
