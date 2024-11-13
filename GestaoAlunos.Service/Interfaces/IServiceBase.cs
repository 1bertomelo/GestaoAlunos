using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoAlunos.Service.Interfaces
{
    public interface IServiceBase<T>
    {
        public bool Adicionar(T entidade);

        public T ObterPorId(int id);
        public IList<T> ObterTodos();
    }
}

