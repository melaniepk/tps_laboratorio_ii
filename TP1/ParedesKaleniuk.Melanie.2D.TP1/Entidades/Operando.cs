using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Operando
    {
        private double numero;

       
        public string Numero
        {
            set 
            {
                this.numero = this.ValidarOperando(value);
            }
        }

        
        public Operando()
        {
            this.numero = 0;
        }

        public Operando(double numero)
        {
            this.numero = numero;
        }

        public Operando(string strNumero)
        {
            this.Numero = strNumero;
        }

     
        /// <summary>
        /// comprueba si el strign pasado por parametro corresponde o no a un numero binario
        /// </summary>
        /// <param name="binario">string pasado por parametro</param>
        /// <returns>true o false</returns>
        private static bool EsBinario(string binario)
        {
            foreach (char c in binario)
            {
                if (c != '0' && c != '1')
                {
                    return false;
                }
            }
            return true;

        }

        /// <summary>
        /// convierte un numero binario en un numero decimal de ser posible, en caso contrario retorna invalido
        /// </summary>
        /// <param name="binario">string de parametro</param>
        /// <returns>string de numero decimal o "valor invalido"</returns>
        public string BinarioDecimal(string binario)
        {          
            
            if(EsBinario(binario))
            {
                char[] arrayDeBinario = binario.ToCharArray();
                Array.Reverse(arrayDeBinario);
                int sum = 0;

                for (int i = 0; i < arrayDeBinario.Length; i++)
                {
                    if (arrayDeBinario[i] == '1')
                    {
                        sum += (int)Math.Pow(2, i);
                    }
                }
                return sum.ToString();
            }
            else
            {                
               return "Valor inválido";
            }   
            
        }

        /// <summary>
        /// convierte un numero decimal a binario de ser posibible
        /// 
        /// </summary>
        /// <param name="numero">souble recibido por parametro</param>
        /// <returns>string de numero binario</returns>
        public string DecimalBinario(double numero)
        {
            
            string binarioResultado = string.Empty;

            int numAConvertir = (int)Math.Abs(numero);

            if (numAConvertir == 0)
            {
                binarioResultado = "0";
            }
            else
            {
                while (numAConvertir > 0)
                {
                    binarioResultado = (int)numAConvertir % 2 + binarioResultado;
                    numAConvertir = (int)numAConvertir / 2;
                }

            }

            return binarioResultado;

        }

        /// <summary>
        /// utiliza la sobrecarga DecimalBinario y convierte un string de numero decimal
        /// a un string de numero binario, en caso de ser imposible devuelve "valor invalido"
        /// </summary>
        /// <param name="numero">string numero por parametro</param>
        /// <returns>resultado en binario o "valor invalido"</returns>
        public string DecimalBinario(string numero)
        {
            double numeroD;
            string resultado = "0";
            if (double.TryParse(numero, out numeroD))
            {
                resultado = DecimalBinario(numeroD);

            }
            else
            {
                return "Valor inválido";
            }

            return resultado;
           
        }

        
        /// <summary>
        /// valida que el operando recibido sea valido, un numero
        /// </summary>
        /// <param name="strNumero">string de poperando recibido</param>
        /// <returns>devuelve 0 o el operando</returns>
        public double ValidarOperando(string strNumero)
        {
            double retorno = 0;
            double op;
            if (double.TryParse(strNumero.Replace('.', ','), out op))
            {
                retorno = op;
            }
            return retorno;
        }


        public static double operator +(Operando n1, Operando n2)
        {
            return n1.numero + n2.numero;
        }
        public static double operator -(Operando n1, Operando n2)
        {

            return n1.numero - n2.numero;
        }

        public static double operator *(Operando n1,Operando n2)
        {
            return n1.numero * n2.numero;
        }

        public static double operator /(Operando n1, Operando n2)
        {
            if(n2.numero == 0)
            {
                return double.MinValue;
            }
            return n1.numero / n2.numero;
        }



    }
}
