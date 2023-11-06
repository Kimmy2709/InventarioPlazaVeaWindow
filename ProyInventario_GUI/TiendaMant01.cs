using ProyInventario_BL;
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
    public partial class TiendaMant01 : Form
    {
        TiendaBL objTiendaBL = new TiendaBL();
        DataView dtv;

        public TiendaMant01()
        {

            InitializeComponent();
        }

        public void CargarDatos(String strFiltro)
        {
            // Construimos el objeto DataView dtv en base al DataTable devuelto por el metodo ListarProveedor
            // Y lo filtramos de acuerdo al parametro strFiltro
            dtv = new DataView(objTiendaBL.ListarTienda());
            dtv.RowFilter = "Nom_tiend like '%" + strFiltro + "%'";
            dtgDatos.DataSource = dtv;
            lblRegistros.Text = dtgDatos.Rows.Count.ToString();
        }

        private void TiendaMant01_Load(object sender, EventArgs e)
        {
            try
            {
                dtgDatos.AutoGenerateColumns = false;
                CargarDatos(String.Empty);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                TiendaMant02 objTiendaMant02 = new TiendaMant02();
                objTiendaMant02.ShowDialog();

                // Al retornar, refrescamos la vista y cargamos los datos para visualizar
                CargarDatos(txtFiltro.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

            try
            {
                TiendaMant03 objTiendaMant03 = new TiendaMant03();
                objTiendaMant03.Codigo = dtgDatos.CurrentRow.Cells[0].Value.ToString();
                objTiendaMant03.ShowDialog();

                CargarDatos(txtFiltro.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
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
    }
}
