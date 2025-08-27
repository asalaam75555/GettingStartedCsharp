public sealed class Dictionaries
{
    public void RunExample()
    {
        // dictionaries are used to store key value pairs
        // - dictionaries are dynamic in size
        // - we can get values from a dictionary
        // - we can set values in a dictionary
        // - we can add values to a dictionary
        // - we can remove values from a dictionary
        // - we can clear a dictionary
        // - we can check if a dictionary contains a key
        // some other properties:
        // - the keys in a dictionary are unique
        // - the values in a dictionary do not need to be unique
        // - dictionary keys do not need to be integers!

        // here is how we declare a dictionary
        Dictionary<string, int> wordsToNumbers = new Dictionary<string, int>();
        Dictionary<int, string> numbersToWords = new Dictionary<int, string>();
        Dictionary<string, int> shorthand = new();

        Dictionary<string, int> asciiValues = new Dictionary<string, int>();
        Dictionary<int, string> numberName = new Dictionary<int, string>();
        Dictionary<string, string> soccerLeagueNames = new();

        // here is how we add entries into a dictionary
        wordsToNumbers.Add("one", 1);
        wordsToNumbers.Add("two", 2);
        wordsToNumbers.Add("three", 3);

        asciiValues.Add("a", 97);
        asciiValues.Add("b", 98);
        asciiValues.Add("c", 99);
        asciiValues.Add("d", 100);

        foreach (var item in asciiValues.Values)
        {
            Console.WriteLine(item);
        }

        foreach (var item in asciiValues.Keys)
        {
            Console.WriteLine(item);
        }

        foreach(var item in asciiValues)
        {
            Console.WriteLine($"the key of item {item.Key} and the value of item {item.Value}");    
        }

        foreach (KeyValuePair<string, int> item in asciiValues)
        {
            Console.WriteLine($"the key of the item is {item.Key} and value of item is {item.Value}");
        }

        // here is what this will look like as we go line by line:
        // ["one"] = 1
        // ["two"] = 2
        // ["three"] = 3

        // here is how we get values from a dictionary
        int one = wordsToNumbers["one"];
        int two = wordsToNumbers["two"];
        int three = wordsToNumbers["three"];

        int asciiValueOfa = asciiValues["a"];
        int asciiValueOfb = asciiValues["b"];
        int asciiValueOfc = asciiValues["c"];
        int asciiValueOfd = asciiValues["d"];

        // here is how we set values in a dictionary
        wordsToNumbers["one"] = 111;
        wordsToNumbers["two"] = 222;

        asciiValues["a"] = 65;
        asciiValues["b"] = 66;

        // wordsToNumbers is now:
        // ["one"] = 111
        // ["two"] = 222
        // ["three"] = 3

        // here is how we declare and initialize a dictionary
        Dictionary<int, string> numbersToWords2 = new Dictionary<int, string>
{
    { 1, "one" },
    { 2, "two" },
    { 3, "three" },
    { 4, "four" },
};

        Dictionary<string, string> countries = new Dictionary<string, string>
        {
            {"IND", "India" },
            {"CHN", "Chennai" },
            {"RUS", "Russia" },
        };

        Dictionary<int, string> numbersToWords3 = new Dictionary<int, string>
        {
            [1] = "one",
            [2] = "two",
            [3] = "three",
            [4] = "four",
        };

        Dictionary<string, string> southIndianStates = new Dictionary<string, string>
        {
            ["TN"] = "Tamil Nadu",
            ["AP"] = "Andhra Pradesh",
            ["KL"] = "Kerala",
            ["KRT"] = "Karnataka",
        };

        Dictionary<int, string> numbersToWords4 = new()
        {
            [1] = "one",
            [2] = "two",
            [3] = "three",
            [4] = "four",
        };

        Dictionary<int, string> numbersSpelling = new()
        {
            [1] = "one",
            [2] = "two",
            [3] = "three",
            [4] = "four",
            [5] = "five",
            [6] = "six",
            [7] = "seven",
            [8] = "eight",
            [9] = "nine",
            [10] = "ten",
        };
        
        foreach (var item in numbersSpelling)
        {
            Console.WriteLine(item.Value);
        }

        int numbersSpellingItemsCount = numbersSpelling.Count;

        // here is how we get the count of a dictionary
        int count = numbersToWords2.Count; //4

        // numbersToWords2 is:
        // [1] = "one"
        // [2] = "two"
        // [3] = "three"
        // [4] = "four"

        // here is how we remove a value from a dictionary
        numbersToWords2.Remove(1);
        numbersToWords2.Remove(2);

        numbersSpelling.Remove(3);
        numbersSpelling.Remove(4);
        numbersSpelling.Remove(5);

        foreach (var item in numbersSpelling) 
        {
            Console.WriteLine(item.Value);
        }

        // numbersToWords2 is now:
        // [3] = "three"
        // [4] = "four"

        // here is how we clear a dictionary
        numbersToWords3.Clear();
        numbersToWords4.Clear();

        numbersSpelling.Clear();

        var i = numbersSpelling.FirstOrDefault();

        Console.WriteLine(i.Value);


        // here is how we check if a dictionary contains a key
        bool contains = numbersToWords2.ContainsKey(3); //true

        bool has = countries.ContainsKey("IND");

        // here is how we check and get a value from a dictionary
        bool contains2 = numbersToWords2.TryGetValue(
            3,
            out string? value);

        Console.WriteLine(value);

        bool hasState = southIndianStates.TryGetValue(
            "TN",
            out string va);

        Console.WriteLine(va);

        bool hasState2 = southIndianStates.TryGetValue(
            "mah",
            out string va2);

        Console.WriteLine(va2);


        bool hasAsciivlaue = asciiValues.TryGetValue(
            "a",
            out int val);

        Console.WriteLine(val);

        bool hasAsciivlaue2 = asciiValues.TryGetValue(
            "f",
            out int val2);

        Console.WriteLine(val2);

        // what happens if we add something that already exists?
        // ERROR!
        // wordsToNumbers.Add("one", 1);
        // numbersToWords2.Add(1, "one");

        //countries.Add("IND", "Pakistan"); --- this does not work

        countries["IND"] = "Pakistan";
        countries["PAK"] = "INDIA";

        foreach (var item in countries.Values) { Console.WriteLine(item); }


        // we can use the indexer to add or set values
        // which will overwrite existing values
        wordsToNumbers["one"] = 1;
        numbersToWords2[1] = "one";
    }
}