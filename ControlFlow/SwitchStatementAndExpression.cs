public sealed class SwitchStatementAndExpression
{
    public void RunExample()
    {
        // The switch statement is used to select one of
        // many code blocks to be executed.
        // The switch expression is used to select one of
        // many code blocks to be executed.

        // here is an example of a switch statement
        int dayOfWeek = 4;
        switch (dayOfWeek)
        {
            case 1:
            case 2:
            case 3:
            case 4:
            case 5:
                Console.WriteLine("Week Day");
                break;
            case 6:
            case 7:
                Console.WriteLine("Weekend");
                break;
            default:
                Console.WriteLine("Invalid day");
                break;
        }

        int sahabaNumber = 11;
        while (sahabaNumber > 0)
        {
            int number = int.Parse(Console.ReadLine());
            switch (number)
            {
                case 1:
                    Console.WriteLine("abu bakr siddiq");
                    break;
                case 2:
                    Console.WriteLine("umar");
                    break;
                case 3:
                    Console.WriteLine("usman");
                    break;
                case 4:
                    Console.WriteLine("ali");
                    break;
                case 5:
                    Console.WriteLine("abu ubaidah");
                    break;
                case 6:
                    Console.WriteLine("sad");
                    break;
                case 7:
                    Console.WriteLine("zubair");
                    break;
                case 8:
                    Console.WriteLine("talha");
                    break;
                case 9:
                    Console.WriteLine("abdur rahman");
                    break;
                case 10:
                    Console.WriteLine("saeed");
                    break;
                default:
                    Console.WriteLine("not ashratul mubashara");
                    break;

            }
            sahabaNumber--;
        }

        Console.WriteLine("This is after the switch!");

        // here is an example of a switch expression
        string dayOfWeekName = "Haha";
        string result = dayOfWeekName switch
        {
            "Monday" => "First day of the week",
            "Tuesday" => "Second day of the week",
            "Wednesday" => "Third day of the week",
            "Thursday" => "Fourth day of the week",
            "Friday" => "Fifth day of the week",
            "Saturday" => "Sixth day of the week",
            "Sunday" => "Seventh day of the week",
            _ => "Invalid day"
        };

        int count = 5;
        while (count > 0) {
            string caliphaName = Console.ReadLine();
            string answer = caliphaName switch
            {
                "abubakr" => "first calipha",
                "umar" => "second calipha",
                "usman" => "third calipa",
                "ali" => "fourht calipha",
                _ => "invalid calipha rashideen",
            };
            Console.WriteLine(answer);
            count--;
        }
    }
}