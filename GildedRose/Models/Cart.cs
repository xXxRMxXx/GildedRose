using GildedRose.Services;

namespace GildedRose.Models;
public class Cart
{
    public Cart(
        IPricingService pricingService,
        CurrencyConversionService currencyConversionService)
    {
        this.pricingService = pricingService;
        this.currencyConversionService = currencyConversionService;
    }

    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public double GetProductPrice(Product product, string currency)
    {
        double productPrice = pricingService.CalculatePrice(product);
        return currencyConversionService.ConvertToCurrency(productPrice, currency);
    }

    public double CalculateTotalPrice(string currency)
    {
        double total = 0;
        foreach (var product in products)
        {
            double productPrice = pricingService.CalculatePrice(product);
            total += currencyConversionService.ConvertToCurrency(productPrice, currency);
        }
        return total;
    }

    public List<Product> GetProducts()
    {
        return new List<Product>(products);
    }

    private readonly List<Product> products = new List<Product>();
    private readonly IPricingService pricingService;
    private readonly CurrencyConversionService currencyConversionService;
}
