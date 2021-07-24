using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DATOS
{
    public class Producto_DAL
    {
        private cConexion conex = new cConexion();


        SqlDataReader productos;
        DataTable tabla = new DataTable();
        SqlCommand cmd = new SqlCommand();

        //cargar nuestro invetario de productos
        public DataTable mostrar()
        {
            cmd.Connection = conex.AbrirConex();
            cmd.CommandText = "SpMostrarProductos";
            cmd.CommandType = CommandType.StoredProcedure;
            //cmd.Parameters.Add("@Operacion", SqlDbType.VarChar, 2).Value = "S";
            productos = cmd.ExecuteReader();
            tabla.Load(productos);

            conex.CerrarConex();
            return tabla;
        }
        // insertar productos a nuestro inventario
        public void insertar(string CodProducto,string NombreProducto, int Cantidad, decimal PrecioUnitario, string Marca)
        {
            cmd.Connection = conex.AbrirConex();
            cmd.CommandText = "SpInsertarProductos";
            cmd.CommandType = CommandType.StoredProcedure;
            //cmd.Parameters.Add("@Operacion", SqlDbType.VarChar, 2).Value = "I";
            cmd.Parameters.AddWithValue("@CodProducto", CodProducto);
            cmd.Parameters.AddWithValue("@NombreProducto",NombreProducto);
            cmd.Parameters.AddWithValue("@Cantidad",Cantidad);
            cmd.Parameters.AddWithValue("@PrecioUnitario",PrecioUnitario);
            cmd.Parameters.AddWithValue("@Marca",Marca);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            cmd.Connection = conex.CerrarConex();
        }
        // Editar productos a nuestro inventario
        public void Editar(string NombreProducto, int Cantidad, decimal PrecioUnitario, string Marca, int IdProducto)
        {
            cmd.Connection = conex.AbrirConex();
            cmd.CommandText = "SpActualizarProductos";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IdProducto", IdProducto);
            cmd.Parameters.AddWithValue("@NombreProducto", NombreProducto);
            cmd.Parameters.AddWithValue("@Cantidad", Cantidad);
            cmd.Parameters.AddWithValue("@PrecioUnitario", PrecioUnitario);
            cmd.Parameters.AddWithValue("@Marca", Marca);
            
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            cmd.Connection = conex.CerrarConex();
        }


        // Eliminar productos a nuestro inventario
        public void Eliminar(int IdProducto)
        {
            cmd.Connection = conex.AbrirConex();
            cmd.CommandText = "SpEliminarProducto";
            cmd.CommandType = CommandType.StoredProcedure;
            //cmd.Parameters.Add("@Operacion", SqlDbType.VarChar, 2).Value = "D";
            cmd.Parameters.AddWithValue("@IdProducto", IdProducto);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            cmd.Connection = conex.CerrarConex();
        }

        // Buscar productos a nuestro inventario
        public void BuscarProducto(int IdProducto)
        {
            cmd.Connection = conex.AbrirConex();
            cmd.CommandText = "SpBuscarProducto";
            cmd.CommandType = CommandType.StoredProcedure;
            //cmd.Parameters.Add("@Operacion", SqlDbType.VarChar, 2).Value = "BP";
            cmd.Parameters.AddWithValue("@IdProducto", IdProducto);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            cmd.Connection = conex.CerrarConex();
        }
    }
}
