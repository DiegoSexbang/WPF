using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Xml.Linq;
using System.Data.SqlClient;

namespace Modelo
{
    public class Conexion
    {
        private String datosConexion;
        private String nombreBaseDatos;
        private String usuario;
        private String pass;
        private String nombreServidor;
        private SqlConnection cnn= new SqlConnection();

        public Conexion()
        {
           
            datosConexion = "Data Source=.\\SQLEXPRESS;Initial Catalog=Reproductor;Integrated Security=True";
        }
        public String DatosConexion
        {
            get
            {
                return DatosConexion;
            }
            set
            {
                DatosConexion = value;
            }
        }

        //Se implementa la función Conectar quien devolverá la conexion establecida 
        public SqlConnection Conectar()
        {
            cnn.ConnectionString = datosConexion;
            cnn.Open();
            return cnn;

        }
        //Se implementa la función que desconectará de la Base de Datos
        public void Desconectar()
        {
            cnn.Close();
            cnn.Dispose();
        }

        public String EntregarConnectionString()
        {
            return datosConexion;
        }
        public Boolean Conectado()
        {
            if (cnn.State == ConnectionState.Closed)
                return false;
            else
                return true;

        }

    }
}
