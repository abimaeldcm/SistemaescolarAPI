using System;
using System.Collections.Generic;

namespace Sistema_escolar.Models.Alunos
{
    public class AlunoDTO
    {
        public int AlunoId { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public DateTime DataDeNascimento { get; set; }
        public List<DisciplinaDTO> Disciplinas { get; set; } = new List<DisciplinaDTO>();
    }
}
