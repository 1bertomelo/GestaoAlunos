using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoAlunos.Domain.Entidades
{
    public class Professor
    {
        public Professor(string nome)
        {
            this.nome = nome;
        }

        public string nome { get; private set; }
    }
}
