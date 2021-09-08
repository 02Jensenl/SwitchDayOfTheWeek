using System;

namespace SwitchDayOfTheWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            int day =0;

            Console.Write("Please input a number (1-7) for the day of the week: ");
            day = int.Parse(Console.ReadLine());

            switch (day)
            {
                case 1:
                    Console.WriteLine($"The {day}st day of the week is Sunday");
                    break;

                case 2:
                    Console.WriteLine($"The {day}nd day of the week is Monday");
                    break;

                case 3:
                    Console.WriteLine($"The {day}rd day of the week is Tuesday");
                    break;

                case 4:
                    Console.WriteLine($"The {day}th day of the week is Wednesday");
                    break;

                case 5:
                    Console.WriteLine($"The {day}th day of the week is Thursday");
                    break;

                case 6:
                    Console.WriteLine($"The {day}th day of the week is Friday");
                    break;

                case 7:
                    Console.WriteLine($"The {day}th day of the week is Saturday");
                    break;

                default:
                    Console.WriteLine("Incorrect number");
                    break;
            }

        }
    }
}
