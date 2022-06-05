using System;
using System.Runtime.Serialization;

namespace Entidades
{
    [Serializable]
    internal class ArchivosException : Exception
    {
        private Exception e;

        public ArchivosException()
        {
        }

        public ArchivosException(Exception e)
        {
            this.e = e;
        }


        public ArchivosException(string message, Exception innerException) : base(message, innerException)
        {

        }

    }
}