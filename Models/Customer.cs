using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FastAndFurious.Models
{
    public class Customer
    {
        public int Id { get; set;}

        [Display(Name = "First Name")]
        public string FirstName { get; set;}

        
        [Display(Name = "Last Name")]
        public string LastName { get; set;}
        public string Phone { get; set;}
        public string Email { get; set;}
        public string? Address { get; set;}
    }

}