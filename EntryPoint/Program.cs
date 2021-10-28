using System;
using PointAndLines;
using IntroToOOP;

namespace EntryPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User("Raven", Race.Earthling);
            User user0 = new User("Jack", Race.Earthling);
            User user1 = new User("OOOOHHHD", Race.Martian);
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(user.Username);
            Console.WriteLine(user.ID);
           
            Utilities.ColorfulWriteLine("This is Colorful!", ConsoleColor.Yellow);
            Console.WriteLine(user0.ID);
            Console.WriteLine(user1.ID);
            Console.WriteLine(User.currentID);


        }
    }
}
