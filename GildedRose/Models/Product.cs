namespace GildedRose.Models;

public abstract class Product
{
    public string Name { get; set; }
    public int SellIn { get; set; }
    public int Quality { get; set; }
    public double Price { get; set; }

    protected Product(string name, int sellIn, int quality, double price)
    {
        Name = name;
        SellIn = sellIn;
        Quality = quality;
        Price = price;
    }
}
