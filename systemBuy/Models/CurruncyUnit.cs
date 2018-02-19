using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace systemBuy.Models
{
    public class CurruncyUnit
    {
        public int id { get; set; }
        [Required]
        [DisplayName("وصف الوحدة")]
        public string descriptions { get; set; }
        public int curruncy_id { get; set; }
        public virtual bills bills { get; set; }
    }
}