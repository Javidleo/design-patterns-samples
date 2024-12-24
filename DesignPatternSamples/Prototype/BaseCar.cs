namespace Prototype;

public class Program
{
    public static void Main()
    {
        BaseCar baseFord = new Ford("b24");
        // creating a copy instead of creating a new one.
        BaseCar copyFord = baseFord.Clone();

        // then change the copy as you want.
        copyFord.Price += 1000;
    }
}
public abstract class BaseCar
{
    protected BaseCar(string name)
    {
        Name = name;
    }
    public int Price { get; set; }
    public string Name { get; set; }

    public abstract BaseCar Clone();
}

public class Ford : BaseCar
{
    public Ford(string name) : base(name)
    {
    }

    public override BaseCar Clone()
    {
        return (Ford)MemberwiseClone();
    }
}

public class Ferrari : BaseCar
{
    public Ferrari(string name) : base(name)
    {

    }

    public override BaseCar Clone()
    {
        return (Ferrari)MemberwiseClone();
    }
}