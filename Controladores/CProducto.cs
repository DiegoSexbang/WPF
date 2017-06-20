using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using Modelo;
using System.Data;

namespace Controladores
{
    public class  CProducto
    {
        //Definicion de atributos de la Clase
        private int codProducto;
        private String nomProducto;
        private Double totalregistros;
        private Double posicionactual;
        private DataSet productos;
        private SqlDataReader datos;
        private DataRow fila;
        private Modelo.AccesoProductos accesoproductos = new Modelo.AccesoProductos();

        //Definicion de Getter y Setter de los atributos 
        public Double Posicionactual
        {
            get { return posicionactual; }
            set { posicionactual = value; }
        }

        public Double Totalregistros
        {
            get { return totalregistros; }
            set { totalregistros = value; }
        }


        public DataSet Productos
        {
            get { return productos; }
            set { productos = value; }
        }


        public SqlDataReader Datos
        {
            get { return datos; }
            set { datos = value; }
        }

        public int CodProducto
        {
            get { return codProducto; }
            set { codProducto = value; }
        }
        public String NomProducto
        {
            get { return nomProducto; }
            set { nomProducto = value; }
        }
        public DataRow Fila
        {
            get { return fila; }
            set { fila = value; }
        }

        //Implementacion de los Metodos de la Clase.

        public void Agregar(int CodProducto, String NomProducto)
        {
            accesoproductos.Insertar(CodProducto, NomProducto);
        }
        public void Actualizar(int CodProducto, String NomProducto)
        {
            accesoproductos.Actualizar(CodProducto, NomProducto);
        }
        public void Eliminar(int CodProducto)
        {
            accesoproductos.Eliminar(CodProducto);
        }
        public SqlDataReader RecuperarTabla()
        {
            datos = accesoproductos.RecuperarTabla();
            return datos;
        }

        public SqlDataReader BuscarporCodigo(int CodProducto)
        {
            datos = accesoproductos.BuscarporCodigo(CodProducto);

            return datos;
        }
        public SqlDataReader BuscarporNombre(String NomProducto)
        {
            datos = accesoproductos.BuscarporNombre(NomProducto);
            return datos;
        }
        public Boolean BuscarExistente(int CodProd)
        {
            SqlDataReader resultado;
            resultado = accesoproductos.Buscar_Existente(CodProd);

            if (!resultado.Read())
                return false;
            else
            {
                codProducto = Convert.ToInt32(resultado.GetValue(0));
                NomProducto = Convert.ToString(resultado.GetValue(1));
                return true;
            }
        }
    }
}
