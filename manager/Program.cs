using System;

namespace manager
{
    public class Program
    {
        public static String ticketPrice(int age)
        {
            if (age <= 0)
            {
                return "Input is invalid    ";
            }
            else if (age <= 10)
            {
                return "Free";
            }
            else
            {
                return "5$";
            }
        }

        public static String gift(String gender)
        {
            if (gender == "Female")
            {
                return "White bracelet";
            }
            else
            {
                return "Black bracelet";
            }
        }

        public static void Main(string[] args)
        {
            int age = Convert.ToInt32(Console.ReadLine());
            String gender = Console.ReadLine();
            if (ticketPrice(age) == "Input is invalid")
            {
                Console.WriteLine("Input is invalid");
            }
            else
            {
                Console.WriteLine(ticketPrice(age) + " And " + gift(gender));
            }
        }
    }
}

