using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace billsystem.Model
{
    public class Bill
    {
        [Key]
        public int Id { get; set; }
        public int Number { get; set; }
        [Column(TypeName ="date")]
        [Required]
        public DateTime Date { get; set; }

        //Foreign Keys
        [ForeignKey("Client")]
        [Required]
        public int Client_Id { get; set; }

        [ForeignKey("Employee")]
        [Required]
        public int Emp_Id { get; set; }

        //Navigation Properties
        public virtual List<Bill_Item> Bill_Item { get; set; }
        public virtual Client Client { get; set; }
        public virtual Employee Employee { get; set; }

    }
}
