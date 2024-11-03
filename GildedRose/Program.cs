using GildedRose.Models;
using GildedRose.Services;

namespace GildedRose;

public class Program
{
    public static void Main(string[] args)
    {
        var currencyService = new CurrencyConversionService();
        var pricingService = new BulkDiscountService();
        var cart = new Cart(pricingService, currencyService);

        var agedBrie = new AgedBrie(10, 20, 50.0);
        var backstagePass = new BackstagePass(5, 30, 100.0);

        cart.AddProduct(agedBrie);
        cart.AddProduct(backstagePass);

        // Produkte anzeigen
        Console.WriteLine("Produkte im Warenkorb:");
        CartDisplayService.DisplayProducts(cart);

        // Einzelpreise mit Rabatt anzeigen
        Console.WriteLine("\nEinzelpreise der Produkte mit Rabatt in verschiedenen Währungen:");
        CartDisplayService.DisplayProductPrice(cart, agedBrie, "USD");
        CartDisplayService.DisplayProductPrice(cart, backstagePass, "EUR");
        CartDisplayService.DisplayProductPrice(cart, agedBrie, "GBP");

        // Gesamtpreis des Warenkorbs anzeigen
        Console.WriteLine("\nGesamtpreis des Warenkorbs:");
        double totalPriceUSD = cart.CalculateTotalPrice("USD");
        double totalPriceEUR = cart.CalculateTotalPrice("EUR");
        double totalPriceGBP = cart.CalculateTotalPrice("GBP");
        Console.WriteLine($"Gesamtpreis in USD: {totalPriceUSD} USD");
        Console.WriteLine($"Gesamtpreis in EUR: {totalPriceEUR} EUR");
        Console.WriteLine($"Gesamtpreis in GBP: {totalPriceGBP} GBP");

    }
}