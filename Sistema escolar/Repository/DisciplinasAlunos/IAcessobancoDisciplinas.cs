using Sistema_escolar.Models;
using System.Collections.Generic;

namespace Sistema_escolar.Repository.DisciplinasAlunos
{
    public interface IAcessobancoDisciplinas
    {
        List<Disciplinas> BuscarTodos(string materia);
        Disciplinas BuscarPorId(int id);
        Disciplinas Adionar(Disciplinas novoAluno);
        Disciplinas Editar(Disciplinas Aluno, Disciplinas AlunoDb);
        void Remover(int id);
    }
}
