using System;

namespace daire_cizme
{
    public class CircleDrawer
    {
        public static void DrawCircle(int radius)
        {
            double diameter = 2 * radius;
            double radiusSquared = radius * radius;

            for (int i = -radius; i <= radius; i++)
            {
                for (int j = -radius; j <= radius; j++)
                {
                    if (i * i + j * j <= radiusSquared)
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Daire yarıçapı: ");
            int radius = int.Parse(Console.ReadLine());

            CircleDrawer.DrawCircle(radius);
        }
    }
}
