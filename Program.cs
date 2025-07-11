namespace Tasks_6_X;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        Seller seller = new();
        Buyer player = new();

        Console.WriteLine("Here is owned fruits");
        seller.ShowFruits();
        Console.WriteLine("Here is your fruits");
        player.ShowFruits();
        Console.WriteLine("Buying fruit");
        seller.SellFruits(player, "Banana", 7);
        Console.WriteLine("Lasted fruits");
        seller.ShowFruits();
        Console.WriteLine("Your fruits");
        player.ShowFruits();
        
        Console.WriteLine("\nBuying some more fruits");
        seller.SellFruits(player, "Pineapple",-20);
        seller.SellFruits(player, "Apple",random.Next(0,22));
        seller.SellFruits(player, "Pear",0);
        seller.SellFruits(player, "Orange",random.Next(0,22));
        Console.WriteLine("Here is owned fruits");
        seller.ShowFruits();
        Console.WriteLine("Here is your fruits");
        player.ShowFruits();
    }
}