namespace GildedRose.Services;

using GildedRose.Models;

public interface IPricingService
{
    double CalculatePrice(Product product);
}
