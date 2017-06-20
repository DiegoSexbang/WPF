using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Modelo
{
    public class AccesoCanciones
    {
        private SqlDataAdapter adaptador = new SqlDataAdapter();
        private Modelo.Conexion cnn = new Modelo.Conexion();
        private DataSet listas = new DataSet();
        private DataTable dtafps = new DataTable();
        private SqlCommand cmd = new SqlCommand();
        SqlDataReader resultado;


        public SqlDataReader RecuperarTotalCanciones()
        {
            string instruccion = null;
            cnn.Desconectar();
            instruccion = "Select * from CANCIONES";
            cmd = new SqlCommand(instruccion, cnn.Conectar());
            resultado = cmd.ExecuteReader();

            return resultado;
        }

        public SqlDataReader RecuperarTotalCanciones2(int id)
        {
            string instruccion = null;
            cnn.Desconectar();
            instruccion = "Select * from CANCIONES where NUMEROLISTA = "+id;
            cmd = new SqlCommand(instruccion, cnn.Conectar());
            resultado = cmd.ExecuteReader();

            return resultado;
        }
        public void Insertar(int NumeroLista, String NombreCancion, String RutaArchivo, String Artista)
        {
            string instruccion = "";
            cnn.Desconectar();
            instruccion = "INSERT INTO CANCIONES VALUES(" + NumeroLista + ",'" + NombreCancion + "','" + RutaArchivo + "','" + Artista + "')";
            cmd = new SqlCommand(instruccion, cnn.Conectar());
            cmd.ExecuteNonQuery();
          

        }
        public void Actualizar(String NombreCancion, String Artista)
        {
            String instruccion = null;
            cnn.Desconectar();
            instruccion = "UPDATE CANCIONES SET ARTISTA='" + Artista + "'  Where NOMBRECANCION='" + NombreCancion + "'";
            cmd = new SqlCommand(instruccion, cnn.Conectar());
            cmd.ExecuteNonQuery();


        }
        public void Eliminar(int NombreCancion)
        {
            String instruccion = null;
            cnn.Desconectar();
            instruccion = "DELETE from CANCIONES Where ID_CANCION='" + NombreCancion + "'";
            cmd = new SqlCommand(instruccion, cnn.Conectar());
            cmd.ExecuteNonQuery();

        }
        public SqlDataReader BuscarArtista(String Artista)
        {
            String instruccion = null;
            cnn.Desconectar();
            instruccion = "SELECT * from CANCIONES Where ARTISTA='%" + Artista + "'";
            cmd = new SqlCommand(instruccion, cnn.Conectar());
            resultado = cmd.ExecuteReader();

            return resultado;
        }
        public SqlDataReader BuscarCancion(String Cancion)
        {
            String instruccion = null;
            cnn.Desconectar();
            instruccion = "SELECT * from CANCIONES Where NOMBRECANCION='%" + Cancion + "'";
            cmd = new SqlCommand(instruccion, cnn.Conectar());
            resultado = cmd.ExecuteReader();

            return resultado;
        }
        public SqlDataReader BuscarLista(int Lista)
        {
            String instruccion = null;
            cnn.Desconectar();
            instruccion = "SELECT * from CANCIONES Where NUMEROLISTA='" + Lista + "'";
            cmd = new SqlCommand(instruccion, cnn.Conectar());
            resultado = cmd.ExecuteReader();

            return resultado;
        }
    }
}
