using Microsoft.AspNetCore.Mvc;
using Sistema_escolar.Business;
using Sistema_escolar.Business.Alunos;
using Sistema_escolar.Business.DisciplinasAlunos;
using Sistema_escolar.Models;
using Sistema_escolar.Models.Alunos;
using System.Collections.Generic;

namespace Sistema_escolar.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Alunos : ControllerBase
    {
        protected private IRegras _regras;


        public Alunos(IRegras regras)
        {
            _regras = regras;
        }

        [HttpGet]
        public ActionResult<List<AlunoDTO>> BuscarTodos()
        {
            var TodosAlunos = _regras.BuscarTodos();
            
            return TodosAlunos == null ? BadRequest("O banco de dados está vazio") : Ok(TodosAlunos);
        }
        [HttpGet("{Id}")]
        public ActionResult<Alunos> BuscarPorId(int id)
        {
            var AlunoId = _regras.BuscarPorId(id);

            return AlunoId == null ? BadRequest("Aluno não encontrado") : Ok(AlunoId);

        }
        [HttpPost]
        public ActionResult<Alunos> Adicionar([FromBody] Aluno alunoAdd)
        {
            if (alunoAdd == null)
            {
                return BadRequest("Aluno vazio");
            }
            var alunoRetorno = _regras.Adionar(alunoAdd);
            return Ok(alunoRetorno);

        }
        [HttpPut]
        public ActionResult<Alunos> Editar([FromBody] Aluno alunoAdd)
        {
            if (alunoAdd == null)
            {
                return BadRequest("Aluno vazio");
            }
            var alunoRetorno = _regras.Editar(alunoAdd);
            return Ok(alunoRetorno);
        }
        [HttpDelete("{id}")]
        public ActionResult<Alunos> Deletar(int id)
        {
            _regras.Remover(id);
            return Ok("Usuário Deletado");
        }
    }
}
