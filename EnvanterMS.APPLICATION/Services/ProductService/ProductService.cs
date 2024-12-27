using EnvanterMS.DOMAIN.Entities;
using EnvanterMS.DOMAIN.Repositories;

namespace EnvanterMS.APPLICATION.Services.ProductService
{
    public class ProductService : IService<Product>
    {
        private readonly IProductRepository _productRepository;
        public ProductService(IProductRepository productRepository)
        {
                _productRepository = productRepository; 
        }
        public Task AddAsync(Product entity)
        {
            return _productRepository.AddAsync(entity);
        }

        public Task DeleteAsync(int id)
        {
            return (_productRepository.DeleteAsync(id));
        }

        public Task<ICollection<Product>> GetAllAsync()
        {
            return _productRepository.GetAllAsync();
        }

        public async Task<Product?> GetByIdAsync(int id)
        {
            var entity = await _productRepository.GetByIdAsync(id);
            if (entity == null)
            {
                throw new KeyNotFoundException($"{id} ID Numaralı Ürün Bulunamadı");
            }
            return entity;
        }

        public Task UpdateAsync(Product entity)
        {
           return _productRepository.UpdateAsync(entity);
        }
    }
}