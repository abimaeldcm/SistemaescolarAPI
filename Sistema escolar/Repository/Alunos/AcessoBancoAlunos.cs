using Microsoft.EntityFrameworkCore;
using Sistema_escolar.Data;
using Sistema_escolar.Models;
using Sistema_escolar.Repository.DisciplinasAlunos;
using System.Collections.Generic;
using System.Linq;

namespace Sistema_escolar.Repository.Alunos
{
    public class AcessoBancoAlunos : IAcessobancoAlunos
    {
        protected private BancoContext _BancoContext;

        public AcessoBancoAlunos(BancoContext bancoContext)
        {
            _BancoContext = bancoContext;
        }


        public List<Aluno> BuscarTodos()
        {
            var alunoss = _BancoContext.Alunos
                .Include(a => a.Disciplinas).
                ThenInclude(x => x.Notas).ToList();
            /*foreach (var item in alunoss)
            {
                var pp = _BancoContext.Disciplinas.Where(x => x.AlunoId == item.AlunoId).ToList();
                item.Disciplinas.AddRange(pp);
            }*/
            return alunoss;
        }
        public Aluno BuscarPorId(int id)
        {
            var aluno = _BancoContext.Alunos.
                Include(a => a.Disciplinas).
                ThenInclude(x => x.Notas).
                FirstOrDefault(a => a.AlunoId == id);

            return aluno;
        }
        public Aluno Adionar(Aluno novoAluno)
        {
            _BancoContext.Alunos.Add(novoAluno);
            _BancoContext.SaveChanges();

            return novoAluno;
        }
        public Aluno Editar(Aluno EditarAluno, Aluno AlunoDb)
        {
            _BancoContext.Entry(AlunoDb).CurrentValues.SetValues(EditarAluno);
            _BancoContext.SaveChanges();

            return EditarAluno;
        }

        public void Remover(int id)
        {
            Aluno alunoDB = BuscarPorId(id);
            if (alunoDB != null)
            {
                _BancoContext.Alunos.Remove(alunoDB);
                _BancoContext.SaveChanges();
            }
        }
    }
}
