public sealed class BoleanVariables
{
    public void RunExample()
    {
        // A boolean is a true or false value
        // A boolean in C# is 8 bits or 1 byte

        /* A little overkill for boolean value as 1 bit was enough for configuring values for boolean */

        // We can declare a boolean variable
        bool myBool;
        bool my_bool;
        bool MyBool;

        bool myBoolValue;

        // We can assign a value to these variables
        myBool = true;
        myBool = false;

        myBoolValue = false;
        myBoolValue = true;
        Console.WriteLine($" value of my varibale myBoolValue after changing assigning {myBoolValue}");

        // We can declare and assign in one line
        bool coolBool = true;

        bool oneLineBoolValue = false;
        Console.WriteLine($" value of my varibale oneLineBoolValue declared and assigning in the same line {oneLineBoolValue}");

        // We can re-assign a value to these variables
        coolBool = false;

        oneLineBoolValue = true;
        Console.WriteLine($" value of my varibale oneLineBoolValue after reassigning the values of my variable {oneLineBoolValue}");

        // We can do boolean logic with these variables
        // && is the AND operator
        bool trueAndFalse = true && false;
        bool trueAndTrue = true && true;
        bool falseAndFalse = false && false;


        // || is the OR operator
        bool trueOrFalse = true || false;
        bool trueOrTrue = true || true;
        bool falseOrFalse = false || false;

        /* we can do the boolean logic with boolean values and store the logical result into these variables */
        bool trueAndFalseAndTrue = true && false && true;
        bool falseAndFalseAndTrue = false && false && true;
        bool trueOrFalseOrFalse = true || false || false;
        bool falseOrFalseOrTrue = false || false || true;
        Console.WriteLine($" value of trueAndFalseAndTrue after doing the boolean logic then assigning it to my variable {trueAndFalseAndTrue}");
        Console.WriteLine($" value of my falseAndFalseAndTrue after doing the boolean logic then assigning it to my variable {falseAndFalseAndTrue}");
        Console.WriteLine($" value of my trueOrFalseOrFalse after doing the boolean logic then assigning it to my variable {trueOrFalseOrFalse}");
        Console.WriteLine($" value of my falseOrFalseOrTrue after doing the boolean logic then assigning it to my variable {falseOrFalseOrTrue}");

        // ! is the NOT operator
        bool notTrue = !true;
        bool notFalse = !false;

        bool myBoolValueNotTrue = !true;
        bool myBoolValueNotFalse = !false;
        Console.WriteLine($" value of my not boolean myBoolValueNotTrue  {myBoolValueNotTrue}");
        Console.WriteLine($" value of my not boolean myBoolValueNotFalse {myBoolValueNotFalse}");

        // The results of our boolean logic
        // as we see with string interpolation:
        Console.WriteLine($"true && False: {trueAndFalse}");
        Console.WriteLine($"true && True: {trueAndTrue}");
        Console.WriteLine($"false && False: {falseAndFalse}");
        Console.WriteLine($"true || False: {trueOrFalse}");
        Console.WriteLine($"true || True: {trueOrTrue}");
        Console.WriteLine($"false || False: {falseOrFalse}");
        Console.WriteLine($"!True: {notTrue}");
        Console.WriteLine($"!False: {notFalse}");
       
    }
}