using GestaoAlunos.API.Models;
using GestaoAlunos.Domain.Entidades;
using GestaoAlunos.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace GestaoAlunos.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AlunoController : ControllerBase
    {
        private readonly IAlunoService _alunoService;

        public AlunoController(IAlunoService alunoService)
        {
            _alunoService = alunoService;
        }

        [HttpGet]
        public IActionResult ObterTodosAlunos() {

            
            return Ok(_alunoService.ObterTodos());
        }

        [HttpPost]
        public IActionResult Adicionar(NovoAlunoDTO novoAluno)
        {
            bool sucesso = _alunoService.Adicionar(
                new Aluno(
                    novoAluno.nome,
                    novoAluno.email,
                    novoAluno.telefone,
                    novoAluno.cpf
                    )
                );
            if(sucesso)
                return Ok("Inserido com sucesso");

            return BadRequest("Erro ao inserir");
        }
    }
}
