namespace GalacticQuest;

public class Monsters
{
    public string Name { get; set; }
    public int Health { get; set; }
    public int Attack { get; set; }

    public Monsters(string name, int health, int attack)
    {
        Name = name;
        Health = health;
        Attack = attack;
    }

    public static List<Monsters> GenerateMonsters()
    {
        List<string> names = new List<string>
        {
            "Glorbazorg", "Xenotutzi", "Ignifax", "Kryostasis",
            "Nighthorn", "Leviathan-Maw", "Hydro-King Aqueron", "Stonemouth"
        };
        List<Monsters> monsters = new List<Monsters>();
        foreach (string name in names)
        {
            int hp = 100;
            int attack = 29;

            Monsters newMonster = new Monsters(name, hp, attack);
            monsters.Add(newMonster);
        }
        Clontobaur specialMonster = new Clontobaur("Clontobaur", 100, 28, "Big");
        Minotaur humanMonster = new Minotaur("Minotaur", 100, 28, "Red");
        monsters.Add(specialMonster);
        monsters.Add(humanMonster);
        return monsters;
    }
}

public class Clontobaur : Monsters
{
    public string Height{ get; set; }

    public Clontobaur(string name, int health, int attack, string height) : base(name,health,attack)
    {
        Height = height;
        Console.WriteLine($"Clontobaur height: {height}");
    }
}
public class Minotaur : Monsters
{
    public string Color{ get; set; }

    public Minotaur(string name, int health, int attack, string color) : base(name,health,attack)
    {
        Color=color;
        Console.WriteLine($"Minotaur Color: {color}");
    }
}