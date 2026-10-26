using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculos
{
    /// <summary>
    /// Implemneta operações de conversão
    /// </summary>
    internal static class Conversoes
    {
        /// <summary>
        /// Tipo de conversão de temperatura a executar
        /// </summary>
        public enum ConversaoTemperatura
        {
            Nulo = 0,
            CelciusFahrenheit,
            FahrenheitCelcius
        }
        /// <summary>
        /// 
        /// 
        /// </summary>
        /// <param name="conversao">A conversão a efeturar</param>
        /// <param name="temperatura">A temperatura a converter</param>
        /// <returns>Retorna o resultado da conversão</returns>
        public static double ConverterTemperatura(ConversaoTemperatura conversao, double temperatura)
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
