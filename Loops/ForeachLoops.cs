public sealed class ForeachLoops
{
    public void RunExample()
    {
        // a foreach loop is used to iterate over a
        // collection of values
        // to be more specific, it iterates over
        // things that are "IEnumerable"
        // all collections are IEnumerable!

        // here is what a foreach loop looks like
        // foreach (Type thing in collectionOfThings)
        // {
        //     // do something...
        // }

        // let's see a real example with a number array!
        int[] numbers = { 1, 2, 3, 4, 5 };
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }

        string[] vowels =
        [
            "a",
            "e",
            "i",
            "o",
            "u",
        ];

        foreach (string vowel in vowels)
        { 
            Console.WriteLine(vowel); 
        }

        // what about with... a list of strings?
        List<string> words = new List<string>
{
    "red",
    "green",
    "blue",
};
        foreach (string word in words)
        {
            Console.WriteLine(word);
        }

        List<string> fivePillars = new List<string>
        {
            "Iman",
            "Salah",
            "Zakat",
            "Sawm",
            "Haj"
        };

        foreach (string word in fivePillars)
        {
            Console.WriteLine(word);
        }

        // how about with... a dictionary?
        Dictionary<string, int> ages = new()
{
    { "Alice", 25 },
    { "Bob", 24 },
    { "Charlie", 26 },
};
        //foreach (KeyValuePair<string, int> person in ages)
        foreach (var person in ages)
        {
            Console.WriteLine($"{person.Key} is {person.Value} years old");
        }

        Dictionary<char, string> RGBmapper = new()
        {
            {'R', "Red" },
            {'G',"Green" },
            {'B', "Blue" },
        };

        foreach(var color in RGBmapper)
        {
            Console.WriteLine($"the color key is {color.Key} and the color value is {color.Value}");
        }

        // we can use break and continue in a foreach loop
        // just like other loops too!
        foreach (int number in numbers)
        {
            if (number == 3)
            {
                break;
            }

            Console.WriteLine(number);
        }
        int count  = 0;
        foreach (string s in fivePillars)
        {
            count++;
            if(count > 3)
            {
                break;
            }
            Console.WriteLine(s);
        }
    }
}