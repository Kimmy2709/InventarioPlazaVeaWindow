using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyInventario_BL;
using ProyInventario_BE;

namespace ProyInventario_GUI
{
    public partial class EmpleadoMant01 : Form
    {
        EmpleadoBL objEmpleadoBL = new EmpleadoBL();
        DataView dtv;
        public EmpleadoMant01()
        {
            InitializeComponent();
        }

        private void MDIPrincipal_Load(object sender, EventArgs e)
        {
            dtgDatos.AutoGenerateColumns = false;
            CargarDatos("");
        }

        private void CargarDatos(String strFiltro)
        {

            // Construimos  el objeto Dataview dtv  en base al DataTable devuelto por el metodo ListarProducto
            // Y lo filtramos de acuerdo al parametro strFiltro
            dtv = new DataView(objEmpleadoBL.ListarEmpleado());
            dtv.RowFilter = "Ape_emple like '%" + strFiltro + "%'";
            dtgDatos.DataSource = dtv;
            lblRegistros.Text = dtgDatos.Rows.Count.ToString();
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            try
            {
                // Pasaremos al metodo CargarDatos el texto que se va escribiendo
                // en la caja de texto 
                CargarDatos(txtFiltro.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            EmpleadoMant02 objEmpleadoMant02 = new EmpleadoMant02();
            objEmpleadoMant02.ShowDialog();

            CargarDatos(txtFiltro.Text.Trim());
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            EmpleadoMant03 objEmpleadoMant03 = new EmpleadoMant03();
            objEmpleadoMant03.Codigo = dtgDatos.CurrentRow.Cells[0].Value.ToString();
            objEmpleadoMant03.ShowDialog();

            CargarDatos(txtFiltro.Text.Trim());
        }
    }
}
