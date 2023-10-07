using Sistema_escolar.Models;
using System.Collections.Generic;

namespace Sistema_escolar.Business.DisciplinasAlunos
{
    public interface IRegrasDisciplinas
    {
        List<Disciplinas> BuscarTodos(string materia);
        Disciplinas BuscarPorId(int id);
        Disciplinas Adionar(Disciplinas novoAluno);
        Disciplinas Editar(Disciplinas EditarAluno);
        void Remover(int id);


    }
}
