using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace billsystem.Model
{
    public class Unit
    {
        [Key]
      
        public int Id { get; set; }
        [Required]
        [Index("Ix_UnitName", Order = 1, IsUnique = true)]
        [MaxLength(50)]
        public string Name { get; set; }
        public string Notes { get; set; }

        //Foregin Keys


        //Navigation Properties
        public virtual List<Item> Items { get; set; }
    }
}
