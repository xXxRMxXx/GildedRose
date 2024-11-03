namespace GildedRose.Services;

using GildedRose.Models;

public static class CartDisplayService
{
    public static void DisplayProducts(Cart cart)
    {
        foreach (var product in cart.GetProducts())
        {
            Console.WriteLine($"- {product.Name}: Qualität {product.Quality}, SellIn {product.SellIn}");
        }
    }

    public static void DisplayProductPrice(Cart cart, Product product, string currency)
    {
        double price = cart.GetProductPrice(product, currency);
        Console.WriteLine($"Der Preis von {product.Name} in {currency} beträgt {price} {currency}");
    }
}