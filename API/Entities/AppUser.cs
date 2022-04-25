using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using API;
using API.Entities;
using API.Extensions;

namespace Entities
{
    public class AppUser
    {
        public int Id { get; set; }
        [StringLength(20)]

        public string UserName { get; set; }

        public byte[] PasswordHash { get; set; }

        public byte[] PasswordSalt { get; set; }

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
    }
}