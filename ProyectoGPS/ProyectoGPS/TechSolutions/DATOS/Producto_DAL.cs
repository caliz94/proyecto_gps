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

        // Funcion para Cargar el Inventario de Productos
        public DataTable mostrar()
        {
            cmd.Connection = conex.AbrirConex();
            cmd.CommandText = "SpMostrarProductos";
            cmd.CommandType = CommandType.StoredProcedure;
            productos = cmd.ExecuteReader();
            tabla.Load(productos);
            conex.CerrarConex();
            return tabla;
        }
        
        // Metodo para Ingresar Productos en el Inventario
        public void insertar(string CodProducto,string NombreProducto, int Cantidad, decimal PrecioUnitario, string Marca)
        {
            cmd.Connection = conex.AbrirConex();
            cmd.CommandText = "SpInsertarProductos";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@CodProducto", CodProducto);
            cmd.Parameters.AddWithValue("@NombreProducto",NombreProducto);
            cmd.Parameters.AddWithValue("@Cantidad",Cantidad);
            cmd.Parameters.AddWithValue("@PrecioUnitario",PrecioUnitario);
            cmd.Parameters.AddWithValue("@Marca",Marca);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            cmd.Connection = conex.CerrarConex();
        }

        // Método para Grabar las Ventas
        public void grabarVenta(int IdProducto, string NombreCliente, int Cantidad, decimal SubTotal, decimal Descuento, decimal IVA, decimal Total)
        {
            cmd.Connection = conex.AbrirConex();
            cmd.CommandText = "Sp_GrabarVenta";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@NombreCliente", NombreCliente);
            cmd.Parameters.AddWithValue("@IdProducto", IdProducto);
            cmd.Parameters.AddWithValue("@Cantidad", Cantidad);
            cmd.Parameters.AddWithValue("@SubTotal", SubTotal);
            cmd.Parameters.AddWithValue("@Descuento", Descuento);
            cmd.Parameters.AddWithValue("@IVA", IVA);
            cmd.Parameters.AddWithValue("@Total", Total);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            cmd.Connection = conex.CerrarConex();
        }

        // Métodos para Grabar Productos en el Inventario.
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

        // Método para Eliminar Productos del Inventario
        public void Eliminar(int IdProducto)
        {
            cmd.Connection = conex.AbrirConex();
            cmd.CommandText = "SpEliminarProducto";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IdProducto", IdProducto);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            cmd.Connection = conex.CerrarConex();
        }

        // Método para Buscar Productos
        public void BuscarProducto(int IdProducto)
        {
            cmd.Connection = conex.AbrirConex();
            cmd.CommandText = "SpBuscarProducto";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IdProducto", IdProducto);
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            cmd.Connection = conex.CerrarConex();
        }
    }
}
