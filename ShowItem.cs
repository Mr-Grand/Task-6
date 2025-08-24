namespace Tasks_6_X;

public static class ShowItem
{
    public static void Show(List<Item> fruitItems)
    {
        Console.WriteLine(new string('-', 50));
        foreach (Item fruit in fruitItems)
            Console.WriteLine($"| fruit name: {fruit.Id} " +
                              $"\t| Price: {fruit.Price} " +
                              $"\t| Count: {fruit.Count} |");
        Console.WriteLine(new string('-', 50));
    }
}