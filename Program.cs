abstract class Prototype { public abstract Prototype Clone(); }

class ConcretePrototype : Prototype
{
    public int Data;
    public ConcretePrototype(int data) { Data = data; }
    public override Prototype Clone() => (Prototype)MemberwiseClone();
}

class Program
{
    static void Main()
    {
        var p1 = new ConcretePrototype(5);
        var p2 = (ConcretePrototype)p1.Clone();
        Console.WriteLine(p2.Data);
    }
}
