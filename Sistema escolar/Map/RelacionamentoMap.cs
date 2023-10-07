using AutoMapper;
using Sistema_escolar.Models;
using Sistema_escolar.Models.Alunos;

namespace Sistema_escolar.Map
{
    public static class RelacionamentoMap
    {
        public static MapperConfiguration mapeador()
        {
            // Configurar o AutoMapper no início do seu aplicativo
            var mapperConfig = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Nota, NotaDTO>();
                cfg.CreateMap<Disciplinas, DisciplinaDTO>()
                   .ForMember(dest => dest.Notas, opt => opt.MapFrom(src => src.Notas));
                cfg.CreateMap<Aluno, AlunoDTO>()
                   .ForMember(dest => dest.Disciplinas, opt => opt.MapFrom(src => src.Disciplinas));
            });

            return mapperConfig;
        }

    }
}
