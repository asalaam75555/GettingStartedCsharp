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

        int[] myArray = new int[7];

        // [1]
        // [2]
        // [3]

        // here is how we set values in an array
        numbers[0] = 1;
        numbers[1] = 2;
        numbers[2] = 3;

        myArray[0] = 1;
        myArray[1] = 2;
        myArray[2] = 3;
        myArray[3] = 4;
        myArray[4] = 5;
        myArray[5] = 6;
        myArray[6] = 7;

        foreach(int i in myArray)
        {
            Console.WriteLine(i);
        }

        // here is how we get values from an array
        int firstNumber = numbers[0];
        int secondNumber = numbers[1];

        int elementInsideArray = myArray[4];

        // here is how we declare and initialize an array
        int[] numbers2 = new int[]
        {
            5,
            6,
            7,
            8,
        };

        int[] myArrayDeclaredAndInitialized = new int[]
        {
            1,
            2,
            3,
            4,
            5,
        };

        foreach (int i in myArrayDeclaredAndInitialized)
        {
            Console.WriteLine(i);
        }

        double[] numbers3 =
        {
            10.1,
            11.1,
            12.1,
        };



        string[] stringArrayDeclaredAndInitialized =
        {
            "khader basha",
            "badrun",
            "abdul ravoof",
            "rizwana",
            "abdul salaam",
            "sana sadiya",
            "haniya izzah",
            "nuha maryam",
        };

        foreach (string i in stringArrayDeclaredAndInitialized)
        {
            Console.WriteLine(i);
        }

        float[] floatArrayDeclaredAndInitialized =
        {
            1.2f,
            3.14f
        };

        foreach (float i in floatArrayDeclaredAndInitialized)
        {
            Console.WriteLine(i);
        }

        int[] numbers4 =
        [
            3,
            4,
            5,
        ];

        long[] phoneNumbersArrayDeclaredAndInitialized = 
        [
            7395906210L,
            8220622781L,
            9884255477L,
            9566235307L,
        ];

        foreach (long i in phoneNumbersArrayDeclaredAndInitialized)
        {
            Console.WriteLine(i);
        }

        int arrLength = phoneNumbersArrayDeclaredAndInitialized.Length;
        Console.WriteLine(arrLength);

        // here is how we get the length of an array
        int length = numbers.Length; //3
    }
}