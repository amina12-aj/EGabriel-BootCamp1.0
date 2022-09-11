namespace RandomUser.WebApp
{
    public class ApiResponse
    {
        public List<User> Results { get; set; } = default!;
        public Information Info { get; set; } = default!;
    }
}