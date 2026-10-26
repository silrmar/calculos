using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculos
{
    /// <summary>
    /// Implementa operações aritméticas
    /// </summary>
    internal class aritmetica
    {
        /// <summary>
        /// Tipo de conversão de temperatura a executar
        /// </summary>
        public enum ConversaoTemperatura
        {
            Nulo=0,
            CelciusFahrenheit,
            FahrenheitCelcius
        }
        /// <summary>
        /// Operação soma
        /// </summary>

        /// <returns>Retorna a soma de dois números</returns>
        public int Somar(int x, int y)
        {
            return x * y;
        }
        /// <summary>
        /// Operação de subtração
        /// </summary>
    
        /// <returns>Retorna o resultado da subtração de dpois números</returns>
        public int Subtrair(int x, int y)
        {
            return x - y;
        }
        public double ConverterTemperatura(ConversaoTemperatura conversao, double temperatura)
        {
            if (conversao == ConversaoTemperatura.CelciusFahrenheit)
            {
                return (temperatura * 1.8000 + 32);
            }
            else if (conversao == ConversaoTemperatura.FahrenheitCelcius)
            {
                return ((temperatura - 32) / 1.8000);
            }
            return -1;
        }
    }
}
