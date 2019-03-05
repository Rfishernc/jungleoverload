using System;
using System.Collections.Generic;
using System.Text;

namespace jungleOverload
{
    class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        static List<string> Restaurants() {
            return new List<string>
            {
                "Ruths Chris",
                "Waffle House",
                "The Bbq Pit",
                "El Molino"
            };
        }

        public string eat()
        {
            var randy = new Random();
            var restSelect = randy.Next(0, Restaurants().Count);
            Console.WriteLine($"{FirstName} {LastName} is at {Restaurants()[restSelect]}");
            return Restaurants()[restSelect];
        }
        public void eat(string food)
        {
            Console.WriteLine($"{FirstName} {LastName} ate {food} at the office.  What a responsible adult.");
        }
        public void eat(List<Employee> companions)
        {
            var randy = new Random();
            var restSelect = randy.Next(0, Restaurants().Count);
            var companionNames = "";
            var counter = 1;
            foreach(Employee emp in companions)
            {
                counter++;
                companionNames += emp.FirstName;
                if (counter < companions.Count)
                {
                    companionNames += " and ";
                }
            }
            Console.WriteLine($"{FirstName} {LastName} is at {Restaurants()[restSelect]} with {companionNames}");
        }
        public void eat(string food, List<Employee> companions)
        {
            var randy = new Random();
            var restSelect = randy.Next(0, Restaurants().Count);
            var companionNames = "";
            var counter = 1;
            foreach (Employee emp in companions)
            {
                counter++;
                companionNames += emp.FirstName;
                if (counter < companions.Count)
                {
                    companionNames += " and ";
                }
            }
            Console.WriteLine($"{FirstName} {LastName} ate {food} at {Restaurants()[restSelect]} with {companionNames}");
        }

    }
}
