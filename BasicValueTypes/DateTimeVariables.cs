public sealed class DateTimeVariables
{
    public void RunExample()
    {
        // Date and time can be stored in a DateTime variable
        // Dates can be assigned to a DateOnly variable
        // Times can be assigned to a TimeOnly variable

        // we can declare a DateTime variable
        DateTime myDateTime;

        DateTime myDateTimeVariable;

        // we can declare a DateOnly variable
        DateOnly myDate;

        DateOnly myDateOnlyVariable;

        // we can declare a TimeOnly variable
        TimeOnly myTime;

        TimeOnly myTimeOnlyVariable;


        // We can assign a value to these variables
        myDateTime = DateTime.Now;
        myDate = new DateOnly(2024, 1, 23);
        myTime = new TimeOnly(1, 23, 45);

        myDateTimeVariable = DateTime.Now.AddYears(-25);
        myDateOnlyVariable = new DateOnly(1999, 10, 22);
        myTimeOnlyVariable = new TimeOnly(3, 45, 00);
        Console.WriteLine($" prinitng the value after assigning the datetime variable { myDateTimeVariable}");
        Console.WriteLine($" prinitng the value after assigning the myDateOnlyVariable variable {myDateOnlyVariable}");
        Console.WriteLine($" prinitng the value after assigning the myTimeOnlyVariable variable {myTimeOnlyVariable}");

        // We can declare and assign in one line
        DateTime myDateTimeVariable2 = DateTime.Now;
        DateOnly myDate2 = new DateOnly(2024, 1, 23);
        TimeOnly myTime2 = new TimeOnly(1, 23, 45);

        DateTime myDateTimeVariableOnly2 = DateTime.Now.AddYears(-20);
        DateOnly myDateOnlyVarible2 = new DateOnly(2006, 09, 09);
        TimeOnly myTimeOnlyVariable2 = new TimeOnly( 12, 15, 30);
        Console.WriteLine($" prinitng the value after assigning the myDateTimeVariable2 variable {myDateTimeVariableOnly2}");
        Console.WriteLine($" prinitng the value after assigning the myDateOnlyVarible2 variable {myDateOnlyVarible2}");
        Console.WriteLine($" prinitng the value after assigning the myTimeOnlyVariable2 variable {myTimeOnlyVariable2}");

        // We can re-assign a value to these variables
        myDateTime = DateTime.Now;
        myDate = new DateOnly(2024, 1, 23);
        myTime = new TimeOnly(1, 23, 45);

        myDateTimeVariableOnly2 = DateTime.Now.AddMonths(10);
        myDateOnlyVarible2 = new DateOnly(2026, 10, 22);
        myTimeOnlyVariable2 = new TimeOnly(04, 30, 30);

        Console.WriteLine($" prinitng the value after re-assigning the myDateTimeVariable2 variable {myDateTimeVariableOnly2}");
        Console.WriteLine($" prinitng the value after re-assigning the myDateOnlyVarible2 variable {myDateOnlyVarible2}");
        Console.WriteLine($" prinitng the value after re-assigning the myTimeOnlyVariable2 variable {myTimeOnlyVariable2}");
        // Dates and times are complex... consider
        // that we haven't factored in time zones!
        string [] myDateTimeArray = myDateTimeVariable2.GetDateTimeFormats();
        Console.WriteLine($" printing the values of the datetimeformats available for the datetime from the method getdatetimeformats {myDateTimeArray}");
        Console.WriteLine("printing the list of arrays");
        foreach ( string format in myDateTimeArray)
        {

        Console.WriteLine($"{ format}"); }
        // we can make a DateTime variable out of
        // a DateOnly and a TimeOnly variable
        DateTime dateTimeFromCombination = new DateTime(
            myDate,
            myTime);

        DateTime myDateTimeFromCombination = new DateTime(
            myDateOnlyVariable,
            myTimeOnlyVariable);
        Console.WriteLine($" printing the datetime combination declared {myDateTimeFromCombination}");

        // Let's write these to the console!
        Console.WriteLine($"Date Only: {myDate}");
        Console.WriteLine($"Time Only: {myTime}");
        Console.WriteLine($"Date Time: {dateTimeFromCombination}");
    }
}