namespace Tasks_6_X;

public class Fruits
{
    public string Name { get; private set; }
    private double _price;
    private int _count;

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

    public Fruits(string name, double price, int count)
    {
        Price = price;
        Count = count;
        Name = name;
    }

    public Fruits(string name, int count)
    {
        Count = count;
        Name = name;
        Price = 9.99; // Дефолтная цена. Или лучше через константное поле?
    }
}