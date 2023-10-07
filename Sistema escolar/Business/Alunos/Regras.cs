using AutoMapper;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Text.Json;
using Sistema_escolar.Models;
using Sistema_escolar.Repository.Alunos;
using Sistema_escolar.Models.Alunos;

namespace Sistema_escolar.Business.Alunos
{
    public class Regras : IRegras
    {
        protected private IAcessobancoAlunos _acessoBanco;
        private readonly IMapper _mapper;

        public Regras(IAcessobancoAlunos acessoBanco, IMapper mapper)
        {
            _acessoBanco = acessoBanco;
            _mapper = mapper;
        }

        public List<AlunoDTO> BuscarTodos()
        {
            var AlunosLista = _acessoBanco.BuscarTodos();
            return _mapper.Map<List<AlunoDTO>>(AlunosLista);

            /*foreach (var aluno in AlunosLista)
            {
                _mapper.Map<AlunoDTO>(aluno);

                foreach (var discipina in aluno.Disciplinas)
                {
                    _mapper.Map<DisciplinaDTO>(discipina);

                    foreach (var nota in discipina.Notas)
                    {
                        _mapper.Map<NotaDTO>(nota);
                    }
                }
            }*/
        }
        public AlunoDTO BuscarPorId(int id)
        {
            var AlunoId = _acessoBanco.BuscarPorId(id);
            if (AlunoId == null)
            {
                return null;
            }
            var disciplinasDTO = _mapper.Map<List<DisciplinaDTO>>(AlunoId.Disciplinas);
            var notas = new List<NotaDTO>();

            var alunosDTO = _mapper.Map<AlunoDTO>(AlunoId);
            alunosDTO.Disciplinas = disciplinasDTO;

            var options = new JsonSerializerOptions
            {
                ReferenceHandler = ReferenceHandler.Preserve
            };

            return alunosDTO;
        }
        public Aluno Adionar(Aluno novoAluno)
        {
            Aluno aluno = _acessoBanco.Adionar(novoAluno);

            return aluno;
        }
        public Aluno Editar(Aluno EditarAluno)
        {
            var AlunoDb = _acessoBanco.BuscarPorId(EditarAluno.AlunoId);

            var update = _acessoBanco.Editar(EditarAluno, AlunoDb);
            return update;

        }

        public void Remover(int id)
        {
            _acessoBanco.Remover(id);
        }
    }
}
