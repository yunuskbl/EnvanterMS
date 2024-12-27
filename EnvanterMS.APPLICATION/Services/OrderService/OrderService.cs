using EnvanterMS.DOMAIN.Entities;
using EnvanterMS.DOMAIN.Repositories;

namespace EnvanterMS.APPLICATION.Services.OrderService
{
    public class OrderService : IService<Order>
    {
        private readonly IOrderRepository _orderRepository;
        public OrderService( IOrderRepository orderRepository)
        {
             _orderRepository = orderRepository;    
        }
        public Task AddAsync(Order entity)
        {
            return _orderRepository.AddAsync(entity); 
        }

        public Task DeleteAsync(int id)
        {
            return (_orderRepository.DeleteAsync(id));
        }

        public Task<ICollection<Order>> GetAllAsync()
        {
           return _orderRepository.GetAllAsync();
        }

        public async Task<Order?> GetByIdAsync(int id)
        {
            var entity = await _orderRepository.GetByIdAsync(id);
            if (entity == null)
            {
                throw new KeyNotFoundException($"{id} ID Numaralı Sipariş Bulunamadı");
            }
            return entity;
        }

        public Task UpdateAsync(Order entity)
        {
            return _orderRepository.UpdateAsync(entity);    
        }
    }
}