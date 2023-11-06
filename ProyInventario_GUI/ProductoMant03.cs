using ProyInventario_BE;
using ProyInventario_BL;
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

namespace ProyInventario_GUI
{
    public partial class ProductoMant03 : Form
    {
        ProductoBL objProductoBL = new ProductoBL();
        ProductoBE objProductoBE = new ProductoBE();
        UnidadMedidaBL objUnidadMedidaBL = new UnidadMedidaBL();
        CategoriaBL objCategoriaBL = new CategoriaBL();

        public ProductoMant03()
        {
            InitializeComponent();
        }

        public String Codigo { get; set; }

        private void ProductoMant03_Load(object sender, EventArgs e)
        {
            try
            {
                // Cargamos los combos...
                DataTable dt = objUnidadMedidaBL.ListarUM();
                DataRow dr;
                dr = dt.NewRow();
                dr["Cod_uni"] = 0;
                dr["Dscp_uni"] = "--Seleccione una opcion--";
                dt.Rows.InsertAt(dr, 0);
                cboUM.DataSource = dt;
                cboUM.ValueMember = "Cod_uni";
                cboUM.DisplayMember = "Dscp_uni";

                // Codifique                

                objProductoBE = objProductoBL.ConsultarProducto(this.Codigo);

                // Mostramos sus datos...
                lblCod.Text = objProductoBE.Cod_pro.ToString();
                txtDescripcion.Text = objProductoBE.Dscp_pro;
                txtPrecio.Text = objProductoBE.Pre_pro.ToString();
                txtStkAct.Text = objProductoBE.Stk_act.ToString();
                txtStkMin.Text = objProductoBE.Stk_min.ToString();

                chkActivo.Checked = Convert.ToBoolean(objProductoBE.Estd_pro);
                // Mostramos categoria y UM
                CargarCategoria(objProductoBE.Cod_area.ToString(), objProductoBE.Cod_sec.ToString(), objProductoBE.Cod_lin.ToString(), objProductoBE.Cod_fam.ToString(), objProductoBE.Cod_sub.ToString());


                cboUM.SelectedValue = objProductoBE.Cod_uni;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void CargarCategoria(String strCodArea, String strCodSec, String strCodLin, String strCodFam, String strCodSubfam)
        {
            CategoriaBL objCategoriaBL = new CategoriaBL();

            cboArea.DataSource = objCategoriaBL.Producto_Area();
            cboArea.ValueMember = "Cod_area";
            cboArea.DisplayMember = "Dscp_area";
            cboArea.SelectedValue = strCodArea;

            cboSeccion.DataSource = objCategoriaBL.Producto_SeccionArea(strCodArea);
            cboSeccion.ValueMember = "Cod_sec";
            cboSeccion.DisplayMember = "Dscp_sec";
            cboSeccion.SelectedValue = strCodSec;

            cboLinea.DataSource = objCategoriaBL.Producto_LineaSeccionArea(strCodArea, strCodSec);
            cboLinea.ValueMember = "Cod_lin";
            cboLinea.DisplayMember = "Dscp_lin";
            cboLinea.SelectedValue = strCodLin;

            cboFamilia.DataSource = objCategoriaBL.Producto_FamiliaLineaSeccionArea(strCodArea, strCodSec, strCodLin);
            cboFamilia.ValueMember = "Cod_fam";
            cboFamilia.DisplayMember = "Dscp_fam";
            cboFamilia.SelectedValue = strCodFam;

            cboSubFamilia.DataSource = objCategoriaBL.Producto_SubFamiliafamiliaLineaSeccionArea(strCodArea, strCodSec, strCodLin, strCodFam);
            cboSubFamilia.ValueMember = "Cod_sub";
            cboSubFamilia.DisplayMember = "Dscp_sub";
            cboSubFamilia.SelectedValue = strCodSubfam;
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDescripcion.Text.Trim() == String.Empty)
                {
                    throw new Exception("La descripcion es obligatoria");
                }

                if (cboUM.SelectedIndex == 0)
                {
                    throw new Exception("Debe seleccionar unidad de medida");
                }

                if (cboArea.SelectedIndex == -1)
                {
                    throw new Exception("Debe seleccionar una Area");
                }

                if (cboSeccion.SelectedIndex == -1)
                {
                    throw new Exception("Debe seleccionar una Seccion");
                }
                if (cboLinea.SelectedIndex == -1)
                {
                    throw new Exception("Debe seleccionar una Linea");
                }
                if (cboFamilia.SelectedIndex == -1)
                {
                    throw new Exception("Debe seleccionar una Familia");
                }
                if (cboSubFamilia.SelectedIndex == -1)
                {
                    throw new Exception("Debe seleccionar una Subfamilia");
                }

                // Cargamos la cantidad de negocio
                objProductoBE.Dscp_pro = txtDescripcion.Text;
                objProductoBE.Pre_pro = Convert.ToSingle(txtPrecio.Text.Trim());
                objProductoBE.Stk_act = Convert.ToInt16(txtStkAct.Text.Trim());
                objProductoBE.Stk_min = Convert.ToInt16(txtStkMin.Text.Trim());
                if (chkActivo.Checked == true)
                {
                    objProductoBE.Estd_pro = 1;
                }
                else
                {
                    objProductoBE.Estd_pro = 0;
                }
                objProductoBE.Cod_area = cboArea.SelectedValue.ToString();
                objProductoBE.Cod_sec = cboSeccion.SelectedValue.ToString();
                objProductoBE.Cod_lin = cboLinea.SelectedValue.ToString();
                objProductoBE.Cod_fam = cboFamilia.SelectedValue.ToString();
                objProductoBE.Cod_sub = cboSubFamilia.SelectedValue.ToString();
                objProductoBE.Cod_uni = cboUM.SelectedValue.ToString();
                objProductoBE.Usu_Ult_Mod = clsCredenciales.Usuario;

                // Actualizamos el registro...
                if (objProductoBL.ActualizarProducto(objProductoBE) == true)
                {
                    // Si se inserto el registro, cerramos el formulario..
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

        private void txtStkAct_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar)
                    || e.KeyChar == (char)Keys.Back);
        }

        private void cboArea_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CargarCategoria(cboArea.SelectedValue.ToString(), "", "", "", "");
        }

        private void cboSeccion_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CargarCategoria(cboArea.SelectedValue.ToString(), cboSeccion.SelectedValue.ToString(), "", "", "");
        }

        private void cboLinea_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CargarCategoria(cboArea.SelectedValue.ToString(), cboSeccion.SelectedValue.ToString(), cboLinea.SelectedValue.ToString(), "", "");
        }

        private void cboFamilia_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CargarCategoria(cboArea.SelectedValue.ToString(), cboSeccion.SelectedValue.ToString(), cboLinea.SelectedValue.ToString(), cboFamilia.SelectedValue.ToString(), "");
        }
    }
}
