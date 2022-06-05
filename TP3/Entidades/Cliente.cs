using System;
using System.Text;

namespace Entidades
{
    public enum EGenero
    {
        Femenino,
        Masculino,
        NoBinario
    }
    public class Cliente
    {
        string nombre;
        string apellido;
        EGenero genero;
        int dni;
        int telefono;
        Membresia planAdquirido;
        bool estaActivo;

        public Cliente()
        {

        }

        public Cliente(int dni):this()
        {

        }
        public Cliente(string nombre, string apellido, EGenero genero, int dni, int telefono, Membresia planAdquirido,bool estaActivo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.genero = genero;
            this.dni = dni;
            this.telefono = telefono;
            this.planAdquirido = planAdquirido;
            this.estaActivo = estaActivo;
           
        }

        public string Nombre { get { return nombre; } set { nombre = value; } }
        public string Apellido { get { return apellido; } set { apellido = value; } }
        public EGenero Genero { get { return genero; } set { genero = value; } }
        public int Dni { get { return dni; } set { dni = value; } }
        public int Telefono { get { return telefono; } set { telefono = value; } }
        public Membresia PlanAdquirido { get { return planAdquirido; } set { planAdquirido = value; } }
        public bool EstaActivo { get { return estaActivo; } set { estaActivo = value; } }

        /// <summary>
        /// devuelve los datos importantes de un cliente
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("TICKET DE SUSCRIPCION");
            sb.AppendLine($"Nombre Cliente: {nombre}");
            sb.AppendLine($"Apellido Cliente : {apellido}");
            sb.AppendLine($"DNI: {dni}");
            sb.AppendLine($"Plan Adquirido: {planAdquirido.Nombre}");
            sb.AppendLine($"Precio del plan: {planAdquirido.Precio}");
            return sb.ToString();
        }
        /// <summary>
        /// comprueba que exista un dni igual al
        /// ingresado por parametro
        /// </summary>
        /// <param name="dni"></param>
        /// <returns>true si se encuentra un dni en la lista igual al
        /// dni del parametro, false en caso contrario</returns>
        public static bool ComprobarExistencia(int dni)
        {
            foreach (Cliente cliente in Base.clientes)
            {
                if (dni == cliente.Dni)
                {
                    return true;
                }
            }
            return false;

        }

        /// <summary>
        /// comprueba los datos recibidos para crear al cliente,
        /// llama al contructor y devuelve un cliente en caso favorable, null en caso
        /// de que no lo pueda crear
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="genero"></param>
        /// <param name="dni"></param>
        /// <param name="telefono"></param>
        /// <param name="membresia"></param>
        /// <param name="estaACtivo"></param>
        /// <returns>un cliente o null</returns>
        public static Cliente CrearCliente(string nombre, string apellido, EGenero genero, int dni, int telefono, Membresia membresia,bool estaACtivo)
        {
            if (!string.IsNullOrEmpty(nombre) && !string.IsNullOrEmpty(apellido) && dni > 1000000
                        && dni < 99999999 && membresia != null)
            {
                nombre.ToLower();
                apellido.ToLower();
                Cliente nuevoCliente = new Cliente(nombre, apellido, genero, dni, telefono, membresia, estaACtivo);
                return nuevoCliente;
            }
            return null;
        }


    }
}
