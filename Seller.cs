namespace Tasks_6_X;

public class Seller
{
    private List<Items> _items;

    public Seller(List<Items> items)
    {
        _items = items;
    }

    public void ShowFruits()
    {
        ShowItem.Show(_items);
    }

    public Items? GetFruit(string name)
    {
        Items? gettedFruit = _items.Find(f => f.Name == name);
        if (gettedFruit != null)
        {
            return gettedFruit;
        }
        else
        {
            Console.WriteLine("Item not found");
            return null;
        }
    }

    public void SellFruits(Buyer buyer, string itemName, int takenCount)
    {
        Items? item = GetFruit(itemName);

        if (item != null)
        {
        }
        else
        {
            Console.WriteLine("Item not found!");
        }

        if (takenCount <= 0)
        {
        } // не вижу смысла что-то делать, возможно использовать исключения или вывод на консоль с текстом?
        else if (item.Count > takenCount)
        {
            buyer.BuyFruits(item, takenCount);
            item.Count -= takenCount;
        }
        else if (item.Count == takenCount)
        {
            buyer.BuyFruits(item, takenCount);
            _items.Remove(item);
        }
        else
        {
            buyer.BuyFruits(item, item.Count);
            _items.Remove(item);
        }
    }
}