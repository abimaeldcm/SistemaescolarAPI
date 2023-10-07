using System.Collections.Generic;
using System;

namespace Sistema_escolar.Models.Alunos
{
    public class DisciplinaDTO
    {
        public string Nome { get; set; }
        public List<NotaDTO> Notas { get; set; } = new List<NotaDTO>();

    }
}
