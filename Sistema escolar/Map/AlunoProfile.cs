using AutoMapper;
using Sistema_escolar.Models;
using Sistema_escolar.Models.Alunos;

namespace Sistema_escolar.Map
{


    public class AlunoProfile : Profile
    {
        public AlunoProfile()
        {
            CreateMap<Aluno, AlunoDTO>(); // Mapeia Aluno para AlunoDTO
            CreateMap<Disciplinas, DisciplinaDTO>(); // Mapeia Aluno para AlunoDTO
            CreateMap<Nota, NotaDTO>(); // Mapeia Aluno para AlunoDTO
        }
    }

}
