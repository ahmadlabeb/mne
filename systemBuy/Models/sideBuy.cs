using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace systemBuy.Models
{
    public class sideBuy
    {
        public int id { get; set; }
        [Required]
        public string nameSide { get; set; }
        [Required]
        public string descriptions { get; set; }
        [Required]
        public string addressSide { get; set; }
        public int sideBuy_id { get; set; }
        public virtual bills bill { get; set; }
    }
}