using GestaoAlunos.Data.Contexto;
using GestaoAlunos.Domain.Entidades;
using GestaoAlunos.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoAlunos.Data.Repositorios
{
    public class AlunoRepository : IAlunoRepository
    {
        private readonly AppDBContext _appDBContext ;

        public AlunoRepository(AppDBContext appDBContext)
        {
            _appDBContext = appDBContext;
        }

        public void Adicionar(Aluno novoAluno)
        {
            //fazer um insert no bd
            _appDBContext.Aluno.Add(novoAluno);
            _appDBContext.SaveChanges();
        }

        public Aluno? ObterPorCpf(string pCpf)
        {
            //select  * from aluno
            //where cpf = pCpf; 

            return _appDBContext.Aluno.Where(
                tabelaAluno => tabelaAluno.cpf == pCpf
                ).FirstOrDefault();
        }

        public Aluno? ObterPorId(int id)
        {
            return _appDBContext.Aluno.Where(
                aluno => aluno.Id == id).FirstOrDefault();
        }

        public IList<Aluno> ObterTodos()
        {//select * from aluno
            return _appDBContext.Aluno.ToList();
        }
    }
}
