using System.ComponentModel.DataAnnotations;

namespace Blog.Models
{
    public class RoleDetails
    {
        [Required]
        public int RoleId { get; set; }
        [Required]
        public string? RoleName { get; set; }
    }
}
