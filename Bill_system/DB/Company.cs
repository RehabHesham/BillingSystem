using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bill_system.DB
{
    public class Company
    {
        [Key]
        public int compan_id { get; set; }
        [Required(ErrorMessage = "COMPANY NAME is Required”")]
        [StringLength(150)]
        [Index(IsUnique = true)]
        public string company_name { get; set; }
        [StringLength(500)]
        public string company_notes { get; set; }

        //Navigation Property
        public virtual ICollection<Type_p> company_types { get; set; }

        //public virtual ICollection<Item> company_items { get; set; }

    }
}
