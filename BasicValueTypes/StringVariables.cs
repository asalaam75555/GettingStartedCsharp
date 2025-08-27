using System.Text;

public sealed class StringVariables
{
    public void RunExample()
    {
        // Keep your eyes peeled:
        // What do you notice at the end of
        // the lines of code?

        // strings are represented by double quotes ""
        // In the following line, what part is the string?
        Console.WriteLine("Hello, World!");

        // We can "declare" a string variable
        string myString;
        string my_string;
        string MyString;

        string myStringVariable;

        // we can assign a value to a string variable
        myString = "Hello, World!";

        myStringVariable = "Abdul Salaam";

        // we can declare and assign in one line
        string coolString = "Hello, World!";

        string myStringVariable2 = "sulaiman";
        // we can re-assign a value to a string variable
        coolString = "Goodbye, World!";

        myStringVariable2 = "james bond";

        // we can "concatenate" strings
        string firstName = "John";
        string lastName = "Doe";
        string fullName = firstName + " " + lastName;

        // we can use Console.WriteLine() to print strings
        Console.WriteLine(fullName);

        // we can use Console.ReadLine() to read strings
        // (this will be helpful for some basic programs!)
        myString = Console.ReadLine();

        // we can print the length of a string
        Console.WriteLine(myString.Length);

        // we can access individual characters in a string
        Console.WriteLine(myString[0]);

        myStringVariable2 = Console.ReadLine();

        Console.WriteLine(myStringVariable2);

        // if you just wanted to declare a single character
        // and assign it, it would look like:
        char myChar = 'a';

        byte variable = Convert.ToByte(myChar);
        byte[] byteArray = Encoding.Unicode.GetBytes(new[] { myChar });

        Console.WriteLine(variable);
        foreach (var s in byteArray)
        {
            Console.WriteLine(s);
        }
    }
}