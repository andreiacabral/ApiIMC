using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Service
{
    public interface IConsultaService
    {
        Task<ConsultaIMC> Get(Guid id);
        Task<IEnumerable<ConsultaIMC>> GetAll();
        Task<ConsultaIMC> Post(ConsultaIMC user);
        Task<ConsultaIMC> Put(ConsultaIMC user);
        Task<bool> Delete(Guid id);
    }
}
