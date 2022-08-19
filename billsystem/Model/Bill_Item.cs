using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace billsystem.Model
{
    public class Bill_Item
    {
        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "The quantity must be greater than zero.")]
        public int Quantity { get; set; }

        //Foreign Keys

        [ForeignKey("Item")]
        [Key, Column(Order = 1)]
        public int Item_Id { get; set; }
        [ForeignKey("Bill")]
        [Key, Column(Order = 2)]
        public int Bill_Id { get; set; }


        //Navigation Properties
        public virtual Item Item { get; set; }
        public virtual Bill Bill { get; set; }

    }
}
