public sealed class ReferenceType
{
    public void RunExample()
    {
        // objects are "reference types" in C#
        // and up until now we've only been working with
        // "value types" like int, double, and bool
        // ... except for our collections!

        OurClass object1 = new OurClass(); // new reference
        OurClass object2 = new OurClass(); // new reference
        OurClass object3 = object1; // same reference as object1!

        //MyClass myClass = new MyClass();
        //MyClass myClass2 = new MyClass();
        //MyClass myClass3 = myClass;

        Console.WriteLine("object1 == object2:");
        Console.WriteLine(object1 == object2); // false
        Console.WriteLine("object1 == object3:");
        Console.WriteLine(object1 == object3); // true

        //Console.WriteLine("myclass == myclass2");
        //Console.WriteLine(myClass == myClass2);
        //Console.WriteLine("myclass1 == myclass3");
        //Console.WriteLine(myClass == myClass3);

        // collections are very much the same!
        List<int> myNumbers1 = new List<int> { 1, 2, 3 };
        List<int> myNumbers2 = new List<int> { 1, 2, 3 };

        //List<int> oddNumbers = new List<int> { 1, 3, 5, 7, 9 };
        //List<int> evenNumbers = new List<int> { 2,4,6,8,10 };


        Console.WriteLine("myNumbers1 == myNumbers2:");
        Console.WriteLine(myNumbers1 == myNumbers2); // false

        //Console.WriteLine("oddNumbers == evenNumbers");
        //Console.WriteLine(oddNumbers == evenNumbers);

        // let's wrap up with re-examining parameter passing
        // with value types and reference types!
        void ChangeValue(int value)
        {
            value = 42;
        }

        //void ChangeValues(int value)
        //{
        //    value = 43;
        //}

        int myValue = 1337;

        //int myValue2 = 1232;

        Console.WriteLine("myValue before ChangeValue:");
        Console.WriteLine(myValue); // 1337
        ChangeValue(myValue);
        Console.WriteLine("myValue after ChangeValue:");
        Console.WriteLine(myValue); // 1337

        //Console.WriteLine("myValue2 before changevaue");
        //Console.WriteLine(myValue2); //1232;
        //ChangeValue(myValue2);
        //Console.WriteLine("myvalue2 after changevalue");
        //Console.WriteLine(myValue2); //1232;

        void ChangeReference(List<string> words)
        {
            words = new List<string>();
            words.Add("from");
            words.Add("Dev");
            words.Add("Leader");
        }

        void ChangeReferenceValue(List<string> colors)
        {
            //colors = new List<string>();
            colors.Add("red");
            colors.Add("blue");
            colors.Add("green");
        }

        List<string> myWords = new List<string> { "Hello", "World" };
        Console.WriteLine("myWords before ChangeReference:");
        Console.WriteLine(string.Join(" ", myWords)); // Hello World
        ChangeReference(myWords);
        Console.WriteLine("myWords after ChangeReference:");
        Console.WriteLine(string.Join(" ", myWords)); // Hello World from Dev Leader

        List<string> colors = new List<string>
        {
            "black",
            "white",
        };
        Console.WriteLine("colors before change reference");
        Console.WriteLine(string.Join(" ", colors));
        ChangeReferenceValue(colors);
        Console.WriteLine("colors after change in reference");
        Console.WriteLine(string.Join(" ", colors));

        // this is because when we pass a value type to a method
        // we're passing a copy of the value but when we pass a
        // reference type to a method we're passing the reference!
    }

    // in C# we can create a class by using the class keyword
    class OurClass
    {

    }

    //class MyClass
    //{

    //}
}