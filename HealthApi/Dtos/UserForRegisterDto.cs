using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HealthApi.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username { get; set; }
        [Required]
        [StringLength(30, MinimumLength = 6, ErrorMessage = "Your password must have at least 6 characters!")]
        public string Password { get; set; }
    }
}
