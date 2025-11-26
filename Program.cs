namespace Tasks_6_X;

class Program
{
    static void Main(string[] args)
    {
        SellerFactory firstSellerFactory = new FruitsSellerFactory("Fruit seller");
        Seller seller = firstSellerFactory.CreateSeller();
        Buyer player = new();

        ShowFruitsPresence(player, seller);
        
        FirstShopping(player, seller);
        ShowFruitsPresence(player, seller);
        
        SecondShopping(player, seller);
        ShowFruitsPresence(player, seller);
    }

    public static void ShowFruitsPresence(Buyer player, Seller seller)
    {
        Console.WriteLine("Вот фрукты в наличии");
        seller.ShowItems();
        Console.WriteLine("Вот ваши фрукты");
        player.ShowItems();
    }
    
    public static void FirstShopping(Buyer player, Seller seller)
    {
        Console.WriteLine("Покупаем фрукты");
        seller.SellItems(player, "Banana", 7);
    }

    public static void SecondShopping(Buyer player, Seller seller)
    {
        Random random = new Random();
        Console.WriteLine("\nПокупаем еще фруктов");
        seller.SellItems(player, "Apple", random.Next(1, 22));
        seller.SellItems(player, "Orange", random.Next(1, 22));
    }
}