using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API.DTOs
{
    public class RegisterDto
    {
        [Required]
        [StringLength(10,MinimumLength =4)]
        public string Username { get; set; }
        [Required]
        [StringLength(12,MinimumLength =4)]
        public string Password { get; set; }
    }
}