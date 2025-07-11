﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace negocio
{
    public class AccesoDatos
    {
        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlDataReader lector;

        public SqlDataReader Lector
        {
            get {  return lector; }
        }

        public AccesoDatos()
        {
            //conexion = new SqlConnection("server=.\\SQLEXPRESS; database=GestionStockDB; integrated security=true");
            //Casa
            conexion = new SqlConnection("server=192.168.100.66; database=CafeteriaStockDB; User ID=sa; Password=VeryStr0ngP@ssw0rd;");
            
            //conexion = new SqlConnection("server=192.168.1.10; database=CafeteriaStockDB; User ID=sa; Password=VeryStr0ngP@ssw0rd;");

            //Celu
            //conexion = new SqlConnection("server=192.168.211.202; database=CafeteriaStockDB; User ID=sa; Password=VeryStr0ngP@ssw0rd;");

            comando = new SqlCommand();
        }

        public void setearConsulta(string consulta)
        {
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = consulta;
        }

        public void ejecutarLectura()
        {
            comando.Connection = conexion;
            try
            {
                conexion.Open();
                lector = comando.ExecuteReader();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void setearSP(string sp)
        {
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.CommandText = sp;
        }

        public void setearParametro(string nombre, object valor)
        {
            comando.Parameters.AddWithValue(nombre, valor);
        }

        public void ejecutarAccion()
        {
            comando.Connection = conexion;
            try
            {
                conexion.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void cerrarConexion()
        {
            if (lector != null)
                lector.Close();
            conexion.Close();
        }

    }
}
