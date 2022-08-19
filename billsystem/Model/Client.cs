using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace billsystem.Model
{
    public class Client
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Index("Ix_ClientName", IsUnique = true)]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]

        public string Phone { get; set; }

        public int Number { get; set; }
        [Required]
        public string Address { get; set; }

        //Navigation Properties
        public virtual List<Bill> Bills { get; set; }

    }
}
