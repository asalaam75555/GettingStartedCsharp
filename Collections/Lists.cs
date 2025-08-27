public sealed class Lists
{
    public void RunExample()
    {
        // lists are used to store multiple values 
        // - lists are zero based
        // - lists are dynamic in size
        // - we can get values from a list
        // - we can set values in a list
        // - we can add values to a list
        // - we can remove values from a list
        // - we can insert values into a list
        // - we can clear a list
        // - we can sort a list!

        // here is how we declare a list
        List<string> words = new List<string>();

        List<string> fruits = new List<string>();
        Console.WriteLine("before adding anythig to list ");
        foreach (string word in fruits) 
        {
            Console.WriteLine(word);
        }

        // here is how we add values to a list
        words.Add("one");
        words.Add("two");
        words.Add("three");

        fruits.Add("apple");
        fruits.Add("mango");
        fruits.Add("banana");
        fruits.Add("pineapple");

        foreach (string word in fruits)
        {
            Console.WriteLine(word);
        }

        // here is how we get values from a list
        string firstWord = words[0];
        string secondWord = words[1];
        string thirdWord = words[2];

        string fruit1 = fruits[0];
        string fruit2 = fruits[1];
        string fruit3 = fruits[2];
        string fruit4 = fruits[3];

        fruits.Insert(0, null!);

        foreach (string word in fruits)
        {
            Console.WriteLine(word);
        }

        words[0] = "four";
        // words is now:
        // ["four"]
        // ["two"]
        // ["three"]
        // after sorting:
        // ["four"]
        // ["three"]
        // ["two"]

        fruits[3] = "watermelon";

        foreach (string word in fruits)
        {
            Console.WriteLine(word);
        }

        // here is how we declare and initialize a list
        List<int> numbers = new List<int>
        {
            1,
            2,
            3,
            4,
        };

        List<int> mySibblingsAge = new List<int>
        {
            28,
            25,
            19,
        };

        foreach (int number in mySibblingsAge) 
        {
            Console.WriteLine(number);
        }

        // here is how we get the count of a list
        int count = numbers.Count; //4

        int sibblingscount = mySibblingsAge.Count;

        Console.WriteLine(sibblingscount);

        // here is how we remove a value from a list
        numbers.Remove(1);
        numbers.Remove(2);
        numbers.Remove(3);

        // numbers is now:
        // [2]
        // [3]
        // [1]
        // [4]


        mySibblingsAge.Remove(25);

        foreach (int number in mySibblingsAge)
        {
            Console.WriteLine(number);
        }

        mySibblingsAge.Remove(1);

        // here is how we insert a value into a list
        numbers.Insert(0, 1);
        numbers.Insert(0, 2);
        numbers.Insert(1, 3);

        mySibblingsAge.Insert(1, 25);
        mySibblingsAge.Insert(2, 14);

        foreach (int number in mySibblingsAge)
        {
            Console.WriteLine(number);
        }


        // here is how we clear a list
        numbers.Clear();
        numbers.Clear();
         numbers.Sort();

        mySibblingsAge.Clear();

        foreach (int number in mySibblingsAge)
        {
            Console.WriteLine(number);
        }

        // here is how we sort a list
        words.Sort();

       fruits.Sort();

        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }
    }
}