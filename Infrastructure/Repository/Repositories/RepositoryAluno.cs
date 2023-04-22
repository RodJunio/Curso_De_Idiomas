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
    public class RepositoryAluno : RepositoryGenerics<Aluno>, IAluno
    {
        private readonly DbContextOptions<ContextBase> _OptionsBuilder;
        public RepositoryAluno()
        {
            _OptionsBuilder = new DbContextOptions<ContextBase>();
        }
    }
}
