namespace Tasks_6_X;

public class Items
{
    private double _price;
    private int _count;
    private const double _defaultPrice = 9.99;
    public string Name { get; private set; }

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

    public int Count
    {
        get { return _count; }
        set
        {
            if (value >= 0)
                _count = value;
            else
                Console.WriteLine("Count  must be positive number");
        }
    }

    public Items(string name, double price, int count)
    {
        Price = price;
        Count = count;
        Name = name;
    }

    public Items(string name, int count)
    {
        Count = count;
        Name = name;
        Price = _defaultPrice; // Дефолтная цена. Или лучше через константное поле?
    }
}