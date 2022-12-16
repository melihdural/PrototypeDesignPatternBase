namespace PrototypeDesignPattern;

internal static class Program
{
    private static void Main(string[] args)
    {
        PrototypeController controller = new PrototypeController();

        var prototype = controller.CreateItem("Prototype", 0);
        
        var clone1 = controller.Clone(prototype);
        
        var clone2 = controller.Clone(prototype);
        
        var clone3 = controller.Clone(prototype);
        
        var clone4 = controller.Clone(prototype);
        
        controller.GetAllPrototypes();
        Console.WriteLine("----------------------------");

        Console.WriteLine("Finish");
        Console.ReadLine();
    }

}