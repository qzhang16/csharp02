namespace Class2;

public class Class1
{
    public required string Name { get; set; }

    public void Ace01()
    {
        Console.WriteLine("hello from " + Name);
    }

    public int Test01(int a, int b)
    {
        return a + b; ;
    }
}

public enum ShippingMethod
{
    AIR = 1,
    TRUCK = 2,
    BOAT = 3,
    TRAILER=4
}
