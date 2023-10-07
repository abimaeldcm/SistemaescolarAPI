using System;
using System.Collections.Generic;

namespace Sistema_escolar.Models
{
    public class Aluno
    {
        public int AlunoId { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public DateTime DataDeNascimento { get; set; }
        public Nota Nota { get; set; }
        public List<Disciplinas> Disciplinas { get; set; } = new List<Disciplinas>();
    }
}
