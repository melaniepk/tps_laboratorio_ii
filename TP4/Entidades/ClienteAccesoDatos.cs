using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Entidades
{
    public class ClienteAccesoDatos
    {
        static string connectionString;
        static SqlCommand command;
        static SqlConnection connection;

        /// <summary>
        /// crea la conexion con la base de datos
        /// </summary>
        static ClienteAccesoDatos()
        {
            connectionString = @"Data Source=.;Initial Catalog= GimansioJustDoIt;Integrated Security=True";
            command = new SqlCommand();
            connection = new SqlConnection(connectionString);
            command.CommandType = System.Data.CommandType.Text;
            command.Connection = connection;
        }

        /// <summary>
        /// hace un insert en la base de datos con los datos ingresados por parametro
        /// de no ser posible, lanza una excepcion
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="genero"></param>
        /// <param name="dni"></param>
        /// <param name="telefono"></param>
        /// <param name="membresia"></param>
        /// <param name="estaActivo"></param>
        public static void Guardar(string nombre,string apellido,EGenero genero,int dni,int telefono,string membresia,bool estaActivo)
        {
            try
            {
                command.Parameters.Clear();
                connection.Open();
                command.CommandText = $"INSERT INTO Clientes (Nombre,Apellido,Genero,DNI,Telefono,Membresia,EstaActivo)" +
                    $" VALUES (@Nombre,@Apellido,@Genero,@DNI,@Telefono,@Membresia,@EstaActivo)";
                command.Parameters.AddWithValue("@Nombre", nombre);
                command.Parameters.AddWithValue("@Apellido", apellido);
                command.Parameters.AddWithValue("@Genero", genero);
                command.Parameters.AddWithValue("@DNI", dni);
                command.Parameters.AddWithValue("@Telefono", telefono);
                command.Parameters.AddWithValue("@Membresia", membresia);
                command.Parameters.AddWithValue("@EstaActivo", estaActivo);

                int rows = command.ExecuteNonQuery();
                
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        /// <summary>
        /// hace un update en el campo estaActivo del cliente 
        /// del dni recibido por parametro
        /// </summary>
        /// <param name="dni"></param>
        public static void Eliminar(int dni)
        {
            try
            {
                command.Parameters.Clear();
                connection.Open();
                command.CommandText = $"UPDATE Clientes SET EstaActivo = @EstaActivo WHERE DNI ={dni} ";
                command.Parameters.AddWithValue("@DNI", dni);
                command.Parameters.AddWithValue("@EstaActivo", 0);

                int rows = command.ExecuteNonQuery();

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        public static List<Cliente> clientes = new List<Cliente>();

        /// <summary>
        /// lee la base de datos de clientes, los añade a una lista y la devuelve
        /// en caso de no ser posible, lanza una excepcion.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public static List<Cliente> LeerClientes()
        {

            try
            {
                connection.Open();
                command.CommandText = "SELECT * FROM Clientes";

                using (SqlDataReader dataReader = command.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        Cliente cliente = new Cliente();

                        cliente.Nombre = dataReader["Nombre"].ToString();
                        cliente.Apellido = dataReader["Apellido"].ToString();
                        cliente.Genero = (EGenero)Enum.Parse(typeof(EGenero), dataReader["Genero"].ToString());
                        cliente.Dni = int.Parse(dataReader["Dni"].ToString());
                        cliente.Telefono = int.Parse(dataReader["Telefono"].ToString());
                        cliente.PlanAdquirido = dataReader["Membresia"].ToString();
                        cliente.EstaActivo = Convert.ToBoolean(dataReader["EstaActivo"]);

                        
                        clientes.Add(cliente);

                    }
                    return clientes;
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Imposible leer la base de datos, excepcion : {ex.Message}");

            }
            finally
            {
                connection.Close();
            }

        }
    }
}

