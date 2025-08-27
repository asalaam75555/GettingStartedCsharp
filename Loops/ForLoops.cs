﻿public sealed class ForLoops
{
    public void RunExample()
    {
        // a for loop is a loop that runs a specific number of times
        // we saw how to count with while loops...
        // but a for loop is designed to count!

        // here is the syntax for a for loop:
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(i);
        }

        for (int i =0; i < 5; i++)
        {
            Console.WriteLine(i);
        }

        // a for loop has three parts:
        // 1. the initializer: int i = 0;
        // 2. the condition: i < 10;
        // 3. the iterator: i++

        // note that we can't access i outside of the for loop!
        //i = 123; // this will not work!

        //i = 1243 // yes it is not working 

        // we can use break and continue in a for loop as well,
        // just like we did with a while loop.

        // here's an example of a for loop with a break:
        for (int i = 0; i < 10; i++)
        {
            if (i == 5)
            {
                Console.WriteLine("We're outta here!");
                break;
            }

            Console.WriteLine(i);
        }

        for (int i = 0; i < 10; i++)
        {
            if (i > 5) 
            {
                Console.WriteLine("we are outta here");
                break;
            }
            Console.WriteLine(i);
        }

        // here's an example of a for loop with a continue:
        for (int i = 0; i < 10; i++)
        {
            if (i == 5)
            {
                Console.WriteLine("Skipping 5!");
                continue;
            }

            Console.WriteLine(i);
        }

        for (int i = 0; i < 10; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine("skipping even numbers");
                continue;
            }
            Console.WriteLine(i);
        }
    }
}