using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using dominio;
using System.Net;
using System.Xml.Linq;

namespace negocio
{
    public class VistaNegocio
    {
        public List<StockPorSucursal> obtenerVistaStock()
        {
            List<StockPorSucursal> lista = new List<StockPorSucursal>();
            AccesoDatos datos = new AccesoDatos(); // Instancia de tu clase AccesoDatos

            try
            {
                // La consulta SQL directa a tu nueva vista
                datos.setearConsulta("SELECT IdSucursal, Sucursal, Código, Articulo, Cantidad FROM VW_StockPorSucursal ORDER BY IdSucursal ASC");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    StockPorSucursal item = new StockPorSucursal();
                    item.IdSucursal = (int)datos.Lector["IdSucursal"];
                    item.Sucursal = (string)datos.Lector["Sucursal"];
                    item.Codigo = (string)datos.Lector["Código"];
                    item.Articulo = (string)datos.Lector["Articulo"];
                    item.Cantidad = (int)datos.Lector["Cantidad"];
                    lista.Add(item);
                }
                return lista;
            }
            catch (Exception ex)
            {
                // Lanzar una excepción de ApplicationException para manejarla en la capa de UI
                throw new ApplicationException("Error al obtener datos de la vista de stock: " + ex.Message, ex);
            }
            finally
            {
                datos.cerrarConexion(); // Asegura que la conexión se cierre
            }
        }

        public List<StockPorArticulo> obtenerVistaStockArticulo()
        {
            List<StockPorArticulo> lista = new List<StockPorArticulo>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("SELECT Código, Articulo, StockTotal FROM VW_StockTotalPorArticulo");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    StockPorArticulo item = new StockPorArticulo();
                    item.Codigo = (string)datos.Lector["Código"];
                    item.Articulo = (string)datos.Lector["Articulo"];
                    item.StockTotal = (int)datos.Lector["StockTotal"];
                    lista.Add(item);
                }
                return lista;
            }
            catch (Exception ex)
            {
                // Lanzar una excepción de ApplicationException para manejarla en la capa de UI
                throw new ApplicationException("Error al obtener datos de la vista de stock: " + ex.Message, ex);
            }
            finally
            {
                datos.cerrarConexion(); // Asegura que la conexión se cierre
            }
        }

    }
}
