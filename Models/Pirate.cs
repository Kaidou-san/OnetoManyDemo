using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OtoMDemo.Models
{
    public class Pirate
    {
        [Key]
        public int PirateId {get; set;}
        [Required]
        public string Name {get; set;}
        [Required]
        public string Position {get; set;}
        public DateTime CreatedAt {get; set;} = DateTime.Now;
        public DateTime UpdatedAt {get; set;} = DateTime.Now;
        [Required]
        public int ShipId {get; set;}
        //ADD NAVIGATION PROPERTY for which ship the pirate belongs too
        public Ship Ship {get; set;}
        public List<Pet> Pets {get; set;}
    }
}