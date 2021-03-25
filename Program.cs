using System;
using System.Collections.Generic;

namespace FirstConsoleAppDotNetCore
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Human> clients = new List<Human>();
            Human client = null;
            Random rand = new Random();

            for(int i = 0; i < 50; i++)
            {
                string name = "Name" + i.ToString();
                string surname = "Surname" + i.ToString();
                int age = rand.Next(14, 111);

                client = new Human(name, surname, age);
                clients.Add(client);
            }

            //Introduce our clients
            Console.WriteLine("Using foreach loop");
            foreach(var c in clients)
            {
                c.Introduce();
            }
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

        public void SayPassword()
        {
            Console.WriteLine($"{this.Name}: ******************");
        }

        public int CalculateSum(int a, int b)
        {
            return a + b;
        }
    }
}
