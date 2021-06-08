using System;

namespace Age
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;

            Console.WriteLine("Enter your age");
            age = Convert.ToInt32(Console.ReadLine());
            if (age > 18)
            {
                Console.WriteLine(" You are an adult now");
            }
            else
            {
                Console.WriteLine("You are minor yet");
            }
        }
    }
}
