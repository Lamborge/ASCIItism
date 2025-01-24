namespace ASCIItism.Objects.MapBuilding;

// Это не совсем постройка в привычном понимании
// В любом случае я не знаю как лучше назвать этот класс, поэтому пусть будет постройка (таверна, магазинчик, так далее)
public class Building
{

    public string Name { get; init; }
    public string Description { get; init; }

    protected Building(string name, string description)
    {
        // TODO: create constructor with json serialization
        this.Name = name;
        this.Description = description;
    }

    //This maybe will never be used cause of init-like in-class fields
    /*public Building()
    {

    }*/
}