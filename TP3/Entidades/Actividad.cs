using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Actividad
    {
         string nombre;
         int cantAlumnos;
         string dias;
         string horario;

        public  Actividad()
        {

        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public int CantAlumnos
        {
            get { return cantAlumnos;}
            set { cantAlumnos = value; }
        }

        public string Dias
        {
            get { return dias;}
            set { dias = value; }
        }

        public string Horario
        {
            get { return horario;}
            set { horario = value; }
        }
    }
}
