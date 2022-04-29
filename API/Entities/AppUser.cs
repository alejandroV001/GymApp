using API.Entities;
using Microsoft.AspNetCore.Identity;

namespace Entities
{
    public class AppUser : IdentityUser<int>
    {
        public DateTime DateOfBirth { get; set; }

        public DateTime Created { get; set; }=DateTime.Now;

        public DateTime LastActive { get; set; }=DateTime.Now;

        public string Gender { get; set; }
        public string City { get; set; }
        public string Country { get; set; }

        public ICollection<Photo> Photos { get; set; }

        public ICollection<UserCard> Cards { get; set; }

        public ICollection<UserLike> LikedByUsers { get; set; }
        public ICollection<UserLike> LikedUsers { get; set; }
        public ICollection<Message> MessagesSent { get; set; }
        public ICollection<Message> MessagesReceived { get; set; }
        public ICollection<AppUserRole> UserRoles { get; set; }

    }
}