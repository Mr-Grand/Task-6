namespace Tasks_6_X;

public class Buyer
{
    private Dictionary<Item, int> _boughtItems = new();
    public double MoneySpent { get; private set; }

    public void ShowFruits()
    {
        ShowItem.Show(_boughtItems);
        Console.WriteLine($"MoneySpent: {MoneySpent}");
    }

    public void BuyFruits(Item item, int boughtCount)
    {
        if (!_boughtItems.ContainsKey(item))
        {
            _boughtItems.Add(item, boughtCount);
            MoneySpent += item.Price * boughtCount;
        }
        else
        {
            _boughtItems[item]++;
            MoneySpent += item.Price * boughtCount;
        }
    }
}