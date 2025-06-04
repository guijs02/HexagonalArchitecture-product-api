namespace Product.Persistence.Model;
using System.ComponentModel.DataAnnotations.Schema;

[Table("Product")]
public class ProductModel
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public decimal Price { get; set; }
}