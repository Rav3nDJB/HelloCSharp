using System;

namespace ImprovedPatternMatching
{
    class Program
    {
        static void Main(string[] args)
        {
            var myNumber = new Random().Next(0, 20);
            if (myNumber is >= 0 and <= 10)
            {
                Console.WriteLine("More than 10, Less than 20");
            }
            else if (myNumber is > 10 and <= 20)
            {
                Console.WriteLine("More than 10, Less than 20");
            }
            switch (myNumber)
            {
                case >= 0 and <= 10:
                    Console.WriteLine("More than 10, Less than 20");
                    break;
                case > 10 and >= 20:
                    Console.WriteLine("More than 10, Less than 20");
                    break;
            }

            var result = myNumber switch
            {
                >= 0 and <= 10 => "More Than 0, Less Than 11.",
                > 10 and <= 20 => "More Than 10, Less Than 21.",
                < 0 or > 20 => "Invalid selection",
            };
            Console.WriteLine(result);
            //var myNumber = new Random().Next(1, 10);
            //if (myNumber is > 2 and < 8)
            //{

            //}

            //IMyInterface instance = new MyClass();
            //if (instance is MyClass or MySecondClass)
            //{

            //}
            //if (instance is IMyInterface and not MySecondClass )
            //{

            //} 
        }
        //public interface IMyInterface
        //{

        //}
        //public class MyClass : IMyInterface
        //{

        //}
        //public class MySecondClass : IMyInterface 
        //{

        //}
    }
}
