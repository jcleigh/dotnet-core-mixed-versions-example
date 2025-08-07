using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using DotNetCoreTwoPointTwo.Models;

namespace DotNetCoreTwoPointTwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Demonstrate serialization
            var person = new Person
            {
                Name = "John Doe",
                Age = 30,
                Email = "john@example.com",
                TemporaryData = "This will be ignored in JSON"
            };

            // Basic serialization
            string jsonString = JsonConvert.SerializeObject(person);
            Console.WriteLine("Basic serialization:");
            Console.WriteLine(jsonString);

            // Pretty print JSON
            string prettyJson = JsonConvert.SerializeObject(person, Formatting.Indented);
            Console.WriteLine("\nPretty printed JSON:");
            Console.WriteLine(prettyJson);

            // Demonstrate deserialization
            string jsonInput = @"{""Name"":""Jane Smith"",""Age"":25,""email_address"":""jane@example.com""}";
            var deserializedPerson = JsonConvert.DeserializeObject<Person>(jsonInput);
            Console.WriteLine($"\nDeserialized person: {deserializedPerson.Name}, {deserializedPerson.Age}");

            // Working with JSON arrays
            var people = new List<Person>
            {
                new Person { Name = "Alice", Age = 20, Email = "alice@example.com" },
                new Person { Name = "Bob", Age = 25, Email = "bob@example.com" }
            };

            string jsonArray = JsonConvert.SerializeObject(people, Formatting.Indented);
            Console.WriteLine("\nJSON array:");
            Console.WriteLine(jsonArray);

            // Dynamic JSON manipulation using JObject
            var jsonObject = JObject.Parse(jsonInput);
            jsonObject["Age"] = 26;  // Modify a value
            jsonObject.Add("Country", "USA");  // Add a new property
            
            Console.WriteLine("\nModified JSON:");
            Console.WriteLine(jsonObject.ToString(Formatting.Indented));
        }
    }
}