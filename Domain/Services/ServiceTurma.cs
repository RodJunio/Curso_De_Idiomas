using Domain.Interfaces;
using Domain.Interfaces.InterfaceServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public class ServiceTurma : ITurmaService
    {
        private readonly ITurma _ITurma;
        public ServiceTurma(ITurma iTurma)
        {
            _ITurma = iTurma;
        }
    }
}
