namespace Tasks_6_X;

public class Buyer
{
    private Dictionary<string, int> _boughtItems = new ();
    private double _moneySpent = 0.0;

    public void ShowItems()
    {
        ShowItem.Show(_boughtItems);
        if(_moneySpent > 0)
            Console.WriteLine($"MoneySpent: {_moneySpent}");
    }

    public void BuyItems(string name, int boughtCount, double price)
    {
        if (!_boughtItems.ContainsKey(name))
        {
            _boughtItems.Add(name, boughtCount);
            AccountingMoneySpent(price, boughtCount);
        }
        else
        {
            _boughtItems[name] += boughtCount;
            AccountingMoneySpent(price, boughtCount);
        }
    }

    private void AccountingMoneySpent(double price, int boughtCount)
    {
        _moneySpent += price * boughtCount;
    }
}