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
    public partial class ProveedorMant03 : Form
    {
        ProveedorBE objProveedorBE = new ProveedorBE();
        ProveedorBL objProveedorBL = new ProveedorBL();
        UbigeoBL objUbigeoBl = new UbigeoBL();
        public ProveedorMant03()
        {
            InitializeComponent();
        }
        public String Codigo { get; set; }

        private void ProveedorMant03_Load(object sender, EventArgs e)
        {
            try
            {
                objProveedorBE = objProveedorBL.ConsultarProveedor(this.Codigo);

                lblCod.Text = objProveedorBE.Cod_prov;
                txtRaz.Text = objProveedorBE.Raz_soc_prov;
                mskRuc.Text = objProveedorBE.Ruc_prov;
                txtDir.Text = objProveedorBE.Dir_prov;
                mskTelf.Text = objProveedorBE.Telf_prov;
                txtEmail.Text = objProveedorBE.Email_prov;

                chkEstado.Checked = Convert.ToBoolean(objProveedorBE.Estd_prov);

                String Id_Ubigeo = objProveedorBE.Id_Ubigeo;
                CargarUbigeo(Id_Ubigeo.Substring(0, 2), Id_Ubigeo.Substring(2, 2), Id_Ubigeo.Substring(4, 2));

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
                //validamos

                if (txtRaz.Text.Trim() == String.Empty)
                {
                    throw new Exception("La selección es obligatoria");
                }
                if (mskRuc.MaskFull == false)
                {
                    throw new Exception("El RUC debe tener 11 caracteres");
                }
                if (mskTelf.MaskFull == false)
                {
                    throw new Exception("El telefono debe tener 9 digitos");
                }

                objProveedorBE.Cod_prov = lblCod.Text;
                objProveedorBE.Ruc_prov = mskRuc.Text;
                objProveedorBE.Telf_prov = mskTelf.Text;
                objProveedorBE.Raz_soc_prov = txtRaz.Text;
                objProveedorBE.Dir_prov = txtDir.Text;
                objProveedorBE.Email_prov = txtEmail.Text;
                objProveedorBE.Usu_Ult_Mod = clsCredenciales.Usuario;
                if (chkEstado.Checked == true)
                {
                    objProveedorBE.Estd_prov = 1;
                }
                else
                {
                    objProveedorBE.Estd_prov = 0;
                }

                objProveedorBE.Id_Ubigeo = cboDepartamento.SelectedValue.ToString() +
                                         cboProvincia.SelectedValue.ToString() +
                                         cboDistrito.SelectedValue.ToString();

                //insertando registros

                if (objProveedorBL.ActualizarProveedor(objProveedorBE) == true)
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
