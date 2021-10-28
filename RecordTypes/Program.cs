using System;

namespace RecordTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person person = new Person();
            //Person person = new Person("Jill");
            //Person person = new Person()
            //person.Name = "Jade";
            //Person person = new Person
            //{
            //    Name = "Jade",
            //    Age = 31
            //};
            //Person person1 = person with { Age = 32 };
            //Person person = new Person("Jill", 31);
            //Person person1 = person with { age = 32 };
            Person person = new Person("John");
            Person person1 = new PersonWithAge("John", 31);

            Console.WriteLine(person.Equals(person1));
            Console.WriteLine(person == person1);

        }

        //public record Person(string name);
        //public record Person
        //{
        //    public string Name { get; init; }
        //    public int Age { get; init; }
        //}
        //public record Person(string name, int age);
        public record Person
        {
            public Person(string name)
            {
                this.Name = name;
            }
            public string Name { get; init; }
        }
        public record PersonWithAge : Person
        {
            public PersonWithAge(string name, int age) : base(name)
            {
                this.Age = age;
            }
            public int Age { get; init; }
        }
    } 
}
