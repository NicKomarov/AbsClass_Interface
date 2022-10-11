
abstract class GeographicObject
{ 
    public decimal CoordX, CoordY;
    public string Name, Description;
    public virtual void GetInfo() { }
}

class River : GeographicObject
{
    public decimal Speed, Length;
}

class Mountain : GeographicObject
{
    public decimal HighestPoint;
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}