using Product.Domain.Entity;
using System.Collections.Generic;

namespace Product.Domain.Ports;

public interface IProductRepository
{
    Task<List<Domain.Entity.Product>> GetAllAsync();
    Task CreateAsync(Domain.Entity.Product product);

}