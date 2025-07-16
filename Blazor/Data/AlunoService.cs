using BlazorAlunoCrud.Models;

namespace BlazorAlunoCrud.Data
{
    public class AlunoService
    {
        private List<Aluno> alunos = new();
        private int idAtual = 1;

        public List<Aluno> Listar() => alunos;

        public void Adicionar(Aluno aluno)
        {
            aluno.Id = idAtual++;
            alunos.Add(aluno);
        }

        public void Editar(Aluno aluno)
        {
            var index = alunos.FindIndex(a => a.Id == aluno.Id);
            if (index != -1)
                alunos[index] = aluno;
        }

        public void Remover(int id)
        {
            var aluno = alunos.FirstOrDefault(a => a.Id == id);
            if (aluno != null)
                alunos.Remove(aluno);
        }
    }
}
