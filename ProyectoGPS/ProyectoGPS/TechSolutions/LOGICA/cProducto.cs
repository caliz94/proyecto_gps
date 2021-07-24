using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DATOS;
using System.Data;

namespace LOGICA
{
    public class cProducto
    {
        Producto_DAL _Product_dal = new Producto_DAL();

        public DataTable tbMostrarInventario()
        {
            DataTable dt = new DataTable();
            dt = _Product_dal.mostrar();
            return dt;
        }

        public void Insertar(string CodProducto,string NombreProducto, int Cantidad, decimal PrecioUnitario, string Marca)
        {
            _Product_dal.insertar(CodProducto,NombreProducto,Convert.ToInt32(Cantidad),Convert.ToDecimal(PrecioUnitario), Marca);
        }

        public void grabarVenta(int IdProducto, string NombreCliente, int Cantidad, decimal SubTotal, decimal Descuento, decimal IVA, decimal Total)
        {
            _Product_dal.grabarVenta(IdProducto, NombreCliente, Cantidad, SubTotal, Descuento, IVA, Total);
        }

        public void Editar(string NombreProducto, int Cantidad, decimal PrecioUnitario, string Marca,int IdProducto)
        {
            _Product_dal.Editar(NombreProducto,Cantidad,PrecioUnitario,Marca,IdProducto);
        }

        public void Eliminar(int IdProducto)
        {
            _Product_dal.Eliminar(IdProducto);
        }

        public void BuscarProducto(int BNombreProducto)
        {
            _Product_dal.BuscarProducto(BNombreProducto);
        }
    }
}
