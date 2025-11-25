namespace Tasks_6_X;

public class Seller
{
    private Dictionary<Item, int> _items;

    public Seller(Dictionary<Item,int> items)
    {
        _items = items.ToDictionary();
    }

    public void ShowItems()
    {
        ShowItem.Show(_items);
    }

    public Item? GetItem(string name)
    {
        Item gettedItemNew = new Item(name/*, _items[name].*/);
        bool isItemFound = _items.ContainsKey(gettedItemNew);

        if (isItemFound)
        {
            return gettedItemNew;
        }
        else
        {
            Console.WriteLine("Item not found");
            return null;
        }
        
        /*Item? gettedItem = _items.Keys.FirstOrDefault(f => f.Id == name);
        
        if (gettedItem != null)
        {
            return gettedItem;
        }
        else
        {
            Console.WriteLine("Item not found");
            return null;
        }*/
    }

    public void SellItems(Buyer buyer, string itemId, int takeCount)
    {
        Item? item = GetItem(itemId);

        if (item == null)
        {
            throw new ArgumentNullException("Item not found");
        }

        if (takeCount <= 0)
        {
            throw new ArgumentNullException("Item not found");
        } 
        else if (_items[item] > takeCount)
        {
            buyer.BuyItems(item, takeCount);
            _items[item] -= takeCount;
        }
        else if (_items[item] == takeCount)
        {
            buyer.BuyItems(item, takeCount);
            _items.Remove(item);
        }
        else
        {
            buyer.BuyItems(item, _items[item]);
            _items.Remove(item);
        }
    }
}