using AutoMapper;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Text.Json;
using Sistema_escolar.Models.Alunos;
using Sistema_escolar.Repository.DisciplinasAlunos;
using Sistema_escolar.Models;

namespace Sistema_escolar.Business.DisciplinasAlunos
{
    public class RegrasDisciplinas : IRegrasDisciplinas
    {
        protected private IAcessobancoDisciplinas _acessoBanco;
        private readonly IMapper _mapper;

        public RegrasDisciplinas(IAcessobancoDisciplinas acessoBanco, IMapper mapper)
        {
            _acessoBanco = acessoBanco;
            _mapper = mapper;
        }

        public List<AlunoDTO> BuscarTodos(string materia)
        {
            var alunosMateria = _acessoBanco.BuscarTodos(materia);
            return _mapper.Map<List<AlunoDTO>>(alunosMateria);
        }

        public Disciplinas BuscarPorId(int id)
        {
            throw new System.NotImplementedException();
        }

        public Disciplinas Adionar(Disciplinas novoAluno)
        {
            throw new System.NotImplementedException();
        }

        public Disciplinas Editar(Disciplinas EditarAluno)
        {
            throw new System.NotImplementedException();
        }

        public void Remover(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
