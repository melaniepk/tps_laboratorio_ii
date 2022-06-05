using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Archivo : IArchivo<string>
    {
        static string path;
        public Archivo()
        {
            path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            path += @"\Archivo-Ticket\";
        }

        /// <summary>
        /// crea un directorio si no existe el path y escibe los datos pasados
        /// por parametro en el archivo, en caso de no ser posible aroja una excepcion
        /// </summary>
        /// <param name="datos"></param>
        /// <param name="nombre"></param>
        /// <exception cref="ArchivosException"></exception>
        public void EscribirArchivo(string datos,string nombre)
        {
            string nombreArchivo = path + nombre + ".txt";
            try
            {
                if(!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
                
                File.WriteAllText(nombreArchivo, datos);
            }
            catch(Exception ex)
            {
                throw new ArchivosException($"Ocurrió un error al escribir el archivo {nombreArchivo}", ex);
            }
        }

        /// <summary>
        /// lee un archivo del path señalado, si el path 
        /// y el archivo existen, caso contrario aroja una excepcion
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        /// <exception cref="ArchivosException"></exception>
        public string LeerArchivo(string path)
        {
            string archivo = string.Empty;
            string informacionRecuperada = string.Empty;
            try
            {

                if (Directory.Exists(path))
                {
                    string[] archivosEnElPath = Directory.GetFiles(path);
                    foreach (string ruta in archivosEnElPath)
                    {
                        if (path.Contains("Nuevo-Ticket"))
                        {
                            archivo = ruta;
                            break;
                        }
                    }

                    if (archivo != null)
                    {
                        informacionRecuperada = File.ReadAllText(archivo);
                    }
                }

                return informacionRecuperada;
            }
            catch (Exception e)
            {
                throw new ArchivosException($"Error en el archivo ubicado en {path}", e);
            }

        }

    }

    
}
