namespace Tasks_6_X;

public class FruitsSeller : SellerFactory
{
    public FruitsSeller(string id) : base(id)
    { }

    public override Seller CreateSeller()
    {
        List<Items> items = new List<Items>()
        {
            new Items("Apple", 4.50, 5),
            new Items("Orange", 7.90, 20),
            new Items("Pear", 5.50, 5),
            new Items("Banana", 4.99, 10),
            new Items("Pineapple", 1),
        };
        Seller seller = new Seller(items);
        return seller;
    }
}