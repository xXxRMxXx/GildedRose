namespace GildedRose.Services;

using GildedRose.Helpers;
using GildedRose.Models;

public class AgedBrieQualityService : IQualityService
{
    public void UpdateQuality(Product product)
    {
        ProductHelper.IncreaseQuality(product);
        ProductHelper.DecreaseSellIn(product);
        if (product.SellIn < 0)
        {
            ProductHelper.IncreaseQuality(product);
        }
    }
}
