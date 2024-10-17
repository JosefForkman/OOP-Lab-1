namespace Intro_till_OOP;

public class Circle
{
    public double Radius { get; set; }


    public Circle(double radius)
    {
        Radius = radius;
    }

    public double GetArea()
    {
        return Math.PI * Radius * Radius;
    }

    public double GetSphereArea()
    {
        return 4 * Math.PI * Math.Pow(Radius, 3) / 3;
    }
}