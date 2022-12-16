namespace PrototypeDesignPattern;

public class Prototype : IPrototype<Prototype>
{
    string _name = String.Empty;
    private int _id = 0;

    public int Id
    {
        get => _id;
        set => _id = value;
    }

    public string Name
    {
        get => _name;
        set => _name = value;
    }

    public Prototype Clone()
    {
        var clone = (Prototype) MemberwiseClone();
        return clone;
    }
}