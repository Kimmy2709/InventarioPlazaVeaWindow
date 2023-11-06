using ProyInventario_BE;
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
    public partial class TiendaMant02 : Form
    {
        TiendaBE objTiendaBE = new TiendaBE();
        TiendaBL objTiendaBL = new TiendaBL();
        UbigeoBL objUbigeoBl = new UbigeoBL();
        public TiendaMant02()
        {
            InitializeComponent();
        }

        private void TiendaMant02_Load(object sender, EventArgs e)
        {
            try
            {
                CargarUbigeo("14", "01", "01");

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
                if (txtNom.Text.Trim() == String.Empty)
                {
                    throw new Exception("La selección es obligatoria");
                }
                if (cboDepartamento.SelectedIndex == 0)
                {
                    throw new Exception("Debe seleccionar Departamento");
                }
                if (cboProvincia.SelectedIndex == 0)
                {
                    throw new Exception("Debe seleccionar Provincia");
                }
                if (cboDistrito.SelectedIndex == 0)
                {
                    throw new Exception("Debe seleccionar Distrito");
                }
                if (mskTelf.MaskFull == false)
                {
                    throw new Exception("El telefono debe tener 9 digitos");
                }

                objTiendaBE.Nom_tiend = txtNom.Text;
                objTiendaBE.Dir_tiend = txtDir.Text;
                objTiendaBE.Telf_tiend = mskTelf.Text;
                objTiendaBE.Usu_Registro = clsCredenciales.Usuario;

                objTiendaBE.Id_Ubigeo = cboDepartamento.SelectedValue.ToString() +
                                         cboProvincia.SelectedValue.ToString() +
                                         cboDistrito.SelectedValue.ToString();

                if (chkEstado.Checked == true)
                {
                    objTiendaBE.Estd_tiend = 1;
                }
                else
                {
                    objTiendaBE.Estd_tiend = 0;
                }

                if (objTiendaBL.InsertarTienda(objTiendaBE) == true)
                {
                    //si se insertó el registro se cierra el formulario
                    this.Close();
                }
                else
                {
                    throw new Exception("Registro no insertado, contacte con el área de TI");
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

        private void CargarUbigeo(String IdDepa, String IdProv, String IdDist)
        {
            cboDepartamento.DataSource = objUbigeoBl.Ubigeo_Departamentos();
            cboDepartamento.ValueMember = "idDepa";
            cboDepartamento.DisplayMember = "Departamento";
            cboDepartamento.SelectedValue = IdDepa;

            cboProvincia.DataSource = objUbigeoBl.Ubigeo_ProvinciasDepartamento(IdDepa);
            cboProvincia.ValueMember = "idProv";
            cboProvincia.DisplayMember = "Provincia";
            cboProvincia.SelectedValue = IdProv;

            cboDistrito.DataSource = objUbigeoBl.Ubigeo_DistritosProvinciaDepartamento(IdDepa, IdProv);
            cboDistrito.ValueMember = "idDist";
            cboDistrito.DisplayMember = "Distrito";
            cboDistrito.SelectedValue = IdDist;
        }

        private void cboDepartamento_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CargarUbigeo(cboDepartamento.SelectedValue.ToString(), "01", "01");
        }

        private void cboProvincia_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CargarUbigeo(cboDepartamento.SelectedValue.ToString(), cboProvincia.SelectedValue.ToString(), "01");
        }
    }
}
