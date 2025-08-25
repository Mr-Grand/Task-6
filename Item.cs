namespace Tasks_6_X;

public class Item
{
    private double _price;
    private const double _defaultPrice = 9.99;
    public string Id { get; private set; }

    public double Price
    {
        get { return _price; }
        set
        {
            if (value > 0)
                _price = value;
            else
                Console.WriteLine("Price must be positive number");
        }
    }
    
    public Item(string id, double price)
    {
        Price = price;
        Id = id;
    }

    public Item(string id)
    {
        Id = id;
        Price = _defaultPrice; // Дефолтная цена. Или лучше через константное поле?
    }
}