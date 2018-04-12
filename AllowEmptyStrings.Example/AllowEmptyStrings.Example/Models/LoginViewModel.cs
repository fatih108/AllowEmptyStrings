using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AllowEmptyStrings.Example.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Email Required")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password Required", AllowEmptyStrings = true)]
        public string Password { get; set; }
    }
}
