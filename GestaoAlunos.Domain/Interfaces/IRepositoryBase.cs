using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoAlunos.Domain.Interfaces
{
    public interface IRepositoryBase<T>
    {
        public void Adicionar(T entidade);

        public T ObterPorId(int id);
        public IList<T> ObterTodos();
    }
}
