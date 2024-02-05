// Exercise 1

internal class Program
{
    private static void Main(string[] args)
    {
        int a = 17;
        int b = 4;


        Console.WriteLine("17 + 4 =", a+b,", 17 - 4 =", a-b, ", 17 X 4 =", a*b, 
        ", 17 ÷ 4 =", a/b, "remainder ",a%b);

// Exercise 2
        Console.WriteLine("enter radius here");
        var radius = double.Parse(Console.ReadLine());

        double areaCircle = Math.PI * radius * radius;

        Console.WriteLine("The area of a circle with a radius of ",radius," is ",areaCircle);

    }
}
