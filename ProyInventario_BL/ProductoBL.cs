using ProyInventario_ADO;
using ProyInventario_BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyInventario_BL
{
    public class ProductoBL
    {
        ProductoADO objProductoADO = new ProductoADO();

        public DataTable ListarProducto()
        {
            return objProductoADO.ListarProducto();
        }
        public ProductoBE ConsultarProducto(String strCodigo)
        {
            return objProductoADO.ConsultarProducto(strCodigo);
        }

        public Boolean InsertarProducto(ProductoBE objProductoBE)
        {
            return objProductoADO.InsertarProducto(objProductoBE);
        }
        public Boolean ActualizarProducto(ProductoBE objProductoBE)
        {
            return objProductoADO.ActualizarProducto(objProductoBE);
        }
        public Boolean EliminarProducto(String strCodigo)
        {
            return objProductoADO.EliminarProducto(strCodigo);
        }
    }
}
