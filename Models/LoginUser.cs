using System;
using System.ComponentModel.DataAnnotations;

namespace DojoActivityCenter.Models
{
    public class LoginUser
    {
        [Required(ErrorMessage = "Email address is required")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string LoginEmail {get;set;}
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Password is required")]
        [MinLength(8, ErrorMessage = "Password must be 8 characters or longer")]
        [RegularExpression("^((?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])|(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[^a-zA-Z0-9])|(?=.*?[A-Z])(?=.*?[0-9])(?=.*?[^a-zA-Z0-9])|(?=.*?[a-z])(?=.*?[0-9])(?=.*?[^a-zA-Z0-9])).{8,}$", ErrorMessage = "Password should be a min length of 8 characters, contain at least 1 number, 1 letter, and a special character")]
        public string LoginPassword {get;set;}
    }
}