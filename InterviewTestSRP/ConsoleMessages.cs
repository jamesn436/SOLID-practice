using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewTestSRP
{
    public static class ConsoleMessages
    {
        public static void InvalidCarSeats(int seats)
        {
            Console.WriteLine("Invalid number of seats: data entered: " + seats + " (between 1 - 8)");
        }

        public static void InvalidAirBags(int bags)
        {
            Console.WriteLine("Invalid number of Airbags: data entered: " + bags + " (between 1 - 10)");
        }

        public static void InvalidDoors(int doors)
        {
            Console.WriteLine("Invalid number of doors: data entered: " + doors + " (between 2 - 5)");
        }

        public static void InvalidReg(String registration)
        {
            Console.WriteLine("Invalid registration number: data entered: " + registration);
        }

        public static void InvalidDate(String date)
        {
            Console.WriteLine("Invalid date of manufacture: data entered: " + date);
        }

        public static void InvalidTime(String time)
        {
            Console.WriteLine("Invalid Time of manufacture: data entered: " + time);
        }

        public static void CloseProgramMessage()
        {
            Console.WriteLine("Closing the program.");
        }
    }
}
