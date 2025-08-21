namespace Tasks_6_X;

abstract public class SellerFactory
{
    public string Id {get; set;}

    public SellerFactory(string id)
    {
        Id = id;
    }

    abstract public Seller CreateSeller();
}