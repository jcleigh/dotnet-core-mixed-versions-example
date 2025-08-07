using Newtonsoft.Json;

namespace DotNetCoreTwoPointTwo.Models
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        
        [JsonProperty("email_address")]
        public string Email { get; set; }

        [JsonIgnore]
        public string TemporaryData { get; set; }
    }
}