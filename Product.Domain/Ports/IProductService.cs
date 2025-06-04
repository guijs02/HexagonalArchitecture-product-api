
using Product.Domain.Entity;

namespace Product.Domain.Ports;

public interface IProductService
{
    // Method to get all products
    public Task<List<Entity.Product>> GetAllAsync();

    public Task CreateAsync(Entity.Product product);
}