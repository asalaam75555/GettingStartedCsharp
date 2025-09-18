public sealed class FieldsAndProperties
{
    public void RunExample()
    {
        // a field is a variable that is declared directly in a class.

        // what does private do in the above examples?
        // "private" is an access modifier.
        // We saw "public" as an access modidier in earlier videos.
        // "private" specifies that something is accessible only within the class

        MyClass myClass = new MyClass();
        //myClass._fullName; not accessible due to its protection level

        Person2 john = new Person2();
        // john._name = "John"; // this will not work because _name is private

        MyClass2 myClass2 = new MyClass2();
        //myClass2._fullName; // not accessible due to its protection level

        Person3 johnWithMethod = new Person3();
        //Console.WriteLine(johnWithMethod.GetName());

        MyCalss3 myCalss3 = new MyCalss3();
        Console.WriteLine(myCalss3.GetName());

        // methods and functions can also have "private" access modifiers
        // if a method/function is private, it can only be accessed within the class
        // there are other access modifiers that we won't cover in this course


        Person4 johnWithProperty = new Person4();
        Console.WriteLine(johnWithProperty.Name);
        Console.WriteLine(johnWithProperty.Name2);
        Console.WriteLine(johnWithProperty.Name3);

        Console.WriteLine("Setting the name...");
        johnWithProperty.MutableName = "John Doe";
        Console.WriteLine(johnWithProperty.MutableName);
        Console.WriteLine(johnWithProperty.Name);
        Console.WriteLine(johnWithProperty.Name2);
        Console.WriteLine(johnWithProperty.Name3);

        Myclass4 myclass4 = new Myclass4();
        Console.WriteLine(myclass4.FullName);
        //myclass4.FullName = "ABDLUL"; // ONLY getable not setable 
        Console.WriteLine(myclass4.fullName2);
        //myclass4._name = "sick"; //only getttable not setable
        Console.WriteLine(myclass4.fullName3);
        //myclass4.fullName3 = "jack"; //only gettable not setable 
        Console.WriteLine(myclass4.MutableName);
        Console.WriteLine("changing the name");
        myclass4.MutableName = "abdul salaam";
        Console.WriteLine(myclass4.MutableName);
    }

    // here is how we declare a field in a class
    class Person
    {
        private string _name;
    }

    class MyClass
    {
        private string _fullName;
    }

    // we can give a field a value when we declare it
    class Person2
    {
        private string _name = "John";
    }

    class MyClass2
    {
        private string _fullName = "Abdul Salaam";
    }

    // we can access _name using a method!
    class Person3
    {
        private string _name = "John";

        public string GetName()
        {
            return _name;
        }
    }

    class MyCalss3
    {
        private string _fullName = "Abdul Salaam";

        public string GetName()
        {
            return _fullName;
        }
    }

    // A property is a member that provides a flexible mechanism to
    // read, write, or compute the value of a private field.
    class Person4
    {
        private string _name = "John";

        public string Name
        {
            get
            {
                return _name;
            }
        }

        public string Name2 => _name;

        public string Name3 { get; } = "John";

        public string MutableName
        {
            get { return _name; }
            set { _name = value; }
        }
    }

    class Myclass4
    {
        private string _fullName = "Name 1";

        public string FullName
        {
            get 
            {
                return _fullName;
            }
        }

        string _name = "name2";

        public string fullName2 => _name;

        public string fullName3 { get; } = "Name3";

        public string MutableName
        {
            get { return _fullName; }
            set { _fullName = value; }
        }
    }
}