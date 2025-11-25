namespace Tasks_6_X;

class Program
{
    static void Main(string[] args)
    {
        SellerFactory firstSellerFactory = new FruitsSellerFactory("Fruit seller");
        Seller seller = firstSellerFactory.CreateSeller();
        
        Random random = new Random();
        //Seller seller = new();
        Buyer player = new();

        Console.WriteLine("Вот фрукты в наличии");
        seller.ShowItems();
        Console.WriteLine("Вот ваши фрукты");
        player.ShowItems();
        Console.WriteLine("Покупаем фрукты");
        seller.SellItems(player, "Banana", 7);
        Console.WriteLine("Оставшиеся фрукты");
        seller.ShowItems();
        Console.WriteLine("Ваши фрукты");
        player.ShowItems();

        Console.WriteLine("\nПокупаем еще фруктов");
        seller.SellItems(player, "Pineapple", -20);
        seller.SellItems(player, "Apple", random.Next(0, 22));
        seller.SellItems(player, "Pear", 0);
        seller.SellItems(player, "Orange", random.Next(0, 22));
        Console.WriteLine("Оставшиеся фрукты");
        seller.ShowItems();
        Console.WriteLine("Ваши фрукты");
        player.ShowItems();
    }
}