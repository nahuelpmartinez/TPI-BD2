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
    public class ArticuloNegocio
    {
        public List<Articulo> listar()
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();

            try
            {

                //datos.setearConsulta("SELECT A.IdArticulo, Codigo, Nombre, PrecioUnidad, A.Estado EstadoA, M.IdMarca, " +
                //    "M.Descripcion DescripcionMarca, C.IdCategoria, C.Descripcion DescripcionCategoria " +
                //    "FROM Articulo A, Marca M, Categoria C WHERE A.IdCategoria = C.IdCategoria And A.IdMarca = M.IdMarca");
                //datos.ejecutarLectura();

                //Listar articulos utilizando un procedimiento almacenado (activo = 1)
                datos.setearSP("SP_ListarArticulos");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Id = (int)datos.Lector["IdArticulo"];
                    aux.Codigo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Precio = (decimal)datos.Lector["PrecioUnidad"];
                    aux.Estado = (bool)datos.Lector["EstadoA"];

                    aux.Marca = new Marca();
                    aux.Marca.Id = (int)datos.Lector["IdMarca"];
                    aux.Marca.Descripcion = (string)datos.Lector["DescripcionMarca"];

                    aux.Categoria = new Categoria();
                    aux.Categoria.Id = (int)datos.Lector["IdCategoria"];
                    aux.Categoria.Descripcion = (string)datos.Lector["DescripcionCategoria"];
                    

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

        public void agregar(Articulo nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                //Inserta en la Tabla Articulos

                //datos.setearConsulta("Insert into Articulo(Codigo, Nombre, IdMarca, IdCategoria, PrecioUnidad) values(@Codigo, @Nombre, @IdMarca, @IdCategoria, @Precio)");

                //Insertar un articulo utilizando un STORED PROCEDURE
                datos.setearSP("SP_InsertarArticulo");

                datos.setearParametro("@Codigo", nuevo.Codigo);
                datos.setearParametro("@Nombre", nuevo.Nombre);
                datos.setearParametro("@IdMarca", nuevo.Marca.Id);
                datos.setearParametro("@IdCategoria", nuevo.Categoria.Id);
                datos.setearParametro("@PrecioUnidad", nuevo.Precio);
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

        public void modificar(Articulo modificar)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                // Modifica en tabla Articulos
                datos.setearConsulta("Update Articulo set Codigo = @codigo, Nombre = @nombre, IdMarca = @idMarca, IdCategoria = @idCategoria, PrecioUnidad = @precio Where IdArticulo = @id");
                datos.setearParametro("@codigo", modificar.Codigo);
                datos.setearParametro("@nombre", modificar.Nombre);
                datos.setearParametro("@idMarca", modificar.Marca.Id);
                datos.setearParametro("@idCategoria", modificar.Categoria.Id);
                datos.setearParametro("@precio", modificar.Precio);
                datos.setearParametro("@id", modificar.Id);
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
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("delete from Articulo where IdArticulo = @IdArticuloAEliminar");
                datos.setearParametro("@IdArticuloAEliminar", id);
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
        public int ultimoAgregado()
        {
            AccesoDatos datos = new AccesoDatos();
            int id;
            try
            {
               
                datos.setearConsulta("Select TOP (1) IdArticulo From Articulo Order By IdArticulo Desc");
                datos.ejecutarLectura();

                if (datos.Lector.Read()) // <- ESTA LÍNEA ES CLAVE
                {
                    id = (int)datos.Lector["IdArticulo"];
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

        public List<Articulo> filtrar(string campo, string criterio, string filtro)
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                string consulta = "Select A.Id, Codigo, Nombre, A.Descripcion , IdMarca, " +
                    "M.Descripcion DescripcionM, IdCategoria, C.Descripcion DescripcionC, " +
                    "Precio, From Articulo A, Marca M, Categoria C " +
                    "Where A.Id = I.IdArticulo And A.IdCategoria = C.Id And A.IdMarca = M.Id And ";
                if (campo == "Código")
                {
                    switch (criterio)
                    {
                        case "Comienza con":
                            consulta += "Codigo like '" + filtro + "%'";
                            break;
                        case "Termina con":
                            consulta += "Codigo like '%" + filtro + "'";
                            break;
                        default:
                            consulta += "Codigo like '%" + filtro + "%'";
                            break;
                    }
                }
                else if (campo == "Nombre")
                {
                    switch (criterio)
                    {
                        case "Comienza con":
                            consulta += "Nombre like '" + filtro + "%'";
                            break;
                        case "Termina con":
                            consulta += "Nombre like '%" + filtro + "'";
                            break;
                        default:
                            consulta += "Nombre like '%" + filtro + "%'";
                            break;
                    }
                }
                else if (campo == "Marca")
                {
                    switch (criterio)
                    {
                        case "Comienza con":
                            consulta += "M.Descripcion like '" + filtro + "%'";
                            break;
                        case "Termina con":
                            consulta += "M.Descripcion like '%" + filtro + "'";
                            break;
                        default:
                            consulta += "M.Descripcion like '%" + filtro + "%'";
                            break;
                    }
                }
                else
                {
                    switch (criterio)
                    {
                        case "Comienza con":
                            consulta += "C.Descripcion like '" + filtro + "%'";
                            break;
                        case "Termina con":
                            consulta += "C.Descripcion like '%" + filtro + "'";
                            break;
                        default:
                            consulta += "C.Descripcion like '%" + filtro + "%'";
                            break;
                    }
                }
                datos.setearConsulta(consulta);
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Codigo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Precio = (decimal)datos.Lector["Precio"];


                    aux.Marca = new Marca();
                    aux.Marca.Id = (int)datos.Lector["IdMarca"];
                    aux.Marca.Descripcion = (string)datos.Lector["DescripcionM"];
                    aux.Categoria = new Categoria();
                    aux.Categoria.Id = (int)datos.Lector["IdCategoria"];
                    aux.Categoria.Descripcion = (string)datos.Lector["DescripcionC"];                 

                    lista.Add(aux);
                }
                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }
    
}
