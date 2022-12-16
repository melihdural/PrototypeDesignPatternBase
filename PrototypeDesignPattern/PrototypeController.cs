namespace PrototypeDesignPattern;

public class PrototypeController
{
    readonly List<Prototype?> _prototypes = new List<Prototype?>();

    internal Prototype CreateItem(string name, int id)
    {
        Prototype p = new Prototype();
        p.Name = name;
        p.Id = _prototypes.Count;
        _prototypes.Add(p);
        return p;
    }
    internal Prototype? GetByName(string name)
    {
        if (_prototypes.Any(x => x?.Name == name))
        {
            return _prototypes.FirstOrDefault(x => x?.Name == name);
        }
        else
        {
            Console.WriteLine("There is no Item as the Name of {0}", name);
            return null;
        }
    }
    internal Prototype? GetById(int id)
    {
        if (_prototypes.Any(x => x != null && x.Id == id))
        {
            return _prototypes.FirstOrDefault(x => x?.Id == id);
        }
        else
        {
            Console.WriteLine("There is no Item as the Id of {0}", id);
            return null;
        }
    }
    
    internal Prototype? Clone(Prototype? prototype)
    {
        var clone = prototype?.Clone();
        if (clone != null)
        {
            clone.Name = clone.Name + " (Clone)";
            clone.Id = _prototypes.Count;
            _prototypes.Add(clone);
        }
        return clone;
    }
    internal void GetAllPrototypes()
    {
        foreach (var prototype in _prototypes)
        {
            Console.WriteLine(prototype?.Name);
            Console.WriteLine(prototype?.Id);
        }
    }

    internal void ChangePrototypeName(Prototype prototype, string name)
    {
        prototype.Name = name;
    }
}