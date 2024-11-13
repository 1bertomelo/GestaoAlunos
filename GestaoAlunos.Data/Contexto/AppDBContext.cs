using GestaoAlunos.Domain.Entidades;
using Microsoft.EntityFrameworkCore;


namespace GestaoAlunos.Data.Contexto
{
    public class AppDBContext : DbContext
    {
        public DbSet<Aluno> Aluno { get; set; }

        public AppDBContext
            (DbContextOptions<AppDBContext> options) : base(options)
        {
         
        }
    }
}
