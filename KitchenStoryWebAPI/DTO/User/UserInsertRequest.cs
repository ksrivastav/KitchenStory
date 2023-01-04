using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using KitchenStoryWebAPI.DTO.ProductCategory;
using KitchenStoryCore.DomainModel;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace KitchenStoryWebAPI.DTO.Users
{
    public class UserInsertRequest 
    {

        [Required(ErrorMessage = "Username can't be blank")]
        public string Username { get; set; }
       // public string UserId { get; set; }

        [Required(ErrorMessage = "{0} can't be blank")]
        [Display(Name = "First Name")]
        [StringLength(40, MinimumLength = 5, ErrorMessage = "{0} should be between {2} to {1} charecters")]
        public string Firstname { get; set; }

        [Required(ErrorMessage = "Lastname can't be blank")]
        public string Lastname { get; set; }

        [Required(ErrorMessage = "Password can't be blank")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Confirm Password can't be blank")]
        //[Compare("Password", ErrorMessage = "Password and confirm password do not match")]
        [Compare("Password", ErrorMessage = "{0}and {1} password do not match")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Email can't be blank")]
        [EmailAddress(ErrorMessage = "Invalid email")]
        public string Email { get; set; }


        [Required(ErrorMessage = "PhoneNumber cant be blank")]
        [Phone(ErrorMessage = "Invalid Phone Number")]
        public string Mobile { get; set; }

        [Required(ErrorMessage = "Date Of birth cant be blank")]
        //[DateofBirthValidation(2000, "invalid dob")]
        public String DateOfBirth { get; set; }

        [Required(ErrorMessage = "Address Line 1 cant be blank")]
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }

        [Required(ErrorMessage = "City Cant be blank")]
        public string City { get; set; }

        [Required(ErrorMessage = "Country Cant be blank")]
        public string Country { get; set; }


    }
}
