namespace Tasks_6_X;

public class FruitsSeller : SellerFactory
{
    public FruitsSeller(string id) : base(id)
    { }

    public override Seller CreateSeller()
    {
        List<Item> fruits = new List<Item>()
        {
            // Не придумал уникального поля для фрукта, сделал просто Item
            new Item("Apple", 4.50, 5),
            new Item("Orange", 7.90, 20),
            new Item("Pear", 5.50, 5),
            new Item("Banana", 4.99, 10),
            new Item("Pineapple", 1),
        };
        Seller sellerFruits = new Seller(fruits);
        return sellerFruits;
    }
}