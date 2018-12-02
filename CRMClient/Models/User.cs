using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
namespace CRMClient.Models
{
    public class User
    {
        public User()
        {
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int userID { get; set; }

        [Display(Name = "Name")]
        public string name { get; set; }

        [Display(Name = "Surname")]
        public string surname { get; set; }

        [Display(Name = "Birth Date")]
        [DataType(DataType.Date)]
        public DateTime? birthDate { get; set; }

        [RegularExpression(@"^[a-zA-Z0-9]*$")]
        [Display(Name = "Login")]
        [Index(IsUnique = true)]
        [MaxLength(30, ErrorMessage = "Your login cannot be longer than 30 characters")]
        [Required(ErrorMessage = "This field is required!")]
        public string login { get; set; }

        [Display(Name = "Password")]
        [RegularExpression((@"^[a-zA-Z0-9@#$%&?!;:]*$"))]
        [MinLength(8, ErrorMessage = "Password must be 8 characters or more")]
        [Required(ErrorMessage = "This field is required!")]
        public string password { get; set; }

        //[ScaffoldColumn(false)]
        //[ForeignKey("roleID")]
        //public int IDrole { get; set; }

        //public Role Role { get; set; }

        [Display(Name = "Is Deleted?")]
        public bool isDeleted { get; set; }

        public string GetUsername()
        {
            return login;
        }
        public string GetPassword()
        {
            return password;
        }

        public string GetUserData()
        {
            return "Name: " + name + "\nSurname: " + surname + "\nBirth Date: " + birthDate;
        }

        public void MarkDeleted()
        {
            isDeleted = true;
        }
    }
}