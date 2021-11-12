using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person(name: "Marcos", lastName: "Allysson", age: 24, weight: 1.75, height: 61, status: EStatus.Married);
            // person.Name = "Marcos";
            // person.LastName = "Allysson";
            // person.Weight = 61;
            // person.Height = 1.75;
            // person.Age = 24;
            Console.WriteLine(person.FullName());

            person.SetName("Silva");
            Console.WriteLine(person.FullName());
            Console.WriteLine(person.GetAge());
            Console.WriteLine(person.GetHeight());
            Console.WriteLine(person.GetWeight());
            Console.WriteLine(person.PersonFullDetails());
        }


    }

    // Struct
    struct Person
    {
        //constructor
        public Person(string name, string lastName, int age, double weight, double height, EStatus status)
        {
            Name = name;
            LastName = lastName;
            Age = age;
            Weight = weight;
            Height = height;
            Status = status;
        }
        public string Name;
        public string LastName;
        public int Age;
        public double Weight;
        public double Height;
        public EStatus Status;

        public string FullName()
        {
            return Name + " " + LastName;
        }

        public void SetName(string newLastName)
        {
            LastName = newLastName;
        }

        public int GetAge()
        {
            return Age;
        }

        public int GetStatus()
        {
            return (int)Status;
        }

        public string PersonFullDetails()
        {
            return FullName() + " is " + Convert.ToInt32(GetAge()) + ", " + Status + Convert.ToString(GetStatus()) + ", he/she has " + Convert.ToString(GetHeight()) + "m and " + Convert.ToString(GetWeight()) + "kg";
        }

        public double GetHeight()
        {
            return Height;
        }

        public double GetWeight()
        {
            return Weight;
        }
    }

    enum EStatus
    {
        Single = 1,
        Married = 2,
        Divorced = 3
    }
}
