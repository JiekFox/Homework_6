internal class Homework_6
{
    public static void Main()
    {
        var car = new Car();
        var ship = new Ship();
        var plane = new Plane();

        Console.WriteLine("Мимо едет машина: ");
        car.Go();
        Console.WriteLine(" ");
        Console.WriteLine("Мимо плывет параход: ");
        ship.Go();
        Console.WriteLine(" ");
        Console.WriteLine("Мимо летит самолет: ");
        plane.Go();

        Vehicle[] vehicles = new Vehicle[] { car, ship, plane };
        Console.WriteLine(" ");

    }
}

public abstract class Vehicle
{
    public abstract void Go();
}

public class Car : Vehicle
{
    public override void Go()
    {
        Console.WriteLine("Бип-бип");
    }
}

public class Ship : Vehicle
{
    public override void Go()
    {
        Console.WriteLine("Биииип");
    }
}

public class Plane : Vehicle
{
    public override void Go()
    {
        Console.WriteLine("А какой звук у самолета :/");
    }
}