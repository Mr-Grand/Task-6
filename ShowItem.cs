namespace Tasks_6_X;

public static class ShowItem
{
    public static void ShowWithTuple(Dictionary<string, (Item item, int count)> items)
    {
        Console.WriteLine(new string('_', 50));

        foreach (var pair in items)
        {
            var name = pair.Key;
            var data = pair.Value;
            
            Item item = data.item;
            int count = data.count;
            
            Console.WriteLine($"| Item name: {name} " +
                              $"\t| Price: {item.Price} " +
                              $"\t| Count: {count} |");
        }
        
        Console.WriteLine(new string('_', 50));
    }

    public static void Show(Dictionary<string, int> items)
    {
        Console.WriteLine(new string('_', 50));
        
        foreach (var pair in items)
        {
            Console.WriteLine($"| Item name: {pair.Key} " +
                              $"\t| Count: {pair.Value} |");
        }
        
        Console.WriteLine(new string('_', 50));
    }
}