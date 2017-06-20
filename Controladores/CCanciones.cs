using Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Controladores
{
    public class CCanciones
    {
        private String nombreCancion;
        private String nombreArtista;
        private String rutaArchivo;
        private int numeroLista;

        public string NombreCancion { get => nombreCancion; set => nombreCancion = value; }
        public string NombreArtista { get => nombreArtista; set => nombreArtista = value; }
        public int NumeroLista { get => numeroLista; set => numeroLista = value; }
        public string RutaArchivo { get => rutaArchivo; set => rutaArchivo = value; }

        AccesoCanciones acc = new AccesoCanciones();
        private SqlDataReader datos;
        public List<String> RescatarCancion(int NumeroLista)
        {

            SqlDataReader resultado = acc.RecuperarTotalCanciones();
            int i = 0;
            List<String> nombres = new List<String>();
            while (resultado.Read())
            {
                int numerolistaa = Convert.ToInt32(resultado["NUMEROLISTA"]);
                if(numerolistaa == NumeroLista)
                {
                    nombres[i] = resultado["NOMBRECANCION"].ToString();
                  }
                
                i++;
            }

            return nombres;
        }
        public SqlDataReader RecuperarTabla() {
            datos = acc.RecuperarTotalCanciones();
            return datos;
        }
        public SqlDataReader RecuperarTabla2(int id)
        {
            datos = acc.RecuperarTotalCanciones2(id);
            return datos;
        }
        public void Agregar(int NumeroLista, String NombreCancion, String RutaArchivo, String Artista)
        {
            acc.Insertar(NumeroLista, NombreCancion, RutaArchivo, Artista);
        }
        public void Actualizar(String NombreCancion, String Artista)
        {
            acc.Actualizar(NombreCancion, Artista);
        }
        public void Eliminar(int NombreCancion)
        {
            acc.Eliminar(NombreCancion);
        }
        public SqlDataReader BuscarArtista(String Artista)
        {
           datos = acc.BuscarArtista(Artista);
            return datos;
        }
        public SqlDataReader BuscarCancion(String Cancion)
        {
           datos= acc.BuscarCancion(Cancion);
            return datos;
        }
        public SqlDataReader BuscarLista(int Lista)
        {
           datos= acc.BuscarLista(Lista);
            return datos;
        }
    }
}
