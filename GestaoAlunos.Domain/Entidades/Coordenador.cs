using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoAlunos.Domain.Entidades
{
    public class Coordenador
    {
        public Coordenador(string nome)
        {
            this.nome = nome;
        }

        public string nome  { get; private set; }
    }
}
