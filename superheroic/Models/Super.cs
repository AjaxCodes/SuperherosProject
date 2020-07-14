using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

 namespace superheroic.Models
 {

    public class Super
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Alias { get; set; }
        public string Allies { get; set; }
        public string Foes { get; set; }

        public int EnergyProjection { get; set; }
        public int Strength { get; set; }
        public int Durability { get; set; }
        public int FightingSkill { get; set; }
        public int Intelligence { get; set; }
        public int Speed { get; set; }


    }






 }
