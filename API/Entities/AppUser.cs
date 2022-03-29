using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Entities
{
    public class AppUser
    {
        public int Id { get; set; }
        [StringLength(20)]

        public string UserName { get; set; }
    }
}