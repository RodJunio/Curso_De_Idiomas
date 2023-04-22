using Entities.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Congifuration
{
    public class ContextBase : IdentityDbContext<Aluno>
    {
        public ContextBase(DbContextOptions<ContextBase> options):base(options)
        {
        }

        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Turma> Turmas { get; set; }
        public DbSet<Matricula> Matriculas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(ObterStringConexao());
                base.OnConfiguring(optionsBuilder);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           modelBuilder.Entity<Aluno>().ToTable("ALUNO").HasKey("ID");
           modelBuilder.Entity<Turma>().ToTable("TURMA").HasKey("ID");
           modelBuilder.Entity<Turma>().ToTable("MATRICULA").HasKey("ID");
           
            base.OnModelCreating(modelBuilder);
        }

        public string ObterStringConexao()
        {
            return "Server=JUNIODEV\\SQLEXPRESS;Database=CursoDeIdiomas;Trusted_Connection=True;";
        }
    }
}
