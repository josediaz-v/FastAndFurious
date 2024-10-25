using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FastAndFurious.Models
{
    public class Employee
    {
        public int Id { get; set;}

        
        [Display(Name = "First Name")]
        public string FirstName { get; set;}

        [Display(Name = "Last Name")]
        public string LastName { get; set;}
        public int Phone { get; set;}
        public string Email { get; set;}
        public string Permission { get; set;}
    }
}