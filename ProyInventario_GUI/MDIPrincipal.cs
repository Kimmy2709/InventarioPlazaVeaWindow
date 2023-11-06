using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyInventario_GUI
{
    public partial class MDIPrincipal : Form
    {
        public MDIPrincipal()
        {
            InitializeComponent();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductoMant01 objProductoMant01 = new ProductoMant01();
            objProductoMant01.MdiParent = this;
            objProductoMant01.Show();
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProveedorMant01 objProveedorMant01 = new ProveedorMant01();
            objProveedorMant01.MdiParent = this;
            objProveedorMant01.Show();
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmpleadoMant01 objEmpleadoMant01 = new EmpleadoMant01();
            objEmpleadoMant01.MdiParent = this;
            objEmpleadoMant01.Show();
        }

        private void tiendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TiendaMant01 objTiendaMant01 = new TiendaMant01();
            objTiendaMant01.MdiParent = this;
            objTiendaMant01.Show();
        }

        private void MDIPrincipal_Load(object sender, EventArgs e)
        {
            this.lblUsuario.Text = clsCredenciales.Usuario;
        }

        private void MDIPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult vrpta;
            vrpta = MessageBox.Show("¿Está seguro que desea salir del aplicativo?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (vrpta == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void MDIPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void salirDelSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
