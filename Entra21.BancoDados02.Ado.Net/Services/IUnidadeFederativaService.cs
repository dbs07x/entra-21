namespace Entra21.BancoDados02.Ado.Net.Models
{
    internal interface IUnidadeFederativaService
    {
        List<UnidadeFederativa> ObterTodos();
        UnidadeFederativa ObterPorId(int id);
        void Cadastrar(UnidadeFederativa unidadeFederativa);
        void Editar(UnidadeFederativa unidadeFederativa);
        void Apagar(int id);
    }
}