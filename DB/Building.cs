using static ASCIItism.DB;

namespace ASCIItism;


// Это не совсем постройка в привычном понимании
// В любом случае я не знаю как лучше назвать этот класс, поэтому пусть будет постройка (таверна, магазинчик, так далее)
public class Building
{

    public string Name { get; set; } = "здание";
    public string Description { get; set; } = "описание";


    public Building(string name, string description)
    {
        Name = name;
        Description = description;
    }

    public Building(string name)
    {
        Name = name;
    }

    public Building()
    {

    }
}

public class Shop : Building
{
    public Shop(string name, string description) : base(name, description)
    {
    }

    public Shop(string name) : base(name)
    {
    }

    public Shop() : base()
    {
    }
}

public class Portal : Building
{
    public Portal(string name, string description) : base(name, description)
    {
    }

    public Portal(string name) : base(name)
    {
    }

    public Portal() : base()
    {
    }
}

public class House : Building
{
    public House(string name, string description) : base(name, description)
    {
    }

    public House(string name) : base(name)
    {
    }

    public House() : base()
    {
    }
}