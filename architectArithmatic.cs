using System;
using System.Linq;

namespace ArchitectArithmetic
{
  class Program
  {
    public static void Main(string[] args)
    {
        double[] numbers = { Rect(1500, 2500), Circle(375) / 2, Triangle(750, 500) };
        double teotihuacan = numbers.Sum();
        double cost = Math.Round(teotihuacan * 180, 2);
        Console.WriteLine($"The Teotihuacan Pyramid would cost {cost} pesos to build.");
    }

    static double Rect(double length, double width)
    {
      return length * width;
    }

    static double Circle(double radius)
    {
      return Math.PI * Math.Pow(radius, 2);
    }

    static double Triangle(double bottom, double height)
    {
      return 0.5 * bottom * height;
    }
  }
}