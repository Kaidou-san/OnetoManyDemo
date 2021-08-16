using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace OtoMDemo.Models
{
    public class Ship
    {
        [Key]
        public int ShipId {get; set;}
        [Required]
        public string ShipName {get; set;}
        public DateTime CreatedAt {get; set;} = DateTime.Now;
        public DateTime UpdatedAt {get; set;} = DateTime.Now;
        //Navigation property on the Ship
        public List<Pirate> Crew {get; set;}
        public List<Pet> Pets {get; set;}
    }
}