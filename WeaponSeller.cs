namespace Tasks_6_X;

public class WeaponSeller : SellerFactory
{
    public WeaponSeller(string id) : base(id)
    { }

    public override Seller CreateSeller()
    {
        List<Weapon> weapons = new() 
        {
            new Weapon("Sword+0", 100),
            new Weapon("Sword+1", 100, 20, 2.2),
        };
        Seller seller = new Seller(weapons);
        return seller;
    }
}
