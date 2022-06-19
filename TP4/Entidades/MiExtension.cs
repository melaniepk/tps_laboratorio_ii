using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class MiExtension
    {
        /// <summary>
        /// cuenta las letras del string recibido y retorna la cantidad
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static int ContarLetras(this string str)
        {
            int contador = 0;
            Action contar = () => contador++;
            foreach(char caracter in str)
            {
                contar();
            }
            return contador;
        }
    }
}
