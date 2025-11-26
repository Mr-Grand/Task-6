namespace Tasks_6_X;

public class Seller
{
    private Dictionary<string, (Item, int)> _items;

    public Seller(List<(string name, Item item, int count)> items)
    {
        _items = items.ToDictionary(
            i => i.name,
            i => (i.item, i.count)
        );
    }

    public void ShowItems()
    {
        ShowItem.ShowWithTuple(_items);
    }
    
    public void SellItems(Buyer buyer, string itemName, int takeCount)
    {
        var itemInfo = GetItemInfo(itemName);
        
        // Разбил предмет на части для удобства чтения
        var data = itemInfo.data;
        Item item = data.item;
        int count = data.count;

        if (item == null || takeCount <= 0)
        {
            throw new ArgumentNullException("Item not found");
        }
        
        int sellCount = Math.Min(count, takeCount);
        buyer.BuyItems(itemName, sellCount, item.Price);

        if (sellCount == count)
        {
            _items.Remove(itemName);
        }
        else
        {
            int newItemCount = count - sellCount;
            _items[itemName] = (item, newItemCount);
        }
    }
    
    private (string name,(Item item, int count) data) GetItemInfo(string itemName)
    {
        bool isItemFound = _items.ContainsKey(itemName);

        if (isItemFound)
        {
            var foundItem = _items[itemName];
            var gettedItem = (itemName, foundItem);
            return gettedItem;
        }
        else
        {
            Console.WriteLine("Item not found");
            return (null,(null,0)); // Это нормальная практика? Не придумал ничего лучше
        }
    }
}