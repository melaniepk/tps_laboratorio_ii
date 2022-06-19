using System;
using System.Runtime.Serialization;

namespace Entidades
{
    [Serializable]
    public class SerializarException : Exception
    {
        private string mensaje;
        private string clase;
        private string metodo;
        private Exception e;

        public SerializarException()
        {
        }


        public SerializarException(string mensaje, string clase, string metodo, Exception e)
        {
            this.mensaje = mensaje;
            this.clase = clase;
            this.metodo = metodo;
            this.e = e;
        }

       
    }
}