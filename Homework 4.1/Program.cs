using System;


while (true)
{
    Console.WriteLine("Enter the day of the week number (1 to 7): ");
    string input = Console.ReadLine();


    if (int.TryParse(input, out int dayNumber))
    {

        if (dayNumber >= 1 && dayNumber <= 7)
        {
            switch (dayNumber)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
            }

            break;
        }
        else
        {
            Console.WriteLine("The number is out of range. Please enter a number between 1 and 7.");
        }
    }
    else
    {
        Console.WriteLine("Invalid input. Please enter a valid number.");
    }
}