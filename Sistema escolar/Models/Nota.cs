namespace Sistema_escolar.Models
{
    public class Nota
    {
        public int Id { get; set; }
        public decimal? PrimNota { get; set; }
        public decimal? SegNota { get; set; }
        public decimal? TerNota { get; set; }
        public decimal? ProvaFinal { get; set; }
        public int DisciplinaId { get; set; }
        public Disciplinas Disciplina { get; set; }
    }
}
