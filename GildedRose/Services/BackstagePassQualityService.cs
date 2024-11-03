namespace GildedRose.Services;

using GildedRose.Helpers;
using GildedRose.Models;

public class BackstagePassQualityService : IQualityService
{
    public void UpdateQuality(Product product)
    {
        ProductHelper.IncreaseQuality(product);
        if (product.SellIn < 11)
        {
            ProductHelper.IncreaseQuality(product);
        }
        if (product.SellIn < 6)
        {
            ProductHelper.IncreaseQuality(product);
        }
        ProductHelper.DecreaseSellIn(product);
        if (product.SellIn < 0)
        {
            product.Quality = ProductHelper.MinQuality;
        }
    }
}
