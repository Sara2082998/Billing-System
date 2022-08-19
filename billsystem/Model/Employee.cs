using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace billsystem.Model
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Index("Ix_EmpName", Order = 1, IsUnique = true)]
        [MaxLength(50)]
        public string Name { get; set; }



        //Navigation Properties
        public virtual List<Bill> Bills { get; set; }
    }
}
