namespace Entra21.ExerciciosListaObjetos.Exercicio02
{
    internal class Aluno
    {
        public string Nome;
        public int CodigoMatricula;
        public int Idade;
        public string MateriaFavorita;
        public double Nota1;
        public double Nota2;
        public double Nota3;

        public double CalcularMedia()
        {
            var calcularMedia = (Nota1 + Nota2 + Nota3) / 3;
            return calcularMedia;
        }

        public AlunoStatus ObterStatus()
        {
            AlunoStatus obterStatus = AlunoStatus.Aprovado;
            if (CalcularMedia() > 5 && CalcularMedia() < 7)
            {
                obterStatus = AlunoStatus.EmExame;
            }
            else
            {
                obterStatus = AlunoStatus.Reprovado;
            }
            return obterStatus;
        }
    }
}
