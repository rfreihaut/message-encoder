using System;

namespace MessageEncoder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your message?");
            string input = Console.ReadLine();
            string message = "";
            int checksum = 0;

            foreach (var character in input.ToUpper())
            {
                // 'A' has a value of 65, to get index position, subtract 64 from character
                int convertedChar = character - 64;
                message += $"{convertedChar}-";
                checksum += character;
            }

            Console.WriteLine("Your encoded message is {0}", message);
            Console.WriteLine("Message checksum is {0}", checksum);
            Console.ReadKey();
        }
    }
}
