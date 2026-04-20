using System;
using System.ComponentModel.DataAnnotations;

namespace wealth_tracker.Models
{
    public enum UserRole
    {
        Admin,
        Parent,
        Child,
        Member
    }

    public class AppUser
    {
        public Guid Id { get; init; } = Guid.NewGuid();

        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string Username { get; set; } = string.Empty;

        [Required]
        public string PasswordHash { get; set; } = string.Empty;
        public UserRole Role { get; set; } = UserRole.Member;
        public Guid? ParentId { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public bool IsActive { get; set; } = true;
        public string DisplayName => $"{Username} ({Role})";
    }
}
