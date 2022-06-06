using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosOrientacaoObjetos.Exercicio02
{
    public class Temperatura
    {
        /*Criar uma classe chamada Temperatura, armazenar as seguintes propriedades:
        - Temperatura de origem
        - Temperatura de destino
        - Valor da temperatura

        Criar métodos:
        - Calcular Celsius para Kelvin
        - Calcular Celsius para Fahrenheit
        - Calcular Kelvin para Celsius
        - Calcular Kelvin para Fahrenheit
        - Calcular Fahrenheit para Celsius
        - Calcular Fahrenheit para Kelvin
        - Obter temperatura convertida

        Exemplo:
        Input:
        Temperatura origem: usuário digitou ‘Celcius’
        Temperatura destino: usuário digitou ‘Fahrenheit’
        Temperatura valor: usuário digitou 42.30;
        Processamento:
        Deve-se executar o método ‘Calcular Celsius para Fahrenheit’, pois de acordo com origem e
        destino deve executar este método.
        Output:
        Temperatura convertida: 108,14
        Obs.: Criar testes unitários, assim como, ExercicioTemperatura.*/

        public string TemperaturaOrigem, TemperaturaDestino;
        public double TemperaturaValor;

        public double CelsiusParaKelvin()
        {
            var calculoCelsiusParaKelvin = TemperaturaValor + 273.15;

            return calculoCelsiusParaKelvin;
        }

        public double CelsiusParaFahrenheit()
        {
            var calculoCelsiusParaFahrenheit = TemperaturaValor * 1.8 + 32;

            return calculoCelsiusParaFahrenheit;
        }

        public double KelvinParaCelsius()
        {
            var calculoKelvinParaCelsius = TemperaturaValor - 273.15;

            return calculoKelvinParaCelsius;
        }

        public double KelvinParaFahrenheit()
        {
            var calculoKelvinParaFahrenheit = 1.8 * (TemperaturaValor - 273.15) + 32;

            return calculoKelvinParaFahrenheit;
        }

        public double FahrenheitParaCelsius()
        {
            var calculoFahrenheitParaCelsius = (TemperaturaValor - 32) / 1.8;

            return calculoFahrenheitParaCelsius;
        }

        public double FahrenheitParaKelvin()
        {
            var calculoFahrenheitParaKelvin = (TemperaturaValor + 459.67) * 5 / 9;

            return calculoFahrenheitParaKelvin;
        }

        public double ObterTemperaturaConvertida()
        {

            var temperaturaConvertida = 0.00;
            if (TemperaturaOrigem == "celsius" && TemperaturaDestino == "kelvin")
            {
                temperaturaConvertida = CelsiusParaKelvin();
            }

            else if (TemperaturaOrigem == "celsius" && TemperaturaDestino == "fahrenheit")
            {
                temperaturaConvertida = CelsiusParaFahrenheit();
            }

            else if (TemperaturaOrigem == "kelvin" && TemperaturaDestino == "celsius")
            {
                temperaturaConvertida = KelvinParaCelsius();
            }

            else if (TemperaturaOrigem == "kelvin" && TemperaturaDestino == "fahrenheit")
            {
                temperaturaConvertida = KelvinParaFahrenheit();
            }

            else if (TemperaturaOrigem == "fahrenheit" && TemperaturaDestino == "celsius")
            {
                temperaturaConvertida = FahrenheitParaCelsius();
            }

            else if (TemperaturaOrigem == "fahrenheit" && TemperaturaDestino == "kelvin")
            {
                temperaturaConvertida = FahrenheitParaKelvin();
            }

            return temperaturaConvertida;
        }
    }
}
