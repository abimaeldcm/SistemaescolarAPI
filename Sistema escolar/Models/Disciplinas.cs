using System.Collections.Generic;

namespace Sistema_escolar.Models
{
    public class Disciplinas
    {
        public int DisciplinaId { get; set; }
        public string Nome { get; set; }
        public int AlunoId { get; set; }
        public Aluno Aluno { get; set; }
        public List<Nota> Notas { get; set; } = new List<Nota>();
    }
}
