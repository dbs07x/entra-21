using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExemplosOrientacaoObjetos.Carros
{
    public class Carro
    {
        public string Modelo;
        public double ValorFipe, ValorParcela;
        public int QuantidadeParcelas, AnoFabricacao, TotalParcialPercorrido, TamanhoTanque;

        public double CalcularValorTotalEmprestimo()
        {
            var valorEmprestimo = (QuantidadeParcelas * ValorParcela) + 30;

            return valorEmprestimo;
        }

        public double CalcularJuros()
        {
            var valorTotalEmprestimo = CalcularValorTotalEmprestimo();
            var valorJuros = 0.0;

            if (valorTotalEmprestimo - ValorFipe >= 0)
            {
                valorJuros = valorTotalEmprestimo - ValorFipe;
            }

            return valorJuros;
        }

        public double CalcularConsumo()
        {
            return TotalParcialPercorrido / Convert.ToDouble(TamanhoTanque);
        }

        public bool VerificarSeCarroVelho()
        {
            // Operador ternário
            return AnoFabricacao < 2010
            ? true
            : false;
        }

        public bool ValidarCompraValida()
        {
            var consumo = CalcularConsumo();

            if (consumo <= 12)
            {
                // Não devo comprar o carro pois consome mto combustível
                return false;
            }

            var ehVelho = VerificarSeCarroVelho();

            if (ehVelho == true)
            {
                // Não devo comprar o carro pois ele é velho
                return false;
            }

            var jurosAbusivos = ValidarQueValorJurosEhAbusivo();
            if (jurosAbusivos == true)
            {
                // Não devo pagar além de 40% do valor da fipe
                return false;
            }

            return true;
        }

        public bool ValidarQueValorJurosEhAbusivo()
        {
            // FIPE                 100%
            // ValorTotalEmprestimo
            var valorTotalEmprestimo = CalcularValorTotalEmprestimo();
            var percentualJuros = (valorTotalEmprestimo * 100) / ValorFipe;

            if (percentualJuros > 140)
            {
                return true;
            }

            return false;
        }
    }
}
