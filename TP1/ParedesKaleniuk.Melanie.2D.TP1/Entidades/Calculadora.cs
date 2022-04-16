using System;


namespace Entidades
{
    public static class Calculadora
    {
        /// <summary>
        /// calcula el resultado entre los dos operandos y el operador que recibe por parametros
        /// 
        /// </summary>
        /// <param name="num1">primer operando</param>
        /// <param name="num2">segundo operando</param>
        /// <param name="operador">operador</param>
        /// <returns>devuelve el resultado de la operacion</returns>
        public static double Operar(Operando num1, Operando num2, char operador)
        {
            double resultado;

            switch(ValidarOperador(operador))
            {
                case '+':
                    resultado = num1 + num2;
                    break;
                case '-':
                    resultado = num1 - num2;
                    break ;
                case '*':
                    resultado = num1 * num2;
                    break;
                case '/':
                    resultado = num1 / num2;
                    break;
                default:  
                    resultado = num1 + num2;
                    break;

            }
            return resultado;


        }

        /// <summary>
        /// valida que el operador seleccionado sea valido, en caso contrario retorna +
        /// </summary>
        /// <param name="operador">operador seleccioando</param>
        /// <returns>operador o "+"</returns>
        private static char ValidarOperador(char operador)
        {
            char retorno = '+';

            if(operador.Equals('+') || operador.Equals('-') || operador.Equals('*') || operador.Equals('/'))
            {
                return operador;
            }
            else
            {
                return retorno;
            }
        }
    }
}
