namespace Tasks_6_X;

public class Item
{
    private const double DEFAULT_PRICE = 9.99;
    
    private double _price;
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
        Price = DEFAULT_PRICE;
    }

    // По итогу из-за изменения словаря мне не понадобилось изменять 2 этих метода
    // т.к. я ищу и сравниваю по ключу string name
    /*public override bool Equals(object obj)
    {
        if (obj is Item newObj)
            return Id == newObj.Id;
        return false;
    }

    public override int GetHashCode()
    {
        return Id.GetHashCode();
    }*/
}