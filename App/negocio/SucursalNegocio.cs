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
    public class SucursalNegocio
    {
        public List<Sucursal> listar()
        {
            List<Sucursal> lista = new List<Sucursal>();
            AccesoDatos datos = new AccesoDatos();

            try
            {

                datos.setearConsulta("SELECT IdSucursal, Nombre, Direccion, FechaCreacion, Estado " +
                    "FROM Sucursal");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Sucursal aux = new Sucursal();
                    aux.Id = (int)datos.Lector["IdSucursal"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Direccion = (string)datos.Lector["Direccion"];
                    aux.FechaCreacion = (DateTime)datos.Lector["FechaCreacion"];
                    aux.Estado = (bool)datos.Lector["Estado"];

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

        public void agregar(Sucursal nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                //Inserta en la Tabla Sucusal

                datos.setearConsulta("Insert into Sucursal(Nombre, Direccion) " +
                    "values(@Nombre, @Direccion)");

                datos.setearParametro("@Nombre", nuevo.Nombre);
                datos.setearParametro("@Direccion", nuevo.Direccion);
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
        public void modificar(Sucursal modificar)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                // Modifica en tabla Sucursal
                datos.setearConsulta("Update Sucursal set Nombre = @Nombre, " +
                    "Direccion = @Direccion " +
                    "Where IdSucursal = @IdSucursal");
                datos.setearParametro("@Nombre", modificar.Nombre);
                datos.setearParametro("@Direccion", modificar.Direccion);
                datos.setearParametro("@IdSucursal", modificar.Id);
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

        public void eliminar(int id)
        {
            //Acá se dispararía el trigger TR_Eliminar_Sucursal
            try
            {
                AccesoDatos datos = new AccesoDatos();
                datos.setearConsulta("Delete from Sucursal Where IdSucursal = @id");
                datos.setearParametro("@id", id);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public int ultimoAgregado()
        {
            AccesoDatos datos = new AccesoDatos();
            int id;
            try
            {

                datos.setearConsulta("Select TOP (1) IdSucursal From Sucursal Order By IdSucursal Desc");
                datos.ejecutarLectura();

                if (datos.Lector.Read()) // <- ESTA LÍNEA ES CLAVE
                {
                    id = (int)datos.Lector["IdSucursal"];
                    return id;
                }
                else
                {
                    throw new Exception("No se encontró ningún artículo en la base de datos.");
                }


            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }
}
