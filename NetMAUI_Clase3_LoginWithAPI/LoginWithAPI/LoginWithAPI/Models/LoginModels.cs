using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginWithAPI.Models;
public class LoginModels
{
    [Required]
    public string Email { get; set; }
    [Required]
    public string Password { get; set; }

}
