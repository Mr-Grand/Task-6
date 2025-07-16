namespace Tasks_6_X;

public class Seller
{
    private List<Fruits> _fruits = new()
    {
        new Fruits("Apple", 4.50, 5),
        new Fruits("Orange", 7.90, 20),
        new Fruits("Pear", 5.50, 5),
        new Fruits("Banana", 4.99, 10),
        new Fruits("Pineapple", 1),
    };

    public void ShowFruits()
    {
        ShowItem.Show(_fruits);
    }

    public Fruits? GetFruit(string name)
    {
        Fruits? gettedFruit = _fruits.Find(f => f.Name == name);
        if (gettedFruit != null)
        {
            return gettedFruit;
        }
        else
        {
            Console.WriteLine("Ошибка! Фрукт не найден!");
            return null;
        }
    }

    public void SellFruits(Buyer buyer, string fruitName, int takenCount)
    {
        Fruits? fruit = GetFruit(fruitName);

        if (fruit != null)
        {
        }
        else
        {
            Console.WriteLine("Фрукт не найден!");
        }

        if (takenCount <= 0)
        {
        } // не вижу смысла что-то делать, возможно использовать исключения или вывод на консоль с текстом?
        else if (fruit.Count > takenCount)
        {
            buyer.BuyFruits(fruit, takenCount);
            fruit.Count -= takenCount;
        }
        else if (fruit.Count == takenCount)
        {
            buyer.BuyFruits(fruit, takenCount);
            _fruits.Remove(fruit);
        }
        else
        {
            buyer.BuyFruits(fruit, fruit.Count);
            _fruits.Remove(fruit);
        }
    }
}