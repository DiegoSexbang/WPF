using Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Controladores
{
   public class CListas
    {
	
        private int numeroLista;
        private String nombreLista;
        private String generoLista;
        private int idgenerolista;
        private AccesoListas accesolistas = new AccesoListas();

        public int NumeroLista { get => numeroLista; set => numeroLista = value; }
        public string NombreLista { get => nombreLista; set => nombreLista = value; }
        public String GeneroLista { get => generoLista; set => generoLista = value; }
        public int Idgenerolista { get => idgenerolista; set => idgenerolista = value; }

        public void Agregar(int NumeroLista, String NombreLista, int GeneroLista)
        {
            accesolistas.Insertar(NumeroLista, NombreLista, GeneroLista);
        }
        public void Actualizar(int NumeroLista, String NombreLista)
        {
            accesolistas.Actualizar(NumeroLista, NombreLista);
        }
        public void Eliminar(int NumeroLista)
        {
            accesolistas.Eliminar(NumeroLista);
        }
        public String[] GeneroNombre() {

            SqlDataReader resultado = accesolistas.RecuperarGenero();
            int i = 0;
            string[] nombres = new string[4];
            while (resultado.Read())
            {

                nombres[i] = resultado["NOMBREGENERO"].ToString();
                i++;
            }

            return nombres;

        }

        public List<int>  RecuperarLista() {

          SqlDataReader resultado= accesolistas.RecuperarLista();
          int i = 0;
            List<int> NumeroLista = new List<int>();
            while (resultado.Read())
            {
                NumeroLista[i] = Convert.ToInt32(resultado["NUMEROLISTA"]);
                i++;
            }
            return NumeroLista;
        }

        public SqlDataReader RecuperarGenero() {
            SqlDataReader datos;
            datos = accesolistas.RecuperarGenero();
            return datos;   
        }
        public SqlDataReader RecuperarLiista()
        {
            SqlDataReader datos;
            datos = accesolistas.RecuperarLista();
            return datos;
        }

        /* public int RescatarID(string nombregenero)
         {
             SqlDataReader resultado = accesolistas.RecuperarGenero();
             int id = 0;
             while (resultado.Read())
             {
                 if (resultado["NOMBREGENERO"].ToString() == nombregenero)
                 {
                     id= Convert.ToInt32(resultado["ID_GENERO"]);
                     return id;
                 }

             } 
             */
    }
    }

