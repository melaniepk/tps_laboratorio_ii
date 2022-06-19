using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
   public enum ENombre
    {
        Basic,Plus,Full
    }
    public enum ETurnos
    {
        DosTurnos =2,
        TresTurnos =3,
        CincoTurnos=5
    }
    public enum EPrecio
    {
        MilQuinientos = 1500,
        DosMil=2000,
        TresMil= 3000
    }
    public class Membresia
    {
        public ENombre nombre;
        public ETurnos turnos;
        public EPrecio precio;

        public Membresia()
        {

        }

        public Membresia(ENombre nombre, ETurnos turnos, EPrecio precio)
        {
            this.nombre = nombre;
            this.turnos = turnos;
            this.precio = precio;
        }
        public ENombre Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public ETurnos Turnos
        {
            get { return turnos; }
            set { turnos = value; }
        }

        public EPrecio Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        /// <summary>
        /// comprueba que el nombre recibido por parametro correpponda a una membresia existente
        /// en caso favorable devuelve la membresia, sino devuelve null
        /// </summary>
        /// <param name="nombre"></param>
        /// <returns>membresia o null</returns>
        public static Membresia MembresiaCorrespondiente(string nombre)
        {
            Membresia membresia = null;
            if (!string.IsNullOrEmpty(nombre))
            {
                if (nombre == "Basic")
                {
                    membresia = Base.membresias[0];
                }
                else if (nombre == "Plus")
                {
                    membresia = Base.membresias[1];
                }
                else if (nombre == "Full")
                {
                    membresia = Base.membresias[2];
                }
                return membresia;
            }
            return membresia;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{nombre}");
            return sb.ToString();
        }
    }
}
