using Microsoft.AspNetCore.Mvc;
using Sistema_escolar.Business.DisciplinasAlunos;
using Sistema_escolar.Models;
using Sistema_escolar.Models.Alunos;
using System.Collections.Generic;

namespace Sistema_escolar.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DisciplinasEscola : ControllerBase
    {
        protected private IRegrasDisciplinas _regras;

        public DisciplinasEscola(IRegrasDisciplinas regras)
        {
            _regras = regras;
        }

        [HttpGet("{materia}")]
        public ActionResult<List<Disciplinas>> AlunosMatriculados( string materia)
        {
            return _regras.BuscarTodos(materia);
        }
        /*[HttpGet("{Id}")]
        public ActionResult<Alunos> BuscarPorId(int id)
        {
            return null;
        }
        [HttpPost]
        public ActionResult<Alunos> Adicionar([FromBody] Aluno alunoAdd)
        {
            return null;

        }
        [HttpPut]
        public ActionResult<Alunos> Editar([FromBody] Aluno alunoAdd)
        {
            return null;
        }
        [HttpDelete("{id}")]
        public ActionResult<Alunos> Deletar(int id)
        {
            _regras.Remover(id);
            return Ok("Usuário Deletado");
        }*/
    }
}
