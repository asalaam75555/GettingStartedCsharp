public sealed class IfStatements
{
    public void RunExample()
    {
        // the most basic type of control flow that we
        // have is called the "if-statement". It allows us
        // to execute a block of code if a certain condition
        // is true. If the condition is false, the block of
        // code is skipped.

        // the expression inside of the parentheses
        // is called the "condition"
        if (true)
        {
            Console.WriteLine("This will always print");
        }

        if (true)
        {
            Console.WriteLine("this will always say hello");
        }

        if (false)
        {
            Console.WriteLine("This will never print");
        }

        if (false)
        {
            Console.WriteLine("this will never execute");
        }

        // we can use variables as the condition to check
        // remember boolean variables?
        // let's use one here!
        bool condition = true;
        if (condition)
        {
            Console.WriteLine("This prints when the condition is true!");
        }

        bool myCondition = false;
        if (myCondition)
        {
            Console.WriteLine("this prints when myCondition is true");
        }
        // we can also use the "else" keyword to execute
        // a block of code if the condition is false
        if (condition)
        {
            Console.WriteLine("This prints when the condition is true!");
        }
        else
        {
            Console.WriteLine("This prints when the condition is false!");
        }

        if (myCondition)
        {
            Console.WriteLine("this will execute if myCondition is true");
        }
        else
        {
            Console.WriteLine("this will execute if myCondition is any other than true");
        }

        // we can also use the "else if" keyword to check
        // multiple conditions
        if (condition)
        {
            Console.WriteLine("This will print when condition is true");
        }
        else if (!condition)
        {
            Console.WriteLine("This will print when condition is false");
        }
        else
        {
            Console.WriteLine("Trick question?!");
        }

        if (myCondition)
        {
            Console.WriteLine("this will execute if the myCondition is true");
        }
        else if (!myCondition)
        {
            Console.WriteLine("this will print if my condition is false");
        }
        else
        {
            Console.WriteLine("this code will never execute because the boolean variable can only be true or false");
        }

        // can the else block above ever print?
        // no!
        // this is because our boolean can only be
        // true or false, so the first two conditions
        // cover all possible cases!

        // let's try this again with an integer!
        // we'll introduce some new syntax here as well
        // < is the "less than" operator
        // > is the "greater than" operator
        // <= is the "less than or equal to" operator
        // >= is the "greater than or equal to" operator
        // == is the "equal to" operator
        // != is the "not equal to" operator

        int number = 6;
        if (number < 5)
        {
            Console.WriteLine("The number is less than 5");
        }
        else if (number == 5)
        {
            Console.WriteLine("The number is equal to 5");
        }
        else
        {
            Console.WriteLine("The number is greater than 5");
        }

        int myNumber = 4;
        if (myNumber < 10)
        {
            Console.WriteLine("the mynumber is less than 10");
        }
        else if(myNumber == 10)
        {
            Console.WriteLine("the mynumber is equal to 10");
        }
        else
        {
            Console.WriteLine("the mynumber is greater than 10");
        }

        // remember the && and || operators?
        // we can use them to combine conditions!
        number = 6;
        if (number >= 1 && number <= 5)
        {
            Console.WriteLine("The number is between 1 and 5");
        }
        else
        {
            Console.WriteLine("The number is not between 1 and 5");
        }

        if (number < 1 || number > 5)
        {
            Console.WriteLine("The number is not between 1 and 5");
        }
        else
        {
            Console.WriteLine("The number is between 1 and 5");
        }

        myNumber = 15;
        if (myNumber >= 1 && myNumber <= 10)
        {
            Console.WriteLine("the mynumber is between 1 and 10");
        }
        else
        {
            Console.WriteLine("mynumber is not between 1 and 10");
        }

        if (myNumber < 1 || myNumber > 10)
        {
            Console.WriteLine("mynumber is not between 1 and 10 ");
        }
        else 
        {
            Console.WriteLine("mynumber is between 1 and 10 ");
        }
    }
}