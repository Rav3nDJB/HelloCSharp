using System;

namespace TargetTyping
{
    class Program
    {
        static void Main(string[] args)
        {
            //var myClass = new MyClass();
            //MyClass instance = new();
            //MyClassWithContructor instance = new("abc");
            //{   
            //};
        }
    }
    class MyClass
    {
        public string MyValue { get; set; }
    }
    class MyClassWithContructor
    {
        private readonly string myValue;
        public MyClassWithContructor(string myValue)
        {
            this.myValue = myValue;
        }
    }
}
