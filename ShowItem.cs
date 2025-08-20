namespace Tasks_6_X;

public static class ShowItem
{
    public static void Show(List<Items> fruitItems)
    {
        Console.WriteLine(new string('-', 50));
        foreach (Items fruit in fruitItems)
            Console.WriteLine($"| fruit name: {fruit.Name} " +
                              $"\t| Price: {fruit.Price} " +
                              $"\t| Count: {fruit.Count} |");
        Console.WriteLine(new string('-', 50));
    }
}