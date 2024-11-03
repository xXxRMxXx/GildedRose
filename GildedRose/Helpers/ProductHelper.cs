namespace GildedRose.Helpers;

using GildedRose.Models;

public static class ProductHelper
{
    public const int MaxQuality = 50;
    public const int MinQuality = 0;

    public static void IncreaseQuality(Product product, int amount = 1)
    {
        product.Quality = Math.Min(product.Quality + amount, MaxQuality);
    }

    public static void DecreaseQuality(Product product, int amount = 1)
    {
        product.Quality = Math.Max(product.Quality - amount, MinQuality);
    }

    public static void DecreaseSellIn(Product product)
    {
        product.SellIn--;
    }
}
