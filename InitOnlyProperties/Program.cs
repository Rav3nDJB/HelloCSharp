using System;

namespace InitOnlyProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person
            {
                Name = "Jack"
            };
            Person person1 = new Person("Hank");
        }

        public record Person
        {
            private readonly string _name;
           //public string Name { get; init; }
            //public string Name => _name;
           
            public string Name
            {
                get => _name;
                init => Name = value;
            }

            public Person() { }
            public Person(string name)
            {
                //this.Name = name;
                this._name = name;
            }
            

        }

    }
}
