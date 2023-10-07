using Sistema_escolar.Models;
using System.Collections.Generic;

namespace Sistema_escolar.Repository.Alunos
{
    public interface IAcessobancoAlunos
    {
        List<Aluno> BuscarTodos();
        Aluno BuscarPorId(int id);
        Aluno Adionar(Aluno novoAluno);
        Aluno Editar(Aluno EditarAluno, Aluno AlunoDb);
        void Remover(int id);
    }
}
