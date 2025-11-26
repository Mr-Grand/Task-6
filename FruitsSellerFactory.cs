namespace Tasks_6_X;

public class FruitsSellerFactory : SellerFactory
{
    public FruitsSellerFactory(string id) : base(id)
    { }

    public override Seller CreateSeller()
    {
        List<(string name, Item item, int count)> fruits = new ()
        {
            ("Apple",new Item("Apple_1", 4.5), 5 ),
            ("Orange", new Item("Orange_Good", 7.90), 10 ),
            ("Pear", new Item("Pear", 5.50), 5 ),
            ("Banana", new Item("Banana", 4.99), 10 ),
            ("Pineapple", new Item("Pineapple", 1), 1 ),
        };
        
        Seller sellerFruits = new Seller(fruits);
        return sellerFruits;
    }
}