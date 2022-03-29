using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Entities;

namespace API.Entities
{
    public class UserCard
    {
         public int Id { get; set; }
        [StringLength(20)]

        public string Status { get; set; } = string.Empty;

        public int MemberId { get; set; }
        public AppUser AppUser { get; set; }
    }
}