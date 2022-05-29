using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExemplosOrientacaoObjetos.Pessoas
{
    public class ExemploPessoa
    {
        public void Executar()
        {
            var claudinho = new Pessoa();
            claudinho.Nome = "Claudinho";
            claudinho.Altura = 2.03;
            claudinho.Peso = 98;

            claudinho.CalcularImc();
            claudinho.ApresentarImc();
        }
    }
}