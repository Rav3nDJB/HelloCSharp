using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("\' \" \\ \0 \a \b \f \n \r \t \v \u0000 \U0001F47D \x01 \x0102");
            Nullable<int> i1 = null;
            int? i2 = i1;
            Console.WriteLine(i1.GetValueOrDefault());
            Console.WriteLine(i2.GetValueOrDefault());
        }
    }
}
