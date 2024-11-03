namespace GildedRose.Models;

public class BackstagePass : Product
{
    public BackstagePass(int sellIn, int quality, double price)
        : base("Backstage Pass", sellIn, quality, price)
    {
    }
}
