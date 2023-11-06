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
    public partial class ProductoMant01 : Form
    {
        ProductoBL objProductoBL = new ProductoBL();
        DataView dtv;
        public ProductoMant01()
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
            dtv = new DataView(objProductoBL.ListarProducto());
            dtv.RowFilter = "Dscp_pro like '%" + strFiltro + "%'";
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
            ProductoMant02 objProductoMant02 = new ProductoMant02();
            objProductoMant02.ShowDialog();

            // Al regresar refrescamos el datagrid...
            CargarDatos(txtFiltro.Text.Trim());
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                ProductoMant03 objProductoMant03 = new ProductoMant03();
                objProductoMant03.Codigo = dtgDatos.CurrentRow.Cells[0].Value.ToString();
                objProductoMant03.ShowDialog();

                // Al regresar refrescamos el datagrid...
                CargarDatos(txtFiltro.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }
    }
}
