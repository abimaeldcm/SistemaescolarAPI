using Sistema_escolar.Models;
using Sistema_escolar.Models.Alunos;
using System.Collections.Generic;

namespace Sistema_escolar.Business.Alunos
{
    public interface IRegras
    {
        List<AlunoDTO> BuscarTodos();
        AlunoDTO BuscarPorId(int id);
        Aluno Adionar(Aluno novoAluno);
        Aluno Editar(Aluno EditarAluno);
        void Remover(int id);


    }
}
