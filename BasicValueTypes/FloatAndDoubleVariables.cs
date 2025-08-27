public sealed class FloatAndDoubleVariables
{
    public void RunExample()
    {
        // Floating point numbers are numbers with a decimal point
        // A float in C# is 32 bits or 4 bytes
        // The range of a float is 1.5 x 10^-45 to 3.4 x 10^38
        // A double in C# is 64 bits or 8 bytes
        // The range of a double is 5.0 x 10^-324 to 1.7 x 10^308

        // We can declare a float variable
        float myFloat;
        float my_float;
        float MyFloat;

        float myFloatVariable;

        // We can declare a double variable
        double myDouble;
        double my_double;
        double MyDouble;

        double MyDoubleVariable;

        // We can assign a value to these variables
        myFloat = 5.5f;
        myDouble = 5.5d;

        myFloatVariable = 3.14f;
        MyDoubleVariable = 12.5d;

        // We can declare and assign in one line
        float coolFloat = 5.5f;
        double coolDouble = 5.5;

        double myDoubleVariable2 = 3.5d;
        float myFloatVariable2 = 34.23f;

        // We can re-assign a value to these variables
        coolFloat = 10.5f;
        coolDouble = 10.5;
        myFloatVariable2 = 13.34f;
        MyDoubleVariable = 324.32423d;

        // We can do math with these numbers
        float sum = 5.5f + 10.5f;
        float difference = 5.5f - 10.5f;
        float product = 5.5f * 10.5f;
        float quotient = 15.5f / 10.5f;

        float floatSum = 2342.234f + 3232.4234242f;
        float floatDifference = 342341234.342234f - 234234234.2342423f;
        float floatProduct = 2423423423424.23423113123f * 3242342.4234241f;
        float floatQuotient = 113131314.14152353241f / 3414121.42342342f;

        double doubleSum = 234242.234242d + 32423432.4234242d;
        double doubleDifference = 342341234.342234d - 234234234.2342423d;
        double doubleProduct = 2423423423424.23423113123d * 3242342.4234241d;
        double doubleQuotient = 113131314.14152353241d / 3414121.42342342d;

        decimal deciamlSum = 234242.234242m + 32423432.4234242m;
        decimal deciamlDifference = 342341234.342234m - 234234234.2342423m;
        decimal deciamlProduct = 24234234234252.23423113123m * 3242342.4234241m;
        decimal deciamlQuotient = 113131314.14152353241m / 3414121.42342342m;

        Console.WriteLine($" printing the float sum {floatSum}");
        Console.WriteLine($" priniting the float difference {floatDifference}");
        Console.WriteLine($" printing the float product {floatProduct}");
        Console.WriteLine($" printing the float quotient {floatQuotient}");
        Console.WriteLine($" printing the double sum {doubleSum}");
        Console.WriteLine($" printing the double difference {doubleDifference}");
        Console.WriteLine($" printing the double product {doubleProduct}");
        Console.WriteLine($" printing the double quotient {doubleQuotient }");
        Console.WriteLine($" printing the double sum {deciamlSum}");
        Console.WriteLine($" printing the double difference {deciamlDifference}");
        Console.WriteLine($" printing the double product {deciamlProduct}");
        Console.WriteLine($" printing the double quotient {deciamlQuotient}");

        // (the same thing for doubles)

        // The results of our math with string "interpolation"
        Console.WriteLine($"5.5 + 10.5={sum}");
        Console.WriteLine($"5.5 - 10.5={difference}");
        Console.WriteLine($"5.5 * 10.5={product}");
        Console.WriteLine($"15.5 / 10.5={quotient}");

        // Much better for decimals!
    }
}