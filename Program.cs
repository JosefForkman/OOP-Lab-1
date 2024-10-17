// See https://aka.ms/new-console-template for more information

namespace Intro_till_OOP
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Circle[] cirkels = [new Circle(5), new Circle(6)];

            foreach (var circle in cirkels)
            {
                Console.WriteLine($"Aria: {circle.GetArea()}");
                Console.WriteLine($"Sfär: {circle.GetSphereArea()}");
            }
        }
    }
}