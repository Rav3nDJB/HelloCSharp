using System;

namespace HelloCSharp
{
    class HelloCSharp
    {
        static void Main(string[] args)
        {
            //throw new NotImplementedException("Intended exception.");
            Console.WriteLine("Good Day!");
            Console.WriteLine("Don Ferreira");
            Console.WriteLine("1");
            Console.WriteLine("101");
            Console.WriteLine("1001");
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(Math.Sqrt(12345));

            bool addMinus = false;
            for (int a = 2; a <= 102; a += 1)
            {
                if (addMinus == false)
                {
                    Console.Write(a + ", ");
                }
                else if (a == 102)
                {
                    Console.Write(a); Console.WriteLine();
                }
                else
                {
                    Console.Write("-" + a + ", ");
                }
            }
            string age;
            Console.WriteLine("Please input your age");
            age = Console.ReadLine();
            Console.WriteLine("In ten years you will be " + (Convert.ToInt32(age) + 10).ToString() + " old.");
            Console.WriteLine("In ten years you will be " + (int.Parse(age) + 10).ToString() + " old.");

        }
    }
}
