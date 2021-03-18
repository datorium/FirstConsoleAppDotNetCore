using System;

namespace FirstConsoleAppDotNetCore
{
    class Program
    {
        static void Main(string[] args)
        {
            Human human1 = new Human("Anna", "Lopez", 16);
            human1.Introduce();

            Human human2 = new Human("John", "Jackson", 40);
            human2.Introduce();

            Human human3 = new Human("Jenifer", "Branson", 25);
            human3.Introduce();
        }
    }

    class Human
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }

        public Human(string name, string surname, int age)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
        }

        public void Introduce()
        {
            Console.WriteLine($"Hi, my name is {this.Name} {this.Surname} and I am {this.Age} years old.");
        }
    }

}
