using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PetStoreMVC.Models
{
    public enum Breed
    {
        Dog, Cat, Fish, Hamster, GuineaPig
    }
    public class Pet
    {
        public int ID { get; set; }
        [Required]
        [StringLength(10, ErrorMessage = "Pet name can't be more than 10 char")]
        public string Name { get; set; }
        [Required]
        public DateTime DOB { get; set; }
        [Required]
        public Breed Breed { get; set; }
        [Required]
        public int OwnerId { get; set; }
        public Owner Owner { get; set; }
    }
}
