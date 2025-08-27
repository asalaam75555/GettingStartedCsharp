public sealed class Arrays
{
    public void RunExample()
    {
        // arrays are a collection of variables of the same type
        // - arrays are zero based
        // - arrays are fixed in size
        // - we can get values from an array
        // - we can set values in an array

        // here is how we declare an array
        int[] numbers = new int[3];

        // [1]
        // [2]
        // [3]

        // here is how we set values in an array
        numbers[0] = 1;
        numbers[1] = 2;
        numbers[2] = 3;

        int[] weightClasses = new int[8];

        weightClasses[0] = 125;
        weightClasses[1] = 135;
        weightClasses[2] = 145;

        // here is how we get values from an array
        int firstNumber = numbers[0];
        int secondNumber = numbers[1];

        int flyweight = weightClasses[0];
        int bantamweight = weightClasses[1];
        int featherweight = weightClasses[2];

        foreach (int i in weightClasses)
        {
            Console.WriteLine(i);
        }

        // here is how we declare and initialize an array
        int[] numbers2 = new int[]
        {
            5,
            6,
            7,
            8,
        };

        int[] primeNumbersUnder10 = new int[]
        {
            1,
            2,
            3,
            5,
            7,

        };

        foreach (int i in primeNumbersUnder10)
        {
            Console.WriteLine(i);
        }

        double[] numbers3 =
        {
            10.1,
            11.1,
            12.1,
        };

        double[] constantsValue =
        {
            3.14,
            6.366,
        };

        foreach(double i in constantsValue)
        {
            Console.WriteLine(i);
        }

        int[] numbers4 =
        [
            3,
            4,
            5,
        ];

        string[] vowels =
        [
            "a",
            "e",
            "i",
            "o",
            "u",
        ];

        foreach (string i in vowels)
        {
            Console.WriteLine(i);
        }

        // here is how we get the length of an array
        int length = numbers.Length; //3

        int vowelsLength = vowels.Length;
        Console.WriteLine(vowelsLength);
    }
}