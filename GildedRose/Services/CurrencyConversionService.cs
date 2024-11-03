namespace GildedRose.Services;

public sealed class CurrencyConversionService
{
    public CurrencyConversionService()
    {
        exchangeRates = new Dictionary<string, double>
        {
            { "USD", 1.0 },
            { "EUR", 0.85 },
            { "GBP", 0.75 }
        };
    }

    public double ConvertToCurrency(double price, string currency)
    {
        return price * (exchangeRates.TryGetValue(currency, out double value) ? value : 1.0);
    }

    private readonly Dictionary<string, double> exchangeRates;
}
