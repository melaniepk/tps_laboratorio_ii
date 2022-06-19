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
        }

        /// <summary>
        /// Crea las membresias y las serializa en un archivo
        /// </summary>
        public static void CrearMembresias()
        {
            membresias = new List<Membresia>()
            {
                new Membresia(ENombre.Basic, ETurnos.DosTurnos, EPrecio.MilQuinientos),
                new Membresia(ENombre.Plus, ETurnos.TresTurnos, EPrecio.DosMil),
                new Membresia(ENombre.Full, ETurnos.CincoTurnos, EPrecio.TresMil)
            };

            Serializador<List<Membresia>> membList = new Serializador<List<Membresia>>();
            membList.EscribirArchivo(membresias, "MembresiasJson");

        }

    }
}
