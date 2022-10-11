
interface IGeographicObject
{
    decimal CoordX { get; set; }
    decimal CoordY { get; set; }
    string Name { get; set; }
    string Description { get; set; }

    void GetInfo();
}

class River : IGeographicObject
{
    public decimal Speed, Length;
    public decimal CoordX { get; set; }
    public decimal CoordY { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }

    public void GetInfo()
    {
        Console.WriteLine($"Назва: {Name}, Опис: {Description}, координата х: {CoordX}, координата y: {CoordY} ");
    }
}

class Mountain : IGeographicObject
{
    public decimal HighestPoint;
    public decimal CoordX { get; set; }
    public decimal CoordY { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }

    public void GetInfo()
    {
        Console.WriteLine($"Назва: {Name}, Опис: {Description}, координата х: {CoordX}, координата y: {CoordY} ");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}