namespace Entra21.BancoDados02.Ado.Net.Models
{
    internal interface ICidadeService
    {
        List<Cidade> ObterTodos();
        Cidade ObterPorId(int id);
        void Cadastrar(Cidade cidade);
        void Editar(Cidade cidade);
        void Apagar(int id);
    }
}
