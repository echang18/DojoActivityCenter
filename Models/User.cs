using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace DojoActivityCenter.Models
{
    public class User
    {
        [Key]
        public int UserId {get;set;}
        [Required(ErrorMessage = "Name is required")]
        [MinLength(2, ErrorMessage = "Name must be 2 characters or longer")]
        public string Name {get;set;}
        [Required(ErrorMessage = "Email address is required")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string Email {get;set;}
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Password is required")]
        [MinLength(8, ErrorMessage = "Password must be 8 characters or longer")]
        [RegularExpression("^((?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])|(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[^a-zA-Z0-9])|(?=.*?[A-Z])(?=.*?[0-9])(?=.*?[^a-zA-Z0-9])|(?=.*?[a-z])(?=.*?[0-9])(?=.*?[^a-zA-Z0-9])).{8,}$", ErrorMessage = "Password should be a min length of 8 characters, contain at least 1 number, 1 letter, and a special character")]

        public string Password {get;set;}
        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;
        [NotMapped]
        [Required(ErrorMessage = "Confirm password is required")]
        [Compare("Password", ErrorMessage = "Password does not match")]
        [DataType(DataType.Password)]
        public string Confirm {get;set;}
        public List<Plan> PlannedPlans {get;set;}
        public List<Join> PlannedAttendees {get;set;}

    }
}