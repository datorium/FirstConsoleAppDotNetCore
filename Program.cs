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

            client = new Human("Anna", "Lopez", 16);
            clients.Add(client); 

            client = new Human("John", "Jackson", 40);
            clients.Add(client);

            client = new Human("Jenifer", "Branson", 25);
            clients.Add(client);

            client = new Human("Android", "Smart", 18);
            clients.Add(client);

            client = new Human("Android", "Smart", 18);
            clients.Add(client);

            client = new Human("Android", "Smart", 18);
            clients.Add(client);

            client = new Human("Android", "Smart", 18);
            clients.Add(client);

            //Introduce our clients
            Console.WriteLine("The simple way of printing");
            clients[0].Introduce();
            clients[1].Introduce();
            clients[2].Introduce();
            clients[3].Introduce();
            clients[4].Introduce();
            clients[5].Introduce();
            clients[6].Introduce();

            Console.WriteLine("Using for loop");
            for(int i = 0; i < 7; i++)
            {
                clients[i].Introduce();
            }

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
