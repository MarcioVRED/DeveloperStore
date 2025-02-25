using Ambev.DeveloperStore.Domain.Entities;

namespace Ambev.DeveloperStore.Application.Sales.GetSale;

/// <summary>
/// Response model for GetSale operation
/// </summary>
public class GetSaleResult
{
    public Guid Id { get; set; }
    public DateTime SaleDate { get; set; }
    public required string Customer { get; set; }
    public required string Branch { get; set; }
    public required List<SaleItem> Items { get; set; }
    public bool IsCancelled { get; set; }
    public decimal TotalAmount { get; set; }
}
