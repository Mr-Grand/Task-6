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
        Item? gettedFruit = _items.Keys.FirstOrDefault(f => f.Id == name);
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

    public void SellFruits(Buyer buyer, string itemId, int takenCount)
    {
        Item? item = GetFruit(itemId);

        if (item != null)
        {
        }
        else
        {
            Console.WriteLine("Item not found");
        }

        if (takenCount <= 0)
        {
        } // не вижу смысла что-то делать, возможно использовать исключения или вывод на консоль с текстом?
        else if (_items[item] > takenCount)
        {
            buyer.BuyFruits(item, takenCount);
            _items[item] -= takenCount;
        }
        else if (_items[item] == takenCount)
        {
            buyer.BuyFruits(item, takenCount);
            _items.Remove(item);
        }
        else
        {
            buyer.BuyFruits(item, _items[item]);
            _items.Remove(item);
        }
    }
}