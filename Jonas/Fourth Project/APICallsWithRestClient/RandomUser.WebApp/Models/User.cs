using Newtonsoft.Json;

namespace RandomUser.WebApp
{
    public class User
    {
        public string? Gender { get; set; }
        public Name? Name { get; set; }
        public string? Email { get; set; }
        [JsonProperty("dob")]
        public DateOfBirth? DOB { get; set; }
        public string? Phone { get; set; }
        public Picture? Picture { get; set; }
    }
}