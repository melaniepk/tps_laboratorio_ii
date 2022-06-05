using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Xml;
using System.IO;
using System.Xml.Serialization;
using System.Text.Json.Serialization;

namespace Entidades
{
    public class Serializador<T> : IArchivo<T> where T : class
    {
        //xml

        public string path;
        public string ruta;
        public Serializador()
        {
            path = AppDomain.CurrentDomain.BaseDirectory;
            ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        }

        /// <summary>
        /// escribe un archivo xml, lo crea si el directorio no existe
        /// en caso de no poder escibirlo, lanza una excepcion
        /// </summary>
        /// <param name="cliente"></param>
        /// <exception cref="SerializarException"></exception>
        public  void Escribir(T cliente)
        {
            string nombreArchivo = ruta + @"\dataset.xml";

            try
            {
                if (!Directory.Exists(ruta))
                {
                    Directory.CreateDirectory(ruta);
                }
                using (StreamWriter streamWriter = new StreamWriter(nombreArchivo))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
                    xmlSerializer.Serialize(streamWriter, cliente);
                }

            }
            catch (Exception e)
            {
                throw new SerializarException($"Error en el archivo ubicado en {ruta}","Clase Serializador","Metodo Escribir(xml)", e);
            }
        }

        /// <summary>
        /// lee un archivo xml si el directorio y el archivo existen
        /// caso contrario lanza una excepcion
        /// </summary>
        /// <returns></returns>
        /// <exception cref="SerializarException"></exception>
        public T Leer()
        {
            string archivo = string.Empty;
            string informacionRecuperada = string.Empty;
            T cliente = null;

            try
            {

                if (Directory.Exists(ruta))
                {
                    string[] archivosEnElPath = Directory.GetFiles(ruta);
                    foreach (string path in archivosEnElPath)
                    {
                        if (path.Contains("dataset.xml"))
                        {
                            archivo = path;
                            break;
                        }
                    }

                    if (archivo != null)
                    {

                        using (StreamReader sr = new StreamReader(archivo))
                        {

                            XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
                            cliente = (T)xmlSerializer.Deserialize(sr);

                        }
                    }
                }

                return cliente;
            }
            catch (Exception e)
            {
                throw new SerializarException($"Error en el archivo ubicado en {ruta}","clase serializador","Metodo Leer (xml)", e);
            }
        }


        // json

        /// <summary>
        /// escribe un archivo json con cualquier dato recibido que sea
        /// una clase, crea el directorio si este no existe
        /// de no poder escibirlo, lanza una excepcion
        /// </summary>
        /// <param name="datos"></param>
        /// <param name="nombre"></param>
        /// <exception cref="SerializarException"></exception>
        public void EscribirArchivo(T datos, string nombre)
        {
            string nombreArchivo = path + "SerializandoJson_" + nombre + ".json";

            try
            {
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }


                File.WriteAllText(nombreArchivo, JsonSerializer.Serialize(datos));

            }
            catch (Exception e)
            {
                throw new SerializarException($"Error en el archivo ubicado en {path}","Clase Serializador","Metodo EscribirArchivo(json)", e);
            }
        }

        /// <summary>
        /// lee un archivo json si este y el directorio existen, devuelve los datos del archivo en un tipo 
        /// generico. en caso de fallar,lanza una excepcion
        /// </summary>
        /// <param name="nombre"></param>
        /// <returns></returns>
        /// <exception cref="SerializarException"></exception>
        public T LeerArchivo(string nombre)
        {
            string archivo = string.Empty;
            string informacionRecuperada = string.Empty;
            T datosRecuperados = default;
            try
            {

                if (Directory.Exists(path))
                {
                    string[] archivosEnElPath = Directory.GetFiles(path);
                    foreach (string path in archivosEnElPath)
                    {
                        if (path.Contains(nombre))
                        {
                            archivo = path;
                            break;
                        }
                    }

                    if (archivo != null)
                    {
                        datosRecuperados = JsonSerializer.Deserialize<T>(File.ReadAllText(archivo));
                    }
                }

                return datosRecuperados;
            }
            catch (Exception e)
            {
                throw new SerializarException($"Error en el archivo ubicado en {path}","Clase Serializar","Metodo LeerArchivo (json)", e);
            }

        }


    }

}


        
    

