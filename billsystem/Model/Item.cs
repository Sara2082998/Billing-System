using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace billsystem.Model
{
    public class Item
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Index("Ix_ItemName", Order = 1, IsUnique = true)]
        [MaxLength(50)]
        public string Name { get; set; }

        [Range(0,Double.MaxValue, ErrorMessage = "The price must be greater than or equal zero.")]
        public decimal Selling_Price { get; set; }

        [Range(0, Double.MaxValue, ErrorMessage = "The price must be greater than or equal zero.")]
        public decimal Buying_Price { get; set; }
        public string Notes { get; set; }

        // for billing dg 
        [NotMapped]
        public int? Quntatiy   { get; set; }

        [NotMapped]
        public  decimal total { get; set; }



        //Foreign Keys
        [ForeignKey("Type")]
        [Required]
        public int Type_Id { get; set; }

        [ForeignKey("Unit")]
        [Required]
        public int Unit_Id { get; set; }


        //Navigation Properties
        public virtual Type Type { get; set; }
        public virtual Unit Unit { get; set; }
        public virtual List<Bill_Item> Item_Bill { get; set; }

    }
}
