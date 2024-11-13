using GestaoAlunos.Domain.Entidades;
using GestaoAlunos.Domain.Interfaces;
using GestaoAlunos.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoAlunos.Service.Servicos
{
    public class AlunoService : IAlunoService
    {
        private readonly IAlunoRepository _alunoRepository;

        public AlunoService(IAlunoRepository alunoRepository)
        {
            _alunoRepository = alunoRepository;
        }

        public bool Adicionar(Aluno novoAluno)
        {
            Aluno aluno = _alunoRepository.ObterPorCpf(novoAluno.cpf);

            if(aluno is null) {
                _alunoRepository.Adicionar(novoAluno);

                return true;
            }

            return false;

        }

        public Aluno ObterPorId(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Aluno> ObterTodos()
        {
            throw new NotImplementedException();
        }
    }
}
