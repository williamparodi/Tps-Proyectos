using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.ExceptionServices;
using TpUtiles;


namespace Entidades
{
    public static class UtilDAO
    {
        static SqlConnection conexion;
        static SqlCommand command;
        static string conexionString;
        static UtilDAO()
        {
            conexionString = "Server=.;Database=BaseTP;Trusted_Connection=True;";
            //conexionString = "Server=.;Database=UTILES_DB;Trusted_Connection=True;";
            command = new SqlCommand();
            conexion = new SqlConnection(conexionString);
            command.Connection = conexion;
            command.CommandType = System.Data.CommandType.Text;
        }

        /// <summary>
        /// Lee los datos del lapiz desde la base de datos. 
        /// </summary>
        /// <returns></returns>
        /// <exception cref="ExceptionArchivo"></exception>
        public static List<Lapiz> LeerDatosLapiz()
        {
            List<Lapiz> listaLapiz = new List<Lapiz>();

            try
            {
                conexion.Open();
                command.CommandText = "SELECT * FROM LAPICES";
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Lapiz lapiz = new Lapiz();
                    string color = reader["COLOR"].ToString();
                    string tipo = reader["TIPO"].ToString();
                    lapiz.Color = (EColor)Enum.Parse(typeof(EColor), color);
                    lapiz.TipoDeLapiz = (ETipoLapiz)Enum.Parse(typeof(ETipoLapiz), tipo);
                    lapiz.Precio = (double)reader["PRECIO"];
                    lapiz.Marca = reader["MARCA"].ToString();
                    lapiz.Id = (int)reader["ID_LAPIZ"];
                    listaLapiz.Add(lapiz);
                }
                reader.Close();
            }
            catch (Exception)
            {
                throw new ExceptionArchivo("Error al leer la base");
            }
            finally
            {
                if (conexion.State == System.Data.ConnectionState.Open)
                {
                    conexion.Close();
                }
            }

            return listaLapiz;
        }

        public static List<Fibron> LeerDatosFibrones()
        {
            List<Fibron> listaFibron = new List<Fibron>();

            try
            {
                conexion.Open();
                command.CommandText = "SELECT * FROM FIBRONES";
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Fibron fibron = new Fibron();
                    string color = reader["COLOR"].ToString();
                    string cantidad = reader["CANTIDAD"].ToString();
                    fibron.Color = (EColor)Enum.Parse(typeof(EColor), color);
                    fibron.CantidadTinta= (int)Enum.Parse(typeof(int), cantidad);
                    fibron.Id = (int)reader["ID_LAPIZ"];
                    listaFibron.Add(fibron);
                }
                reader.Close();
            }
            catch (Exception)
            {
                throw new ExceptionArchivo("Error al leer la base");
            }
            finally
            {
                if (conexion.State == System.Data.ConnectionState.Open)
                {
                    conexion.Close();
                }
            }

            return listaFibron;
        }

        /// <summary>
        /// Lee los datos desde la base de datos del util goma 
        /// </summary>
        /// <returns></returns>
        /// <exception cref="ExceptionArchivo"></exception>
        public static List<Goma> LeerDatosGoma()
        {
            List<Goma> listaGoma = new List<Goma>();

            try
            {
                command.Parameters.Clear();
                conexion.Open();
                command.CommandText = "SELECT * FROM GOMAS";
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Goma goma = new Goma();
                    string tamanio = reader["TAMANIO"].ToString();
                    string tipo = reader["TIPO"].ToString();
                    goma.Tamanio = (ETamanio)Enum.Parse(typeof(ETamanio), tamanio);
                    goma.TipoGoma = (ETipoGoma)Enum.Parse(typeof(ETipoGoma), tipo);
                    goma.Precio = (double)reader["PRECIO"];
                    goma.Marca = reader["MARCA"].ToString();
                    goma.Id = (int)reader["ID_GOMA"];
                    listaGoma.Add(goma);
                }
                reader.Close();
            }
            catch (Exception)
            {
                throw new ExceptionArchivo("Error al leer la base");
            }
            finally
            {
                if (conexion.State == System.Data.ConnectionState.Open)
                {
                    conexion.Close();
                }
            }

            return listaGoma;
        }

        /// <summary>
        /// Lee los datos del sacapunta desde la base de datos
        /// </summary>
        /// <returns></returns>
        /// <exception cref="ExceptionArchivo"></exception>
        public static List<Sacapunta> LeerDatosSacapuntas()
        {
            List<Sacapunta> listaSacapuntas = new List<Sacapunta>();

            try
            {
                command.Parameters.Clear();
                conexion.Open();
                command.CommandText = "SELECT * FROM SACAPUNTAS";
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Sacapunta sacapunta = new Sacapunta();
                    string tipo = reader["TIPO"].ToString();
                    sacapunta.TipoSacapuntas = (ETipoSacapuntas)Enum.Parse(typeof(ETipoSacapuntas), tipo);
                    sacapunta.Marca = reader["MARCA"].ToString();
                    sacapunta.Precio = (double)reader["PRECIO"];
                    sacapunta.Id = (int)reader["ID_SACAPUNTAS"];
                    listaSacapuntas.Add(sacapunta);
                }
                reader.Close();
            }
            catch (Exception)
            {
                throw new ExceptionArchivo("Error al leer la base");
            }
            finally
            {
                if (conexion.State == System.Data.ConnectionState.Open)
                {
                    conexion.Close();
                }
            }

            return listaSacapuntas;
        }

        /// <summary>
        /// Guarda los datos del lapiz en la base de datos 
        /// </summary>
        /// <param name="lapiz"></param>
        /// <exception cref="ExceptionArchivo"></exception>
        public static void GuardaLapiz(Lapiz lapiz)
        {
            try
            {
                command.Parameters.Clear();
                conexion.Open();
                command.CommandText = "INSERT INTO LAPICES VALUES (@precio,@marca,@tipo,@color)";

                command.Parameters.AddWithValue("@precio", lapiz.Precio);
                command.Parameters.AddWithValue("@marca", lapiz.Marca);
                command.Parameters.AddWithValue("@color", lapiz.Color);
                command.Parameters.AddWithValue("@tipo", lapiz.TipoDeLapiz);

                if (command.ExecuteNonQuery() == 0)
                {
                    throw new ExepcionesDatos("No se agrego Util");
                }

            }
            catch (Exception)
            {
                throw new ExceptionArchivo("Error al cargar el util a la base");
            }
            finally
            {
                if (conexion.State == System.Data.ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
        }

        public static void GuardaFibron(Fibron fibron)
        {
            try
            {
                command.Parameters.Clear();
                conexion.Open();
                command.CommandText = "INSERT INTO FIBRONES VALUES (@color,@cantidad)";
                command.Parameters.AddWithValue("@color", fibron.Color);
                command.Parameters.AddWithValue("@cantidad", fibron.CantidadTinta);

                if (command.ExecuteNonQuery() == 0)
                {
                    throw new ExepcionesDatos("No se agrego Util");
                }

            }
            catch (Exception)
            {
                throw new ExceptionArchivo("Error al cargar el util a la base");
            }
            finally
            {
                if (conexion.State == System.Data.ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
        }

        /// <summary>
        /// Guarda los datos del util goma en al base de datos 
        /// </summary>
        /// <param name="goma"></param>
        /// <exception cref="ExceptionArchivo"></exception>
        public static void GuardaGoma(Goma goma)
        {
            try
            {
                command.Parameters.Clear();
                conexion.Open();
                command.CommandText = "INSERT INTO GOMAS (PRECIO,MARCA,TIPO,TAMANIO) VALUES (@precio,@marca,@tipo,@tamanio)";
                if (goma is not null)
                {
                    command.Parameters.AddWithValue("@precio", goma.Precio);
                    command.Parameters.AddWithValue("@marca", goma.Marca);
                    command.Parameters.AddWithValue("@tipo", goma.TipoGoma);
                    command.Parameters.AddWithValue("@tamanio", goma.Tamanio);

                    if (command.ExecuteNonQuery() == 0)
                    {
                        throw new ExepcionesDatos("No se agrego Util");
                    }
                }

            }
            catch (Exception)
            {
                throw new ExceptionArchivo("Error al cargar el util a la base");
            }
            finally
            {
                if (conexion.State == System.Data.ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
        }

        /// <summary>
        /// Guarda en al base de datos los datosd el util sacapunta 
        /// </summary>
        /// <param name="sacapuntas"></param>
        /// <exception cref="ExceptionArchivo"></exception>
        public static void GuardaSacapuntas(Sacapunta sacapuntas)
        {
            try
            {
                command.Parameters.Clear();
                conexion.Open();
                command.CommandText = "INSERT INTO SACAPUNTAS VALUES (@precio,@marca,@tipo)";
                if (sacapuntas is not null)
                {
                    command.Parameters.AddWithValue("@precio", sacapuntas.Precio);
                    command.Parameters.AddWithValue("@marca", sacapuntas.Marca);
                    command.Parameters.AddWithValue("@tipo", sacapuntas.TipoSacapuntas);

                    if (command.ExecuteNonQuery() == 0)
                    {
                        throw new ExepcionesDatos("No se agrego Util");
                    }
                }

            }
            catch (Exception)
            {
                throw new ExceptionArchivo("Error al cargar el util a la base");
            }
            finally
            {
                if (conexion.State == System.Data.ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
        }

        /// <summary>
        /// Borra los datos de la base de datos dependiendo del util 
        /// </summary>
        /// <param name="util"></param>
        /// <exception cref="ExceptionArchivo"></exception>
        public static void BorraDatos(Util util)
        {
            try
            {
                command.Parameters.Clear();
                conexion.Open();
                switch (util)
                {
                    case Lapiz:
                        command.CommandText = $"DELETE FROM LAPICES WHERE ID_LAPIZ = {util.Id}";
                        command.ExecuteNonQuery();
                        break;
                    case Goma:
                        command.CommandText = $"DELETE FROM GOMAS WHERE ID_GOMA = {util.Id}";
                        command.ExecuteNonQuery();
                        break;
                    case Sacapunta:
                        command.CommandText = $"DELETE FROM SACAPUNTAS WHERE ID_SACAPUNTAS = {util.Id}";
                        command.ExecuteNonQuery();
                        break;
                    case Fibron:
                        command.CommandText = $"DELETE FROM FIBRONES WHERE ID_SACAPUNTAS = {util.Id}";
                        command.ExecuteNonQuery();
                        break;
                    default:
                        throw new ExceptionArchivo("No se pudo borrar");

                }
            }
            catch (Exception)
            {
                throw new ExceptionArchivo("Error al borrar la base");
            }
            finally
            {
                if (conexion.State == System.Data.ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
        }
        
        /// <summary>
        /// Modifica los datos del sacapunta pisando los datos por los nuevos en ese mismo id 
        /// </summary>
        /// <param name="sacapunta"></param>
        /// <exception cref="ExceptionArchivo"></exception>
        public static void ModificarSacapuntas(Sacapunta sacapunta)
        {
            try
            {
                command.Parameters.Clear();
                conexion.Open();
                command.CommandText = $"UPDATE SACAPUNTAS SET PRECIO = @precio, MARCA = @marca ,TIPO = @tipo WHERE ID_SACAPUNTAS = {sacapunta.Id}";
                if (sacapunta is not null)
                {
                    command.Parameters.AddWithValue("@precio", sacapunta.Precio);
                    command.Parameters.AddWithValue("@marca", sacapunta.Marca);
                    command.Parameters.AddWithValue("@tipo", sacapunta.TipoSacapuntas);

                    if (command.ExecuteNonQuery() == 0)
                    {
                        throw new ExepcionesDatos("No se modifico Util");
                    }
                }

            }
            catch (Exception)
            {
                throw new ExceptionArchivo("Error al modificar el util a la base");
            }
            finally
            {
                if (conexion.State == System.Data.ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
        }

        public static void ModificarFibron(Fibron fibron)
        {
            try
            {
                command.Parameters.Clear();
                conexion.Open();
                command.CommandText = $"UPDATE FIBRONES SET COLOR = @color, @cantidadtinta WHERE ID_FIBRON = {fibron.Id}";
                if (fibron is not null)
                {

                    command.Parameters.AddWithValue("@color", fibron.Color); 
                    command.Parameters.AddWithValue("@cantidadtinta", fibron.CantidadTinta);

                    if (command.ExecuteNonQuery() == 0)
                    {
                        throw new ExepcionesDatos("No se modifico Util");
                    }
                }

            }
            catch (Exception)
            {
                throw new ExceptionArchivo("Error al modificar el util a la base");
            }
            finally
            {
                if (conexion.State == System.Data.ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
        }

        /// <summary>
        /// Modifica los datos del util goma pisando los datos por los nuevos en ese mismo id
        /// </summary>
        /// <param name="goma"></param>
        /// <exception cref="ExceptionArchivo"></exception>
        public static void ModificarGoma(Goma goma)
        {
            try
            {
                command.Parameters.Clear();
                conexion.Open();
                command.CommandText = $"UPDATE GOMAS SET PRECIO = @precio,MARCA = @marca,TIPO = @tipo,TAMANIO = @tamanio WHERE ID_GOMA = {goma.Id}";
                if (goma is not null)
                {
                    command.Parameters.AddWithValue("@precio", goma.Precio);
                    command.Parameters.AddWithValue("@marca", goma.Marca);
                    command.Parameters.AddWithValue("@tamanio", goma.Tamanio);
                    command.Parameters.AddWithValue("@tipo", goma.TipoGoma);

                    if (command.ExecuteNonQuery() == 0)
                    {
                        throw new ExepcionesDatos("No se modifico Util");
                    }
                }

            }
            catch (Exception)
            {
                throw new ExceptionArchivo("Error al modificar el util a la base");
            }
            finally
            {
                if (conexion.State == System.Data.ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
        }

        /// <summary>
        /// Modifica los datos del lapiz pisando los datos por los nuevos en ese mismo id
        /// </summary>
        /// <param name="lapiz"></param>
        /// <exception cref="ExceptionArchivo"></exception>
        public static void ModificarLapiz(Lapiz lapiz)
        {
            try
            {
                command.Parameters.Clear();
                conexion.Open();
                command.CommandText = $"UPDATE LAPICES SET PRECIO = @precio,MARCA = @marca,TIPO = @tipo,COLOR = @color WHERE ID_LAPIZ = {lapiz.Id}";
                if (lapiz is not null)
                {
                    command.Parameters.AddWithValue("@precio", lapiz.Precio);
                    command.Parameters.AddWithValue("@marca", lapiz.Marca);
                    command.Parameters.AddWithValue("@tipo", lapiz.TipoDeLapiz);
                    command.Parameters.AddWithValue("@color", lapiz.Color);

                    if (command.ExecuteNonQuery() == 0)
                    {
                        throw new ExepcionesDatos("No se modifico Util");
                    }
                }

            }
            catch (Exception)
            {
                throw new ExceptionArchivo("Error al modificar el util a la base");
            }
            finally
            {
                if (conexion.State == System.Data.ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
        }

    }
}
