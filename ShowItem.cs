namespace Tasks_6_X;

public static class ShowItem
{
    public static void Show(Dictionary<Item, int> items)
    {
        Console.WriteLine(new string('-', 50));
        
        foreach (var item in items)
            Console.WriteLine($"| Item name: {item.Key.Id} " +
                              $"\t| Price: {item.Key.Price} " +
                              $"\t| Count: {item.Value} |");
        
        Console.WriteLine(new string('-', 50));
    }
}