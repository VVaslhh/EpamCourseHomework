using System;
using System.Collections.Generic;
using System.Text;

namespace Collections
{
    class Task12
    {
        //Task1
        public readonly List<Person> persons = new List<Person>()
        {
            new Person(){ Name = "Nathan", Age = 23, PhoneNumbers = new List<string> {GetRandomPhoneNumber(), GetRandomPhoneNumber(), GetRandomPhoneNumber() } },
            new Person() { Name = "Simon", Age = 35, PhoneNumbers = new List<string> {GetRandomPhoneNumber(), GetRandomPhoneNumber(), GetRandomPhoneNumber() } },
            new Person() { Name = "Kelly", Age = 25, PhoneNumbers = new List<string> {GetRandomPhoneNumber(), GetRandomPhoneNumber(), GetRandomPhoneNumber() } },
            new Person() { Name = "Alisha", Age = 20, PhoneNumbers = new List<string> {GetRandomPhoneNumber(), GetRandomPhoneNumber(), GetRandomPhoneNumber() } },
            new Person() { Name = "Curtis", Age = 29, PhoneNumbers = new List<string> {GetRandomPhoneNumber(), GetRandomPhoneNumber(), GetRandomPhoneNumber() } },
            new Person() { Name = "Rudy", Age = 37, PhoneNumbers = new List<string> {GetRandomPhoneNumber(), GetRandomPhoneNumber(), GetRandomPhoneNumber() } },
        };

        public static string GetRandomPhoneNumber()
        {
            Random rand = new Random();
            string number = String.Empty;
            for (int i = 0; i < 10; i++)
            {
                number = "0" + rand.Next();
            }
            return number;
        }

        public void DisplayNameAndAge()
        {
            if (persons != null)
            {
                foreach (var person in persons)
                {
                    Console.WriteLine($"Name: {person.Name}  Age: {person.Age}");
                }
            }
        }

        //Task2
        public void DisplayPhoneNumbers()
        {
            foreach (var person in persons)
            {
                foreach (var number in person.PhoneNumbers)
                    Console.Write($"PhoneNumber:{number}   ");
                Console.Write("\n");
            }
        }
    }
}
