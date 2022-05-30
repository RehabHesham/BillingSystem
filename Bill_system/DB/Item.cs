using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bill_system.DB
{
    public class Item
    {
        [Key]
        public int item_Code { get; set; }
        [Required(ErrorMessage = "ITEM NAME is Required")]
        [StringLength(150)]
        [Index(IsUnique = true)]
        public string item_name { get; set; }
        [StringLength(500)]
        public string item_notes { get; set; }
        [Column(TypeName ="money")]
        public decimal buy_price { get; set; }
        [Column(TypeName = "money")]
        public decimal sell_price { get; set; }

        //[Required(ErrorMessage = "COMPANY NAME is Required")]
        //[ForeignKey("item_company")]
        //public int? company_id { get; set; }
        [Required(ErrorMessage = "TYPE NAME is Required")]
        [ForeignKey("item_type")]
        public int type_id { get; set; }
        [Required(ErrorMessage = "UNIT NAME is Required")]
        [ForeignKey("item_unit")]
        public int unit_id { get; set; }

        //Navigation Property
       // public virtual Company item_company { get; set; }
        public Type_p item_type { get; set; }
        public Unit item_unit { get; set; }
        //public virtual ICollection<Invoive_items> invoive_items { get; set; }

    }
}
