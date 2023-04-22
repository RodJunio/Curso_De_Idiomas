using Domain.Interfaces;
using Entities.Entities;
using Infrastructure.Congifuration;
using Infrastructure.Repository.Generic;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository.Repositories
{
    public class RepositoryTurma : RepositoryGenerics<Turma>, ITurma
    {
        private readonly DbContextOptions<ContextBase> _OptionsBuilder;
        public RepositoryTurma()
        {
            _OptionsBuilder = new DbContextOptions<ContextBase>();
        }
    }
}
