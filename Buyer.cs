namespace Tasks_6_X;

public class Buyer
{
    private List<Items> _boughtItems = new();
    public double MoneySpent { get; private set; }

    public void ShowFruits()
    {
        ShowItem.Show(_boughtItems);
        Console.WriteLine($"MoneySpent: {MoneySpent}");
    }

    public void BuyFruits(Items item, int boughtCount)
    {
        _boughtItems.Add(new Items(item.Name, item.Price, boughtCount));
        MoneySpent += item.Price * boughtCount;
    }
}