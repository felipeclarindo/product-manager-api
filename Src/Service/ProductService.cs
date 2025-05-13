
using Src.Interfaces;
using Src.Models;

namespace Services;

public class ProductService
{
    private readonly IProductRepository _repository;

    public ProductService(IProductRepository repository)
    {
        _repository = repository;
    }

    public Task<IEnumerable<Product>> GetAll() => _repository.GetAllAsync();
    public Task<Product?> Get(int id) => _repository.GetByIdAsync(id);
    public Task Create(Product product) => _repository.AddAsync(product);
    public Task Update(Product product) => _repository.UpdateAsync(product);
    public Task Delete(int id) => _repository.DeleteAsync(id);
}
