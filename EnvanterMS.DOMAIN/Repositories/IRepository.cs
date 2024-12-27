using EnvanterMS.DOMAIN.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnvanterMS.DOMAIN.Repositories
{
    public interface IRepository<T>
    {
        Task<T?> GetByIdAsync(int id);
        Task<ICollection<T>> GetAllAsync();
        Task AddAsync( T entity);
        Task UpdateAsync( T entity);
        Task DeleteAsync( int id);
    }
    public interface ICustomerRepository : IRepository<Customer> { }
    public interface IProductRepository : IRepository<Product> { }
    public interface IOrderRepository : IRepository<Order> { }
}
