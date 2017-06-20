using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Xml.Linq;
using System.Data.SqlClient;

namespace Modelo
{
    public class AccesoProductos
    {

        private SqlDataAdapter adaptador = new SqlDataAdapter();
        private Modelo.Conexion cnn = new Modelo.Conexion();
        private DataSet productos = new DataSet();
        private DataTable dtafps = new DataTable();
        private SqlCommand cmd = new SqlCommand();
        SqlDataReader resultado;

        public SqlDataReader BuscarporCodigo(int prodcodigo)
        {
            string instruccion = null;
            cnn.Desconectar();
            instruccion = "SELECT * FROM PRODUCTO WHERE (PRODCODIGO ='" + prodcodigo + "')";
            cmd = new SqlCommand(instruccion, cnn.Conectar());
            resultado = cmd.ExecuteReader();
            return resultado;
        }
        public SqlDataReader BuscarporNombre(string prodnombre)
        {
            string instruccion = null;
            cnn.Desconectar();
            instruccion = "SELECT * FROM PRODUCTO WHERE (PRODNOMBRE LIKE '" + prodnombre + "%')";
            cmd = new SqlCommand(instruccion, cnn.Conectar());
            resultado = cmd.ExecuteReader();
            return resultado;           
        }
         public SqlDataReader  RecuperarTabla()
         {
            string instruccion = null;
            cnn.Desconectar();
            instruccion = "Select * from PRODUCTO";
            cmd = new SqlCommand(instruccion, cnn.Conectar());
            resultado = cmd.ExecuteReader();
            return resultado;  
         }
         public void Insertar(int CodProducto, String NomProducto) 
         {
            string instruccion = null;
            cnn.Desconectar(); 
            instruccion = "INSERT INTO PRODUCTO VALUES("+CodProducto +",'"+NomProducto +"')";
            cmd = new SqlCommand(instruccion, cnn.Conectar());
            cmd.ExecuteNonQuery();
         
         }
         public void Actualizar(int CodProducto, String NomProducto)
         {
             String instruccion = null;
             cnn.Desconectar();
             instruccion = "UPDATE PRODUCTO SET PRODNOMBRE='"+ NomProducto +"' Where PRODCODIGO='" + CodProducto + "'";
             cmd = new SqlCommand(instruccion, cnn.Conectar());
             cmd.ExecuteNonQuery();

         }
         public void Eliminar(int CodProducto)
         {
             String instruccion = null;
             cnn.Desconectar();
             instruccion = "DELETE from PRODUCTO Where PRODCODIGO='" + CodProducto + "'";
             cmd = new SqlCommand(instruccion, cnn.Conectar());
             cmd.ExecuteNonQuery();
             
         }
        public SqlDataReader Buscar_Existente(int CodProducto)
        {
            String  instruccion=null;
            cnn.Desconectar();
            instruccion = "Select * from PRODUCTO Where PRODCODIGO='" + CodProducto + "'";
            cmd = new SqlCommand(instruccion, cnn.Conectar());
            resultado = cmd.ExecuteReader();
            return resultado;
        }

    }
}