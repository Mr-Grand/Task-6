namespace Tasks_6_X;

public class Seller
{
    private Dictionary<Item, int> _items;

    public Seller(Dictionary<Item,int> items)
    {
        _items = items.ToDictionary();
    }

    public void ShowFruits()
    {
        ShowItem.Show(_items);
    }

    public Item? GetFruit(string name)
    {
        Item? gettedFruit = _items.Find(f => f.Id == name);
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
        Item? item = GetFruit(itemName);

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