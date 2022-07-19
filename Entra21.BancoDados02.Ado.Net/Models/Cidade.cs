namespace Entra21.BancoDados02.Ado.Net.Models
{
    public class Cidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int QunatidadeHabitantes { get; set; }
        public DateTime DataHoraFundacao { get; set; }
        public double Pib { get; set; }
    }
}
