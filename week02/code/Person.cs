public class Person
{
    public readonly string Name;
    public int Turns { get; set; }  // truns of peoples. OK

    internal Person(string name, int turns)
    {
        Name = name;
        Turns = turns;
    }

    public override string ToString()
    {
        return Turns <= 0 ? $"({Name}:Forever)" : $"({Name}:{Turns})";  // if turns is 0 or less, it will show forever. OK
    }
}