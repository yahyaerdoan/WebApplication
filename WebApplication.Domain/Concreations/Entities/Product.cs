namespace WebApplication.Domain.Concreations.Entities;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public decimal Price { get; set; }
    public string Description { get; set; } = null!;
    public string Barcode { get; set; } = null!;
}
