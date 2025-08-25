namespace Tasks_6_X;

public static class ShowItem
{
    public static void Show(Dictionary<Item, int> fruitItems)
    {
        Console.WriteLine(new string('-', 50));
        
        foreach (var item in fruitItems)
            Console.WriteLine($"| fruit name: {item.Key.Id} " +
                              $"\t| Price: {item.Key.Price} " +
                              $"\t| Count: {item.Value} |");
        
        Console.WriteLine(new string('-', 50));
    }
}