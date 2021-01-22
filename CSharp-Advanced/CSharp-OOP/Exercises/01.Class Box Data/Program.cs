using System;

namespace EncapsulationExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            double inputLength = double.Parse(Console.ReadLine());
            double inputWidth = double.Parse(Console.ReadLine());
            double inputHeight = double.Parse(Console.ReadLine());

            var box = new Box(inputLength, inputWidth, inputHeight);
            Console.WriteLine($"Surface Area - {box.SurfaceArea():F2}");
            Console.WriteLine($"Lateral Surface Area - {box.LateralSurfaceArea():F2}");
            Console.WriteLine($"Volume - {box.Volume():F2}");

        }
    }
}
