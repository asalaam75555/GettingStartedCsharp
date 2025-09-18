public sealed class StaticVsInstance
{
    public void RunExample()
    {
        // static is a modifier that makes a member belong to a type, rather than an "instance" of a type
        // we can even make entire classes static.

        // note that we cannot make an instance of "MyStaticClass" because it is marked static
        // MyStaticClass myStaticClass = new MyStaticClass(); // this will not work!

        // static classes cannot have instance members, so anything inside of a static class must also be static
        MyStaticClass.MyStaticMethod();

        ExampleStaticClass.ExampleStaticMethod(); 

        // notice how we don't need to make an instance of MyStaticClass to call MyStaticMethod?
        // this is just like Console.WriteLine! This means that Console.WriteLine is a static method!

        // on non-static classes, we *can* add static members
        MyNonStaticClass myNonStaticClass1 = new MyNonStaticClass();
        MyNonStaticClass myNonStaticClass2 = new MyNonStaticClass();

        Console.WriteLine("Before mutating properties on MyNonStaticClass...");
        myNonStaticClass1.MyInstanceMethod();
        myNonStaticClass2.MyInstanceMethod();
        MyNonStaticClass.MyStaticMethod();

        // let's mutate these things and see what happens!
        myNonStaticClass1.MyInstanceProperty = "Dev";
        myNonStaticClass2.MyInstanceProperty = "Leader";
        MyNonStaticClass.MyStaticProperty = "Nick Cosentino";

        Console.WriteLine("After mutating properties on MyNonStaticClass...");
        myNonStaticClass1.MyInstanceMethod();
        myNonStaticClass2.MyInstanceMethod();
        MyNonStaticClass.MyStaticMethod();

        // static members are accessible across all instances. this can be
        // convenient, but can also lead to bugs if you're not careful!
        // personally - I advise a lot of caution with using static.

        ExampleNonStaticClass exampleNonStaticClass1 = new ExampleNonStaticClass(); 
        ExampleNonStaticClass exampleNonStaticClass2 = new ExampleNonStaticClass();

        Console.WriteLine("before mutating properties on example my non static class......");
        exampleNonStaticClass1.MyInstanceMethod();
        exampleNonStaticClass2.MyInstanceMethod();
        ExampleNonStaticClass.MyStaticMethod();

        exampleNonStaticClass1.MyInstanceProperty = "Abdul";
        exampleNonStaticClass2.MyInstanceProperty = "Salaam";
        ExampleNonStaticClass.MyStaticProperty = "This is a static property";

        Console.WriteLine("aftre the mutating properties on example my non static class .....");
        exampleNonStaticClass1.MyInstanceMethod();
        exampleNonStaticClass2.MyInstanceMethod();
        ExampleNonStaticClass.MyStaticMethod();
    }

    static class MyStaticClass
    {
        public static void MyStaticMethod()
        {
            Console.WriteLine("I am a static method!");
        }
    }

    static class ExampleStaticClass
    {
        public static void ExampleStaticMethod()
        {
            Console.WriteLine("this is example static method");
        }
    }

    class MyNonStaticClass
    {
        public string MyInstanceProperty { get; set; }

        public static string MyStaticProperty { get; set; }

        public static void MyStaticMethod()
        {
            Console.WriteLine($"The static property value is: {MyStaticProperty}");

            // this will not work because MyInstanceProperty is not static!
            //Console.WriteLine($"The instance property value is: {MyInstanceProperty}");
        }

        public void MyInstanceMethod()
        {
            Console.WriteLine($"The static property value is: {MyStaticProperty}");
            Console.WriteLine($"The instance property value is: {MyInstanceProperty}");
        }
    }

    class ExampleNonStaticClass
    { 
        public string MyInstanceProperty { get; set; }

        public static string MyStaticProperty { get; set ; }  

        public static void MyStaticMethod()
        {
            Console.WriteLine($"The static property value is : {MyStaticProperty}");

            //Console.WriteLine($"this is my instance property is : {MyInstanceProperty}"); //this will not work becuse only can access static inside static
        }

        public void MyInstanceMethod()
        {
            Console.WriteLine($"the static property value is : {MyStaticProperty}");
            Console.WriteLine($"the instance property value is : {MyInstanceProperty}");
        }
    }
}
