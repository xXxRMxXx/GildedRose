namespace GildedRose.Services;

using GildedRose.Models;

public class BulkDiscountService : IPricingService
{
    public double CalculatePrice(Product product)
    {
        return product.Price * 0.9;
    }
}
