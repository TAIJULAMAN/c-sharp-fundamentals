using System;
using System.Collections.Generic;
using System.Linq;

namespace DictionaryDemo
{
    // Custom class for dictionary key
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Override Equals and GetHashCode for dictionary key
        public override bool Equals(object obj)
        {
            return obj is Person p && p.FirstName == FirstName && p.LastName == LastName;
        }

        public override int GetHashCode()
        {
            return (FirstName + LastName).GetHashCode();
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // ===== 1. Basic Dictionary =====
            Dictionary<string, int> ages = new Dictionary<string, int>()
            {
                {"Alice", 25},
                {"Bob", 30},
                {"Charlie", 28}
            };

            // Access and update
            Console.WriteLine("Alice's age: " + ages["Alice"]);
            ages["Alice"] = 26;  // Update value

            // Safe access using TryGetValue
            if (ages.TryGetValue("David", out int davidAge))
            {
                Console.WriteLine("David's age: " + davidAge);
            }
            else
            {
                Console.WriteLine("David not found!");
            }

            // Iterating
            Console.WriteLine("\nAll entries:");
            foreach (var kvp in ages)
            {
                Console.WriteLine($"{kvp.Key} => {kvp.Value}");
            }

            // Remove an entry
            ages.Remove("Charlie");
            Console.WriteLine("\nAfter removing Charlie:");
            foreach (var kvp in ages)
            {
                Console.WriteLine($"{kvp.Key} => {kvp.Value}");
            }

            // ===== 2. Merging Dictionaries =====
            Dictionary<string, int> newAges = new Dictionary<string, int>()
            {
                {"Bob", 35},  // Will update
                {"David", 22} // Will add
            };

            foreach (var kvp in newAges)
            {
                ages[kvp.Key] = kvp.Value;  // Add or update
            }

            Console.WriteLine("\nAfter merging newAges:");
            foreach (var kvp in ages)
            {
                Console.WriteLine($"{kvp.Key} => {kvp.Value}");
            }

            // ===== 3. Sorting Dictionary =====
            Console.WriteLine("\nSorted by Name (Key):");
            var sortedByName = ages.OrderBy(kvp => kvp.Key);
            foreach (var kvp in sortedByName)
            {
                Console.WriteLine($"{kvp.Key} => {kvp.Value}");
            }

            Console.WriteLine("\nSorted by Age (Value):");
            var sortedByAge = ages.OrderBy(kvp => kvp.Value);
            foreach (var kvp in sortedByAge)
            {
                Console.WriteLine($"{kvp.Key} => {kvp.Value}");
            }

            // ===== 4. Dictionary with Custom Object as Key =====
            Dictionary<Person, string> personJobs = new Dictionary<Person, string>();

            var person1 = new Person { FirstName = "John", LastName = "Doe" };
            var person2 = new Person { FirstName = "Jane", LastName = "Smith" };

            personJobs[person1] = "Engineer";
            personJobs[person2] = "Designer";

            Console.WriteLine("\nCustom Object as Dictionary Key:");
            foreach (var kvp in personJobs)
            {
                Console.WriteLine($"{kvp.Key} => {kvp.Value}");
            }

            // Access using a new object with same values
            var lookupPerson = new Person { FirstName = "John", LastName = "Doe" };
            if (personJobs.TryGetValue(lookupPerson, out string job))
            {
                Console.WriteLine($"\n{lookupPerson} is a {job}");
            }
        }
    }
}