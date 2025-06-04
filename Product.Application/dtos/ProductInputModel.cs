using System.ComponentModel.DataAnnotations;

namespace Product.Application.dtos;
public sealed record ProductInputModel
{
    [Required]
    public string Name { get; set; } = string.Empty;
    [Required]
    [Range(0.01, double.MaxValue, ErrorMessage = "Price must be greater than zero.")]
    public decimal Price { get; set; }
};