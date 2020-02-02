using System;

namespace helloWorldCS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string message = "";
            if (args.Length < 1) {
                message = "Welcome to .NET Core!";
            }
            else {
                foreach (string item in args) {
                message += item;
                }
            }
            Console.WriteLine(message);
        }
    }
}
