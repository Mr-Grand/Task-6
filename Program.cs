namespace Tasks_6_X;

class Program
{
    static void Main(string[] args)
    {

        SellerFactory firstSellerFactory = new FruitsSeller("Fruit seller");
        Seller seller = firstSellerFactory.CreateSeller();
        
        Random random = new Random();
        //Seller seller = new();
        Buyer player = new();

        Console.WriteLine("Вот фрукты в наличии");
        seller.ShowFruits();
        Console.WriteLine("Вот ваши фрукты");
        player.ShowFruits();
        Console.WriteLine("Покупаем фрукты");
        seller.SellFruits(player, "Banana", 7);
        Console.WriteLine("Оставшиеся фрукты");
        seller.ShowFruits();
        Console.WriteLine("Ваши фрукты");
        player.ShowFruits();

        Console.WriteLine("\nПокупаем еще фруктов");
        seller.SellFruits(player, "Pineapple", -20);
        seller.SellFruits(player, "Apple", random.Next(0, 22));
        seller.SellFruits(player, "Pear", 0);
        seller.SellFruits(player, "Orange", random.Next(0, 22));
        Console.WriteLine("Оставшиеся фрукты");
        seller.ShowFruits();
        Console.WriteLine("Ваши фрукты");
        player.ShowFruits();
    }
}