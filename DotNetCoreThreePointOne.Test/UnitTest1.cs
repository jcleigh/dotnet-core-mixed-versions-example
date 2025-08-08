using NUnit.Framework;

namespace DotNetCoreThreePointOne.Test
{
    using DotNetCoreThreePointOne.Models;
    using Newtonsoft.Json;

    public class Tests
    {
        [Test]
        public void Person_Serialization_IgnoresTemporaryData()
        {
            var person = new Person
            {
                Name = "Test Name",
                Age = 42,
                Email = "test@example.com",
                TemporaryData = "Should be ignored"
            };
            string json = JsonConvert.SerializeObject(person);
            Assert.IsFalse(json.Contains("TemporaryData"));
            Assert.IsTrue(json.Contains("Test Name"));
            Assert.IsTrue(json.Contains("test@example.com"));
        }

        [Test]
        public void Person_Deserialization_MapsEmailAddress()
        {
            string json = "{\"Name\":\"Jane\",\"Age\":28,\"email_address\":\"jane@example.com\"}";
            var person = JsonConvert.DeserializeObject<Person>(json);
            Assert.AreEqual("Jane", person.Name);
            Assert.AreEqual(28, person.Age);
            Assert.AreEqual("jane@example.com", person.Email);
        }

        [Test]
        public void Person_Serialization_UsesEmailAddressPropertyName()
        {
            var person = new Person { Name = "Bob", Age = 35, Email = "bob@example.com" };
            string json = JsonConvert.SerializeObject(person);
            Assert.IsTrue(json.Contains("email_address"));
        }
    }
}