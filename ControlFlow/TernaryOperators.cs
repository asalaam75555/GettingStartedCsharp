public sealed class TernaryOperators
{
    public void RunExample()
    {
        // ternary operators are used to assign a
        // value to a variable based on a condition
        // The syntax is:
        // variable = (condition) ? expressionTrue : expressionFalse;

        int x = 10;
        string result = x > 5
            ? "x is greater than 5"
            : "x is less than 5";
        Console.WriteLine(result);

        int count = count = int.Parse(Console.ReadLine());
        string answer = count == 0
            ? "count is 0"
            : "count is not 0";
        Console.WriteLine(answer);

        result = x == 10
            ? "x is equal to 10"
            : "x is not equal to 10";
        Console.WriteLine(result);

        count = int.Parse(Console.ReadLine());
        answer = count > 0
            ? "count is a positive number"
            : "count is a negative number";
        Console.WriteLine(answer);

        result = x < 20
            ? "x is less than 20"
            : "x is greater than 20";
        Console.WriteLine(result);

        count = int.Parse(Console.ReadLine());
        answer = count > 100
            ? "count is greater than hundred"
            : "count is lesser than hundred";
        Console.WriteLine(answer);
    }
}