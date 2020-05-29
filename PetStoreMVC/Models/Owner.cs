using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PetStoreMVC.Models
{
    public class Owner
    {
        public int ID { get; set; }
        [Required]
        [StringLength(20, ErrorMessage = "Input can't be more than 20 char")]
        public string FirstName { get; set; }
        [Required]
        [StringLength(20, ErrorMessage = "Input can't be more than 20 char")]
        public string LastName { get; set; }

        [NotMapped]
        public string FullName => this.FirstName + " " + this.LastName;
        [Required]
        [StringLength(20, ErrorMessage = "Input can't be more than 20 char")]
        public string Street { get; set; }
        [Required]
        [StringLength(20, ErrorMessage = "Input can't be more than 20 char")]
        public string City { get; set; }
        [Required]
        [DataType(DataType.EmailAddress, ErrorMessage = "Please enter correct email format")]
        public string EmailAddress  { get; set; }
        [Required]
        [DataType(DataType.PhoneNumber, ErrorMessage = "Please enter correct phone number format")]
        public string PhoneNumber { get; set; }
        [Required]
        [StringLength(20, ErrorMessage = "Input can't be more than 20 char")]
        public string Occupation { get; set; }

        public ICollection<Pet> Pets { get; set; }

    }
}
