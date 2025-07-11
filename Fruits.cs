namespace Tasks_6_X;

public class Fruits
{
    private string _name;
    private double _price;
    private int _count;

    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

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
                Console.WriteLine("Price must be positive number");
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