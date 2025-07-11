namespace Tasks_6_X;

public class Buyer
{
    public List<Fruits> _boughtFruits = new();
    public double MoneySpent;
    
    public void ShowFruits()
    {
        Console.WriteLine(new string('-', 50));
        foreach (Fruits fruit in _boughtFruits)
            Console.WriteLine($"| fruit name: {fruit.Name} " +
                              $"\t| Price: {fruit.Price} " +
                              $"\t| Count: {fruit.Count} |");
        Console.WriteLine(new string('-', 50));
    }

    public void BuyFruits(Fruits fruitItem, int boughtCount)
    {
        _boughtFruits.Add(new Fruits(fruitItem.Name, fruitItem.Price, boughtCount));
    }
}