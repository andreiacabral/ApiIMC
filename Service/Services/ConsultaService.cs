using Domain.Entities;
using Domain.Interfaces;
using Domain.Interfaces.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class ConsultaService : IConsultaService
    {
        private readonly IRepository<ConsultaIMC> _repository;

        public ConsultaService(IRepository<ConsultaIMC> consultaIMCRepository)
        {
            _repository = consultaIMCRepository;
        }

        public async Task<bool> Delete(Guid id)
        {
            return await _repository.DeleteAsync(id);
        }

        public async Task<ConsultaIMC> Get(Guid id)
        {
            return await _repository.SelectAsync(id);
        }

        public async Task<IEnumerable<ConsultaIMC>> GetAll()
        {
            return await _repository.SelectAsync();
        }

        public async Task<ConsultaIMC> Post(ConsultaIMC consulta)
        {
            return await _repository.InsertAsync(consulta);

        }

        public async Task<ConsultaIMC> Put(ConsultaIMC consulta)
        {
            return await _repository.UpdateAsync(consulta);
        }
    }
}
