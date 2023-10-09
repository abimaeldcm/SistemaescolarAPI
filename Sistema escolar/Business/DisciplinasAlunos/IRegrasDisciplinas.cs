using Sistema_escolar.Models;
using Sistema_escolar.Models.Alunos;
using System.Collections.Generic;

namespace Sistema_escolar.Business.DisciplinasAlunos
{
    public interface IRegrasDisciplinas
    {
        List<AlunoDTO> BuscarTodos(string materia);
        Disciplinas BuscarPorId(int id);
        Disciplinas Adionar(Disciplinas novoAluno);
        Disciplinas Editar(Disciplinas EditarAluno);
        void Remover(int id);


    }
}
