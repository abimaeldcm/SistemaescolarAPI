using Microsoft.EntityFrameworkCore;
using Sistema_escolar.Data;
using Sistema_escolar.Models;
using Sistema_escolar.Repository.DisciplinasAlunos;
using System.Collections.Generic;
using System.Linq;

namespace Sistema_escolar.Repository.Alunos
{
    public class AcessoBancoDisciplinas : IAcessobancoDisciplinas
    {
        protected private BancoContext _BancoContext;

        public AcessoBancoDisciplinas(BancoContext bancoContext)
        {
            _BancoContext = bancoContext;
        }

        public Disciplinas Adionar(Disciplinas novoAluno)
        {
            throw new System.NotImplementedException();
        }

        public Disciplinas BuscarPorId(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<Disciplinas> BuscarTodos(string materia)
        {
                var a = _BancoContext.Disciplinas.Where(x => x.Nome == materia).Count();
        }

        public Disciplinas Editar(Disciplinas Aluno, Disciplinas AlunoDb)
        {
            throw new System.NotImplementedException();
        }

        public void Remover(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
