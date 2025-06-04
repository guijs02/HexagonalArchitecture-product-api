using Product.Domain.Ports;
using Product.Persistence.Context;
using Product.Domain.Entity;
using Product.Persistence.Model;
using Microsoft.EntityFrameworkCore;
public class ProductRepository : IProductRepository
{
    private readonly AppDbContext _context;

    public ProductRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task CreateAsync(Product.Domain.Entity.Product product)
    {
        _context.Products.Add(new ProductModel
        {
            Id = product.Id,
            Name = product.Name,
            Price = product.Price
        });

        await _context.SaveChangesAsync();
    }

    public async Task<List<Product.Domain.Entity.Product>> GetAllAsync()
    {
        return await _context.Products.Select(s => new Product.Domain.Entity.Product(s.Id, s.Name, s.Price)).ToListAsync();
        
    }
}