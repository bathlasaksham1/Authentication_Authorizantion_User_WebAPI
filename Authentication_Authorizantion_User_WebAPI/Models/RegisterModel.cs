using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Authentication_Authorizantion_User_WebAPI.Models
{
    public class RegisterModel
    {
        [Required(ErrorMessage = "FirstName is required")]
        public string FirstName { get; set; }

        public string LastName { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress]
        public string UserName { get; set; }


        //[Required(ErrorMessage ="Email is required")]
        //[EmailAddress]
        //public string Email { get; set; }


        [Required(ErrorMessage = "Password is required")]

        public string Password { get; set; }


        [Required(ErrorMessage = "Address is required")]
        public string Address { get; set; }
    }
}
