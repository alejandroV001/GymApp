using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Entities;

namespace Entities
{
    [Table("Cards")]
    public class UserCard
    {
         public int Id { get; set; }
        public string Code { get; set; }
        public string Status { get; set; }
        public string Type { get; set; }

        public AppUser AppUser{ get; set; }
        public int AppUserId { get; set; }
    }
}