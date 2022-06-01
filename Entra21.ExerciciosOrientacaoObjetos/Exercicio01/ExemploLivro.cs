using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosOrientacaoObjetos.Exercicio01
{
    public class ExemploLivro
    {
        public void Executar()
        {
            Livro livro = new Livro();
            livro.Titulo = "O pequeno principe";
            livro.Autor = "Antonie de Saint - Exupéry";
            livro.CodigoIsbn = "978-8595081512";
            livro.Idioma = "Português";
            livro.DataLancamento = new DateTime(2018, 01, 01);
            livro.QuantidadePaginas = 96;
            livro.QuantidadePaginasLidas = 50;
            livro.QuantidadeReleituras = 2;

            livro.ApresentarTituloAutor();
            Console.WriteLine(
            "\nCódigo ISBN: " + livro.CodigoIsbn +
            "\nIdioma: " + livro.Idioma +
            "\nData de Lançamento: " + livro.DataLancamento +
            "\nQuantidade de páginas: " + livro.QuantidadePaginas +
            "\nQuantidade de páginas lidas: " + livro.QuantidadePaginasLidas +
            "\nQuantidade de releituras: " + livro.QuantidadeReleituras);
            livro.ApresentarQuantidadePaginasParaLer();
            livro.ApresentarQuantidadePaginasLidasNoTotal();
            livro.ApresentarQuantidadeAnosAposPublicação();
        }
    }
}
