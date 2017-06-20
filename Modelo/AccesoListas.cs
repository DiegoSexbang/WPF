using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Modelo
{
   public class AccesoListas
    {
        private SqlDataAdapter adaptador = new SqlDataAdapter();
        private Modelo.Conexion cnn = new Modelo.Conexion();
        private DataSet listas = new DataSet();
        private DataTable dtafps = new DataTable();
        private SqlCommand cmd = new SqlCommand();
        SqlDataReader resultado;

        public void Insertar(int NumeroLista, String NombreLista, int IdGeneroLista)
        {

            string instruccion = null;
            cnn.Desconectar();
            instruccion = "INSERT INTO LISTAREPRODUCCION VALUES(" + NumeroLista + ",'" + NombreLista + "'," + IdGeneroLista + ")";
            cmd = new SqlCommand(instruccion, cnn.Conectar());
            cmd.ExecuteNonQuery();
            

        }
        public void Actualizar(int NumeroLista, String NombreLista)
        {
            String instruccion = null;
            cnn.Desconectar();
            instruccion = "UPDATE LISTAREPRODUCCION SET NOMBRELISTA='" + NombreLista + "'  Where NUMEROLISTA='" + NumeroLista + "'";
            cmd = new SqlCommand(instruccion, cnn.Conectar());
            cmd.ExecuteNonQuery();
            

        }
        public void Eliminar(int NumeroLista)
        {
            String instruccion = null;
            cnn.Desconectar();
            instruccion = "DELETE from LISTAREPRODUCCION Where NUMEROLISTA='" + NumeroLista + "'";
            cmd = new SqlCommand(instruccion, cnn.Conectar());
            cmd.ExecuteNonQuery();

        }
        public SqlDataReader RecuperarLista()
        {
            string instruccion = null;
            cnn.Desconectar();
            instruccion = "Select * from LISTAREPRODUCCION";
            cmd = new SqlCommand(instruccion, cnn.Conectar());
            resultado = cmd.ExecuteReader();
            return resultado;
        }
        public SqlDataReader RecuperarGenero()
        {
            string instruccion = null;
            cnn.Desconectar();
            instruccion = "Select * from GENERO";
            cmd = new SqlCommand(instruccion, cnn.Conectar());
            resultado = cmd.ExecuteReader();

            return resultado;
        }
    }
}
