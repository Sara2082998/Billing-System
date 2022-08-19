using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace billsystem.Model
{
    public class Type
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Index("Ix_TypeName", Order = 1, IsUnique = true)]
        [MaxLength(50)]
        public string Name { get; set; }
        public string Notes { get; set; }

        //Foreign Keys
        [ForeignKey("Comp")]
        [Required]
        public int Comp_Id { get; set; } 

        //Navigation Properties
        public virtual Company Comp { get; set; }
        public virtual List<Item> Items { get; set; }
    }
}
