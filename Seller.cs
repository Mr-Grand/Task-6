namespace Tasks_6_X;

public class Seller
{
    private Buyer _buyer;

    private readonly List<Fruits> _fruits = new()
    {
        new Fruits("Apple", 4.50, 5),
        new Fruits("Orange", 7.90, 20),
        new Fruits("Pear", 5.50, 5),
        new Fruits("Banana", 4.99, 10),
        new Fruits("Pineapple", 1)
    };

    public void ShowFruits()
    {
        Console.WriteLine(new string('-', 50));
        foreach (Fruits fruit in _fruits)
            Console.WriteLine($"| fruit name: {fruit.Name} " +
                              $"\t| Price: {fruit.Price} " +
                              $"\t| Count: {fruit.Count} |");
        Console.WriteLine(new string('-', 50));
    }

    public Fruits GetFruit(string name)
    {
        return _fruits.Find(f => f.Name == name);
    }

    public void SellFruits(Buyer buyer, string fruitName, int takenCount)
    {
        Fruits Fruit = GetFruit(fruitName);

        if (takenCount <= 0)
        {
        }
        else if (Fruit.Count > takenCount)
        {
            buyer.BuyFruits(Fruit, takenCount);
            Fruit.Count -= takenCount;
        }
        else if (Fruit.Count == takenCount)
        {
            buyer.BuyFruits(Fruit, takenCount);
            _fruits.Remove(Fruit);
        }
        else
        {
            buyer.BuyFruits(Fruit, Fruit.Count);
            _fruits.Remove(Fruit);
        }
    }
}