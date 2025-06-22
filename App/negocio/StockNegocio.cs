using dominio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace negocio
{
    public class StockNegocio
    {
        public List<Stock> listar()
        {
            List<Stock> lista = new List<Stock>();
            AccesoDatos datos = new AccesoDatos();

            try
            {

                datos.setearConsulta("SELECT IdArticulo, IdSucursal, Cantidad FROM Stock");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Stock aux = new Stock();
                    aux.Id = (int)datos.Lector["IdArticulo"];
                    aux.IdSucursal = (int)datos.Lector["IdSucursal"];
                    aux.Cantidad = (int)datos.Lector["Cantidad"];

                    lista.Add(aux);
                }

                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void agregar(Stock nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearSP("SP_ActualizarOInsertarStock");

                datos.setearParametro("@IdArticulo", nuevo.Id);
                datos.setearParametro("@IdSucursal", nuevo.IdSucursal);
                datos.setearParametro("@Cantidad", nuevo.Cantidad);

                datos.ejecutarAccion();


            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void reducirStock(Stock nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearSP("SP_ReducirStock");

                datos.setearParametro("@IdArticulo", nuevo.Id);
                datos.setearParametro("@IdSucursal", nuevo.IdSucursal);
                datos.setearParametro("@Cantidad", nuevo.Cantidad);
                datos.ejecutarAccion();
            }
            catch (SqlException sqlEx)
            {
                throw new ApplicationException("Error de base de datos al dar de baja stock: " + sqlEx.Message, sqlEx);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error inesperado al dar de baja stock: " + ex.Message, ex);
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void mover(Stock nuevo, int destino)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearSP("SP_MoverStockEntreSucursales");

                datos.setearParametro("@IdArticulo", nuevo.Id);
                datos.setearParametro("@IdSucursalOrigen", nuevo.IdSucursal);
                datos.setearParametro("@IdSucursalDestino", destino);
                datos.setearParametro("@CantidadAMover", nuevo.Cantidad);
                datos.ejecutarAccion();
            }
            catch (SqlException sqlEx)
            {
                throw new ApplicationException(sqlEx.Message, sqlEx);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error inesperado al dar de baja stock: " + ex.Message, ex);
            }
            finally
            {
                datos.cerrarConexion();
            }
        }



        //public int ultimoAgregado()
        //{
        //    AccesoDatos datos = new AccesoDatos();
        //    int id;
        //    try
        //    {

        //        datos.setearConsulta("Select TOP (1) IdSucursal From Sucursal Order By IdSucursal Desc");
        //        datos.ejecutarLectura();

        //        if (datos.Lector.Read()) // <- ESTA LÍNEA ES CLAVE
        //        {
        //            id = (int)datos.Lector["IdSucursal"];
        //            return id;
        //        }
        //        else
        //        {
        //            throw new Exception("No se encontró ningún artículo en la base de datos.");
        //        }


        //    }
        //    catch (Exception ex)
        //    {

        //        throw ex;
        //    }
        //}

    }
}
