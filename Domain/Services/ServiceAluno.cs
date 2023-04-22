using Domain.Interfaces;
using Domain.Interfaces.InterfaceServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public class ServiceAluno : IServiceAluno
    {
        private readonly IAluno _IAluno;

        public ServiceAluno(IAluno iAluno)
        {
            _IAluno= iAluno;
        }
    }
}
