using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CompetitionTracker.Models.AccountViewModels
{
    public class RegisterViewModel
    {
        //First name 
        [Required(ErrorMessage = "Please enter your name.")]
        [DataType(DataType.Text)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        //Last name
        [Required(ErrorMessage = "Please enter your last name.")]
        [DataType(DataType.Text)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        //Username
        [Required(ErrorMessage = "Please enter a username.")]
        [DataType(DataType.Text)]
        [Display(Name = "Username")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Please enter your e-mail address.")]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter a password.")]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 7)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }


        //Birthday
        [Required(ErrorMessage = "Please enter your date of birth.")]
        [DataType(DataType.Date)]
        [Display(Name = "Birthday")]
        public DateTime Birthday { get; set; }

        //Gender
        [Required(ErrorMessage = "Please select your gender.")]
        [Display(Name = "Gender")]
        public string Gender { get; set; }


        //High School name
        [Required(ErrorMessage = "Please enter your Highschool name. If homeschooled please enter homeschooled. If graduated please enter the highschool you graduated from.")]
        [DataType(DataType.Text)]
        [Display(Name = "High School Name")]
        public string HSName { get; set; }

        //Desired College
        [DataType(DataType.Text)]
        [Display(Name = "Desired College")]
        public string NextCollege { get; set; }

        //Awards
        //MultilineText doesn't make a textbox
        [DataType(DataType.MultilineText)]
        [Display(Name = "Awards")]
        public string Awards { get; set; }

        //Previous Experience
        //MultilineText doesn't make a textbox
        [DataType(DataType.MultilineText)]
        [Display(Name = "Previous Experience")]
        public string Experience { get; set; }

        //Phone Number
        [DataType(DataType.Text)]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }


        public bool IsTrue
        { get { return true; } }

        [Display(Name = "I am 13 years of age, older, or authorized by my parents or guardian to participate in the competition.")]
        [Compare("IsTrue", ErrorMessage = "You need to meet at least one of these requirements in order to register.")]
        public bool Authorized { get; set; }

    }
}
