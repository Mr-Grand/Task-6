namespace Tasks_6_X;

public class Buyer
{
    private List<Fruits> _boughtFruits = new();
    public double MoneySpent { get; private set; }

    public void ShowFruits()
    {
        ShowItem.Show(_boughtFruits);
        Console.WriteLine($"MoneySpent: {MoneySpent}");
    }

    public void BuyFruits(Fruits fruitItem, int boughtCount)
    {
        _boughtFruits.Add(new Fruits(fruitItem.Name, fruitItem.Price, boughtCount));
        MoneySpent += fruitItem.Price * boughtCount;
    }
}