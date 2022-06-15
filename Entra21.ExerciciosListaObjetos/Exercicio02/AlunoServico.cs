namespace Entra21.ExerciciosListaObjetos.Exercicio02
{
    internal class AlunoServico
    {
        private List<Aluno> alunos = new List<Aluno>();

        private int codigoMatricula = 1;

        public void AdicionarAluno(string nome, int idade, string materiaFavorita, double nota1, double nota2, double nota3)
        {
            Aluno aluno = new Aluno();

            aluno.Nome = nome;
            aluno.Idade = idade;
            aluno.MateriaFavorita = materiaFavorita;
            aluno.Nota1 = nota1;
            aluno.Nota2 = nota2;
            aluno.Nota3 = nota3;

            aluno.CodigoMatricula = codigoMatricula;

            codigoMatricula++;

            alunos.Add(aluno);
        }

        public bool RemoverAluno(string nome)
        {
            return false;
        }

        public bool EditarDadosCadastrais(int codigoMatricula, string nome, int idade, string materiaFavorita)
        {
            return false;
        }

        public bool EditarNotasAluno(int codigoMatricula, double nota1, double nota2, double nota3)
        {
            return false;
        }

        public List<Aluno> ObterTudo()
        {
            return alunos;
        }

        public List<string> ObterNomes()
        {
            var nomes = new List<string>();

            for (int i = 0; i < alunos.Count; i++)
            {
                var nomeAtual = alunos[i].Nome;

                nomes.Add(nomeAtual);
            }

            return nomes;
        }

        public List<double> ObterMedias()
        {
            var medias = new List<double>();

            return medias;
        }

        public List<string> ObterAprovados()
        {
            var aprovados = new List<string>();

            return aprovados;
        }

        public List<string> ObterReprovados()
        {
            var reprovados = new List<string>();

            return reprovados;
        }

        public List<string> ObterEmExame()
        {
            var emExame = new List<string>();

            return emExame;
        }

        public double ObterMediaPorCodigoMatricula(int codigoMatricula)
        {
            var obterMediaPorCodigoMatricula = 0;
            return obterMediaPorCodigoMatricula;
        }

        /*public AlunoStatus ObterStatusPorCodigoMatricula(int codigoMatricula)
        {
        var obterStatusPorCodigoMatricula = 0;
        return AlunoStatus;

        }
        */

        public double ObterMediaIdade()
        {
            var obterMediaIdade = 0.0;
            return obterMediaIdade;
        }
    }
}
