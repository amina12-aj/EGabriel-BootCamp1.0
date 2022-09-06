namespace UserManagement.Domain.DTOs
{
    public class CreateUserDto
    {
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
    }
}