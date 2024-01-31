using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Project.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string UserId { get; set; }
        public string? Firstname { get; set; }
        public string? Lastname { get; set; }

    }
}
