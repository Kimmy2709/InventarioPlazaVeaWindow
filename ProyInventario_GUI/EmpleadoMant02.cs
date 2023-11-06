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
    public partial class EmpleadoMant02 : Form
    {
        EmpleadoBL objEmpleadoBL = new EmpleadoBL();
        EmpleadoBE objEmpleadoBE = new EmpleadoBE();
        UbigeoBL objUbigeoBl = new UbigeoBL();
        EmpleadoTipoUsuarioBL objEmpleadoTipoUsuarioBL = new EmpleadoTipoUsuarioBL();
        public EmpleadoMant02()
        {
            InitializeComponent();
        }
        private void EmpleadoMant02_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = objEmpleadoTipoUsuarioBL.ListarTipoUsuario();
                DataRow dr;
                dr = dt.NewRow();
                dr["Tipo_Usuario"] = 0;
                dr["TipoUsuario"] = "--Seleccione una opcion--";
                dt.Rows.InsertAt(dr, 0);
                cboTipUsuario.DataSource = dt;
                cboTipUsuario.ValueMember = "Tipo_Usuario";
                cboTipUsuario.DisplayMember = "TipoUsuario";
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
                    throw new Exception("El Nombre es obligatorio");
                }
                if (mskDni.MaskFull != true)
                {
                    throw new Exception("El DNI consta de 8 caracteres");
                }
                if (mskTelf.MaskFull != true)
                {
                    throw new Exception("El Telefono tiene que contener 9 digitos");
                }
                objEmpleadoBE.Nom_emple = txtNom.Text.Trim();
                objEmpleadoBE.Ape_emple = txtApe.Text.Trim();
                objEmpleadoBE.Dni_emple = mskDni.Text;
                objEmpleadoBE.Dir_emple = txtDir.Text.Trim();
                objEmpleadoBE.Telf_emple = mskTelf.Text;
                objEmpleadoBE.Sue_emple = Convert.ToSingle(txtSue.Text.Trim());
                if (chkEstado.Checked == true)
                {
                    objEmpleadoBE.Estd_emple = 1;
                }
                else
                {
                    objEmpleadoBE.Estd_emple = 0;
                }
                objEmpleadoBE.Id_Ubigeo = cboDepartamento.SelectedValue.ToString() +
                                             cboProvincia.SelectedValue.ToString() +
                                             cboDistrito.SelectedValue.ToString();
                objEmpleadoBE.Tipo_Usuario = cboTipUsuario.SelectedValue.ToString();
                objEmpleadoBE.Login_Usuario = clsCredenciales.Usuario;
                objEmpleadoBE.Usu_Registro = clsCredenciales.Usuario;
                objEmpleadoBE.Foto_emple = File.ReadAllBytes(openFileDialog1.FileName);
                if (objEmpleadoBL.InsertarEmpleado(objEmpleadoBE) == true)
                {
                    this.Close();
                }
                else
                {
                    throw new Exception("No se inserto el registro");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ha producido el error: " + ex.Message);
            }

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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.FileName = String.Empty;
                openFileDialog1.Multiselect = false;
                openFileDialog1.ShowDialog();

                // Si se escogio una foto se carga en el picture Box
                if (openFileDialog1.FileName != String.Empty)
                {
                    pcbFoto.Image = Image.FromFile(openFileDialog1.FileName);
                }


            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
