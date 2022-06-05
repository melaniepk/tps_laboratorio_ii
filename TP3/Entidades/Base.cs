using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Base
    {
       public static List<Cliente> clientes;
       public static List<Membresia> membresias;

        public static void CargarClientes()
        {
            clientes = new List<Cliente>();
            CrearMembresias();
            CrearClientes();
            SerializarClientes();
       
        }

        /// <summary>
        /// Crea las membresias
        /// </summary>
        public static void CrearMembresias()
        {
            membresias = new List<Membresia>(); 
            membresias.Add(new Membresia("Basic",2,1500));
            membresias.Add(new Membresia("Plus", 3, 2000));
            membresias.Add(new Membresia("Full", 5, 3000));
        }

        /// <summary>
        /// Crea los clientes base de la app
        /// </summary>
        public static void CrearClientes()
        {

            clientes.Add(new Cliente("Juan", "Perez", EGenero.Masculino,35256365,1585987465,membresias[0],true));
            clientes.Add(new Cliente("Maria", "Juaez", EGenero.Femenino, 35896365, 1585787465, membresias[1],true));
            clientes.Add(new Cliente("Pedro", "Messi", EGenero.NoBinario, 35256965, 1565987465, membresias[2],true));
            
        }

        /// <summary>
        /// serializa toda la lista de clientes
        /// sirve para actualizarla
        /// </summary>
        public static void SerializarClientes()
        {
            Serializador<List<Cliente>> clienteSerializador = new Serializador<List<Cliente>>();
            try
            {
                clienteSerializador.Escribir(clientes);
            }
            catch(Exception ex)
            {
                throw new Exception($"{ex.Message}");
            }
        }

    }
}
