using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bill_system.DB
{
    public class Type_p
    {
        [Key]
        public int typ_id { get; set; }
        [Required(ErrorMessage = "TYPE NAME is Required")]
        [StringLength(150)]
        [Index(IsUnique = true)]
        public string typ_name { get; set; }
        [StringLength(500)]
        public string typ_notes { get; set; }
        [Required(ErrorMessage = "COMPANY NAME is Required")]
        [ForeignKey("type_comp_obj")]
        public int company_id { get; set; }


        //Navigation Property
        public virtual Company type_comp_obj { get; set; }
        public virtual ICollection<Item> type_items { get; set; }
    }
}
