namespace Tasks_6_X;

public class WeaponSeller : SellerFactory
{
    public WeaponSeller(string id) : base(id)
    { }

    public override Seller CreateSeller()
    {
        Dictionary<Weapon, int> weapons = new()
        {
            { new Weapon("Sword+0"), 100 },
            { new Weapon("Sword+1", 100, 20), 10}
        };
        Seller seller = new Seller(weapons);
        return seller;
    }
}
