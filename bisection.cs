using System;

class Bisection
{
    static void Main()
    {
        double a = 0, b = 5, eps = 0.0001;
        double c;

        while ((b - a) > eps)
        {
            c = (a + b) / 2;
            if (f(c) == 0.0)
                break;
            else if (f(a) * f(c) < 0)
                b = c;
            else
                a = c;
        }

        Console.WriteLine("Корінь ≈ " + (a + b) / 2);
        Console.ReadLine();
    }

    static double f(double x)
    {
        return x * x - 4;
    }
}
