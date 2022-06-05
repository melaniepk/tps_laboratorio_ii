using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Membresia
    {
        string nombre;
        int turnos;
        double precio;

        public Membresia()
        {

        }

        public Membresia(string nombre, int turnos, double precio)
        {
            this.nombre = nombre;
            this.turnos = turnos;
            this.precio = precio;
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public int Turnos
        {
            get { return turnos; }
            set { turnos = value; }
        }

        public double Precio
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
            if(!string.IsNullOrEmpty(nombre))
            {
                if (nombre == "Basic")
                {
                    membresia = Base.membresias[0];
                }
                else if (nombre == "Plus")
                {
                    membresia = Base.membresias[1];
                }
                else if(nombre == "Full")
                {
                    membresia = Base.membresias[2];
                }
                return membresia;
            }
            return membresia;
        }
    }
}
