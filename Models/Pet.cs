using System.ComponentModel.DataAnnotations;
using System;

namespace OtoMDemo.Models
{
    public class Pet
    {
        [Key]
        public int PetId {get; set;}
        [Required]
        public string PetName {get; set;}
        [Required]
        public string Species {get; set;}
        [Required]
        public string Trick {get; set;}
        public DateTime CreatedAt {get; set;} = DateTime.Now;
        public DateTime UpdatedAt {get; set;} = DateTime.Now;
        public int PirateId {get; set;}
        public Pirate Owner {get; set;}
    }
}