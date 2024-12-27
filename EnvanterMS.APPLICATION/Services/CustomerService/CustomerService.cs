using EnvanterMS.DOMAIN.Entities;
using EnvanterMS.DOMAIN.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnvanterMS.APPLICATION.Services.CustomerService
{
    public class CustomerService : IService<Customer>
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;   
        }
        public Task AddAsync(Customer entity)
        {
            return _customerRepository.AddAsync(entity);
        }

        public Task DeleteAsync(int id)
        {
            return _customerRepository.DeleteAsync(id);
        }

        public Task<ICollection<Customer>> GetAllAsync()
        {
            return _customerRepository.GetAllAsync();   
        }

        public async Task<Customer?> GetByIdAsync(int id)
        {
            var entity = await _customerRepository.GetByIdAsync(id);
            if (entity==null)
            {
                throw new KeyNotFoundException($"{id} ID Numaralı Kullanıcı Bulunamadı");
            }
            return entity;
        }

        public Task UpdateAsync(Customer entity)
        {
            return _customerRepository.UpdateAsync(entity);
        }
    }
}
