namespace Tasks_6_X;

public class Buyer
{
    private List<Item> _boughtItems = new();
    public double MoneySpent { get; private set; }

    public void ShowFruits()
    {
        ShowItem.Show(_boughtItems);
        Console.WriteLine($"MoneySpent: {MoneySpent}");
    }

    public void BuyFruits(Item item, int boughtCount)
    {
        _boughtItems.Add(new Item(item.Id, item.Price, boughtCount));
        MoneySpent += item.Price * boughtCount;
    }
}