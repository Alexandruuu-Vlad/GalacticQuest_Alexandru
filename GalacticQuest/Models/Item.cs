namespace GalacticQuest;

public abstract class Item
{
    public string Name { get; set; }
    public int AttackValue{ get; set; }
    public int HealthValue { get; set; }

    public Item(string name,int  attackvalue, int healthvalue)
    {
        Name = name;
        AttackValue = attackvalue;
        HealthValue = healthvalue;
    }

    public abstract void SpecialPower();
}

public class Weapon : Item
{
    public Weapon(string name, int attackvalue) : base(name, attackvalue, 0)
    {
    }

    public override void SpecialPower()
    {
        Console.WriteLine($"[ABILITY] {Name} has {AttackValue} Damage");
    }
}
public class Potion : Item
{
    public Potion(string name, int healthvalue) : base(name, 0, healthvalue)
    {
    }
    public override void SpecialPower()
    {
        Console.WriteLine($"[ABILITY] {Name} gave you {HealthValue}HP");
    }
}