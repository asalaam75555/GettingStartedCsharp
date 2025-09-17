// constructors are used to initialize a class

public sealed class Constructors
{
    public void RunExample()
    {
        ImplicitConstructor implicitConstructor = new();
        HasImplicitConstructor hasImplicitConstructor = new();
        ExplicitConstructor explicitConstructor = new();
        HasParameterlessConstructor hasParameterlessConstructor = new();
        ConstructorWithParameter constructorWithParameter = new("this is argument 1");
        MultipleConstructors multipleConstructors = new MultipleConstructors();
        HasConstructorThatCanTakeValue hasConstructorThatCanTakeValue = new("this is argument 2");
        MultipleConstructors multipleConstructors1 = new MultipleConstructors();
        ChainingMultipleConstructor chainingMultipleConstructor = new();
        OurCollectionOfWords ourCollectionOfWords = new();
        ourCollectionOfWords.Add("one");
        ourCollectionOfWords.Add("two");
        ourCollectionOfWords.Add("three");
        ourCollectionOfWords.Print();
        ToInitializeClassUsingConstructorDemo toInitializeClassUsingConstructorDemo = new ToInitializeClassUsingConstructorDemo();
        toInitializeClassUsingConstructorDemo.Add("ek");
        toInitializeClassUsingConstructorDemo.Add("do");
        toInitializeClassUsingConstructorDemo.Add("teen");
        toInitializeClassUsingConstructorDemo.PrintName();
        List<string> listOfColors = new List<string>
        {
            "orange",
            "green",
            "blue",
        };
        OurCollectionOfWords2 ourCollectionOfWords2 = new(listOfColors);
        ourCollectionOfWords2.Print();
        List<string> listOfShapes = new List<string>();
        listOfShapes.Add("circle");
        listOfShapes.Add("triangle");
        listOfShapes.Add("rectangle");
        ToInitializeClassUsingConstructorDemo2 toInitializeClassUsingConstructorDemo2 = new ToInitializeClassUsingConstructorDemo2(listOfShapes);
        toInitializeClassUsingConstructorDemo2.Print();
        StaticConstructor staticConstructor = new StaticConstructor();
        StaticConstructor staticConstructor2 = new();
        StaticConstrutorDemo staticConstrutorDemo = new StaticConstrutorDemo();
        StaticConstrutorDemo staticConstructorDemo2 = new();
        OurClassWithAHiddenConstructor ourClassWithAHiddenConstructor = new OurClassWithAHiddenConstructor(619);
        UseCasesOfPrivateConstructor useCasesOfPrivateConstructor = new(22);
        //OurClassWithAHiddenConstructor instance = new(123);
        //Console.ReadLine();
    }

    // this still has a constructor even though we can't see it!
    class ImplicitConstructor
    {
    }

    class HasImplicitConstructor
    {

    }

    // this class has a parameterless constructor
    class ExplicitConstructor
    {
        public ExplicitConstructor()
        {
            Console.WriteLine("ExplicitConstructor constructor called");
        }
    }

    class HasParameterlessConstructor
    {
        public HasParameterlessConstructor()
        {
            Console.WriteLine($"{nameof(HasParameterlessConstructor)}");
        }

    }

    // this class has a constructor that takes in a value
    class ConstructorWithParameter
    {
        public ConstructorWithParameter(string message)
        {
            Console.WriteLine(message);
        }
    }

    class HasConstructorThatCanTakeValue
    {
        public HasConstructorThatCanTakeValue(string message)
        {
            Console.WriteLine($"the message that was passed to the constructor is {message}");
        }
    }

    // this is a class with multiple constructors "chained"
    // together by using : this() syntax
    class MultipleConstructors
    {
        public MultipleConstructors()
            : this("This is the default message!")
        {
        }

        public MultipleConstructors(string message)
        {
            Console.WriteLine(message);
        }
    }

    class ChainingMultipleConstructor
    {
        public ChainingMultipleConstructor()
            : this("message")
        {
            Console.WriteLine("this parameterless construcor will call the parameterized constructor");
        }

        public ChainingMultipleConstructor(string message)
        {
            Console.WriteLine($"this {message} passed to the parameterized constructor from parameterless constructor");
        }
    }

    // generally we use constructors to initialize the class
    class OurCollectionOfWords
    {
        private List<string> _strings;

        public OurCollectionOfWords()
        {
            // we can initialize the list here! this
            // will make it safe for us to use the list
            // later on in the class
            _strings = new List<string>();
        }

        public void Add(string word)
        {
            _strings.Add(word);
        }

        public void Print()
        {
            foreach (var word in _strings)
            {
                Console.WriteLine(word);
            }
        }
    }

    class ToInitializeClassUsingConstructorDemo
    {
        private List<string> _listOfNames;

        public ToInitializeClassUsingConstructorDemo()
        {
            _listOfNames = new List<string>();
        }

        public void Add(string name)
        {
            _listOfNames.Add(name);
        }
            
        public void PrintName()
        {
            foreach (var name in _listOfNames)
            {
                Console.WriteLine(name);
            }
        }
    }

    // we can build on the previous example by passing in
    // some words to the constructor
    class OurCollectionOfWords2
    {
        private List<string> _strings;

        public OurCollectionOfWords2(List<string> words)
        {
            _strings = new List<string>();

            foreach (var word in words)
            {
                _strings.Add(word);
            }
        }
        public void Print()
        {
            foreach (var word in _strings)
            {
                Console.WriteLine(word);
            }
        }
    }

    class ToInitializeClassUsingConstructorDemo2
    {
        private List<string> _listOfNames;

        public ToInitializeClassUsingConstructorDemo2 (List<string> listOfNames)
        {
            _listOfNames = new List<string> ();

            foreach (var name in listOfNames)
            {
                _listOfNames.Add(name);
            }
        }

        public void Print()
        {
            foreach (var name in _listOfNames)
            {
                Console.WriteLine(name);
            }
        }
    }

    // we can have static constructors which
    // will run the first time the type is used
    class StaticConstructor
    {
        static StaticConstructor()
        {
            Console.WriteLine("StaticConstructor constructor called");
        }
    }

    class StaticConstrutorDemo
    {
        static StaticConstrutorDemo()
        {
            Console.WriteLine("static constructor will be called only the first time when the type is used");
        }
    }

    // we can also have private constructors to prevent
    // certain access patterns for our class
    class OurClassWithAHiddenConstructor
    {
        public OurClassWithAHiddenConstructor(int value)
            : this()
        {
            Console.WriteLine(
                $"This is the public constructor and " +
                $"we received value {value}.");
        }

        private OurClassWithAHiddenConstructor()
        {
            Console.WriteLine(
                "Nobody can call this constructor " +
                "directly from the outside!");
        }
    }

    class UseCasesOfPrivateConstructor
    {
        public UseCasesOfPrivateConstructor(int value)
            : this()
        {
            Console.WriteLine($"this is a public constructor and we have recieved the value of demo {value}");
        }

        public UseCasesOfPrivateConstructor()
        {
            Console.WriteLine("this is a private constructor of demo and cannot be called from the outseide of the class");
        }
    }
}