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

        public List<Aluno> BuscarTodos(string materia)
        {
            var AlunosNaDisciplina = _BancoContext.Disciplinas.Where(x => x.Nome == materia).Include(x => x.Aluno).ToList();
            List<Aluno> Alunos = new List<Aluno>(); 
            foreach (var aluno in AlunosNaDisciplina)
            {
                Alunos.Add(aluno.Aluno);
            }
            return Alunos;
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
