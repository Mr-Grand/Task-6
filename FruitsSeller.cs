namespace Tasks_6_X;

public class FruitsSeller : SellerFactory
{
    public FruitsSeller(string id) : base(id)
    { }

    public override Seller CreateSeller()
    {
        Dictionary<Item, int> fruits = new Dictionary<Item, int>()
        {
            { new Item("Apple", 4.5), 5 },
            { new Item("Orange", 7.90), 10 },
            { new Item("Pear", 5.50), 5 },
            { new Item("Banana", 4.99), 10 },
            { new Item("Pineapple", 1), 1 },
        };
        Seller sellerFruits = new Seller(fruits);
        return sellerFruits;
    }
}