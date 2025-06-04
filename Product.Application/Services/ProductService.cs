using Product.Application.dtos;
using Product.Domain.Entity;
using Product.Domain.Ports;

namespace Product.Application.Services;

public class ProductService : IProductService
{
    private readonly IProductRepository _productRepository;

    public ProductService(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public async Task CreateAsync(Domain.Entity.Product product)
    {
        if (product == null)
        {
            throw new ArgumentNullException(nameof(product));
        }
        
        await _productRepository.CreateAsync(product);
    }

    public async Task<List<Domain.Entity.Product>> GetAllAsync()
    {
        return await _productRepository.GetAllAsync();
    }
}