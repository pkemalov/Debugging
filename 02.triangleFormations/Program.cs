using System;

class TriangleFormations
{
    static void Main(string[] args)
    {
        var a = int.Parse(Console.ReadLine());
        var b = int.Parse(Console.ReadLine());
        var c = int.Parse(Console.ReadLine());

        if (a > 0 && b > 0 && c > 0)
        {
            GetValidityConditions(a, b, c);
            GetRightTriagleConditions(a, b, c);
        }
        else
        {
            Console.WriteLine("Invalid Triangle.");
        }

    }

    static void GetRightTriagleConditions(int a, int b, int c)
    {
        var rightTriangleCondition1 = a * a + b * b == c * c;
        var rightTriangleCondition2 = b * b + c * c == a * a;
        var rightTriangleCondition3 = a * a + c * c == b * b;

        if (rightTriangleCondition1)
        {
            Console.WriteLine("Triangle has a right angle between sides a and b");
        }
        else if (rightTriangleCondition2)
        {
            Console.WriteLine("Triangle has a right angle between sides b and c");
        }
        else if (rightTriangleCondition3)
        {
            Console.WriteLine("Triangle has a right angle between sides a and c");
        }
        else if (a + b > c && b + c > a && a + c > b)
        {
            Console.WriteLine("Triangle has no right angles");
        }
    }

    static void GetValidityConditions(int a, int b, int c)
    {
        var triangleValidityCondition1 = a + b > c;
        var triangleValidityCondition2 = b + c > a;
        var triangleValidityCondition3 = a + c > b;

        var ValidTriangle = triangleValidityCondition1 && triangleValidityCondition2 && triangleValidityCondition3;

        if (!ValidTriangle)
        {
            Console.WriteLine("Invalid Triangle.");
        }
        else
        {
            Console.WriteLine("Triangle is valid.");
        }
    }
}
