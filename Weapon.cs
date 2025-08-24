namespace Tasks_6_X;

public class Weapon : Item
{
    private double _damage;
    private const double BaseDamage = 1;

    public double Damage
    {
        get { return _damage; }
        set
        {
            if (value < 0)
            {
                Console.WriteLine("Damage cannot be less than 0");
            }
            else
            {
                _damage = value;
            }
        }
    }
    
    public Weapon(string id, int count, double price, double damage) : base(id, count)
    {
        Damage = damage;
    }

    public Weapon(string id, int count) : base(id, count)
    {
        Damage = BaseDamage;
    }
}