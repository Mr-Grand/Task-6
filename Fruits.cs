namespace Tasks_6_X;

public class Fruits
{
    private int _count;
    private double _price;
    private string? _name;

    public string? Name 
    { 
        get => _name;
        set
        {
            if (value != null)
                _name = value;
            else
                Console.WriteLine("Name must exist");
        }
    }
    
    public double Price
    {
        get => _price;
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
        get => _count;
        set
        {
            if (value >= 0)
                _count = value;
            else
                Console.WriteLine("Count must be positive number");
        }
    }
    
    public Fruits(string name, double price, int count)
    {
        Name = name;
        Price = price;
        Count = count;
        _name = Name;
        _price = Price;
        _count = Count;
    }

    public Fruits(string name, int count)
    {
        Name = name;
        Count = count;
        _name = Name;
        _price = 9.99;
        _count = Count;
    }

    
}