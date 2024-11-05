using System;

using System.Collections.Generic;

class Calculator

{

    public static double Add(double a, double b)

    {

        return a + b;

    }

    public static double Subtract(double a, double b)

    {

        return a - b;

    }

    public static double Multiply(double a, double b)

    {

        return a * b;

    }

    public static double Divide(double a, double b)

    {

        return a / b;

    }

    public static double MakeOpp(double x, double y, Func<double, double, double> Op)

    {

        return Op(x, y);

    }

    static void Main()

    {

        Console.WriteLine(MakeOpp(6, 4, Multiply));

        Console.WriteLine(MakeOpp(6, 4, Subtract));

        Console.WriteLine(MakeOpp(6, MakeOpp(21, 7, Divide), Multiply));

    }

}