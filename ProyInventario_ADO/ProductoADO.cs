using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyInventario_BE;

namespace ProyInventario_ADO
{
    public class ProductoADO
    {
        // Insumos.....
        ConexionADO MiConexion = new ConexionADO();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dtr;

        public DataTable ListarProducto()
        {

            try
            {
                // Codifique
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ListarProducto";
                cmd.Parameters.Clear();

                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                DataSet dts = new DataSet();
                ada.Fill(dts, "Productos");

                return dts.Tables["Productos"];

            }
            catch (SqlException ex)
            {

                throw new Exception(ex.Message);
            }
        }
        public ProductoBE ConsultarProducto(String strCodigo)
        {
            try
            {
                //Codifique
                ProductoBE objProductoBE = new ProductoBE();
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ConsultarProducto";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@vcod", strCodigo);
                cnx.Open();
                dtr = cmd.ExecuteReader();

                if (dtr.HasRows == true)
                {
                    dtr.Read();
                    objProductoBE.Cod_pro = Convert.ToInt16(dtr["Cod_pro"]);
                    objProductoBE.Dscp_pro = dtr["Dscp_pro"].ToString();
                    objProductoBE.Pre_pro = Convert.ToSingle(dtr["Pre_pro"]);
                    objProductoBE.Stk_act = Convert.ToInt16(dtr["Stk_act"]);
                    objProductoBE.Stk_min = Convert.ToInt16(dtr["Stk_min"]);
                    objProductoBE.Cod_uni = dtr["Cod_uni"].ToString();
                    objProductoBE.Cod_area = dtr["Cod_area"].ToString();
                    objProductoBE.Cod_sec = dtr["Cod_sec"].ToString();
                    objProductoBE.Cod_lin = dtr["Cod_lin"].ToString();
                    objProductoBE.Cod_fam = dtr["Cod_fam"].ToString();
                    objProductoBE.Cod_sub = dtr["Cod_sub"].ToString();
                    objProductoBE.Estd_pro = Convert.ToInt16(dtr["Estd_pro"]);
                }
                dtr.Close();
                return objProductoBE;
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }

            }

        }
        public Boolean InsertarProducto(ProductoBE objProductoBE)
        {

            try
            {
                //Codifique
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_InsertarProducto";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@vdscp", objProductoBE.Dscp_pro);
                cmd.Parameters.AddWithValue("@vpre", objProductoBE.Pre_pro);
                cmd.Parameters.AddWithValue("@vstkm", objProductoBE.Stk_min);
                cmd.Parameters.AddWithValue("@vstka", objProductoBE.Stk_act);
                cmd.Parameters.AddWithValue("@vEst_pro", objProductoBE.Estd_pro);
                cmd.Parameters.AddWithValue("@vCod_area", objProductoBE.Cod_area);
                cmd.Parameters.AddWithValue("@vCod_sec", objProductoBE.Cod_sec);
                cmd.Parameters.AddWithValue("@vCod_lin", objProductoBE.Cod_lin);
                cmd.Parameters.AddWithValue("@vCod_fam", objProductoBE.Cod_fam);
                cmd.Parameters.AddWithValue("@vCod_sub", objProductoBE.Cod_sub);
                cmd.Parameters.AddWithValue("@vCod_uni", objProductoBE.Cod_uni);
                cmd.Parameters.AddWithValue("@vUsu_Registro", objProductoBE.Usu_Registro);


                cnx.Open();
                cmd.ExecuteNonQuery();
                return true;

            }
            catch (SqlException x)
            {
                throw new Exception(x.Message);
                return false;
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }

            }
        }
        public Boolean ActualizarProducto(ProductoBE objProductoBE)
        {
            try
            {
                //Codifique
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ActualizarProducto";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@vcod", objProductoBE.Cod_pro);
                cmd.Parameters.AddWithValue("@vdscp", objProductoBE.Dscp_pro);
                cmd.Parameters.AddWithValue("@vpre", objProductoBE.Pre_pro);
                cmd.Parameters.AddWithValue("@vstkm", objProductoBE.Stk_min);
                cmd.Parameters.AddWithValue("@vstka", objProductoBE.Stk_act);
                cmd.Parameters.AddWithValue("@vEst_pro", objProductoBE.Estd_pro);
                cmd.Parameters.AddWithValue("@vCod_area", objProductoBE.Cod_area);
                cmd.Parameters.AddWithValue("@vCod_sec", objProductoBE.Cod_sec);
                cmd.Parameters.AddWithValue("@vCod_lin", objProductoBE.Cod_lin);
                cmd.Parameters.AddWithValue("@vCod_fam", objProductoBE.Cod_fam);
                cmd.Parameters.AddWithValue("@vCod_sub", objProductoBE.Cod_sub);
                cmd.Parameters.AddWithValue("@vCod_uni", objProductoBE.Cod_uni);
                cmd.Parameters.AddWithValue("@vUsu_Ult_Mod", objProductoBE.Usu_Ult_Mod);

                cnx.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (SqlException x)
            {
                throw new Exception(x.Message);
                return false;
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }

            }


        }
        public Boolean EliminarProducto(String strCodigo)
        {
            try
            {
                //Codifique
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_EliminarProducto";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@vcod", strCodigo);

                cnx.Open();
                cmd.ExecuteNonQuery();
                return true;

            }
            catch (SqlException x)
            {
                throw new Exception(x.Message);
                return false;
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }

            }


        }
    }
}
