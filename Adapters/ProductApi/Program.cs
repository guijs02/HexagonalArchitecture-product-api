using System.Net.Http.Headers;
using Product.Persistence.Context;
using Product.Application.dtos;
using Product.Domain.Ports;
using Product.Application.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddContext(builder.Configuration);
builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<IProductService, ProductService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();


app.MapPost("/", async (ProductInputModel input, IProductService productService) =>
{

    await productService.CreateAsync(new Product.Domain.Entity.Product(
       Guid.NewGuid(),
        input.Name,
        input.Price
    ));
    
    return Results.Created($"/products/{input.Name}", new
    {
        input.Name,
        input.Price
    });
})
.WithName("CreateProduct")
.WithSummary("Creates a new product");


app.MapGet("/", async (IProductService productService) =>
{
    var products = await productService.GetAllAsync();
    return Results.Ok(products.Select(p => new
    {
        p.Id,
        p.Name,
        p.Price
    }));
})
.WithName("GetAllProducts");


app.Run();



